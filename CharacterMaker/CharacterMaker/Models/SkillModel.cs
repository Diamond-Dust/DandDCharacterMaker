using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class SkillModel
    {
        public int SkillID { get; set; }
        public string Name { get; set; }
        public string KeyAbility { get; set; }

        public SkillModel(int ID, string name, string ability)
        {
            SkillID = ID;
            Name = name;
            KeyAbility = ability;
        }
    }
}