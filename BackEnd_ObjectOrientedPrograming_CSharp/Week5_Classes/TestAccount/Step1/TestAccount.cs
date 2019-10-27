// TestAccount.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.TestAccount.Step1
{
    public class TestAccount
    {
        public static void DisplayTest()
        {
            Account acc;        // acc is a reference to an Account object
                                // The object itself does not yet exist
            acc = new Account();        // Account object now exists
                                        // and acc is a reference to it
            acc.Id = 1;
            acc.Balance = 100;      // Fields have now been assigned
            Console.WriteLine("Account id {0} has balance {1}", acc.Id, acc.Balance);
        }
    }
}