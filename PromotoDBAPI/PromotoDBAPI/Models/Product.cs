using System;
using System.Collections.Generic;

#nullable disable

namespace PromotoDBAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int PID{ get; set; }
        public string PName { get; set; }
        public string Category { get; set; }
        public int? QtyInStock{ get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
