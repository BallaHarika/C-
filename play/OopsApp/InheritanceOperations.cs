using System;
using System.Collections.Generic;
using System.Text;

namespace OopsApp
{
    //Base class
    public class Rectangle
    {

        public Rectangle(int length,int breadth)
        {
            Length = length;
            Breadth = breadth;


        }
        protected int Length { get; set; }
        protected int Breadth { get; set; }

        public int CalculateArea()
        {
            return Length = Breadth;
        }

    }
    //Derived class
    public class Square :Rectangle
    {
        public Square(int side):base(side,side)
        {
            AccessRectangleprop();


        }
       public string AccessRectangleprop()
        {
            

          //  CalculateArea();
            return $"This square has a side of dimension :{Length}cm. The area of this square is :{CalculateArea()}";
        }
        public void AccessingSealed()
        {
            ICannotBeDerived sealedclass = new ICannotBeDerived();
            Console.WriteLine(sealedclass.CallMe());

        }

    }
    public sealed class ICannotBeDerived
    {
        public string CallMe()
        {
            return "Hi, i'm accessible ,Don't try to change me.";
        }


    }
    public static class ICannotBeInstantiated
    {
        
      
     
            static ICannotBeDerived obj=new ICannotBeDerived();
            public static void CallMe()
            {

            }
      
    }
    public class OnlyStaticFunction
    {
         public static  void AnotherMain()
         {
                Console.WriteLine("i'm a static function in a non static class");
         }
          public void NormalMethod()
          {
                     Console.WriteLine("I'm a non static function in a non static class");
          }
    }
 /*   public class TestClass : ICannotBeInstantiated
    {

      
    }*/
        
  //}

   
}
