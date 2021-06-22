

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI
{
    public class Product
    {

            [Required(ErrorMessage = "id is a mandatory field")]
            [Key]
            public int id { get; set; }

            [StringLength(20, ErrorMessage = "plese enter a value minimum 10 characters")]
            public String Name { get; set; }
            [Required]
            [Range(1, 10000, ErrorMessage = "plese enter a value b/w 1-10000 ")]
            public double Price { get; set; }

            public string Features { get; set; }
            public double Discount { get; set; }
            [Required]
            [Range(1, 100, ErrorMessage = "plese enter a value b/w 1-100 .only 100 produts are available ")]
            public int stock { get; set; }

            public DateTime DateOfManifacturing { get; set; }


        }
    }

