// DelegateAccount.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.DelegateAccount
{
    public class DelegateAccount
    {
        public static void DisplayTest()
        {
            Account acc = new Account(100);
            Notify custDlg = new Notify(NotifyCustomer);
            Notify bankDlg = new Notify(NotifyBank);

            // Notify customer of an overdraft
            acc.notifyDlg += custDlg;
            acc.Withdraw(125);

            // Also notify bank of an overdraft
            acc.notifyDlg += bankDlg;
            acc.Withdraw(50);

            // Remove bank notification
            acc.notifyDlg -= bankDlg;
            acc.Withdraw(50);
        }
        private static void NotifyCustomer(decimal balance)
        {
            Console.WriteLine("Dear customer,");
            Console.WriteLine("   Account overdrawn, balance = {0}", balance);
        }
        private static void NotifyBank(decimal balance)
        {
            Console.WriteLine("Dear bank,");
            Console.WriteLine("   Account overdrawn, balance = {0}", balance);
        }
    }
}