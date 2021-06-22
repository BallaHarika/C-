using System;

namespace BankingSys
{
    class Bank 
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("enter your Adhar no");
            string Name = Console.ReadLine();

             SavingAccount savingaccount = new SavingAccount(Name);

             int Balance = 0;
          

         //   Account  = savingaccount.CreateAccount(Name , Balance);
            
           


            Console.WriteLine(savingaccount.Credit(2000));


            Console.WriteLine( savingaccount.Debit(1400));

                   
          





        }





    }

}

