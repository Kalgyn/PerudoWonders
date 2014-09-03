using MongoDB.Bson;
using MongoDB.Driver;
using PerudoWonders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerudoWonders.MongoDB
{
    public class RoomService : MongoService<Room>
    {
        public RoomService(MongoDatabase database)
            : base(database)
        {

        }

        public ObjectId Insert(Room room)
        {
            Collection.Insert(room);
            return room.Id;
        }

    }
}