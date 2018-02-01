using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class DetailsViewModel
    {
        public DetailsModel DetailSet {get; set;}
        public List<string> Deities { get; set; }
        public List<string> Alignments { get; set; }

        public DetailsViewModel()
        {
            Deities = new List<string>();
            Alignments = new List<string>();
        }
    }
}