using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack names = new Stack(5);
            names.push("Harika");
            names.push("vidya");
            names.push("Haritha");
            names.push("Laxmi");
            names.push("Srinivas");
            Console.WriteLine("================== \nAbout to peek:");
            Console.WriteLine("'" + names.peek() + "'" + " is at the top of the stack.\n");

            Console.WriteLine("================== \nThe Stack contains:\n");
            while (!names.isEmpty())
            {
                string name = names.pop();
                Console.WriteLine(name);
            }

        }


    }

    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }
        public void push(string m)
        {
            if (isFull())
            {
                Console.WriteLine("This stack is full");
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }  
            public string pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("The stack is empty.");
                    return "--";
                }
                else
                {
                    int old_top = top;
                    top--;
                    return stackArray[old_top];
                }
            }
            
              public string peek()
             {
                  return stackArray[top];
             }

                 public bool isEmpty()
                {
                 return (top == -1);
                 }

                    public bool isFull()
                    {
                     return (maxSize - 1 == top);
                    }


    }

    

}
