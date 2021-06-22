using System;

namespace OopsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.Main(null);


            //Program objprogram=new Program();
           // objprogram.Main(null);


            Person Samprada = new Person();
            Person sairam = new Person();


          //  Person harika = new Person("abc14532072");
            //Person pragathi = new Person("cc2ji4528043","pragathi","female","TN",23);
            AssignProperties(ref Samprada, "ADH2394u302493222", "samprada N", 23, "Female", "Banglore", "Wheatish");
            AssignProperties(ref sairam, "BDH394u3024932222", "sairam N", 25, "male", "Banglore", "Wheatish");

            //cal function for samprada
            CallpersonFunction(ref Samprada);
            CallpersonFunction(ref sairam);



            //==== Demo 15=====//

            Square sq = new Square(10);
            Console.WriteLine(sq.CalculateArea());

           
            Rectangle rec = new Rectangle(10,5);
            Console.WriteLine(rec.CalculateArea());




            //=====Demo 16===

               sq.AccessingSealed();





            //===DEMO 17====

            //Testing static
            //1.Test static class
            ICannotBeInstantiated.CallMe();

            OnlyStaticFunction.AnotherMain();

            OnlyStaticFunction objNonstaticClass = new OnlyStaticFunction();
            objNonstaticClass.NormalMethod();




            //======DEMO 18=======//

            //singleton pattern

            SingletoProjectSettings mysettings = SingletoProjectSettings.GetInstance();


            mysettings.AssemblyName = "Oopsapp";
            mysettings.DefaultNamespace = "Oopsapp";
            mysettings.TargetFramework = ".NET Core 3.1";
            mysettings.OutputType = "console app";


            Console.WriteLine("printing values of object mysetting");
            Console.WriteLine(SingletoProjectSettings.GetInstance().AssemblyName);
            Console.WriteLine(SingletoProjectSettings.GetInstance().DefaultNamespace);
            Console.WriteLine(SingletoProjectSettings.GetInstance().TargetFramework);
            Console.WriteLine(SingletoProjectSettings.GetInstance().OutputType);
            Console.WriteLine(mysettings.TargetFramework);



            SingletoProjectSettings mysettings2 = SingletoProjectSettings.GetInstance();

            
            Console.WriteLine("printing values of object mysettings2");
            Console.WriteLine(mysettings2.AssemblyName);
            Console.WriteLine(mysettings2.DefaultNamespace);
            Console.WriteLine(mysettings2.TargetFramework);
            Console.WriteLine(mysettings2.OutputType);


            mysettings.AssemblyName = "Changedvalue";
            Console.WriteLine($"value of mysettings assemblyName:{mysettings.AssemblyName}");
            Console.WriteLine($"value of mysettings assemblyName:{mysettings2.AssemblyName}");



            //========Demo19======//

            //Experimenying with Runtime Polymorphism
            Console.WriteLine("please type c for circle and t for triangle");
            string shape = Console.ReadLine();
            Shape sh;
            switch (shape)
            {
                case "c": //Base class object=new derived class()
                    sh = new Circle();
                    ((Circle)sh).Radius = 10;
                    Console.WriteLine( sh.Draw());
                    Console.WriteLine(sh.GetStatus());


                    Circle c = new Circle();
                    c.Radius = 30;
                    Shape sResult = c.Clone();

                    Console.WriteLine($"A clone is created with a value of property {nameof(c.Radius)} ={ c.Radius}");
                    Console.WriteLine($"A clone of original with a value of property {nameof(c.Radius)}= {((Circle)sh).Radius}");
                    Console.WriteLine($"A clone of original with a value of property {nameof(c.Radius)}= {((Circle)sResult).Radius}");



                    break;
                case "t"://Base class object=new derived class()
                    sh = new Triangle();
                    ((Triangle)sh).Height = 5;
                    ((Triangle)sh).Base = 10;
                   
                    Console.WriteLine( sh.Draw());
                    Console.WriteLine(sh.GetStatus());
                    break;

                case "ex":
                    try
                    {
                        Shape s = null;

                        Console.WriteLine(s.NormalProperty);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"error occured {ex.Message}");

                    }
                    break;





                default:
                    throw new Exception(" Invalid shape cannot be drawn");

                    break;
            
            
            }


            //=======Demo  20 =====//

            NewFeatures features= new NewFeatures();

            Tuple<int,string,bool> result_v1 = features.GetValues123_v1();
            Console.WriteLine($"result of v1 are:{nameof(result_v1.Item1)}={result_v1.Item1},"+$"{nameof(result_v1.Item2)}={result_v1.Item2},{nameof(result_v1.Item3)}={result_v1.Item3}");


            var result_v2 = features.GetValues123_v2();
            var result_v3 = features.GetValue123_v3();

            Console.WriteLine($"result of v3 are:{nameof(result_v3.rValue)}={result_v3.rValue}," + $"{nameof(result_v3.name)}={result_v3.name},{nameof(result_v3.isTrue)}={result_v3.isTrue}");



            //=======demo21======//

            features.TestShapes(new Circle());


        }

        private static void CallpersonFunction(ref Person obj)
        {
            bool isMultipleTasks = obj.Works("coding", "testing");

            string workstatus = string.Empty;
            bool isWorks = obj.Works("Coding", out workstatus);
            Console.WriteLine($"{obj.Name} complexion status:{isWorks}. work status :{workstatus}");
            Console.WriteLine(obj.Eats());
            Console.WriteLine($"{obj.Name} has a sleep cycle of {obj.sleep()}");
            Console.WriteLine(obj.Speaks("Good Day"));


  


            Console.WriteLine($"aadhar no of{obj.Name} is:{obj.Aadhar}");
            Console.WriteLine($"addess  of{obj.Name} is:{obj.Address}");
            Console.WriteLine($"age  of{obj.Name} is:{obj.Age}");
            Console.WriteLine($"complexion  of{obj.Name} is:{obj.complexion}");
            Console.WriteLine($"gender  of{obj.Name} is:{obj.Gender}");


        }

        private static void AssignProperties(ref Person obj, string aadhar, string name, int age, string gender, string address, string complexion)
        {
            obj.Aadhar = aadhar;
            obj.Address = address;
            obj.Age = age;
            obj.complexion = complexion;
            obj.Gender = gender;
            obj.Name = name;
           


        }
    }
}
