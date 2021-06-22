using System;

namespace Banksystem1
{
    class Program
    {
        static int totalbalance = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("please enter your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("please enter your last name");
            string lastname = Console.ReadLine();


            Console.WriteLine("please enter credit amount");
            int creditamount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter debit amount");
            int debitamount = Convert.ToInt32(Console.ReadLine());


            Guid uniqueAccId = Register(firstname, lastname);
            totalbalance = Credit(uniqueAccId, creditamount);
            totalbalance = Debit(uniqueAccId, debitamount);
            Console.WriteLine($"Total amount is:{ totalbalance}");

        }
        static Guid Register(string firstname, string lastname)
        {
            string[] namearray = { firstname, lastname };
            Guid uniqueAccId = Guid.NewGuid();
            string userid = firstname.Substring(0, 3) + lastname.Substring(0, 4);

            Console.WriteLine($"user successfully registered .user uniqueid is :{uniqueAccId}");
            Console.WriteLine($"your userid is:{userid}");
            return uniqueAccId;
        }

        static int Credit(Guid uniqueAccId, int creditamount)
        {


            totalbalance = totalbalance + creditamount;

            return totalbalance;

        }
        static int Debit(Guid uniqueAccId, int debitamount)
        {

            if (totalbalance - debitamount < 0)
            {
                Console.WriteLine("insufficiant amount");


                return 0;
            }
            else
            {
                totalbalance = totalbalance - debitamount;

                return totalbalance;
            }

        }

    }
}
