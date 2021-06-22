using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public class test
    {
        public test() { }

        ~test() { }
        public test s = null;
        public Int32 i = 0;
        public String str = string.Empty;

    
        public  string  strprop { get; set; } //Auto-property

        public string DoSomething()
        {
            return $"value of strpop is :{strprop}";
        }

    }
}
