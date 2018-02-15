namespace CharacterMaker.ADO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Classes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Classes()
        {
            Player = new HashSet<Player>();
            Races = new HashSet<Races>();
            ClassImgs = new HashSet<ClassImgs>();
            ClassTraits = new HashSet<ClassTraits>();
        }

        [Key]
        public int ClassID { get; set; }

        public int HitDie { get; set; }

        public int ModifiersID { get; set; }

        public int GoldDieNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ModifierSets ModifierSets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player> Player { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Races> Races { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassImgs> ClassImgs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassTraits> ClassTraits { get; set; }
    }
}
