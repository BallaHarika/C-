using System;
using System.Collections.Generic;
using System.Text;

namespace mockApplication
{
    public class Shopclasses
    {

        public int Shopid{ get; set; }
        public string Name { get; set; }

        public void shopdetails()
        {
            Shopid = 1234;
            Name = "vmart";
        }
      public  List<Product> warehouse = new List<Product>();
        public List<Product> listofproducts()
        {
            

            

            warehouse.Add(new Product() { itemcode = 1, item_name = "cake", cost = 200.00 } );
            warehouse.Add(new Product() { itemcode = 2, item_name = "apple", cost = 25.00 });
            warehouse.Add(new Product() { itemcode = 3, item_name = "sugar", cost = 50.00 });
            warehouse.Add(new Product() { itemcode = 3, item_name = "ricepacket", cost = 60.00 });
            warehouse.Add(new Product() { itemcode = 3, item_name = "oil", cost = 90.00 });

             warehouse.ForEach((p) =>
            {
                Console.WriteLine($"itemcode ={p.itemcode},item_name={p.item_name},cost={p.cost}");
            });


            return warehouse;

        } 
        public void Buy(Product prod)
        {

            warehouse.Remove(prod);


        }



    }
    public class Product
    {
        public int itemcode { get; set; }
        public string item_name { get; set; }
        public double cost { get; set; }

       public Product() { }
       public   Product(int itemcode, string item_name, double cost)
        {
            this.itemcode = itemcode;
            this.item_name= item_name;
            this.cost = cost;

        }                


    }
   public class Customer
    {
      public  Customer() { }
        
        public string CName { get; set; }
        public int CID{ get; set; }
        public Customer Createcustomerform(string cusname)
        {
            int customer_id =System.Math.Abs(Guid.NewGuid().GetHashCode());

            Console.WriteLine($" account id is{customer_id}");
           
           
           
            this.CID = customer_id;
            this.CName = cusname;
         
            return this;

        }

       public List<Product> customerbag = new List<Product>();
       

       


    }
}
