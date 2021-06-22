using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelLamdas
{
    //Declaration
   delegate int AddDel(int a, int b);
   public class Delegates
    {
        public int Start(int a,int b)
        {
            //Instantiate the delegate

            AddDel objDel = new AddDel(Add);
            //instance using anonymous function
            


            //using Lamdas,Delgete object objLambdel points to anon    



            //Invocation
            return objDel(100,50);

        }

        public int UsinganonymousMethod(int a,int b)
        {
            AddDel objAnonDel = new AddDel(delegate (int a, int b) { return a + b; });
            objAnonDel += delegate (int a, int b) { return a - b; };
            return objAnonDel(a,b); //50
        }

        public int UsingLambda(int a,int b)
        {
            AddDel objLamdaDel = (int a, int b) =>
             {
                int r = a + b;
                return r;

             };

            AddDel objshortlambda = (a, b) => a + b;
            return objshortlambda(a, b);

        }
     


      //  Func<string, bool> condition = (movies) => movies == "pk";

        private int Add(int a,int b)
        {
            
            return a + b;
    
        }
 

        #region Generic Delegates

        public void F1()
        {
            Func<int, int, int> likeAddDel = (a, b) => a + b;
          
            Action<int, int> doesNotReturnValue = (a, b) => Console.WriteLine(a + b);
            Predicate<string> onlyReturnsBool = (str) => str == string.Empty;

            Console.WriteLine(likeAddDel(100, 200));  //doubt 4

            Console.WriteLine($"Predicate<> output: {onlyReturnsBool}");








            Console.WriteLine(doesNotReturnValue);
        }


        public void Delparam(Func<string,string> fn)
            {
               Console.WriteLine( fn("neeta"));//doubt 5

            }
        public void printsomething()
        {
            string[] movies = { "Hera pheri-priya darshan -paresh rawl", "3 Idiots -Rajukumar Hirani-Amir Khan,kk" };
            int[] ints = { 10, 20, 30, 40 };
               ints.ToList().ForEach((items) =>
                {
                Console.WriteLine(items);
                });
 
                movies.ToList().ForEach((movie) =>
                {
                    
                    string[] splits = movie.Split('-');


                    Console.WriteLine(splits[0]);
                    Console.WriteLine(splits[1]);
                    Console.WriteLine(splits[2]);




                });


            Func<string, bool> condition = (movie) => movie == "pk";
            movies.Where(condition);
            //The above line can be represented as follows.

            Console.WriteLine($"is this movie name? 'pk'{movies.Where((movie) => movie=="3 Idiots -Rajukumar Hirani-Amir Khan,kk").FirstOrDefault()}");


            //LINQ
            var result = (from movie in movies
                          where movie == "Hera pheri-priya darshan -paresh rawl"
                          select movie).FirstOrDefault();

            Console.WriteLine($"result using LINQ:{result}");

            // "LINQ" => Language Integrated Query => Lambdas representes in a query format
            //SQL
            //select  * from movies where moviename = "PK"

            //LINQ
            //from movie in movies
            //where movie.moviename == "PK"


            //LAMBDAS
            //movies.where(movie=>movie.moviename == "PK")

           
                string[] list = new string[2];
                foreach (var movie in movies)
                {
                    int i = 0;
                    if (movie == "Hera pheri-priya darshan -paresh rawl")
                    {
                        list[i] = movie;
                    }
                    i++;
                }
                 //return list;
            
        }
       

        /*foreach(var item in ints)
        {

        Console.WriteLine(item);

        }

        */

        #endregion Generic Delegates

    }
}
