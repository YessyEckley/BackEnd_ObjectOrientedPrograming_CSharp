// HeterogeneousAccount.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Samples.HeterogeneousAccount
{
    public class HeterogeneousAccount
    {
        public static void DisplayTest()
        {
            Account[] list = new Account[3];
            list[0] = new CheckingAccount(100, "Bob", 1);
            list[1] = new SavingsAccount(200, "Mary", 2);
            list[2] = new CheckingAccount(300, "Charlie", 3);
            foreach (Account acc in list)
                ShowAccount(acc.Prompt, acc);
        }
        private static void ShowAccount(string caption, Account acc)
        {
            Console.Write("{0}: ", caption);
            Console.WriteLine(acc.GetStatement());
        }
    }
}