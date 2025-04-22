using Music_Application.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Application.BLL
{
    public class BLL_Playlists
    {
        private static BLL_Playlists instance;
        public static BLL_Playlists Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLL_Playlists();
                }
                return instance;
            }
        }
        private BLL_Playlists()
        {

        }
        public List<Playlist> GetAdminPlaylists()
        {
            return DAL_Playlists.Instance.GetPlaylists(0);
        }
        public List<Playlist> GetPlaylistsByUser(int id)
        {
            return DAL_Playlists.Instance.GetPlaylists(id);
        }
        public Playlist getPlaylistByID(int id) 
        {
            return DAL_Playlists.Instance.GetPlaylistByID(id);
        }
        public void RemoveMusicFromPlaylist(int playlistID, int musicID)
        {
            DAL_Playlists.Instance.RemoveMusicFromPlaylist(playlistID, musicID);
        }
        public void RemovePlaylist(int playlistID)
        {           
            DAL_Playlists.Instance.RemovePlaylist(playlistID); 
        }
    }
}
