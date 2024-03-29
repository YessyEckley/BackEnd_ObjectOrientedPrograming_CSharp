// Account.cs - Step 0

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.AccountList.Step0
{
    public class Account
    {
        private decimal balance;
        private string owner;
        private int id;
        public Account(decimal balance, string owner, int id)
        {
            this.balance = balance;
            this.owner = owner;
            this.id = id;
        }
        public string Info
        {
            get
            {
                return id.ToString().PadRight(4) + owner.PadRight(12)
                    + string.Format("{0:C}", balance);
            }
        }
    }
}