using System;

namespace Lab1_MovieName
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadInputToArray();
        }

        static void ReadInputToArray()
        {

            Console.WriteLine($"enter moviename:director name:cast,cast");
            string input = Console.ReadLine();
            string[] arr = input.Split(':');
            Console.WriteLine($"movie name :{arr[0]}");
            Console.WriteLine($"director name:{ arr[1]}");

            string[] a = arr[2].Split(',');
            foreach (string item in a)
            {
                Console.WriteLine($"cast:{item}");

            }
        }


    }
}
