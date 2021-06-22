using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApis;

namespace MyAPIs.Controllers
{
    [Route("api/[controller]")] 

    [ApiController]
    public class DemoController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>();



        [HttpGet("/getallemployees")]        //https://localhost:5001/getallemployees
        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }

 

        [HttpPost("/addEmployee/{msg}")] //210 created  //https://localhost:5001/addEmployee/hi
        public IActionResult Employee([FromForm] Employee newemp,[FromRoute] string msg)
        {
            if (ModelState.IsValid)
            {

                _employees.Add(newemp);
                Console.WriteLine("employeee added");
                return Ok(newemp);


              //  return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/", newemp);

            }
            else
            {
                return BadRequest(ModelState.ErrorCount);   //status code:400  //client side input error

            }


        }
        [HttpGet("/searchemp/{eid}")]

        public IActionResult searchemp(int eid)  //https://localhost:5001/searchemp/1
        {
            Employee foundProduct = _employees.Find((p) => p.eid == eid);
            if (foundProduct != null)
            {
                Console.WriteLine($"employee with id :{eid} found");
                return Ok(foundProduct);
            }
            else
            {
                Console.WriteLine($"employee couldn't found");
                return Ok("employee not in the database");
            }



        }





        [HttpPut("/updateemp")]  //https://localhost:5001/updateemp

        public IActionResult UpdateEmp([FromForm]   Employee tobeupdated)
        {
            int eid = tobeupdated.eid;
            
            Employee foundemp = _employees.Find((p) => p.eid == eid);   //for more conditions use &&
            //make the updates
            if (foundemp != null)
            {
                foundemp.name = tobeupdated.name;
                foundemp.email = tobeupdated.email;
              //  foundemp.eid = tobeupdated.eid;
                return Ok(foundemp);
            }
            else
            {
                return Ok("not updated");
            }
                    

           
        }






    }
}