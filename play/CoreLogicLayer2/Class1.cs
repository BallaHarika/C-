using log4net;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CoreLogicLayer2
{
    //=====================Employee Class====================================//
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime DateofJoining { get; set; }
        public string project { get; set; }
        public ProjectManganer projectManager { get; set; }
        public Company company { get; set; }
        protected List<Employee> _employees = new List<Employee>();

        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);


        public Employee empdetails (String name,String Managername)
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
            if (emp != null)
            {
                _employees.Add(emp);
                logger.Info("employee added to list of employees");
                return true;
            }
            else
            {
                Console.WriteLine("You didn't added the emp");
                logger.Error("employee not added to the lsit of employees");
               
                return false;
            }
        }
        public bool Assign(string projectName)
        {
            project = projectName;
            return true;
        }

        public bool Remove(Employee emp)
        {
            if (emp != null)
            {
                _employees.Remove(emp);
                return true;
            }
            else
            {
                Console.WriteLine("employee not removed from list of employees");
                logger.Error("employee not removed from list of employees");
                return false;
            }
           
        }
        public ProjectManganer GetPM()
        {
            return projectManager;
        }
        public List<Employee>  GetTeamMembers()
        {
            return _employees;
        }
        

        public virtual  string Works(string[] tasks)
        {

            return " Training on boot camp ";

        }
       


    }

   
    //===============Company class========================================//
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

            com.FounderName = "nigel vaz";
            com.TotalEmployes = 100000;
            
            return com;
        }

        public List<Employee> empDetails=new List<Employee>();
       

    }

    //====================================ProjectManager class==================

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
