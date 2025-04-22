using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music_Application.BLL;

namespace Music_Application.DAL
{
    public class DAL_Musics
    {      
        private static DAL_Musics instance;
        public static DAL_Musics Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Musics();
                }
                return instance;
            }
        }
        private DAL_Musics()
        {

        }
        public int getCount()
        {
            MusicAppEntities db = new MusicAppEntities();
            return db.Musics.Count();
        }
        public List<Music> GetAllMusics()
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Musics.Select(p => p);
            return list.ToList();
        }
        public List<Music> GetMusicsFromPlaylist(int PlaylistID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var playlist = db.Playlists.Where(p => p.PlaylistID == PlaylistID).FirstOrDefault();
            return playlist.Musics.ToList();
        }
        public List<Music> GetMusicByName(string musicName)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Musics.Where(p => p.MusicName.Contains(musicName)).Select(p => p);
            return list.ToList();
        }
        public void UpdatePlayCount(int MusicID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var music = db.Musics.Where(p => p.MusicID == MusicID).FirstOrDefault();
            music.TotalViews += 1;
            db.SaveChanges();
        }
        public List<Music> getTop(int count)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Musics.OrderByDescending(p => p.TotalViews).Take(count);
            return list.ToList();
        }
        public void AddMusic(Music music)
        {
            MusicAppEntities db = new MusicAppEntities();
            db.Musics.Add(music);
            db.SaveChanges();
        }
        public void RemoveMusic(int MusicID)
        {
            MusicAppEntities db = new MusicAppEntities();
            Music music = db.Musics.Where(p => p.MusicID == MusicID).FirstOrDefault();
            db.Musics.Remove(music);
            foreach (Playlist playlistID in BLL_Playlists.Instance.GetAdminPlaylists())
            {
                DAL_Playlists.Instance.RemoveMusicFromPlaylist(playlistID.PlaylistID, MusicID);
            }    
            db.SaveChanges();
        }
        public void EditMusic(Music editmusic)
        {
            MusicAppEntities db = new MusicAppEntities();
            var music = db.Musics.Find(editmusic.MusicID);
            if (music != null)
            {
                music.MusicName = editmusic.MusicName;
                music.ArtistID = editmusic.ArtistID;
                music.ReleaseDate = editmusic.ReleaseDate;
                music.MusicURL = editmusic.MusicURL;
                music.ImageURL = editmusic.ImageURL;
                db.SaveChanges();
            }
        }
        public List<dynamic> GetMusicsForDGV(string search)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Musics.Where(p => p.MusicName.Contains(search)).
                Select(p => new { p.MusicID, p.MusicName, p.Artist.ArtistName }).ToList();
            return list.Cast<dynamic>().ToList();
        }
        public List<dynamic> GetMusicsForDGV(int collectionID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Musics.Where(p => p.Collections.Any(c => c.CollectionID == collectionID)).
                Select(p => new { p.MusicID, p.MusicName, p.Artist.ArtistName }).ToList();
            return list.Cast<dynamic>().ToList();
        }
    }
}
