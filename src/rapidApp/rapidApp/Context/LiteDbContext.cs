using Newtonsoft.Json;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace rapidApp.Context
{
    public class LiteDbContext
    {
        public string Path { get; set; } = string.Empty;

        public LiteDbContext() 
        {
            if(false == Directory.Exists(System.IO.Path.Combine(Environment.CurrentDirectory, "data")))
            {
                Directory.CreateDirectory(System.IO.Path.Combine(Environment.CurrentDirectory, "data"));
            }

            this.Path = System.IO.Path.Combine(Environment.CurrentDirectory, "data", "litedb.db"); 
        }

        public BsonDocument GetById(string collectionName, string id)
        {
            BsonDocument document = null;

            using(var liteDatabase = new LiteDatabase(this.Path))
            {
                var col = liteDatabase.GetCollection(collectionName);

                id = id.Replace(@"""", "");

                document = col.FindById(new ObjectId(id));
            }          
            return document;     
        }

        public T GetById<T>(string collectionName, string id)
        {
            T result;

            using(var liteDatabase = new LiteDatabase(this.Path))
            {
                var col = liteDatabase.GetCollection<T>(collectionName);

                id = id.Replace(@"""", "");

                result = col.FindById(new ObjectId(id));
            }          
            return result;     
        }

        public List<BsonDocument> GetAll(string collectionName)
        {
            var result = new List<BsonDocument>();

            using(var liteDatabase = new LiteDatabase(this.Path))
            {
                var col = liteDatabase.GetCollection(collectionName);

                result = col.FindAll().ToList();

            }          
            return result;
        }

        public List<T> GetAll<T>(string collectionName)
        {
            var result = new List<T>();

            using(var liteDatabase = new LiteDatabase(this.Path))
            {
                var col = liteDatabase.GetCollection<T>(collectionName);

                result = col.FindAll().ToList<T>();

            }          
            return result;
        }        

        public bool Save(string collectionName, BsonDocument document)
        {
            bool result = false;

            using(var liteDatabase = new LiteDatabase(this.Path))
            {
                var col = liteDatabase.GetCollection(collectionName);

                result = col.Upsert(document);
            }  
            return result;        
        }

        public bool Save<T>(string collectionName, T document)
        {
            bool result = false;

            using(var liteDatabase = new LiteDatabase(this.Path))
            {
                var col = liteDatabase.GetCollection<T>(collectionName);

                result = col.Upsert(document);
            }  
            return result;        
        }        
    
        public bool Delete(string collectionName, string id)
        {
            bool result = false;

            using(var liteDatabase = new LiteDatabase(this.Path))
            {
                var col = liteDatabase.GetCollection(collectionName);

                id = id.Replace(@"""", "");
            
                result = col.Delete(new ObjectId(id));
            }          
            return result;     
        }             
    }
}