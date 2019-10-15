﻿using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week3_ObjectOrientedProgramming.Bank
{
    public class Account
    {
        private int id;
        protected decimal balance;
        private string owner;
        protected int numXact = 0;  // number of transactions

        public Account(decimal balance, string owner, int id)
        {
            this.balance = balance;
            this.owner = owner;
            this.id = id;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }

        public int Transactions
        {
            get
            {
                return numXact;
            }
        }

        public string GetStatement()
        {
            string s = "Statement for " + this.Owner + " id = " + Id + "\n" +
                this.Transactions + " transactions, balance = " + balance;
            return s;
        }
        //public virtual string GetStatement()
        //{
        //    string s = "Statement for " + this.Owner + " id = " + Id + "\n" +
        //        this.Transactions + " transactions, balance = " + balance;
        //    return s;
        //}

        public void Deposit(decimal amount)
        {
            balance += amount;
            numXact++;
        }
        //public virtual void Deposit(decimal amount)
        //{
        //    balance += amount;
        //    numXact++;
        //}

        public void Withdraw(decimal amount)
        {
            balance -= amount;
            numXact++;
        }
        //public virtual void Withdraw(decimal amount)
        //{
        //    balance -= amount;
        //    numXact++;
        //}
    }
}
