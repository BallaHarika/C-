using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
        public interface  ILogger
        {
            void Log(LogEntry entry); 
        }

     public class LogEntry
    { 
          public DateTime LogTime { get; set; }
          public string Message { get; set; }

    }
    public class ConsoleLogger : ILogger
    {
        public void Log(LogEntry entry)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine($"Log entry at {entry.LogTime}:{entry.Message}");
            Console.ResetColor();
        }

    }
}

