using Music_Application.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Music_Application.BLL
{
    public class BLL_Users
    {
        public User currentUser { get; set;}
        private static BLL_Users _Instance;
        public static BLL_Users Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Users();
                return _Instance;
            }
            private set { }
        }
        private BLL_Users() 
        { 

        }
        public bool checkLogIn(string account, string password)
        {
            User user = DAL_Users.Instance.GetUser(account, password);
            if (user != null) 
            {
                currentUser = user;
                return true;
            }
            else
                return false;
        }
        public void addUser(string name, string account, string password) 
        {
            User newUser = new User();
            newUser.UserID = DAL_Users.Instance.getCount();
            newUser.UserName = name;
            newUser.UserLoginName = account;
            newUser.UserPassword = password;
            DAL_Users.Instance.addNewUser(newUser);
        }
        public bool checkSignUp(string account)
        {
            return DAL_Users.Instance.Check(account);
        }
        public int addPlaylist(string name)
        {
            Playlist pl = new Playlist();
            pl.PlaylistName = name;
            DAL_Users.Instance.addPlaylistToUser(pl, currentUser.UserID);
            return pl.PlaylistID;
        }
        public void addMusicToPlaylist(int musicId, int playlistId) 
        {
            Playlist pl = DAL_Playlists.Instance.GetPlaylistByID(playlistId);
            foreach (Music music in pl.Musics)
            {
                if (music.MusicID == musicId)
                {
                    return;
                }
            }
            DAL_Users.Instance.addMusicToPlaylist(musicId, playlistId);
        }
    }
}
