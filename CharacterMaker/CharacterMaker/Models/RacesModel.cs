using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class RacesModel
    {
        public RaceModel[] Races {get; private set;}

        public RacesModel(ApplicationDbContext _dbContext)
        {
            int RaceId, ModifiersId;
            string Name;

            var raceList = _dbContext.Races.ToList();
            Races = new RaceModel[raceList.Count()];

            for (int i = 0; i < raceList.Count(); i++)
            {
                RaceId = raceList[i].RaceID;
                Name = raceList
                    .Where(x => x.RaceID == RaceId)
                    .FirstOrDefault()
                    .Name;
                ModifiersId = raceList.Where(x => x.RaceID == RaceId).FirstOrDefault().ModifiersID;

                Races[i] = new Models.RaceModel(RaceId, Name, ModifiersId);
            }
        }
    }
}