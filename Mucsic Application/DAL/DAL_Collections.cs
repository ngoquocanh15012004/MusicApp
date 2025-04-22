using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;

namespace Music_Application.DAL
{
    public class DAL_Collections
    {
        private static DAL_Collections instance;
        public static DAL_Collections Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Collections();
                }
                return instance;
            }
        }
        private DAL_Collections()
        {

        }
        public void AddCollection(Collection collection, int[] musicId)
        {
            MusicAppEntities db = new MusicAppEntities();
            foreach (int i in musicId)
            {
                var music = db.Musics.Where(p => p.MusicID == i).FirstOrDefault();
                collection.Musics.Add(music);
            }
            db.Collections.Add(collection);
            db.SaveChanges();
        }
        public void UpdateCollectionName(int CollectionID, string newName)
        {
            MusicAppEntities db = new MusicAppEntities();
            var collection = db.Collections.Find(CollectionID);
            collection.CollectionName = newName;
            db.SaveChanges();
        }
        public void UpdateCollectionMusics(int CollectionID, int newMusicID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var collection = db.Collections.Find(CollectionID);
            var newMusic = db.Musics.Find(newMusicID);
            collection.Musics.Add(newMusic);
            db.SaveChanges();
        }
        public void RemoveCollection(int CollectionID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var collection = db.Collections.Where(p => p.CollectionID == CollectionID).FirstOrDefault();
            collection.Musics.Clear();
            db.Collections.Remove(collection);
            db.SaveChanges();
        }
        public Collection GetCollectionByID(int id)
        {
            MusicAppEntities db = new MusicAppEntities();
            var collection = db.Collections.Where(p => p.CollectionID == id).FirstOrDefault();
            return collection;
        }
        public void RemoveMusicFromCollection(int CollectionID, int MusicID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var collection = db.Collections.Where(p => p.CollectionID == CollectionID).FirstOrDefault();
            var music = db.Musics.Where(p => p.MusicID == MusicID).FirstOrDefault();
            collection.Musics.Remove(music);
            db.SaveChanges();
        }
        public List<Collection> GetAllCollections()
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Collections.Select(p => p);
            return list.ToList();
        }
        public List<Collection> GetCollectionsByOrder(int order)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Collections.Where(p => p.DisplayOrder == order).ToList();
            return list;
        }
        public List<dynamic> GetCollectionsForDGV(string search)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Collections.Where(p => p.CollectionName.Contains(search)).
                Select(p => new { p.CollectionID, p.CollectionName}).ToList();
            return list.Cast<dynamic>().ToList();
        }
    }
}
