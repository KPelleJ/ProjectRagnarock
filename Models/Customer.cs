﻿using System.ComponentModel.DataAnnotations;

namespace ProjectRagnarock.Models
{
    public class Customer
    {
        [Required]
        [StringLength(4)]
        [DataType(DataType.Password)]
        [Display(Name = "Pincode")]
        public string Pincode { get; set; }
    }
}
