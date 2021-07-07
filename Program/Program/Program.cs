using System;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of students in a class");
            var count =int.Parse( Console.ReadLine());
            var name = new string[count];
            var grade = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("student name");
                name[i] = Console.ReadLine();
                Console.WriteLine("student grade :");
                grade[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < count; i++)
            {

                Console.WriteLine("student name:{0},student grade:{1}", name[i], grade[i]);


            }


            

        }
    }
}
