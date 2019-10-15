using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week3_ObjectOrientedProgramming.Bank
{
    public class Account
    {
        //Attributes
        private int id;
        protected decimal _balance;
        private string owner;
        protected int numXact = 0;  // number of transactions

        //Constructor
        public Account(decimal balance, string owner, int id)
        {
            _balance = balance;
            //We add the this when attributes and passed parameters have the same name
            this.owner = owner;
            this.id = id;
        }

        //Properties
        public decimal Balance
        {
            get
            {
                return _balance;
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

        //Methods
        public int Transactions
        {
            get
            {
                return numXact;
            }
        }

        //public string GetStatement()
        //{
        //    string s = "Statement for " + this.Owner + " id = " + Id + "\n" +
        //        this.Transactions + " transactions, balance = " + _balance;
        //    return s;
        //}
        public virtual string GetStatement()
        {
            string s = "Statement for " + this.Owner + " id = " + Id + "\n" +
                this.Transactions + " transactions, balance = " + _balance;
            return s;
        }

        //public void Deposit(decimal amount)
        //{
        //    _balance += amount;
        //    numXact++;
        //}
        //Virtual
        public virtual void Deposit(decimal amount)
        {
            _balance += amount;
            numXact++;
        }
        //Overloaded
        public virtual void Deposit(decimal amount, int fee)
        {
            _balance += amount;
            numXact++;
        }

        //public void Withdraw(decimal amount)
        //{
        //    _balance -= amount;
        //    numXact++;
        //}
        public virtual void Withdraw(decimal amount)
        {
            _balance -= amount;
            numXact++;
        }
    }
}
