// ConstantAccount.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.ConstantAccount
{
    public class ConstantAccount
    {
        public static void DisplayTest()
        {
            Console.WriteLine("FEE = {0}", Account.FEE);
            // Account.FEE = 7.00m;		// illegal
            Account acc = new Account(10);
            Console.WriteLine("{0} free checks", acc.FreeChecks);
            // acc.FreeChecks = 20;		// illegal
        }
    }
}