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
        public EmployeeDetailsController(emplyeeservices es, IRespository<Employeee> emprepo)
        {
            _employeeservices = es;
            _employeerepository = emprepo;


        }
             

        [HttpGet("/getemp")]
        public object GetempByID(int id) //json object
        {


           var result= _employeeservices.GetEmpByID(id);
            var jsonResult = JsonConvert.SerializeObject(result);
            return jsonResult;
        }
        [HttpGet("/getallemp")]
        public object GetAllemps(String Company)
        {

            var result1 = _employeeservices.GetAllEmps(Company);
            var jsonResult1= JsonConvert.SerializeObject(result1);
            return jsonResult1;


        }
        [HttpPost("/addemp")]
        public async Task<Employeee> AddPerson(string Company, string Email, string EmployeeName)
        {
        
              var objtask= await _employeeservices.GetEmpAdded(Company, Email, EmployeeName);
                return objtask;
    
            
        }
        [HttpPut("/updateemp")]
        public bool UpdatePerson(Employeee obj)
        {
            try
            {
                _employeeservices.GetEmpUpdate(obj);
                return true;
            }
            catch
            {
                return false;

            }
           
        }

     
       
        [HttpDelete("/deleteemp")]
        public bool Deleteemp(int id)
        {

            try
            {
                _employeeservices.GetEmpRemove(id);
                return true;
            }
            catch
            {
                return false;

            }

        }
    }
}
