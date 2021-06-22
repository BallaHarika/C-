using CorelogicLayer;
using System;
using System.Collections.Generic;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sav = new SavingsAccount();
            List<Account> accountBook = new List<Account>();
            int j = 0;
            while(j==0)
            {

                Console.WriteLine("press 1 for create account \n press 2 for credit amount \n press 3 for debit amount \n press 4 for delete account \n press 5 for exit ");
                int ch = int.Parse(Console.ReadLine());
               
                switch(ch)
                {
                    case 1:
                         Console.WriteLine("enter your name");
                          string Name = Console.ReadLine();
                          int Balance = 0;
                          Account a = sav.Create(Name, Balance);
                          accountBook.Add(a);
                        break;

                    case 2:
                        Console.WriteLine("crediting amount to the account");
                        int creditamount = int.Parse(Console.ReadLine());
                        Console.WriteLine("please enter the accountid to credit money");
                        int creditId = int.Parse(Console.ReadLine());
                        Console.Write(accountBook[0].AccountId);
                        Account temp = accountBook.Find((p) => p.AccountId == creditId);

                        ((SavingsAccount)temp).Credit(creditamount);

                        break;

                    case 3:
                        Console.WriteLine("debiting amount to the account");
                        int debitamount = int.Parse(Console.ReadLine());
                        Console.WriteLine("please enter the accountid to debit money");
                        int debitId = int.Parse(Console.ReadLine());
                        Account temp1= accountBook.Find((p) => p.AccountId == debitId);
                        if (temp1 != null)
                            ((SavingsAccount)temp1).Debit(debitamount);
                        break;

                    case 4:
                        Console.WriteLine("enter accounid to delete account ");

                        int userid=int.Parse(Console.ReadLine());

                        Account temp2 = accountBook.Find((p => p.AccountId == userid));
                        if(temp2!=null)
                        {
                            accountBook.Remove(temp2);
                            Console.WriteLine($"Accountid {userid} is deleted successfully");
                        }
                   
                     
                        else
                        {
                            Console.WriteLine($"Accountid{userid} is not found ");

                        }

                       



                        break;
                    case 5:
                        j = 3;
                        break;
                    default:
                        break;







                }

            }

           




        }
    }
}
