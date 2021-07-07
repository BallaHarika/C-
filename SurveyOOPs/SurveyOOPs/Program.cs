using System;

namespace SurveyOOPs
{
    class student
    {
        public String name;
        public int age;
        public string month;
        public int grade;
        public void display()
        {
            Console.WriteLine("name:{0} ,age:{1},month:{2},grade:{3}",name,age,month,grade);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var student = new student();
            Console.WriteLine("student name");
            student.name = Console.ReadLine();

            Console.WriteLine("student age");
            student.age= int.Parse(Console.ReadLine());

            Console.WriteLine("birth month");
             student.month = Console.ReadLine();

            Console.WriteLine("grade");
            student.grade=int.Parse(Console.ReadLine());

            student.display();

            
        }
    }
    
}
