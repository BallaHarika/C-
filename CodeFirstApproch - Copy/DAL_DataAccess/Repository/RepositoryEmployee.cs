using Employee.DAL.Data;
using Employee.DAL.Interface;
using Employee.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAL.Repository
{
   public class RepositoryEmployee : IRespository<Employeee>
    {
        private EmployeeDBContext _dbContext;

        public RepositoryEmployee(EmployeeDBContext dbcontextobj)
        {
            _dbContext = dbcontextobj;
                
        }


        public async Task<Employeee>  Add(string Company, string Email, string EmployeeName)
        {
            Employeee obj = new Employeee();
            obj.Company = Company;
            obj.Email = Email;
            obj.EmployeeName = EmployeeName;
            var returnedobj= await _dbContext.Employees.AddAsync(obj);
            _dbContext.SaveChanges();
            return returnedobj.Entity;

        }

        public IEnumerable<Employeee> DisplayAll(String company)
        {
            try
            {
                return _dbContext.Employees.Where(x => x.Company == company).ToList();
            }
            catch
            {
                throw;
            }

          


        }

        public  Employeee DisplayByID(int id)
        {
            try
            {
                return _dbContext.Employees.Where(x => x.EmployeeId.Equals(id)).FirstOrDefault();
            }
            catch
            {
                throw;
            }

        }

        public void Remove(int id)
        {
            try
            {
                Employeee removeobj = _dbContext.Employees.Where(x => x.EmployeeId==id).FirstOrDefault();
                _dbContext.Employees.Remove(removeobj);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void update(Employeee obj)
        {
                _dbContext.Update(obj);
                _dbContext.SaveChanges();

            
        }
    }
   

}
