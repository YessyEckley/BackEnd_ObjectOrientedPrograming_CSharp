// Account.cs
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.StaticAccount
{
    public class Account
    {
        private int id;
        private decimal balance = 700m;
        private static int nextid = 1;

        public Account()
        {
            this.id = nextid++;
        }
        public Account(decimal balance)
        {
            this.id = nextid++;
            this.balance = balance;
        }

        public static int GetNextId()
        {
            return nextid;
        }

        public void Deposit(decimal amount)
        {
            balance = Add(balance, amount);
        }
        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }
        public int GetId()
        {
            return id;
        }

        static private decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
    }
}