using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerudoWonders.MongoDB
{
    public abstract class MongoService<T> where T : class
    {
        private MongoCollection _collection;

        public MongoCollection Collection
        {
            get { return _collection; }
            set { _collection = value; }
        }

        public MongoService(MongoDatabase database)
        {
            _collection = database.GetCollection<T>(typeof(T).Name);
        }
    }
}