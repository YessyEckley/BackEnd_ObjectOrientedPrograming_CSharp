// Account.cs
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.InitialAccount.Step1
{
    public class Account
    {
        private int id = 7;
        private decimal balance = 700;
        public void Deposit(decimal amount)
        {
            balance += amount;
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