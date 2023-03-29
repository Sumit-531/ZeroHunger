using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.Ef.Models
{
    public class DistributionDetails
    {
        [Key]
        public int DId { get; set; }
        [Required]
        public string FoodType { get; set; }
        [Required]
        public string ResId { get; set; }
        [Required]
        public string Date { get; set; }
    }
}