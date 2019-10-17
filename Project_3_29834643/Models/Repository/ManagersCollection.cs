using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_3_29834643.Models.Repository
{
    public class ManagersCollection
    {
        internal MongoDBReps repo = new MongoDBReps("mongodb://127.0.0.1:27017", "superStoredb");

        //Collection name in the database
        private const string _collectionName = "Managers";

        //Contains all documents inside the collection
        public IMongoCollection<SuperstoreManagers> Collection;

        public ManagersCollection()
        {
            this.Collection = repo.Db.GetCollection<SuperstoreManagers>(_collectionName);
        }

        public List<SuperstoreManagers> SelectAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }
      
        public List<SuperstoreManagers> Specific()
        {

            var filter = new BsonDocument { { "Region", new BsonDocument { { "$regex","Asia" }, { "$options", "i" } } } };

            var query = this.Collection.Find(filter).ToListAsync();
            return query.Result;

        }
        public void UpdateManager(string id, SuperstoreManagers manager)
        {
            manager.Id = new ObjectId(id);

            var filter = Builders<SuperstoreManagers>.Filter.Eq(s => s.Id, manager.Id);
            this.Collection.ReplaceOneAsync(filter, manager);
        }
        public void InsertManager(SuperstoreManagers manager)
        {
            this.Collection.InsertOneAsync(manager);
        }
        public SuperstoreManagers Get(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
    }
}
