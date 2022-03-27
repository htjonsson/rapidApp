using Newtonsoft.Json;
using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace rapidApp.Context
{
    public class LiteDbContext
    {
        public string ConnectionString { get; private set; }

        public BsonDocument GetById(string collectionName, string id)
        {
            BsonDocument document = null;

            using(var liteDatabase = new LiteDatabase(this.ConnectionString))
            {
                var col = liteDatabase.GetCollection(collectionName);

                id = id.Replace(@"""", "");

                document = col.FindById(new ObjectId(id));
            }          
            return document;     
        }

        public List<BsonDocument> GetAll(string collectionName)
        {
            var result = new List<BsonDocument>();

            using(var liteDatabase = new LiteDatabase(this.ConnectionString))
            {
                var col = liteDatabase.GetCollection(collectionName);

                result = col.FindAll().ToList();

            }          
            return result;
        }

        public bool Save(string collectionName, BsonDocument document)
        {
            bool result = false;

            using(var liteDatabase = new LiteDatabase(this.ConnectionString))
            {
                var col = liteDatabase.GetCollection(collectionName);

                result = col.Upsert(document);
            }  
            return result;        
        }
    
        public bool Delete(string collectionName, string id)
        {
            bool result = false;

            using(var liteDatabase = new LiteDatabase(this.ConnectionString))
            {
                var col = liteDatabase.GetCollection(collectionName);

                id = id.Replace(@"""", "");
            
                result = col.Delete(new ObjectId(id));
            }          
            return result;     
        }        
    }
}