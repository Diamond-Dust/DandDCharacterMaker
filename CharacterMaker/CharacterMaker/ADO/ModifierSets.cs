namespace CharacterMaker.ADO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ModifierSets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModifierSets()
        {
            Classes = new HashSet<Classes>();
            Feats = new HashSet<Feats>();
            Races = new HashSet<Races>();
        }

        [Key]
        public int ModifierID { get; set; }

        public int STRModifier { get; set; }

        public int DEXModifier { get; set; }

        public int CONModifier { get; set; }

        public int INTModifier { get; set; }

        public int WISModifier { get; set; }

        public int CHAModifier { get; set; }

        public int SPDModifier { get; set; }

        public int SkillPointsModifier { get; set; }

        public int BonusFeats { get; set; }

        public int BonusSkillPoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Classes> Classes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feats> Feats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Races> Races { get; set; }
    }
}
