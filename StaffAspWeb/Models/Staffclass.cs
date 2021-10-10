using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StaffAspWeb.Models
{
    public class Staffclass
    {
        [Key]
        public int StaffId { get; set; }
        public string Name { get; set; }
        public int Organismic_code { get; set; }
        public float Salary { get; set; }
    }
}