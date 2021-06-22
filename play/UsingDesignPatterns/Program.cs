using System;
using Absiphonefactory;
using AdapterPattern;
namespace UsingDesignPatterns
{
    class Program
    {
        static ILogger myLogger;
        static void Main(string[] args)
        {


             Console.WriteLine("choose Logger:('c': console | 'f' :file)");
            string userInput = Console.ReadLine();
            myLogger = GetCorrectLogger(userInput);
            //start Logging//
            myLogger.Log(new LogEntry() { LogTime = DateTime.Now, Message = "Working with choosing the apple store" });
            MobileClient client = new MobileClient(new ApplePcmc(), "oneplus");

            myLogger.Log(new LogEntry() { LogTime = DateTime.Now, Message = $"Mobile client chosen:{client.GetType().Name}" });
            Console.WriteLine(client.GetPhoneDetails());

            myLogger.Log(new LogEntry() { LogTime = DateTime.Now, Message = $"Phone details printed successfully" });
           
        }


        private static ILogger GetCorrectLogger(string userInput)
        {
            switch(userInput.ToLower())
            {
                case "f":
                    return new DbAdapter();
                case "c":
                    return new ConsoleLogger();
              default:
                    return new ConsoleLogger();
            }
        }
    }
}
