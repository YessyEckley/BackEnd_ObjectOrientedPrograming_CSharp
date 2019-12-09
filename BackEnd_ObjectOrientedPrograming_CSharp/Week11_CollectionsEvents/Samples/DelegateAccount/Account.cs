// Account.cs
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.DelegateAccount
{
    public delegate void Notify(decimal balance);

    public class Account
    {
        private decimal balance;
        public Notify notifyDlg;
        public Account(decimal bal)
        {
            balance = bal;
        }
        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            balance -= amount;
            if (balance < 0)
                notifyDlg(balance);
        }
    }
}