using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZeroHunger.Ef.Models
{
    public class CollectRequests
    {
        [Key]
        public int CrId { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [ForeignKey("Resturant")]
        public int ResId { get; set; }
        public DateTime CollectionDate { get; set; }
        public string FoodType { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Resturant Resturant { get; set; }

    }
}