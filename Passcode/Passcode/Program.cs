using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your pass code");
            var passcode = Console.ReadLine();
            if (passcode == "secret")
            {
                Console.WriteLine("authenticated");
            }
            else if(passcode!="secret"){
                Console.WriteLine("Not authenticated");

            }
        }
    }
}
