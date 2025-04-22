using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Application.DAL
{
    internal class DAL_Artists
    {
        private static DAL_Artists instance;
        public static DAL_Artists Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Artists();
                }
                return instance;
            }
        }
        private DAL_Artists()
        {

        }
        public int getCount()
        {
            using (var context = new MusicAppEntities())
            {
                return context.Artists.Count();
            }
        }
        public void AddArtist(Artist artist)
        {
            using (var context = new MusicAppEntities())
            {
                context.Artists.Add(artist);
                context.SaveChanges();
            }
        }

        public List<Artist> GetAllArtists()
        {
            List<Artist> artists = new List<Artist>();
            using (var context = new MusicAppEntities())
            {
                artists = context.Artists.ToList();
            }
            return artists;
        }

        public Artist GetArtistByName(string name)
        {
            Artist artist = new Artist();
            using (var context = new MusicAppEntities())
            {
                artist = context.Artists.Where(p => p.ArtistName == name).FirstOrDefault();
            }
            return artist;
        }
        public Artist GetArtistByID(int id)
        {
            Artist artist = new Artist();
            using (var context = new MusicAppEntities())
            {
                artist = context.Artists.Where(p => p.ArtistID == id).FirstOrDefault();
            }
            return artist;
        }
    }
}
