namespace ADOHelper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Races
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Races()
        {
            Player = new HashSet<Player>();
        }

        [Key]
        public int RaceID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int ModifiersID { get; set; }

        public int Speed { get; set; }

        [Required]
        [StringLength(50)]
        public string Size { get; set; }

        public int? PreferredClassID { get; set; }

        public virtual Classes Classes { get; set; }

        public virtual ModifierSets ModifierSets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player> Player { get; set; }
    }
}
