using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("integrated security=true;data source=DESKTOP-843P44O;initial catalog=product");
             SqlDataAdapter ad = new SqlDataAdapter("select * from products",conn);
             DataSet ds = new DataSet();
             ad.Fill(ds, "products");
             foreach(DataRow dr in ds.Tables["products"].Rows)
             {
                 Console.WriteLine("Product Id" + dr["ID"]);
                 Console.WriteLine("Product Name" + dr["Name"]);
                 Console.WriteLine("category" + dr["Category"]);
                 Console.WriteLine("Product Price" + dr["Price"]);

             }

          //  string strcon = ConfigurationManager.ConnectionStrings["cart"].ConnectionString;
              
            
        }
        
    }
}
