using System;

namespace FindMin
{
    class Minfind
    {
        static int findMin(int[] b)
        {
            int min = b[1];
            for(int i=0;i<b.Length;i++)
            {
                int temp = b[i];
               int nextelement = b[i];
                if(min>temp)
                {
                    min =b[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] a = { 78, 37, 26, 49 ,2};
            int minvalue = findMin(a);

            Console.WriteLine(minvalue);
        }
    }
}
