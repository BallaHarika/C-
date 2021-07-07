using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAL.Interface
{
    public interface IRespository<T>
    {
        public Task<T> Add(string company,string Email,string EmployeeName);
        public void update(T obj);
        public void Remove(int id);
        public T DisplayByID(int id);
        public IEnumerable<T> DisplayAll(string Company);

    }



   class IRespository
    {
        
    }

}
