using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class RacesViewModel
    {
        public RaceModel[] Races {get; private set;}
        public int[] StatModifiers { get; set; }
        public List<string>[] AdditionalInfo { get; set; }
        public string[] AbilitiesInfo { get; set; }

        public RacesViewModel(ApplicationDbContext _dbContext)
        {
            int RaceId, ModifiersId;
            string Name;

            var raceList = _dbContext.Races.ToList();
            Races = new RaceModel[raceList.Count()];
            StatModifiers = new int[6];
            AdditionalInfo = new List<string>[raceList.Count()];
            AbilitiesInfo = new string[6];

            AbilitiesInfo[0] = _dbContext.AbilityInfo.Where(x => x.Ability == "Strength").FirstOrDefault().Info;
            AbilitiesInfo[1] = _dbContext.AbilityInfo.Where(x => x.Ability == "Dexterity").FirstOrDefault().Info;
            AbilitiesInfo[2] = _dbContext.AbilityInfo.Where(x => x.Ability == "Constitution").FirstOrDefault().Info;
            AbilitiesInfo[3] = _dbContext.AbilityInfo.Where(x => x.Ability == "Wisdom").FirstOrDefault().Info;
            AbilitiesInfo[4] = _dbContext.AbilityInfo.Where(x => x.Ability == "Intelligence").FirstOrDefault().Info;
            AbilitiesInfo[5] = _dbContext.AbilityInfo.Where(x => x.Ability == "Charisma").FirstOrDefault().Info;

            for (int i = 0; i < raceList.Count(); i++)
            {
                RaceId = raceList[i].RaceID;
                Name = raceList
                    .Where(x => x.RaceID == RaceId)
                    .FirstOrDefault()
                    .Name;
                ModifiersId = raceList.Where(x => x.RaceID == RaceId).FirstOrDefault().ModifiersID;

                AdditionalInfo[i] = new List<string>();
                if(_dbContext.RaceImgs.Where(x => x.RaceID == RaceId).FirstOrDefault() != null)
                    AdditionalInfo[i].Add(_dbContext.RaceImgs.Where(x => x.RaceID == RaceId).FirstOrDefault().Address);
                var Traits = _dbContext.RaceTraits.Where(x => x.RaceID == RaceId);
                foreach (var trait in Traits)
                    AdditionalInfo[i].Add(trait.Text);

                Races[i] = new Models.RaceModel(RaceId, Name, ModifiersId);
            }
        }
    }
}