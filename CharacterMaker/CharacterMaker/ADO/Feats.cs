namespace CharacterMaker.ADO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Feats
    {
        [Key]
        public int FeatID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int ModifiersID { get; set; }

        [Required]
        public string Description { get; set; }

        public bool CanStack { get; set; }
    }
}
