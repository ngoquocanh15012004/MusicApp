using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WMPLib;
using System.Windows.Forms;
using System.Timers;
using Music_Application.BLL;

namespace Music_Application
{
    internal class BLL_Player
    {
        public event EventHandler SongChanged;
        public event EventHandler queueChanged;
        public int currentSongIndex { get; set; } = 0;
        public int originalSongIndex { get; set; } = 0;
        public List<Music> musicQueue { get; set; }
        public List<Music> originalQueue { get; set; }
        public WindowsMediaPlayer player { get; set; } = new WindowsMediaPlayer();
        public bool isPlaying { get; set; } = false;
        public bool isLoop { get; set; } = false;
        public bool isShuffle { get; set; } = false;

        public static BLL_Player _Instance;

        public static BLL_Player Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Player();
                return _Instance;
            }
            private set { }
        }
        private BLL_Player()
        {
            musicQueue = new List<Music>();
            player.settings.volume = 50;
            player.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(MediaPlayer_PlayStateChange);
        }
        public void addMusic(Music music)
        {
            if (checkExistMusic(music.MusicID) == false)
            { 
                musicQueue.Add(music);
            }
        }
        public void removeMusic(Music music)
        {
            musicQueue.Remove(music);
        }
        public void playMusic()
        {
            isPlaying = true;
            if (player.playState == WMPPlayState.wmppsPaused)
            {
                player.controls.play();
            }
            else
            {
                player.URL = musicQueue[currentSongIndex].MusicURL;
                player.controls.play();
                BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
            }
        }       
        public void pauseMusic()
        {
            isPlaying = false;
            player.controls.pause();
        }
        private async void MediaPlayer_PlayStateChange(int NewState)
        {
            if ((WMPPlayState)NewState == WMPPlayState.wmppsMediaEnded && !isLoop)
            {
                await Task.Delay(2000);
                if (currentSongIndex < musicQueue.Count)
                {
                    playMusic();
                    SongChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    currentSongIndex = 0;
                    playMusic();
                    SongChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public void nextSong()
        {
            isPlaying = true;
            try
            {
                if (currentSongIndex < musicQueue.Count - 1)
                {
                    currentSongIndex++;
                    player.URL = musicQueue[currentSongIndex].MusicURL;
                    player.controls.play();
                    BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
                }
                else
                {
                    currentSongIndex = 0;
                    player.URL = musicQueue[currentSongIndex].MusicURL;
                    player.controls.play();
                    BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
                }
            }
            catch { }
        }
        public void previousSong()
        {
            isPlaying = true;
            try
            {
                if (currentSongIndex > 0)
                {
                    currentSongIndex--;
                    player.URL = musicQueue[currentSongIndex].MusicURL;
                    player.controls.play();
                    BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
                }
                else
                {
                    currentSongIndex = musicQueue.Count - 1;
                    player.URL = musicQueue[currentSongIndex].MusicURL;
                    player.controls.play();
                    BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
                }
            }
            catch { }
        }
        public void Shuffle(bool b)
        {
            isShuffle = b;
            if (isShuffle)
            {
                originalQueue = new List<Music>(musicQueue);
                Random random = new Random();
                int n = musicQueue.Count;
                while (n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    Music value = musicQueue[k];
                    musicQueue[k] = musicQueue[n];
                    musicQueue[n] = value;
                }
            }
            else
            {
                musicQueue = new List<Music>(originalQueue);
            }
        }
        public void Loop(bool b)
        {
            isLoop = b;
            player.settings.setMode("loop", b);           
        }
        public void setVolume(int value)
        {
            player.settings.volume = value;
        }
        public int getVolume()
        {
            return player.settings.volume;
        }
        public void Scroll(int value)
        {
            if (isPlaying)
            {
                double newPotition = player.currentMedia.duration * value / 100;
                if (Math.Abs(player.controls.currentPosition - newPotition) > 0.05)
                {
                    player.controls.currentPosition = newPotition;
                }
            }
        }
        public void setMusicQueue(List<Music> queue)
        {
            musicQueue = queue;
            currentSongIndex = 0;
            isPlaying = true;
            if (isShuffle)
                Shuffle(true);
            player.URL = musicQueue[currentSongIndex].MusicURL;
            player.controls.play();
            BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
        }
        public Music getCurrentMusic()
        {
            try
            {
                return musicQueue[currentSongIndex]; 
            }
            catch { return null; }
        }
        public void playMusicInQueue(Music music)
        {
            isPlaying = true;
            int index = orderOfMusicInQueue(music.MusicID);
            currentSongIndex = index;
            player.URL = musicQueue[currentSongIndex].MusicURL;
            player.controls.play();
            BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
            MainForm.Instance.setPlayer();
        }
        public void playAddedMusic(Music music)
        {
            isPlaying = true;
            if (checkExistMusic(music.MusicID) == true)
                playMusicInQueue(music);
            else
            {
                musicQueue.Add(music);
                currentSongIndex = musicQueue.Count - 1;
                player.URL = musicQueue[currentSongIndex].MusicURL;
                player.controls.play();
                BLL_Musics.Instance.UpdatePlayCount(musicQueue[currentSongIndex].MusicID);
            }
        }
        public bool checkExistMusic(int id)
        {
            foreach(Music music in musicQueue) 
            {
                if (music.MusicID == id)
                {
                    return true;
                }
            }
            return false;
        }
        public int orderOfMusicInQueue(int id)
        {
            for (int i = 0; i < musicQueue.Count; i++)
            {
                if (musicQueue[i].MusicID == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}