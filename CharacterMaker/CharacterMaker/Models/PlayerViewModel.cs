using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class PlayerViewModel
    {
        public PlayerModel Player { get; set; }
        public RollModel Rolls { get; set; }

        public PlayerViewModel()
        {
            Player = new PlayerModel();
            Rolls = new RollModel();
        }
    }
}