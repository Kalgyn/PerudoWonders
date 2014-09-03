using MongoDB.Bson;
using MongoDB.Driver;
using PerudoWonders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerudoWonders.MongoDB
{
    public class PlayerService : MongoService<Player>
    {
        public PlayerService(MongoDatabase database)
            : base(database)
        {

        }

        public ObjectId Insert(Player player)
        {
            Collection.Insert(player);
            return player.Id;
        }
    }
}