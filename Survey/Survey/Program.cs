using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();
            Console.WriteLine("your name is :{0} \nyour age is:{1} \nyour birth month is:{2}",name, age, month);

            

        }
    }
}
