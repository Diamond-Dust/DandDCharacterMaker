using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class SkillModel
    {
        public int SkillID { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
        public string KeyAbility { get; set; }

        public SkillModel()
        {

        }

        public SkillModel(int ID, int value, string name, string ability)
        {
            SkillID = ID;
            Value = value;
            Name = name;
            KeyAbility = ability;
        }
    }
}