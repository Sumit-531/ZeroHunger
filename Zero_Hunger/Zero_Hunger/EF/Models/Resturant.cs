using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.Ef.Models
{
    public class Resturant
    {
        [Key]
        public int ResId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string FoodType { get; set; }
        public string MaxPreTime { get; set; }
        public virtual ICollection<CollectRequests> CollectRequests { get; set; }

        public Resturant()
        {
            CollectRequests = new List<CollectRequests>();
        }
    }
}