using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class RaceModel
    {
        private int RaceId;
        public string Name { get; private set; }
        private int ModifiersId;

        public RaceModel(int ID, string name, int modID)
        {
            RaceId = ID;
            Name = name;
            ModifiersId = modID;
        }

        public int GetModID()
        {
            return ModifiersId;
        }
    }
}