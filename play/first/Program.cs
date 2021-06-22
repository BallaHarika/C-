using System;

namespace first
{
    class Program
    {

        public static int aInt = 100;
        public static string astr = "harika balla";
        static void Main(string[] args)
        {


            bool inMain = true;
            Console.WriteLine("Hello World!");
            Console.WriteLine(Program.aInt);
            Console.WriteLine(first.Program.astr);
            Console.WriteLine(inMain);
            TypeChanges();



            Console.WriteLine("Hello World!");

            CreatSimpleArray();
            //===startofdemo4==============//
            CreateArrayOfThree(1,2,3);
            //-------startofdemo5---------//
            ReadInputToArray();
            //------satrtofdemo 6====//

            //====testing pass by val====//
            int arg=4;
            squareval(arg);
            Console.WriteLine($"the value of arg after function is:{arg}");
            //====testing pass by ref======//

            squareref(ref arg);
             Console.WriteLine($"the value of arg after passing by,ref to function is:{arg}");
            //resing in& out parameters;
            squareIn(in arg);
          //  GUID licensekey=new GUID();(GUID is global unique identifier)
          //
          //or
            
            
            Guid licensekey=Guid.NewGuid();
            string outstatus=String.Empty;
            bool isverified= VerifyLicense(in licensekey,out outstatus );
            
            
            
            
            
            Console.WriteLine($"The license verification returned {isverified}.The status message is:{outstatus}");
            Console.WriteLine($"The license key suppiled is:{licensekey}");



            //=======start demo 8=========//
            Useparams(10,20,30,40,50);
            Useparams(111);
            Useparams(222,333,555);

            //====start of demo 9====//
            UseDefault(1001);
            UseDefault(9001,"HP");


            int val=10;
            string str="harika";

            allparams(val,ref val ,in val ,out str,"50",20,50,50);
            //  paramspam(10,20,30,"ball","cat","mat");
            //========start of demo 10====//
            test objsample = new test();
            objsample.strprop = "Helllo oops";
            Console.WriteLine($"value of strprop is: { objsample.DoSomething()}");
        }
        static void TypeChanges()
        {
            int changedInt = 0;
            short shortInt = 100;

            changedInt = (int)shortInt;
            string str = "100";
            int convertedToInt = Convert.ToInt32(str);
            Console.WriteLine(convertedToInt);
            Console.WriteLine(Convert.ToInt32(str));

        }



        static void CreatSimpleArray()
        {
            int[] ints;
            ints = new int[5];
            ints[0] = 111;
            ints[1] = 222;
            ints[2] = 333;
            //breakpoint
            
            ints = new int[] {100, 200, 300, 400, 500 };

            foreach(int item in ints)
            {
              //  Console.WriteLine(item);
                Console.WriteLine($"current item:{item}");
            }
        }
        static void CreateArrayOfThree(int n1,int n2,int n3)
        {
            int[] result = new int[] { n1, n2, n3 };
            Console.WriteLine($"the value at pos 1 is{result[1]}");
        }

       static void ReadInputToArray()
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(',');
            foreach(string item in arr)
            {
                Console.WriteLine($"seperated values of strings :{item}");
            }
        }
        static void squareval(int  valparameter)
        {
             valparameter= valparameter*valparameter;
        }
        static void squareref(ref int refparameter)
        {
            refparameter=refparameter*refparameter;
        }

        static void squareIn(in int inparameter)
        {
            //inparameter=100;not allowed

            int result=inparameter*inparameter;
            Console.WriteLine($"the result of square using in parameter:{inparameter*inparameter}");
        }

        static bool VerifyLicense(in Guid licensekey,out string outstatus)
        {
            //isd4-ghks-jkk=>GUID
            if(string.IsNullOrEmpty(Convert.ToString(licensekey)))
            {
                outstatus=" The key is  a validated successfully";
                return true;
            }
            else
            {
                outstatus="invalid key";
                return false;
            }
       }
             static void Useparams(params int[] ints )
            {

                int result=0;
                foreach(int item in ints)
                {
                    result+=item;
                    
                }
                 Console.WriteLine($"the sum is:{result}");
            }

                  
        static void UseDefault(int id,string empPrefix="SAPI")
        {
            string empid=$"{empPrefix}-{id}-{Guid.NewGuid()}";
            Console.WriteLine($"The generated empid is :{empid}");

        }
       
        static  void allparams(int id, ref int num,in int no  ,out string str ,string empid="91",params int[] ints)
        {
           int id1=id*id;
           int num1=num*num;
           int no1=no+no;
            int result=0;
            str="hello";
            Console.WriteLine($"id is:{id1} reference num is:{num1} in value is :{no1} outstring is :{str} defaultpar is :{empid} ");
          foreach(int item in ints)
                {
                   result=result+item;
                    
                }
            Console.WriteLine($"params result is:{result}");
        }
       
    


    }

}
