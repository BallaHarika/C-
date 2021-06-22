using System;

namespace DelegatesAndLambdas
{
    class Program
    {
        static void Main(string[] args)
        {

            DelsLambdas obj = new DelsLambdas();
            Console.WriteLine($"using  delegate object: {obj.Start(100, 200)}");



            Console.WriteLine($"using  Delegate output:{obj.SubMethod(100, 200)}");


            Console.WriteLine($"using  anonymous Delegate output:{obj.UsinganonymousMulMethod(100, 200)}");

            Console.WriteLine($"using  Lamda output:{obj.UsingLambda(200, 100)}");
            PrintSomething();

        }


        public static void PrintSomething() => Console.WriteLine("Printing something ");
        


    }

}

