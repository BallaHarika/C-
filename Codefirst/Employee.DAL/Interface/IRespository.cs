using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAL.Interface
{
    public interface IRespository<T>
    {
        public Task<T> Add(T obj);
        public void update(T obj);
        public void Remove(int id);
        public T DisplayByID(int id);
        public IEnumerable<T> DisplayAll();

    }



   class IRespository
    {
        
    }

}
