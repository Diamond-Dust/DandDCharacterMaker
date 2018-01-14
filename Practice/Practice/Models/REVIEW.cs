namespace Practice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REVIEW")]
    public partial class REVIEW
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [DisplayName("Content")]
        public string CONTENT { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Author")]
        public string AUTHOR { get; set; }

        [DisplayName("Rate")]
        public int RATE { get; set; }
        
        public int MOVIEID { get; set; }

        public virtual MOVIE MOVIE { get; set; }
    }
}
