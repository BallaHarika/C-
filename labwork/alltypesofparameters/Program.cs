using System;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            ReadInputToArray();


            int val = 10;
            string str = "harika";
            allparams(val, ref val, in val, out str, "50", 20, 50, 50);
         

        }
        static void ReadInputToArray()
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(':');
            Console.WriteLine($"movie name :{arr[0]}");
            Console.WriteLine($"director name:{ arr[1]}");

            string[] a = arr[2].Split(',');
            foreach(string item in a)
            {
                Console.WriteLine($"cast:{item}");
       
            }
        }

        static void allparams(int id, ref int num, in int no, out string str, string empid = "91", params int[] ints)
        {
            int id1 = id * id;
            int num1 = num * num;
            int no1 = no + no;
            int result = 0;
            str = "hello";
            Console.WriteLine($"id is:{id1} reference num is:{num1} in value is :{no1} outstring is :{str} defaultpar is :{empid} ");
            foreach (int item in ints)
            {
                result = result + item;

            }
            Console.WriteLine($"params result is:{result}");
     
    }
}
