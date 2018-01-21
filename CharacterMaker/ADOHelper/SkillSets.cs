namespace ADOHelper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SkillSets
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SkillID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClassPlayerModifierID { get; set; }

        public int WhichTable { get; set; }

        public virtual Classes Classes { get; set; }

        public virtual ModifierSets ModifierSets { get; set; }

        public virtual Player Player { get; set; }

        public virtual Skills Skills { get; set; }
    }
}
