using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_3_29834643.Models.Repository
{
    public class ReturnsCollection
    {
        internal MongoDBReps repo = new MongoDBReps("mongodb://127.0.0.1:27017", "superStoredb");


        //Collection name in the database
        private const string _collectionName = "Returns";
        public string[] regionname;

        //Contains all documents inside the collection
        public IMongoCollection<SuperstoreReturns> Collection;

        public ReturnsCollection()
        {
            this.Collection = repo.Db.GetCollection<SuperstoreReturns>(_collectionName);
        }

        public List<SuperstoreReturns> SelectAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }
        public int[] returnsInRegion()
        {
            List<SuperstoreReturns> theReturns = this.Collection.AsQueryable<SuperstoreReturns>().ToList(); 
            int[] totalRegions = new int[24];
            regionname = this.Collection.AsQueryable<SuperstoreReturns>().Select(e => e.Region).Distinct();



            for (int k=0; k < 24; k++)
            {
                string reg = regionname[k];
                int CentralUS = (from x in theReturns.Where(x => x.Region.Contains(reg)) select x.Region).Count();
                totalRegions[k] = CentralUS;
            }
           
            return totalRegions;
        }
    }
}
