using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class SkillsViewModel
    {
        SkillModel[] Skills {get; set;}
        int[] SkillIDs { get; set; }
        int[] SkillValues { get; set; }
    }
}