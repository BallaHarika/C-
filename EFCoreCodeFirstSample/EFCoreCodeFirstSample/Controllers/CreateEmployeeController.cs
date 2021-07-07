using EFCoreCodeFirstSample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>();



        [HttpGet("/getallemployees")]       
        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }



        [HttpPost("/addEmployee")] 
        public IActionResult Employee([FromForm] Employee newemp)
        {
            if (ModelState.IsValid)
            {

                _employees.Add(newemp);
                Console.WriteLine("employeee added");
                return Ok(newemp);



            }
            else
            {
                return BadRequest(ModelState.ErrorCount);   

            }


        }
        [HttpGet("/searchemp/{eid}")]

        public IActionResult searchemp(int eid)  
        {
            Employee foundProduct = _employees.Find((p) => p.EmployeeId == eid);
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

        public IActionResult UpdateEmp([FromForm] Employee tobeupdated)
        {
            int eid = tobeupdated.EmployeeId;

            Employee foundemp = _employees.Find((p) => p.EmployeeId == eid);   //for more conditions use &&
           
            if (foundemp != null)
            {
                foundemp.EmployeeName = tobeupdated.EmployeeName;
                foundemp.Email = tobeupdated.Email;
                foundemp.Company = tobeupdated.Company;
               
                return Ok(foundemp);
            }
            else
            {
                return Ok("not updated");
            }



        }






    }







}

