using CharacterMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.BL
{
    public class BusinessLogic
    {
        public void RollTide(int[,] array)
        {
            Random rand = new Random();

            for(int i=0; i<6; i++)
            {
                for(int j=0; j<4; j++)
                {
                    array[i,j] = rand.Next(1, 7);
                }
            }
        }

        public void SumTheStrong(RollModel roll)
        {
            int Lowest;

            for (int i = 0; i < 6; i++)
            {
                Lowest = roll.Rolls[i,0];
                roll.SumOfRolls[i] = 0;
                roll.LowestRollIndexes[i] = 0;
                for (int j = 0; j < 4; j++)
                {
                    if(Lowest > roll.Rolls[i,j])
                    {
                        Lowest = roll.Rolls[i, j];
                        roll.LowestRollIndexes[i] = j;
                    }
                }
                for (int j = 0; j < 4; j++)
                {
                    if (j != roll.LowestRollIndexes[i])
                    {
                        roll.SumOfRolls[i] += roll.Rolls[i,j];
                    }
                }
            }
        }
    }
}