using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace PerudoWonders.Models
{
    public class Room
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public int Capacity { get; set; }
    }
}