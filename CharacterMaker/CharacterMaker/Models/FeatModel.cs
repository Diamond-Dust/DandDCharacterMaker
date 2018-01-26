﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class FeatModel
    {
        public int FeatID { get; set; }
        
        public string Name { get; set; }

        public int ModifiersID { get; set; }
        
        public string Description { get; set; }

        public bool CanStack { get; set; }
    }
}