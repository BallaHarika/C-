using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApis;

namespace MyAPIs.Controllers
{
    [Route("api/[controller]")] //pattern of uri

    [ApiController]
    public class MyController : ControllerBase
    {
        public static List<Product> _products = new List<Product>();



        [HttpGet("/getallproducts")]        //https://localhost:5001/getallproducts
        public List<Product> GetAllProducts()
        {
            return _products;
        }

        [HttpGet]
        [Route("product/{title:alpha?}")]   //https://localhost:5001/api/My/product/HarikaBalla
        public string Hello(string title)
        {
            return title;
        }


        [HttpGet]
        [Route("product/{id:Range(1,3)?}")]     //https://localhost:5001/api/My/product/3

        public int Greeting(int id)
        {

            
            return id;
            
            
        }

        [HttpGet]
        [Route("Minvalue/{id:int:min(45)}")]     

        public int MinInt(int id)
        {


            return id;


        }





        [HttpGet]
        [Route("doubleprice/{Price:double?}")]     

        public double Greet(Double Price)
        {


            return Price;


        }







        [HttpPost("newproduct/{msgs}")] //210 created  //https://localhost:5001/api/My/newproduct/hello
        public IActionResult Product([FromForm] Product newproduct , [FromRoute] string msgs)
        {
            if (ModelState.IsValid)
            {

                _products.Add(newproduct);

              
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/", newproduct);

            }
            else
            {
                return BadRequest(ModelState.ErrorCount);   //status code:400  //client side input error

            }


        }
        [HttpGet("/searchproduts/{id}")]

        public IActionResult searchproduts(int id)  //https://localhost:5001/searchproduts/1
        {
            Product foundProduct = _products.Find((p) => p.id == id);
            if (foundProduct!=null)
            {
                Console.WriteLine("$product with id :{id} found");
                return Ok(foundProduct);
            }
            else
            {
                Console.WriteLine($"product couldn't found");
                return Ok("Product not in the database");
            }
               
            

        }





        [HttpPut("/updateProduct/{id}")]  //https://localhost:5001/updatesProduct/1

        public IActionResult UpdateProduct([FromRoute] int id, [FromForm] Product tobeupdated)
        {
            Product foundProduct = _products.Find((p) => p.id == id);   //for more conditions use &&
            //make the updates
            foundProduct.Name = tobeupdated.Name;
            foundProduct.Price = tobeupdated.Price;
            foundProduct.Discount = tobeupdated.Discount;
            foundProduct.Features = tobeupdated.Features;
            foundProduct.DateOfManifacturing = tobeupdated.DateOfManifacturing;
            foundProduct.stock = tobeupdated.stock;
          

            return Ok(foundProduct);
        }

        [HttpDelete("/deleteProduct/{id}")]    //https://localhost:5001/deleteProduct/1

        public IActionResult DeleteProduct(int id)
        {
            Product deletePosts = _products.Find((p) => p.id == id);   //for more conditions use &&

            _products.Remove(deletePosts);



            return Ok("delete successfully");
        }





    }
}