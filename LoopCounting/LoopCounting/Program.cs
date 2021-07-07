using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<5;i++)
            {
                for(int j=1;j<=10;j++)
                {
                    Console.WriteLine(j);
                }
                for(int j=10;j>=1;j--)
                {
                    Console.WriteLine(j);

                }
            }
            
        }
    }
}
