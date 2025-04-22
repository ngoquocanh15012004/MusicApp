using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Application.DAL
{
    public class DAL_Users
    {
        private static DAL_Users _Instance;
        public static DAL_Users Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Users();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_Users()
        {

        }
        public User GetUser(string account, string password)
        {
            MusicAppEntities db = new MusicAppEntities();
            var user = db.Users.Where(p => p.UserLoginName == account && p.UserPassword == password).FirstOrDefault();
            return user;
        }
        public bool Check(string account)
        {
            MusicAppEntities db = new MusicAppEntities();
            var user = db.Users.Where(p => p.UserLoginName == account).FirstOrDefault();
            if (user == null)
                return false;
            return true;
        }
        public int getCount()
        {
            MusicAppEntities db = new MusicAppEntities();
            return db.Users.Count();
        }
        public void addNewUser(User user) 
        {
            MusicAppEntities db = new MusicAppEntities();
            db.Users.Add(user);
            db.SaveChanges();
        }
        public void addPlaylistToUser(Playlist playlist, int userId) 
        {
            MusicAppEntities db = new MusicAppEntities();
            var user = db.Users.Where(p => p.UserID == userId).FirstOrDefault();
            user.Playlists.Add(playlist);
            db.SaveChanges();
        }
        public void addMusicToPlaylist(int musicId, int playlistId)
        {
            MusicAppEntities db = new MusicAppEntities();
            var playlist = db.Playlists.Where(p => p.PlaylistID == playlistId).FirstOrDefault();
            var music = db.Musics.Where(p => p.MusicID == musicId).FirstOrDefault();
            playlist.Musics.Add(music);
            db.SaveChanges();
        }
    }
}
