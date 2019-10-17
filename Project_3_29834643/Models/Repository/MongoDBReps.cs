using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Project_3_29834643.Models.Repository
{
    public class MongoDBReps
    {
        public MongoClient Client;
        public IMongoDatabase Db;

       
        /// <param name="url">Mongo server url</param>
        /// <param name="database">Database name</param>
        public MongoDBReps(string url, string database)
        {
            this.Client = new MongoClient(url);
            //if the database is not exist, creates the database
            this.Db = this.Client.GetDatabase(database);
        }
    }
}
