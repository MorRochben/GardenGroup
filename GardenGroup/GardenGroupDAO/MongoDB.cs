﻿using GardenGroupModel;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        // (DB)

        public List<T> GetUsersTicketsSortedByIDDocuments<T>(string table, User user)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("ReportedBy", user.Id);
            var sort = Builders<T>.Sort.Descending("Id");

            return collection.Find<T>(filter).Sort(sort).ToList();
        }

        public List<T> GetUsersTicketsSortedByPriorityDocuments<T>(string table, User user)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("ReportedBy", user.Id);
            var pSort = Builders<T>.Sort.Descending("Priority");
            var rSort = Builders<T>.Sort.Descending("ReportedDate");

            return collection.Find<T>(filter).Sort(rSort).Sort(pSort).ToList();
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
            var pSort = Builders<T>.Sort.Descending("Priority");
            var rSort = Builders<T>.Sort.Descending("ReportedDate");

            //Better way?
            //First the reportedDate sort, then priotrity sort --> cause the priority is the most important
            return collection.Find<T>(new BsonDocument()).Sort(rSort).Sort(pSort).ToList();
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
    }
}
