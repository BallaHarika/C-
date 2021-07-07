using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    public class CartController : Controller
    {

        [Route("api/[controller]")]
        [ApiController]
        public class CreateOrderController : ControllerBase
        {
            [HttpGet("/getproductsincart")]
            public IActionResult ProductList()
            {
                ProductContext db = new ProductContext();
                return Ok(db.Products.ToList()); //List of records=>product class as list .Here we should write products not product

            }
           
            [HttpPost("/updatecart")]
            public IActionResult createpincode(Product prodobj)
            {
                ProductContext db = new ProductContext();
                db.Products.Add(prodobj);
                db.SaveChanges();
                return Ok("The record has been saved successfully");

            }

        }
    }
}
