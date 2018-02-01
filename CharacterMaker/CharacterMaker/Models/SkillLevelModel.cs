using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class SkillLevelModel
    {
        public int[] SkillID { get; set; }
        public int[] SkillLevel { get; set; }

        public SkillLevelModel(int size)
        {
            SkillID = new int[size];
            SkillLevel = new int[size];
        }
    }
}