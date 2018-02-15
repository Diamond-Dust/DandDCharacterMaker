using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class PlayerFinaliseModel
    {
        public string Class { get; set; }

        public string Race { get; set; }

        public string Deity { get; set; }

        public string Alignment { get; set; }

        public string Gender { get; set; }

        public string Name { get; set; }

        public int[] RaceModifiers {get; set;}

        public PlayerFinaliseModel()
        {
            RaceModifiers = new int[6];
        }
    }
}