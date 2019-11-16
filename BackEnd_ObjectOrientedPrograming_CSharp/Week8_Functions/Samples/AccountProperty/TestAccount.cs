// TestAccount.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Samples.AccountProperty
{
    public class TestAccount
    {
        public static void DisplayTest()
        {
            Account acc;
            acc = new Account(100, "Bob");
            ShowAccount(acc);
            acc.Deposit(25);
            acc.Withdraw(50);
            ShowAccount(acc);
            acc.Owner = "Carl";
            ShowAccount(acc);
            acc = new Account(200, "Mary");
            ShowAccount(acc);
        }
        private static void ShowAccount(Account acc)
        {
            Console.WriteLine("id: {0} owner: {1} balance: {2:C}",
                                    acc.Id, acc.Owner, acc.Balance);
        }
    }
}