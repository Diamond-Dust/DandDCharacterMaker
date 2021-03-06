﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class DetailsModel
    {
        public string Deity { get; set; }
        
        public string Alignment { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        [StringLength(50)]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}