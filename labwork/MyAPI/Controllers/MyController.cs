using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAPI;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")] //pattern of uri

    [ApiController]
    public class MyController : ControllerBase
    {
        public static List<Product> _products = new List<Product>();



        [HttpGet("/getallproducts")]     //https://localhost:5001/getallproducts
        public List<Product> GetAllProducts()
        {
            return _products;
        }


        [HttpPost("newproduct/{msgs}")] //210 created           //https://localhost:5001/api/My/newproduct/hello

        public IActionResult Product([FromForm] Product newproduct, [FromRoute] string msgs)
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
            return Ok(foundProduct);


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
