using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class RollModel
    {
        public int[,] Rolls { get; set; }
        public int[] SumOfRolls { get; set; }
        public int[] LowestRollIndexes { get; set; }

        public RollModel()
        {
            Rolls = new int[6,4];
            SumOfRolls = new int[6];
            LowestRollIndexes = new int[6];
        } 
    }
}