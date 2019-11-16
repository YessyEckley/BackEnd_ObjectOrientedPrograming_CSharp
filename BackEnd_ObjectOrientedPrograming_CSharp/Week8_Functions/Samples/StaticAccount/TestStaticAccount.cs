// TestStaticAccount.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Samples.StaticAccount
{
    public class TestAccount
    {
        public static void DisplayTest()
        {
            Account acc = new Account();
            CheckingAccount chk = new CheckingAccount();
            acc.Show();
            chk.Show();
            //chk = acc;		// illegal
            acc = chk;
            acc.Show();         // still Account.Show
        }
    }
}