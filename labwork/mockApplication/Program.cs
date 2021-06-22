using System;
using System.Collections.Generic;

namespace mockApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopclasses shop = new Shopclasses();
            Product prod = new Product();

            List<Customer>  customerbook = new List<Customer>();

            int j = 0;
          //  char chartocheck='';
            while (j == 0)
            {
                Customer c = new Customer();
                Console.WriteLine("press 1 for create customer account \n press 2 for  products menu \n press 3 for add product to bag  \n press 4 for delete customer account \n press 5 for exit ");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Hello customer");
                        Console.WriteLine("please enter your name");
                        string customer_name = Console.ReadLine();
                       
                         Customer cus =c.Createcustomerform(customer_name);
                        customerbook.Add(cus);
                        
                        break;

                    case 2:
                        Console.WriteLine("please enter your customeris");
                        int id =Convert.ToInt32( Console.ReadLine());
                        Customer temp = customerbook.Find((p) => p.CID == id);

                        if (temp != null)
                        {
                            Console.WriteLine("please check our menu , add products to your bag");
                            shop.listofproducts();
                        }
                       
                      // Customer temp = customerbook.Find((p) => p.CID == id);

                      

                        break;

                    case 3:


                        char chartocheck;
                     //   List<Product> personBag = new List<Product>();
                        
                        do
                        {
                            Console.WriteLine("do you want to add produncts press y for yes n for No");
                             chartocheck = char.Parse(Console.ReadLine());
                            if (chartocheck == 'y')
                            {
                                Console.WriteLine("enter product name that you want");
                                string productname = Console.ReadLine();


                                Product prodtemp = shop.warehouse.Find((p) => p.item_name == productname);

                                Console.WriteLine("your product is added to bag");
                                //personBag.Add(prodtemp);
                                shop.Buy(prodtemp);
                                c.customerbag.Add(prodtemp);
                            }

                           
                        } while (chartocheck == 'y') ;
                        Console.WriteLine("list of product itemsthat are added to bag  ");
                        c.customerbag.ForEach((p) =>
                        {
                            Console.WriteLine($"itemcode ={p.itemcode},item_name={p.item_name},cost={p.cost}");
                        });

                        break;

                    case 4:
                       Console.WriteLine("enter accounid to delete account ");

                        int userid = int.Parse(Console.ReadLine());

                        Customer deletetemp = customerbook.Find((p) => p.CID == userid);
                        if (deletetemp != null)
                        {
                            customerbook.Remove(deletetemp);
                            Console.WriteLine($"Accountid {userid} is deleted successfully");
                        }


                        else
                        {
                            Console.WriteLine($"Accountid{userid} is not found ");

                        }



                        

                        break;
                    case 5:
                        j = 3;
                        break;
                    default:
                        break;







                }

            }
           
           
        }
    }
}
