using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLogicLayer
{
   public class Employee
    {
        public int Salary{ get; set; }
        public  string EmployeeName { get; set; }

        public void EmpSalary()
        {
            Console.WriteLine($"employee salary {Salary} ");

        }

        public void EmpName()
        {
            Console.WriteLine($"employee Name {EmployeeName} ");
        }


    }
}
