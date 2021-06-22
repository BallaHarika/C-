using System;
using System.Collections.Generic;
using CoreLogicLayer2;
namespace UI2
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();

            ProjectManganer proj = new ProjectManganer();
            Company com = new Company();

            Console.WriteLine("----- Welcome to Sapient MIS ----");


            int j = 0;
            while (j == 0)
            {
                
                

                Console.WriteLine(" press 1 for Create a    Employee  " +
                    "press 2 for Create a project Manager for  employees \n press 3 for assign PM to employee" +
                    " \n  press 5 for exit ");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Please Enter your name");


                        string name = Console.ReadLine();

                        Console.WriteLine("Please Enter your project manager name");
                        string Mangaername=Console.ReadLine();
                        Employee empp=emp.EmployeeDetails(name,Mangaername);
                        emp.Add(empp);
                        com.empDetails.Add(empp);
                        Console.WriteLine($"emp id :{empp.EmployeeId}");
                        Console.WriteLine($"emp name:{ empp.Name}");
                        Console.WriteLine($"company name{empp.company.CompanytName}");
                        Console.WriteLine(empp.DateofJoining);
                         
                        break;

                    case 2:


                        Console.WriteLine("Please Enter your project manager name");
                        string ProjectManagerName = Console.ReadLine();



                      //  Employee temp =emp._employees.Find((p) => p.Name == ProjectManagerName);


                       

                        Console.WriteLine("Please Enter total teams");
                        int teamcount = int.Parse(Console.ReadLine());
                        proj.ProjecetMangerName = ProjectManagerName;
                        proj.TotalTeams = teamcount;

                        

                        break;

                    

                    case 3:
                        Console.WriteLine("Please Enter project manager name");
                        string pname = Console.ReadLine();
                        Console.WriteLine("Please Enter employee name");
                        string ename = Console.ReadLine();
                       
                        Employee projemp = com.empDetails.Find((p) => p.Name ==pname);
                        if (projemp != null)
                        {
                            Employee emp2 = com.empDetails.Find((p) => p.Name == ename);

                            projemp.Add(emp2);
                            emp2.projectManager = proj;
                            Console.WriteLine("Added");
                            List<Employee> teammem = projemp.GetTeamMembers();
                            Console.WriteLine("Team members list");
                            foreach (Employee item in teammem)
                            {
                                Console.WriteLine($"emp's under projeect manager{item}");

                            }
                        }
                        break;
                    
                    case 5:
                        j = 3;
                        break;
                    default:
                        break;




                }


            }



        }
    }
}

