using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class RollModel
    {
        public bool CanReroll { get; set; }
        public int numOfRolls { get; private set; }
        public int numOfStats { get; private set; }
        public int[,] Rolls { get; set; }
        public int[] SumOfRolls { get; set; }
        public int[] LowestRollIndexes { get; set; } 
        public string[] StatNames { get; private set; }

        public RollModel()
        {
            StatNames = new string[] { "STR", "DEX", "CON", "INT", "WIS", "CHA" };
            numOfRolls = 4;
            numOfStats = 6;
            Rolls = new int[numOfStats, numOfRolls];
            SumOfRolls = new int[numOfStats];
            LowestRollIndexes = new int[numOfStats];
        } 
    }
}