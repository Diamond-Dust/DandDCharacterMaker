namespace ADOHelper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Feats
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Feats()
        {
            Player = new HashSet<Player>();
        }

        [Key]
        public int FeatID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int ModifiersID { get; set; }

        [Required]
        public string Description { get; set; }

        public bool CanStack { get; set; }

        public virtual ModifierSets ModifierSets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player> Player { get; set; }
    }
}
