using System;
using System.Collections.Generic;

namespace BankApp
{
    class Program
    {

        static void Main(string[] args)
        {
            SavingAccount sav = new SavingAccount();



            Account temp = Account.GetInstance();

            int j = 0;
            while (j == 0)
            {

                Console.WriteLine("press 1 for create account \n press 2 for credit amount \n press 3 for debit amount \n press 4 for delete account \n press 5 for exit ");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("enter your name");
                        string Name = Console.ReadLine();
                        int Balance = 0;
                        string a = sav.Create(Name, Balance);

                        break;

                    case 2:
                        Console.WriteLine("crediting amount to the account");
                        int creditamount = int.Parse(Console.ReadLine());

                        sav.Credit(creditamount);

                        break;

                    case 3:
                        Console.WriteLine("debiting amount to the account");
                        int debitamount = int.Parse(Console.ReadLine());

                        sav.Debit(debitamount);
                        break;

                    case 4:
                        Console.WriteLine("enter accounid to delete account ");

                        string userid = Console.ReadLine();

                        sav.Delete(userid);



                        break;
                    case 5:
                        j = 3;
                        break;
                    default:
                        break;




                }


            }
        }

        public class Account
        {
            public string name { get; set; }
            public string AccountId { get; set; }
         
           

          
            private static readonly Account _instance = new Account();
            protected Account() { }

            //here return type of instance is Singletoprojectsettings
            public static Account GetInstance()
            {
                return _instance;
            }
        }
        class SavingAccount : Account
        {

            // this.accountBook;
            public List<string> accountBook = new List<string>();

            public SavingAccount() { }
            public static double Balance { get; private set; }
            

            public double Credit(double amount)
            {


                Console.WriteLine("please enter the accountid to credit money");
                string creditId = Console.ReadLine();
                Console.WriteLine(accountBook.Count);
                foreach (string item in accountBook)
                {
                    string c = item;
                    if(String.Equals(item, creditId))

                    {
                        Balance = Balance + amount;
                        Console.WriteLine($"U r balance is{Balance}");
                    }

                }
                Console.WriteLine($"U r balance is{Balance}");

                return Balance;


            }
            public double Debit(double amount)
            {


                Console.WriteLine("please enter the accountid to debit money");
                string debitId = Console.ReadLine();

                foreach (string item in accountBook)
                {
                    string c = item;
                    if (String.Equals(item, debitId))

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



                    }
                    else
                    {
                        Console.WriteLine("user not found");

                    }


                }
                return Balance;

            }

            public string Create(string name, int balance)
            {
                Console.WriteLine("creating account -------");
                double Balance = balance;
                string str = "SBI_";
                string AccountId = (System.Math.Abs(Guid.NewGuid().GetHashCode())).ToString();

                string aid = str + AccountId;

                this.AccountId = aid;
                this.name = name;

                Console.WriteLine($"user successfully registered  uniqueid is :{this.AccountId}");
                accountBook.Add(this.AccountId);
                // return _instance;
                return this.AccountId;

            }
            public bool Delete(string id)
            {

                //    string userid = Console.ReadLine();

                foreach (string item in accountBook)
                {
                    string c = item;
                    if (String.Equals(item, id))

                    {

                        accountBook.Remove(id);
                        Console.WriteLine($"Accountid {id} is deleted successfully");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Accountid{id} is not found ");

                    }

                }


                return true;

            }

        }
    }
}

