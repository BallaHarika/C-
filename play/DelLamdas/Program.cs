using System;

namespace DelLamdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegates obj = new Delegates();
            Console.WriteLine($"using  delegate object: {obj.Start(100, 200)}");


            //using anonymous functins
            Console.WriteLine($"using anonymous Delegate output:{obj.UsinganonymousMethod(100, 200)}");

            //using lambda
            Console.WriteLine($"using Lamda Delegate output:{obj.UsingLambda(100, 200)}");

            DoSomething();

            Console.WriteLine(CanIUseLamdas);
            //CanIUseLamdas = false; //cannot be done



            //Generic Delegate Func()
            obj.F1();

            //passing func as parameter

            Func<string, string> f1 = (str) => $"Welcome {str}";
            obj.Delparam(f1);

            obj.printsomething();


            }

        public static void DoSomething() => Console.WriteLine("Did Something !!!:D");


        //Read-only property
        public static bool CanIUseLamdas { get => true;  } 
    }
}

