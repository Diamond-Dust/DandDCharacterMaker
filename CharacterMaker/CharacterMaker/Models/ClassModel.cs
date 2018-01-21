using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class ClassModel
    {
        public int ClassID { get; private set; }

        public int HitDie { get; set; }

        public int ModifiersID { get; set; }
        
        public string Name { get; set; }

        public ClassModel(int ID, string name, int modID)
        {
            ClassID = ID;
            Name = name;
            ModifiersID = modID;
        }
    }
}