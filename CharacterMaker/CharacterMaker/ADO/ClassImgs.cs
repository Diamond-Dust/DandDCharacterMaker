namespace CharacterMaker.ADO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassImgs
    {
        [Key]
        public int ImgID { get; set; }

        public int ClassID { get; set; }

        [Required]
        public string Address { get; set; }

        public virtual Classes Classes { get; set; }
    }
}
