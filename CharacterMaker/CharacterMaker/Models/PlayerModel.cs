using CharacterMaker.ADO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class PlayerModel
    {
        public int PlayerID { get; set; }

        public int ClassID { get; set; }

        public int RaceID { get; set; }

        public int Gold { get; set; }

        public int DeityID { get; set; }

        public int AlignmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Gender { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}