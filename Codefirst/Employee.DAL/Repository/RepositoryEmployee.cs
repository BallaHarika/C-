/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAL.Repository
{
    class RepositoryEmployee
    {
    }
}*/
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
    public class RepositoryEmployee : IRespository<Employee>
    {
        private EmployeeDBContext _dbContext;

        public RepositoryEmployee(EmployeeDBContext dbcontextobj)
        {
            _dbContext = dbcontextobj;

        }


        public async Task<Employee> Add(Employee obj)
        {
            var returnedobj = await _dbContext.Employees.AddAsync(obj);
            _dbContext.SaveChanges();
            return returnedobj.Entity;

        }

        public IEnumerable<Employee> DisplayAll()
        {
            try
            {
                return _dbContext.Employees.Where(x => x.IsDeleted == false).ToList();
            }
            catch
            {
                throw;
            }




        }

        public Employee DisplayByID(int id)
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
                Employee removeobj = _dbContext.Employees.Where(x => x.EmployeeId.Equals()).FirstOrDefault();
                _dbContext.Employees.Remove(removeobj);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void update(Employee obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();


        }
    }


}

