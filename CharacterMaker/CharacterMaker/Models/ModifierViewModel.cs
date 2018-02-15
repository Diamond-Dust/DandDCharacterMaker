using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class ModifierViewModel
    {
        public ModifierModel Modifiers { get; set; }
        public string[] AbilitiesInfo { get; set; }

        public ModifierViewModel()
        {
            Modifiers = new ModifierModel();
            AbilitiesInfo = new string[6];
        }

        public ModifierViewModel(ApplicationDbContext _dbContext)
        {
            Modifiers = new ModifierModel();
            AbilitiesInfo = new string[6];

            AbilitiesInfo[0] = _dbContext.AbilityInfo.Where(x => x.Ability == "Strength").FirstOrDefault().Info;
            AbilitiesInfo[1] = _dbContext.AbilityInfo.Where(x => x.Ability == "Dexterity").FirstOrDefault().Info;
            AbilitiesInfo[2] = _dbContext.AbilityInfo.Where(x => x.Ability == "Constitution").FirstOrDefault().Info;
            AbilitiesInfo[3] = _dbContext.AbilityInfo.Where(x => x.Ability == "Wisdom").FirstOrDefault().Info;
            AbilitiesInfo[4] = _dbContext.AbilityInfo.Where(x => x.Ability == "Intelligence").FirstOrDefault().Info;
            AbilitiesInfo[5] = _dbContext.AbilityInfo.Where(x => x.Ability == "Charisma").FirstOrDefault().Info;
        }
    }
}