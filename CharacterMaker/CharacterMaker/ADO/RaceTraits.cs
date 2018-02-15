namespace CharacterMaker.ADO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RaceTraits
    {
        [Key]
        public int TraitID { get; set; }

        public int RaceID { get; set; }

        [Required]
        public string Text { get; set; }

        public virtual Races Races { get; set; }
    }
}
