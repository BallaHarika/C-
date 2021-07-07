using System;
using System.Collections.Generic;
using System.Text;

namespace util
{
    class Console
    {
        static public string Ask(string question)
        {
            System.Console.WriteLine(question);
            return System.Console.ReadLine();

        }
    }
}
