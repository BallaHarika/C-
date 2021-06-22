using System;
using System.Collections.Generic;

namespace CoreLogicLayer2
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime DateofJoining { get; set; }
        public ProjectManganer projectManager { get; set; }
        public Company company { get; set; }
        protected List<Employee> _employees = new List<Employee>();


        public Employee  EmployeeDetails(String name,String Managername)
        {

            Employee emp = new Employee();
            Company com = new Company();
            Company comm=com.ComapnyDetails();
    
            string str = "Sapient_";
            string AccountId = (System.Math.Abs(Guid.NewGuid().GetHashCode())).ToString();

            string aid = str + AccountId;

            emp.EmployeeId = aid;
            DateTime now = DateTime.Now;
            emp.DateofJoining = now;
       
            

            emp.Name = name;
            emp.company = comm;
            emp.projectManager = null;
            comm.empDetails.Add(emp);

            return emp;
        }

      public  bool Add(Employee emp)
        {
            _employees.Add(emp);
            return true;
        }
        
        public bool Remove(Employee emp)
        {
            _employees.Remove(emp);
            return true;
        }
        public ProjectManganer GetPM()
        {
            return projectManager;
        }
        public List<Employee>  GetTeamMembers()
        {
            return _employees;
        }
        // =new List<Employee>();

        public virtual  string Works(string[] tasks)
        {

            return " Training on boot camp ";

        }
       


    }

   

    public class Company
    {

        public string CompanyId { get; set; }
        public string CompanytName { get; set; }

        public string  FounderName { get; set; }

        public int TotalEmployes { get; set; }


        public Company ComapnyDetails()
        {
            Company com = new Company();

            com.CompanytName = "Publicis Sapient";
            string companyprfix = "SAP";
            string CompanyId = (System.Math.Abs(Guid.NewGuid().GetHashCode())).ToString();

            CompanyId = companyprfix + CompanyId;
            com.CompanyId = CompanyId;

            com.FounderName = "";
            com.TotalEmployes = 100000;
            
            return com;
        }

        public List<Employee> empDetails=new List<Employee>();
       

    }

        public class  ProjectManganer:Employee
        {
        public  string ProjecetMangerName { get; set; }
        public int TotalTeams { get; set; }

         public override string Works(string[] tasks)
            {
            return "project on mock project";
            }


        }
}
