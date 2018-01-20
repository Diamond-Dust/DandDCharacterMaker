using CharacterMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.BL
{
    public class BusinessLogic
    {
        public void RollTide(int[,] array, int rolls, int stats)
        {
            Random rand = new Random();

            for(int i=0; i<stats; i++)
            {
                for(int j=0; j<rolls; j++)
                {
                    array[i,j] = rand.Next(1, stats+1);
                }
            }
        }

        public void SumTheStrong(RollModel roll)
        {
            int Lowest;

            for (int i = 0; i < roll.numOfStats; i++)
            {
                Lowest = roll.Rolls[i,0];
                roll.SumOfRolls[i] = 0;
                roll.LowestRollIndexes[i] = 0;
                for (int j = 0; j < roll.numOfRolls; j++)
                {
                    if(Lowest > roll.Rolls[i,j])
                    {
                        Lowest = roll.Rolls[i, j];
                        roll.LowestRollIndexes[i] = j;
                    }
                }
                for (int j = 0; j < roll.numOfRolls; j++)
                {
                    if (j != roll.LowestRollIndexes[i])
                    {
                        roll.SumOfRolls[i] += roll.Rolls[i,j];
                    }
                }
            }
        }

        public void CheckReroll(RollModel roll)
        {
            int modifierSum=0, Highest=0, currentCheckedSum;

            for (int i = 0; i < roll.numOfStats; i++)
            {
                if (roll.SumOfRolls[i] > Highest)
                    Highest = roll.SumOfRolls[i];

                currentCheckedSum = (roll.SumOfRolls[i] % 2 == 0) ? roll.SumOfRolls[i] : roll.SumOfRolls[i]-1;

                modifierSum = currentCheckedSum / 2;
            }

            roll.CanReroll = ((modifierSum < 0) || (Highest <= 13)) ? true : false ;
        }
    }
}