// Account.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.StaticConstructor
{
    public class Account
    {
        private int id;
        private decimal balance;
        private static int nextid = 1;
        static Account()
        {
            Console.WriteLine("Static constructor");
        }
        public Account()
        {
            Console.WriteLine("Account() constructor");
            this.id = nextid++;
        }
        public Account(decimal balance)
        {
            Console.WriteLine("Account(decimal) constructor");
            this.id = nextid++;
            this.balance = balance;
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