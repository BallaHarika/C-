using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using CoreLogicLayer2;
using log4net;
using log4net.Config;

namespace UI2
{
    class Program
    {

        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

             static void Main(string[] args)
             {
              var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("Log4net.config"));


            string logFile = DateTime.Now.ToString("yyyyMMdd") + ".txt";
            if (!System.IO.File.Exists(logFile))
            {
                System.IO.File.Create(logFile);
            }


            string timeStamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ff");
            string taskComplete = (timeStamp) + " Task Complete";

            



            Employee emp = new Employee();

            ProjectManganer proj = new ProjectManganer();
            Company com = new Company();

            Console.WriteLine($"----- Welcome to Sapient MIS ----");
            Console.WriteLine($"Founder name :nigel vaz");


            int j = 0;
            while (j == 0)
            {
 
                Console.WriteLine(" press 1 for Create a    Employee  " +
                    "press 2 for Create a project Manager for  employees \n press 3 for assign PM to employee" +
                    " \n  press 4 for remove employee  +press 5 for exist");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        try
                        {
                           
                            logger.Info("Creating  a  Employee record");
                            Console.WriteLine("Please Enter employee name");

                            string name = Console.ReadLine();
                            Console.WriteLine("Please Enter your project manager name");

                            string Mangaername = Console.ReadLine();

                            Employee empp = emp.empdetails(name, Mangaername);

                            empp.Add(empp);
                            com.empDetails.Add(empp);
                            Console.WriteLine($"emp id :{empp.EmployeeId}");
                            Console.WriteLine($"emp name:{ empp.Name}");
                            Console.WriteLine($"company name:{empp.company.CompanytName}");
                            Console.WriteLine($"employee date of joining:{empp.DateofJoining}");
                            logger.Info("employee details are added and displayed");
                            logger.Warn("for employee list under project manager ,please enter project manager as  an employee");
                        }
                        catch(Exception eX)
                        {
                             logger.Error(eX);
                            Console.WriteLine(eX.Message);
                          
                            

                        }

                        Console.WriteLine($"=================={taskComplete}================");


                        break;

                    case 2:

                        logger.Info("Creating a project Manager for  employees");
                        try
                        {

                            Console.WriteLine("Please Enter your project manager name");
                            string ProjectManagerName = Console.ReadLine();
                            Console.WriteLine("Please Enter total teams");
                            Console.WriteLine("if no emp  added to team then please enter 0 as employee count");
                            int teamcount = int.Parse(Console.ReadLine());
                            proj.ProjecetMangerName = ProjectManagerName;
                            logger.Info("project manager assigned to employee");
                            proj.TotalTeams = teamcount;
                        }
                        catch(Exception e)
                        {
                            logger.Error(e);
                            Console.WriteLine(e.StackTrace);
                        }
                        Console.WriteLine($"=================={taskComplete}================");

                        break;

                    

                    case 3:
                        logger.Info("assigning a  PM to employee");
                        try
                        {

                            Console.WriteLine("Please Enter project manager name");
                            string pname = Console.ReadLine();
                            Console.WriteLine("Please Enter employee name");
                            string ename = Console.ReadLine();

                            Employee projemp = com.empDetails.Find((p) => p.Name == pname);
                            if (projemp != null)
                            {
                                Employee emp2 = com.empDetails.Find((p) => p.Name == ename);

                                projemp.Add(emp2);
                                proj.TotalTeams += 1;
                                emp2.projectManager = proj;
                                Console.WriteLine("Added");
                                List<Employee> teammem = projemp.GetTeamMembers();
                                Console.WriteLine("Team members list");
                                foreach (Employee item in teammem)
                                {
                                    Console.WriteLine($"empolye name   working on project   is {item.Name},employee id is {item.EmployeeId}");

                                }
                                Console.WriteLine($"employee count  workig on projerct is :{proj.TotalTeams}");
                                logger.Info("employees are added successfully to the project Team");

                            }
                            else
                            {
                                Console.WriteLine($"not added");
                                logger.Error("employee not added to employee list");

                            }
                        }
                        catch(Exception ex)
                        {
                            var exceptionType = ex.GetType().FullName;
                            logger.Info(exceptionType);
                            
                        }
                        Console.WriteLine($"=================={taskComplete}================");
                        break;
                    
                    case 4:
                        logger.Info("deleting an employee from employeelist");
                        try
                        {

                            Console.WriteLine("enter empid to delete account ");

                            string empid = Console.ReadLine();

                            Employee temp2 = com.empDetails.Find((p => p.EmployeeId == empid));

                            if (temp2 != null)
                            {
                                com.empDetails.Remove(temp2);
                                Console.WriteLine($"empid {empid} is deleted successfully");
                                logger.Error("empolyee deleted successfully");

                            }

                            else
                            {
                                Console.WriteLine($"empid{empid} is not found ");
                                logger.Error("employee not found in the comapny list");

                            }
                        }

                        catch(Exception ex)
                        {
                            ex.ToString();
                        }


                        Console.WriteLine($"=================={taskComplete}================");

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

