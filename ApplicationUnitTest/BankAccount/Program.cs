using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
          
       }
    }
    public interface IApproveAuthority
    {
        bool Approve(String msg);
    }
     public class SavingsAccount
    {
        public SavingsAccount(int amount)
        {
            Balance = amount;
        }
        
        public int Balance;
        private readonly IApproveAuthority Approver;

        public SavingsAccount(int amount, IApproveAuthority Approver)
        {
            this.Approver = Approver;
            Balance = amount;
        }
        public void deposit(int value)
        {
            if (value <= 0 )
                throw new ArgumentException("Deposit Amount Must be positive :{value}");
            if(Approver.Approve("Please Approve"))
            {
                Balance += value;
            }
           

        }
        public bool withdraw(int value)
        {
            if (value > Balance & value>10000)
            {

                throw new ArgumentException("Withdraw Amount cannot be higher than current balance  and less than : {value}");
            }




            Balance -= value;

                return true;
            
        }

    }
}
