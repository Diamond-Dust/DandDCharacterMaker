using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class RaceModel
    {
        private int[] RaceId;
        public string[] Name { get; private set; }
        private int[] ModifiersId;

        public RaceModel(ApplicationDbContext _dbContext)
        {
            var raceList = _dbContext.Races.ToList();
            ModifiersId = new int[raceList.Count()];
            RaceId = new int[raceList.Count()];

            for (int i=0; i<raceList.Count(); i++)
            {
                RaceId[i] = raceList[i].RaceID;
                Name[i] = raceList.Where(x => x.RaceID == RaceId[i]).FirstOrDefault().Name;
                ModifiersId[i] = raceList.Where(x => x.RaceID == RaceId[i]).FirstOrDefault().ModifiersID;
            }
        }
    }
}