using System;
using System.Collections.Generic;

namespace mockproj
{
    class Program
    {
        static void Main(string[] args)
        {
            Company comp = Company.GetInstance();
            Console.WriteLine($"\t\t\t\t-----Welcome to {comp.CompanyName} MIS--------\n");
            Console.WriteLine($"\t\t\t\t\t\t\t\tFounder Name:{comp.FounderName}");



            //-------------------------------------------------------Employee Details--------------------------------\\
            string choice = "yes";
        start:
            Console.WriteLine("Please Enter employee name:");
            string name = Console.ReadLine();
            Console.WriteLine("\nPlease Enter Project Manager Name");
            string PMname = Console.ReadLine();
            Employee e = new Employee();
            Employee emp = new Employee(name, PMname);

            //Add employee
            if (emp.Add(emp))
                Console.WriteLine($"Employee Added Successfully. Employee Id:{emp.EmployeeID}");
            else
                Console.WriteLine("Error in adding Employee");
            //Assign project
            Console.WriteLine("Enter project name");
            string pname = Console.ReadLine();

            if (emp.Assign(pname))
            {
                Console.WriteLine($"Employee has been assigned project {emp.Projectname}");
            }
            Console.WriteLine("\nWant to add more Employees?");
            choice = Console.ReadLine().ToLower();
            if (choice == "yes" || choice == "y")
                goto start;




            start1:
            Console.WriteLine("Want to remove employee?");
            string ans = Console.ReadLine();
            if (ans.ToLower() == "y" || ans.ToLower() == "yes")
            {
                Console.WriteLine("Enter employee id to be removed");
                string empid = Console.ReadLine();
                if (emp.Remove(e, empid))
                    Console.WriteLine("Employee Removed Successfully");
                else
                {
                    Console.WriteLine("Error in removing Employee");
                }
            }
            else
                goto start2;
            Console.WriteLine("Want to remove more employees?");
            choice = Console.ReadLine();
            if (choice == "yes" || choice == "y")
                goto start1;
            start2:

            Console.WriteLine("Listing all employees who have have been assigned project Bootcamp");
            List<Employee> lis = new List<Employee>();
            lis = emp.GetTeamMembers();
            if (lis.Count == 0)
                Console.WriteLine("No employees have been assigned Project Bootcamp");
            else
            {
                foreach (var employee in lis)
                {
                    Console.WriteLine($"Employee Id:{emp.EmployeeID}, Employee Name:{emp.Name}, Employee Project Name:{emp.Projectname}\n");
                }
            }

            //-----------------------------------Project Manager------------------------------------------------------\\
            Console.WriteLine("\n\nCreating a Project Manager.........Please enter following details");
            Console.WriteLine("Please Enter name");
            string n = Console.ReadLine();
            Console.WriteLine("Enter total teams");
            int teams = Int32.Parse(Console.ReadLine());
            ProjectManager pm = new ProjectManager(n, teams);

            //Get PM details
            Console.WriteLine($"Project Manager Name:{pm.pmName}, List of teams under {pm.pmName}= {pm.TotalTeams()}");

            //----------------------------------------Assigning PM to each Employee-----------------------\\

            //Get Employee List
            Console.WriteLine("Printing Employee List:\n");
            pm.ListEmployees();

            Console.WriteLine($"Thank you for using {comp.CompanyName} MIS. Total Employee Count is:{comp.GetTotalEmployees()}");





        }
    }








    public class Company
    {
        private static Company company = new Company();
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
        public int TotalEmployees { get; set; }
        public string FounderName { get; set; }
        private Company()
        {


            string Id = Guid.NewGuid().ToString();
            this.CompanyID = "SAPIENT" + Id;
            this.CompanyName = "Sapient";
            this.FounderName = "Nigel Vaz";
            this.TotalEmployees = 0;
        }
        public static Company GetInstance()
        {
            return company;  //read-only instance
        }
        public int GetTotalEmployees()
        {
            Employee e = new Employee();
            return e.GetTotalEmployees();
        }
    }











    public class Employee
    {
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string DOJ { get; set; }
        public string Projectname { get; set; }
        public ProjectManager projectmanager { get; set; }
        public Company company { get; set; }
        protected static List<Employee> _employees = new List<Employee>();
        public Employee(string name, string PMname)
        {

            int Id = Guid.NewGuid().GetHashCode();
            this.EmployeeID = "SAPIENT" + Id.ToString();
            this.Name = name;
            this.DOJ = "15-06-2021";

        }
        public Employee()
        {

        }
        public bool Add(Employee obj)
        {
            _employees.Add(obj);
            return true;

        }
        public int GetTotalEmployees()
        {
            return _employees.Count;
        }
        public bool Remove(Employee e, string empid)
        {
            if (_employees.Contains(e))
            {
                if (e.EmployeeID == empid)
                {
                    _employees.Remove(e);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }
        public bool Assign(string proj)
        {
            this.Projectname = proj;
            return true;
        }
        public ProjectManager GetPM()
        {
            ProjectManager pm = new ProjectManager();
            pm.pmName = projectmanager.pmName;
            pm.teams = projectmanager.TotalTeams();
            return pm;
        }
        public List<Employee> GetTeamMembers()
        {
            List<Employee> newlist = new List<Employee>();
            foreach (var emp in _employees)
            {
                if (emp.Projectname == "Bootcamp")
                {
                    newlist.Add(emp);
                }
            }
            return newlist;
        }
        public virtual string Works(string[] tasks)
        {
            return "Employee is working";
        }
    }



    public class ProjectManager : Employee
    {
        public string pmName { get; set; }
        public int teams { get; set; }
        public ProjectManager()
        {

        }
        public ProjectManager(string name, int TotalTeams)
        {
            this.pmName = name;
            this.teams = TotalTeams;
        }
        public int TotalTeams()
        {
            return teams;
        }
        public void ListEmployees()
        {
            foreach (var emp in _employees)
            {
                Console.WriteLine($"Employee Id:{emp.EmployeeID}, Employee Name:{emp.Name}\n");
            }
        }
        public override string Works(string[] tasks)
        {
            //return base.Works(tasks);
            return "Project Manager Works";
        }



    }
}