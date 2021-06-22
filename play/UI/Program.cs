using CoreLogicLayer;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {

            IAmpublic obj = new IAmpublic();
            obj.IAPUrop = 1000;
            Console.WriteLine($"The value of {nameof(obj.IAPUrop)}:{obj.IAPUrop}");



            Employee objemp = new Employee();
            objemp.Salary = 10000;
            objemp.EmployeeName = "Harika";
            objemp.EmpSalary();
            objemp.EmpName();


        }
    }
}

