using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace PerudoWonders.Models
{
    public enum PlayerColor
    {
        BLUE = 1,
        RED = 2,
        GREEN = 3,
        YELLOW = 4,
        PINK = 5,
        DEFAULT = 0
    }

    public class Player
    {
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public PlayerColor Color { get; set; }

        public IEnumerable<Dice> Dices { get; set; }
    }
}