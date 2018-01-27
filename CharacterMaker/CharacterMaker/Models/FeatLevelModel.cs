using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class FeatLevelModel
    {
        public int[] FeatID { get; set; }
        public int[] FeatLevel { get; set; }

        public FeatLevelModel(int size)
        {
            FeatID = new int[size];
            FeatLevel = new int[size];
        }
    }
}