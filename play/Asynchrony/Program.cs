using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchrony
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Method1();
            // Method2();

            //  ModifiedMethod1();


            //  MIM2();


            // MustUseAwait();
            //  UseConcurrentBag();
          //  UsingTaskCancellation();
          //  UseConcurrentBagWithAwait();

               // ParallelLoop();
                //  UsingExceptionFilters((errorCode)=>LogError(errorCode));
            Console.ReadLine();

        }
      /*  public static async Task LogError(int errorCode)
        {
            Console.WriteLine($"##### ERROR  OCCURED :Error code:{errorCode}");
        }*/
        public static async void MIM2()
        {
            Method1();
            Method2();
        }
        public static async void withAwaitMIMI2()
        {
            await Method1();
                  Method2();
        }

        public  static async  Task Method1()
        {
            await Task.Run(()=>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine($"M1-{i} Method 1");
                }
            });
        }

        public static async Task<int> ModifiedMethod1()
        {

            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine($"M1-{i} Method modified 1");
                    count += 1;
                }
            });
            return count;
        }
            

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine($"M2-{i} Method 2");
            }

        }
        public static void Method3(int count)
        {
            Console.WriteLine($"The value of count is {count}");
        }
        public static async void MustUseAwait()
        {
            Task<int> task = ModifiedMethod1();
            Method2();
            int count = await task;
            Method3(count);


        }


        public static void ExecuteMultipleTasks()
        {
            TaskFactory factory = new TaskFactory();

            /*            factory.StartNew(() =>
                        {
                            Method2();
                        });*/
            factory.StartNew(() => Method2());

            factory.StartNew(()=>Method3(9999));

            Task.Factory.StartNew(() => Method2());


        }

        public static void UseConcurrentBag()
        {
            ConcurrentBag<Task> taskbag = new System.Collections.Concurrent.ConcurrentBag<Task>();
            Task t1 = new Task(() => Method1());
            Task t2 = new Task(() => Method2());


            taskbag.Add(t1);
            taskbag.Add(t2);

            foreach(var t in taskbag)
            {
                t.Start();
                Console.WriteLine($"Id:{t.Id},status :{t.Status},IsCancelled :{t.IsCanceled}");
            }



        }
        public static async void UseConcurrentBagWithAwait()
        {
            ConcurrentBag<Task> taskbag = new System.Collections.Concurrent.ConcurrentBag<Task>();
            Task t1 = new Task(() => Method1());
            Task t2 = new Task(() => Method2());


            taskbag.Add(t1);
            taskbag.Add(t2);

            foreach (var t in taskbag)
            {
                await Task.Run(() => t.Start());
                Console.WriteLine($"Id:{t.Id},status :{t.Status},IsCancelled :{t.IsCanceled}");
            }



        }

        public static void UsingTaskCancellation()
        {
            //step1 :Intialize cancellation token source to cancel a task
            CancellationTokenSource tokenSource = new CancellationTokenSource();

            CancellationToken token = tokenSource.Token;

            //start a new task by passing the concellation token

            Task t = Task.Factory.StartNew(() =>
            {
                int counter = 1;
                while(!token.IsCancellationRequested)
                {
                    Console.WriteLine(counter++);
                    Thread.Sleep(1000);
                }

            }, token
            );


            Console.WriteLine("===press any key to cancel this task ====");
            //one key to cancel the task
            Console.ReadKey();
            tokenSource.Cancel();  //cancels a running task
            Console.WriteLine("Task cancelled");


        }

        public static void ParallelLoop()
        {

            List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> longerInts = Enumerable.Range(1, 1000).ToList();
             Parallel.ForEach(longerInts, (singleInt) =>
             {
                 Console.WriteLine($"parallel printing {singleInt}");
             });

        }
        public static async void UsingExceptionFilters(Func<int, Task> onError)
        {
            try
            {
                string s = null;
                s.Contains("abc"); //NullReference exception
            }
            catch (Exception ex)
            {
                await onError(ex.GetHashCode());
                // throw;
                return;
            }
        }
            public static async Task LogError(int errorCode)
            {
                Console.WriteLine($"##### ERROR  OCCURED :Error code:{errorCode}");
            }


        


    }
}

