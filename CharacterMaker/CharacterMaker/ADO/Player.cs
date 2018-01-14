namespace CharacterMaker.ADO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Player")]
    public partial class Player
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlayerID { get; set; }

        public int ClassID { get; set; }

        public int RaceID { get; set; }

        public int Gold { get; set; }

        public int DeityID { get; set; }

        public int AlignmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Gender { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual Alignments Alignments { get; set; }

        public virtual Classes Classes { get; set; }

        public virtual Deities Deities { get; set; }

        public virtual Races Races { get; set; }
    }
}
