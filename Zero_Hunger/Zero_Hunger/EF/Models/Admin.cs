using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.Ef.Models
{
    public class Admin
    {
        [Key]
        public String UserName { get; set; }
        [Required]
        public String Password { get; set; }
    }
}