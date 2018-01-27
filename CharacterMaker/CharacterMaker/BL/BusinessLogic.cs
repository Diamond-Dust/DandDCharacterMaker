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
                currentCheckedSum -= 10;
                modifierSum = currentCheckedSum / 2;
            }

            roll.CanReroll = ((modifierSum < 0) || (Highest <= 13)) ? true : false ;
        }

        public void UpdateModifiers(ApplicationDbContext db, RacesViewModel races, int raceIndex)
        {
            int checkingID = races.Races[raceIndex].GetModID();
            var modifiers = db.ModifierSets.Where(x => x.ModifierID == checkingID).FirstOrDefault();
            races.StatModifiers[0] = modifiers.STRModifier;
            races.StatModifiers[1] = modifiers.DEXModifier;
            races.StatModifiers[2] = modifiers.CONModifier;
            races.StatModifiers[3] = modifiers.INTModifier;
            races.StatModifiers[4] = modifiers.WISModifier;
            races.StatModifiers[5] = modifiers.CHAModifier;
        }
        public void UpdateModifiers(ApplicationDbContext db, ClassesViewModel classes, int classIndex)
        {
            int checkingID = classes.Classes[classIndex].ModifiersID;
            var modifiers = db.ModifierSets.Where(x => x.ModifierID == checkingID).FirstOrDefault();
            classes.StatModifiers[0] = modifiers.STRModifier;
            classes.StatModifiers[1] = modifiers.DEXModifier;
            classes.StatModifiers[2] = modifiers.CONModifier;
            classes.StatModifiers[3] = modifiers.INTModifier;
            classes.StatModifiers[4] = modifiers.WISModifier;
            classes.StatModifiers[5] = modifiers.CHAModifier;
        }
        public int[] UpdateModifiers(ApplicationDbContext db, int classID, int raceID)
        {
            int[] StatArray = new int[6];
            var RmodID = db.Races.Where(x => x.RaceID == raceID).FirstOrDefault().ModifiersID;
            var CmodID = db.Classes.Where(x => x.ClassID == classID).FirstOrDefault().ModifiersID;
            var Rmodifiers = db.ModifierSets.Where(x => x.ModifierID == RmodID).FirstOrDefault();
            var Cmodifiers = db.ModifierSets.Where(x => x.ModifierID == CmodID).FirstOrDefault();
            StatArray[0] = Rmodifiers.STRModifier + Cmodifiers.STRModifier;
            StatArray[1] = Rmodifiers.DEXModifier + Cmodifiers.DEXModifier;
            StatArray[2] = Rmodifiers.CONModifier + Cmodifiers.CONModifier;
            StatArray[3] = Rmodifiers.INTModifier + Cmodifiers.INTModifier;
            StatArray[4] = Rmodifiers.WISModifier + Cmodifiers.WISModifier;
            StatArray[5] = Rmodifiers.CHAModifier + Cmodifiers.CHAModifier;

            return StatArray;
        }

        public void UpdateDetails(ApplicationDbContext db, DetailsViewModel details)
        {
            var Alignments = db.Alignments.ToList();
            foreach (var i in Alignments)
                details.Alignments.Add(i.Name);
            var Deities = db.Deities.ToList();
            foreach (var i in Deities)
                details.Deities.Add(i.Name);
        }

        public void PlayerUpdateRace(ApplicationDbContext db, PlayerModel player, int raceID)
        {
            var RID = db.Races.Where(x => x.RaceID == raceID).FirstOrDefault().RaceID;
            player.RaceID = RID;
        }
        public void PlayerUpdateClass(ApplicationDbContext db, PlayerModel player, int classID)
        {
            var CID = db.Classes.Where(x => x.ClassID == classID).FirstOrDefault().ClassID;
            player.ClassID = CID;
        }

        public void CheckPreferredClass(ApplicationDbContext db, ClassesViewModel classes, int raceID)
        {
            int? prefClassID = db.Races.Where(x => x.RaceID == raceID).FirstOrDefault()?.PreferredClassID;

            classes.PreferredClass = (prefClassID != null) ? db.Classes.Where(x=>x.ClassID == prefClassID).FirstOrDefault().Name : "";
        }

        public int CheckAvailableSkillPoints(ApplicationDbContext db, PlayerViewModel player)
        {
            int ModID = db.Classes.Where(x => x.ClassID == player.Player.ClassID).FirstOrDefault().ModifiersID;
            int SkillPointsModifier = db.ModifierSets.Where(x => x.ModifierID == ModID).FirstOrDefault().SkillPointsModifier;
            int INTCheckModifier = (player.Modifiers.INTModifier % 2 == 0) ? (player.Modifiers.INTModifier-10)/2 : (player.Modifiers.INTModifier-1-10)/2;
            int AddModID = db.Races.Where(x => x.RaceID == player.Player.RaceID).FirstOrDefault().ModifiersID;
            int Additional = db.ModifierSets.Where(x => x.ModifierID == AddModID).FirstOrDefault().BonusSkillPoints;
            int PointPerLevel = (SkillPointsModifier + INTCheckModifier>0) ? SkillPointsModifier + INTCheckModifier : 1;


            return (PointPerLevel) * 4 + Additional;
        }
        public int CheckAvailableFeatPoints(ApplicationDbContext db, PlayerViewModel player)
        {
            int AddModID = db.Races.Where(x => x.RaceID == player.Player.RaceID).FirstOrDefault().ModifiersID;
            int Additional = db.ModifierSets.Where(x => x.ModifierID == AddModID).FirstOrDefault().BonusFeats;

            return 1 + Additional;
        }
    }
}