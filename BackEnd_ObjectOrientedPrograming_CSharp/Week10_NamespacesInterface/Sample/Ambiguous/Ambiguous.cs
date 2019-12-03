// Ambiguous.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week10_NamespacesInterface.Sample.Ambiguous
{
    public class Ambiguous
    {
        public static void DisplayTest()
        {
            Account acc = new Account(100);
            // acc.Show();	// illegal - MUST go through an interface
            IAccount iacc = (IAccount)acc;
            IStatement istat = (IStatement)acc;
            iacc.Show();
            istat.Show();
            iacc.Deposit(25);
            iacc.Withdraw(10);
            iacc.Show();
            istat.Show();
        }
    }
}