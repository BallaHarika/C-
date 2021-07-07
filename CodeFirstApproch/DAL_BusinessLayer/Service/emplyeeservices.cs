using Employee.DAL.Interface;
using Employee.DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL_BusinessLayer
{

    public class emplyeeservices
    {
        private readonly IRespository<Employeee> _employeee;
        public emplyeeservices(IRespository<Employeee> employeee)
        {

            _employeee = employeee ;
        }
        public Employeee GetEmpByID(int id)
        {
            return _employeee.DisplayByID(id);
        }
        public IEnumerable<Employeee> GetAllEmps(string Company)
        {
            return _employeee.DisplayAll(Company);
        }
        public void GetEmpUpdate(Employeee obj)
        {
             _employeee.update(obj);
        }
        public void GetEmpRemove(int id)
        {
            _employeee.Remove(id);
        }
        public Task<Employeee> GetEmpAdded(string Company, string Email, string EmployeeName)
        {

            return _employeee.Add(Company,Email,EmployeeName);
        }
    }
}
