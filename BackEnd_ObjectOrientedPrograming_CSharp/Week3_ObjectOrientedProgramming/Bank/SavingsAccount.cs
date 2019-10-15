﻿using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week3_ObjectOrientedProgramming.Bank
{
    public class SavingsAccount : Account
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

        public void Post()
        {
            balance += Interest;
            numXact = 0;
            minBalance = balance;
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

        public void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            if (balance < minBalance)
            {
                minBalance = balance;
            }
        }
        //public new void Withdraw(decimal amount)
        //{
        //    base.Withdraw(amount);
        //    if (balance < minBalance)
        //    {
        //        minBalance = balance;
        //    }
        //}
        //public override void Withdraw(decimal amount)
        //{
        //    base.Withdraw(amount);
        //    if (balance < minBalance)
        //    {
        //        minBalance = balance;
        //    }
        //}

        public string GetStatement()
        {
            string s = base.GetStatement();
            s += ", interest = " + Interest;
            return s;
        }
        //public new string GetStatement()
        //{
        //    string s = base.GetStatement();
        //    s += ", interest = " + Interest;
        //    return s;
        //}
        //public override string GetStatement()
        //{
        //    string s = base.GetStatement();
        //    s += ", interest = " + Interest;
        //    return s;
        //}
    }

}
