using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class FeatsViewModel
    {
        public List<FeatModel> Feats { get; set; }
        public int AvalaiblePoints { get; set; }

        public FeatsViewModel()
        {
            Feats = new List<FeatModel>();
        }

        public FeatsViewModel(ApplicationDbContext _dbContext)
        {
            Feats = new List<FeatModel>();
            int featID, modifiers;
            bool canStack;
            string name, description;
            var skillList = _dbContext.Feats.ToList();

            for (int i = 0; i < skillList.Count(); i++)
            {
                featID = skillList[i].FeatID;
                name = skillList
                    .Where(x => x.FeatID == featID)
                    .FirstOrDefault()
                    .Name;
                description = skillList.Where(x => x.FeatID == featID).FirstOrDefault().Description;
                modifiers = skillList.Where(x => x.FeatID == featID).FirstOrDefault().ModifiersID;
                canStack = skillList.Where(x => x.FeatID == featID).FirstOrDefault().CanStack;

                Feats.Add(new Models.FeatModel(featID, 0, name, description, canStack, modifiers));
            }
        }
    }
}