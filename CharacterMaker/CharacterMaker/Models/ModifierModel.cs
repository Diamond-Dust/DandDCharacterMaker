using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class ModifierModel
    {
        public int ModifierID { get; set; }

        public int STRModifier { get; set; }

        public int DEXModifier { get; set; }

        public int CONModifier { get; set; }

        public int INTModifier { get; set; }

        public int WISModifier { get; set; }

        public int CHAModifier { get; set; }

        public int SPDModifier { get; set; }

        public int SkillPointsModifier { get; set; }

        public int BonusFeats { get; set; }

        public int BonusSkillPoints { get; set; }

        public ModifierModel()
        {
            SPDModifier = 0;
            SkillPointsModifier = 0;
            BonusFeats = 0;
            BonusSkillPoints = 0;
        }
    }
}