namespace CharacterMaker.ADO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassTraits
    {
        [Key]
        public int TraitID { get; set; }

        public int ClassID { get; set; }

        [Required]
        public string Trait { get; set; }
    }
}
