namespace CharacterMaker.ADO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Items
    {
        [Key]
        public int ItemID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Cost { get; set; }

        public int ItemCategoryID { get; set; }

        public virtual ItemCategories ItemCategories { get; set; }
    }
}
