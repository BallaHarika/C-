using System;
using System.Collections.Generic;
using System.Text;


namespace CollectionDemos
{


    class Institution<T>
    {

      
        public List<T> institutes = new List<T>();
        public bool Register(T institute)
        {
            institutes.Add(institute);
            return true;
        }



    }
    class School
    {
        public string Name { get; set; }
    }
    class College
    { 
      public string TypeOfCollege { get; set; }
    
    }


}
