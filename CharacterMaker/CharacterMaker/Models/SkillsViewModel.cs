using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class SkillsViewModel
    {
        public List<SkillModel> Skills {get; set;}
        public int AvalaiblePoints { get; set; }

        public SkillsViewModel()
        {
            Skills = new List<SkillModel>();
        }

        public SkillsViewModel(ApplicationDbContext _dbContext)
        {
            int skillID;
            string name, ability;
            var skillList = _dbContext.Skills.ToList();
            Skills = new List<SkillModel>();

            for (int i = 0; i < skillList.Count(); i++)
            {
                skillID = skillList[i].SkillID;
                name = skillList
                    .Where(x => x.SkillID == skillID)
                    .FirstOrDefault()
                    .Name;
                ability = skillList.Where(x => x.SkillID == skillID).FirstOrDefault().KeyAbility;

                Skills.Add(new Models.SkillModel(skillID, 0, name, ability));
            }
        }
    }
}