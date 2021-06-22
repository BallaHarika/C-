using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApis
{
    public class Employee
    {
       
        [Required]
        [StringLength(20)]
        public string name { get; set; }

        [EmailAddress]
        public string email { get; set; }

        [Key]
        public int eid { get; set; }

    }
}
