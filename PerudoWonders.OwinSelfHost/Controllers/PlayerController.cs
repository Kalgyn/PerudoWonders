using MongoDB.Bson;
using PerudoWonders.Models;
using PerudoWonders.MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PerudoWonders.Controllers
{
    public class PlayerController : ApiController
    {
        private PlayerService _playerService;

        public PlayerController()
        {
            var connector = new MongoDBConnector();
            _playerService = new PlayerService(connector.GetDatabase());
        }

        [HttpPost]
        public string PostPlayer(Player player)
        {
            return _playerService.Insert(player).Pid.ToJson();   
        }
    }
}
