// TestAccount.cs - Step3

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.TestAccount.Step3
{
    public class TestAccount
    {
        public static void DisplayTest()
        {
            Account acc;
            acc = new Account(1, 100);
            Console.WriteLine("balance of {0} is {1}", acc.GetId(), acc.GetBalance());
            acc.Deposit(25);
            acc.Withdraw(50);
            Console.WriteLine("balance of {0} is {1}", acc.GetId(), acc.GetBalance());
            acc = new Account();
            Console.WriteLine("balance of {0} is {1}", acc.GetId(), acc.GetBalance());
        }
    }
}