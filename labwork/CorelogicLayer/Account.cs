using System;
using System.Collections.Generic;
using System.Text;

namespace CorelogicLayer
{
      
    public abstract class Account
    {

        
        public string name { get; set; }
        public int AccountId { get; set; }
        public  abstract Account Create(string name, int balance);
        public abstract bool Delete(int id);



    }
    public class SavingsAccount:Account
     {
     
        //List<Account> accountBook = new List<Account>();


   
        public double Balance { get; private set; }
        
       
        public double Credit(double amount)
        {

           

           
            Balance = Balance + amount;
            Console.WriteLine($"U r balance is{Balance}");




            return Balance;

              
        }
        public double Debit(double amount)
        {



            if (Balance > amount)
            {

                Balance = Balance - amount;
                Console.WriteLine($"U r balance is{Balance}");
                }
                else
                {
                    Console.WriteLine("insufficient amount in the account");
                    
                }

               
            

           
            return Balance;
         
            
        }
         
        public override Account Create(string name,int balance)
        {
           Account ac = new SavingsAccount();

            Console.WriteLine("creating account -------");
             
         

            double Balance = balance;

            int AccountId = (Guid.NewGuid().GetHashCode());

            ac.AccountId = AccountId;
            ac.name = name;
            
     
            Console.WriteLine($"user successfully registered .user uniqueid is :{AccountId }");

          //  accountBook.Add(ac);

            return ac;

        }
      
        public override bool Delete(int userid)
        {



            return false;

        }

      
    }


}
