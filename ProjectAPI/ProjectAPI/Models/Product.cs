using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class Product
    {
        public string ProductName{ get; set; }
        public double Price { get; set; }
        public string  ProductID{ get; set; }
        public string Features { get; set; }
        public string Origin { get; set; }
    }
}
