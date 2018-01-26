using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class FeatsViewModel
    {
        public FeatModel[] Feats { get; set; }

        public FeatsViewModel(int size)
        {
            Feats = new FeatModel[size];
        }
    }
}