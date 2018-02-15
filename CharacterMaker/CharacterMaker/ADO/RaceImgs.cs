namespace CharacterMaker.ADO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RaceImgs
    {
        [Key]
        public int ImgID { get; set; }

        public int RaceID { get; set; }

        [Required]
        public string Address { get; set; }

        public virtual Races Races { get; set; }
    }
}
