using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel;

namespace GardenGroupDAO
{
    public class MongoDB
    {
        private static MongoDB instance;
        private readonly IMongoDatabase db;

        public static MongoDB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MongoDB();
                }

                return instance;
            }
        }

        private MongoDB()
        {
            var client = new MongoClient(ConfigurationManager.ConnectionStrings["GardenGroupDatabase"].ConnectionString);
            db = client.GetDatabase("GardenGroup");
        }

        public void InsertDocument<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> GetDocuments<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find<T>(new BsonDocument()).ToList();
        }

        public T GetDocumentById<T>(string table, string id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            return collection.Find<T>(filter).First();
        }

        public void UpdateDocument<T>(string id, string table, T updatedRecord)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.ReplaceOne(filter, updatedRecord, new ReplaceOptions() { IsUpsert = true });
        }

        public List<T> FindByQuery<T>(string table, FilterDefinition<T> filter)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find<T>(filter).ToList();
        }

        public void DeleteDocument<T>(string table, string id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }

        //(DB) - Additional functionality - sorting by id and priority
        public List<T> GetSortedIDDocuments<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            var sort = Builders<T>.Sort.Descending("Id");

            return collection.Find<T>(new BsonDocument()).Sort(sort).ToList();
        }

        public List<T> GetSortedPriorityDocuments<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            var sort = Builders<T>.Sort.Descending("Priority");

            return collection.Find<T>(new BsonDocument()).Sort(sort).ToList();
        }

        public List<T> GetSortedDateReportedDocuments<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            var sort = Builders<T>.Sort.Ascending("ReportedDate");
            return collection.Find<T>(new BsonDocument()).Sort(sort).ToList();
        }

        public List<T> GetSortedDeadlineDocuments<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            var sort = Builders<T>.Sort.Ascending("Deadline");

            return collection.Find<T>(new BsonDocument()).Sort(sort).ToList();
        }

        public List<T> GetSortedSolvedDocuments<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            var sort = Builders<T>.Sort.Ascending("IsSolved");

            return collection.Find<T>(new BsonDocument()).Sort(sort).ToList();
        }

        //(TA) -Additional functionality - updating the password through searching by email/username

        public void UpdateDocumentbyEmail<T>( string table,string email, string password)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Email", email);
            var update = Builders<T>.Update.Set("Password", password);
            collection.UpdateOne(filter, update);
        }
    }
}
