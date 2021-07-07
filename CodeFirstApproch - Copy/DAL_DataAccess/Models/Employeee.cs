using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAL.Models
{
    public class Employeee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int EmployeeId { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        [Required]
        [Display(Name = "Employee Email")]
        public string Email { get; set; }
        [Required]
        public string Company { get; set; }
        public bool IsDeleted { get; set; }


    }
}

