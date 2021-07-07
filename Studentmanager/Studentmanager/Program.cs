using System;
using System.Collections.Generic;

namespace Studentmanager
{
    class Program
    {
        static void Main(string[] args)
        {

            var name = new List<string>();
            var grade = new List<int>();
            var add = true;

            while (add)
            { 


            util.Console.Ask("student name");
 
            Console.WriteLine("student grade :");
            grade.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("add another person?yes/no");
                if (Console.ReadLine() !="yes")
                    add = false;

            }
            
            for(int i = 0; i <name.Count; i++)
            {

                Console.WriteLine("student name:{0},student grade:{1}", name[i], grade[i]);


            }

        }
    }
}
