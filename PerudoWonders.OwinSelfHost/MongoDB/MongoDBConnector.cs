using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerudoWonders.MongoDB
{
    public class MongoDBConnector
    {
        private const string ConnectionString = "mongodb://localhost";
        private const string DbName = "PerudoWonders";

        private MongoDatabase _database;

        public MongoDBConnector()
        {
            var client = new MongoClient(ConnectionString);
            var server = client.GetServer();
            _database = server.GetDatabase(DbName);
        }

        public MongoDatabase GetDatabase()
        {
            return _database;
        }
    }
}