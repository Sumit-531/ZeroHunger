using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.Ef.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public virtual ICollection<CollectRequests> CollectRequests { get; set; }
        public Employee()
        {
            CollectRequests = new List<CollectRequests>();
        }
    }
}