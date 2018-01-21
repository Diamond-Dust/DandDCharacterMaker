namespace ADOHelper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Items
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Items()
        {
            Player = new HashSet<Player>();
        }

        [Key]
        public int ItemID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Cost { get; set; }

        public int ItemCategoryID { get; set; }

        public virtual ItemCategories ItemCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player> Player { get; set; }
    }
}
