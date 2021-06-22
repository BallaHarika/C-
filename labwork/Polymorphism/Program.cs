using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please type m for maruti and b for Benz and type f for ferrari");
            string Car = Console.ReadLine();
            Car sh;
            switch (Car)
            {
                case "m": //Base class object=new derived class()
                    sh = new Maruti();
                    ((Maruti)sh).price = 1000000;
                    Console.WriteLine(sh.Purchase());
                    break;
                case "b"://Base class object=new derived class()
                    sh = new Benz();
                    ((Benz)sh).price = 5000000;

                    Console.WriteLine(sh.Purchase());
                    break;

                case "f"://Base class object=new derived class()
                    sh = new Ferrari();
                    ((Ferrari)sh).price = 2500000;

                    Console.WriteLine(sh.Purchase());
                    break;


                default:
                    Console.WriteLine(" Invalid car name cannot be purchased");
                    break;


            }


        }
    }
}
