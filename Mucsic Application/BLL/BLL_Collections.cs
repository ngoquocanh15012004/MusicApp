using Music_Application.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Application.BLL
{
    public class BLL_Collections
    {
        private static BLL_Collections instance;
        public static BLL_Collections Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLL_Collections();
                }
                return instance;
            }
        }
        private BLL_Collections()
        {

        }
        public List<Collection> GetAllCollections()
        {
            return DAL_Collections.Instance.GetAllCollections();
        }
        public Collection GetCollectionByID(int id) 
        {
            return DAL_Collections.Instance.GetCollectionByID(id);
        }
        public void RemoveMusicFromCollection(int collectionID, int musicID)
        {
            DAL_Collections.Instance.RemoveMusicFromCollection(collectionID, musicID);
        }
        public List<Collection> GetCollectionsByOrder(int order)
        {
            return DAL_Collections.Instance.GetCollectionsByOrder(order);
        }
        public void RemoveCollection(int collectionID)
        {
            DAL_Collections.Instance.RemoveCollection(collectionID); 
        }
        public void AddCollection(string name, int[] musicIDs)
        {
            Collection collection = new Collection();
            collection.CollectionName = name;
            DAL_Collections.Instance.AddCollection(collection, musicIDs);
        }
        public List<dynamic> GetCollectionsForDGV(string search)
        {
            return DAL_Collections.Instance.GetCollectionsForDGV(search);
        }
    }
}
