// SavingsAccount.cs - Step 7

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.Bank.Step8
{
    public class SavingsAccount : Account, IAccount, IStatement, ISavings
    {
        private decimal minBalance;
        private decimal rate = 0.06m;
        public SavingsAccount(decimal balance, string owner, int id)
            : base(balance, owner, id)
        {
            minBalance = balance;
        }
        public decimal Interest
        {
            get
            {
                return minBalance * rate / 12;
            }
        }
        override public void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            if (balance < minBalance)
            {
                minBalance = balance;
            }
        }
        override public void Post()
        {
            balance += Interest;
        }
        override public string GetStatement()
        {
            string s = base.GetStatement();
            s += ", interest = " + string.Format("{0:C}", Interest);
            return s;
        }
        public decimal Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }
        }
        override public string Prompt
        {
            get
            {
                return "S: ";
            }
        }
        override public void MonthEnd()
        {
            base.MonthEnd();
            minBalance = balance;
        }
    }
}