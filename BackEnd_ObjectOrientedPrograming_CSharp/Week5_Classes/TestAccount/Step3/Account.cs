// Account.cs - Step3
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.TestAccount.Step3
{
    public class Account
    {
        private int id;
        private decimal balance;
        public Account()
        {
        }
        public Account(int id, decimal balance)
        {
            this.id = id;
            this.balance = balance;
        }
        public void Deposit(decimal amount)
        {
            balance += amount;
            //balance = balance + amount;
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
    }
}