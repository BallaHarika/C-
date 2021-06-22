using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSys
{
    
    public class Account
     {
        static double amount = 0;

        public Account(string Name) { }
        

            string AccountHolderName { get; set; }
            string AccountId { get; set; }
            protected double balance { get; set; }
            protected Guid uniqueAccId;
        
        public   bool CreateAccount(string Name, double Balance)
            {

            Console.WriteLine("please enter your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("please enter your last name");
            string lastname = Console.ReadLine();
            string[] namearray = { firstname, lastname };


             double balance = Balance;
              AccountHolderName = Name;
              Guid AccountId = Guid.NewGuid();

            string userid = firstname.Substring(0, 3) + lastname.Substring(0, 4);

            Console.WriteLine($"user successfully registered .user uniqueid is :{AccountId }");
            Console.WriteLine($"your userid is:{userid}");
           


             return true;
            }



        }

       public class SavingAccount : Account
        {
      
            public SavingAccount(string Name) : base(Name) { }
          public  double Credit(double amount)
             {
            

              balance = balance + amount;

              return balance;
           
             }

          public  double Debit(double amount)
            {

            if (balance - amount < 0)
            {
                Console.WriteLine("insufficiant amount");


                return 0;
            }
            else
            {


                balance = balance - amount;
            }

            return balance;
            }




        }
}

