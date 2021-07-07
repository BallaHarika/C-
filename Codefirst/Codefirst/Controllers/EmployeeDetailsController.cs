using DAL_BusinessLayer;
using Employee.DAL.Interface;
using Employee.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {
        private readonly emplyeeservices _employeeservices;

        private readonly IRespository<Employeee> _employeerepository;
        public EmployeeDetailsController(emplyeeservices empoyeeservice, IRespository<Employeee> emprepo)
        {
            _employeeservices = empoyeeservice;
            _employeerepository = emprepo;


        }
             

        [HttpGet("/getemp")]
        public object GetempByID(int id) //json object
        {

           var result= _employeeservices.GetempByID(id);
            var jsonResult = JsonConvert.SerializeObject(result);
            return jsonResult;
        }
        [HttpGet("/getallpersons")]
        public object GetAllemps()
        {
            var result1 = _employeeservices.GetAllemps();
            var jsonResult1= JsonConvert.SerializeObject(result1);
            return jsonResult1;


        }
        [HttpPost("/addemp")]
        public async Task<Employeee> AddPerson([FromBody] Employeee obj)
        {
        
              var objtask= await _employeeservices.GetempAdded(obj);
                return objtask;
    
            
        }
        [HttpPut("/updateemp")]
        public bool UpdatePerson(Employeee obj)
        {
            try
            {
                _employeeservices.GetempUpdate(obj);
                return true;
            }
            catch
            {
                return false;

            }
           
        }

     
       
        [HttpDelete("/deleteperson")]
        public bool Deleteemp(int id)
        {

            try
            {
                _employeeservices.GetempRemove(id);
                return true;
            }
            catch
            {
                return false;

            }

        }
    }
}
