using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromotoDBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotoDBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateOrderController : ControllerBase
    {
        [HttpGet("/getproducts")]
        public IActionResult ProductList()
        {
            PromotoContext db = new PromotoContext();
            return Ok(db.Products.ToList()); //List of records=>product class as list .Here we should write products not product

        }
        [HttpPost("/placeorder")]
     /*   public IActionResult PlaceOrder(Order orderobj)
        {
            PromotoContext db = new PromotoContext();
            db.Orders.Add(orderobj); //adding order onj to the orderlist
            db.SaveChanges();//it will save changes for remote ,before this statement saving changes in our local machine
            return Ok("The record has been saved successfully");

        }*/
     [HttpPost("/createpincode")]
        public IActionResult createpincode(Pincode pincoderobj)
        {
            PromotoContext db = new PromotoContext();
            db.Pincodes.Add(pincoderobj); 
            db.SaveChanges();
            return Ok("The record has been saved successfully");

        }

    }
}
