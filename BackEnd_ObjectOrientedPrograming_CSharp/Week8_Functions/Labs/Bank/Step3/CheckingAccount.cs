// CheckingAccount.cs - Step 3

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Labs.Bank.Step3
{
    public class CheckingAccount : Account
    {
        private decimal fee = 5.00m;
        private const int FREEXACT = 2;
        public CheckingAccount(decimal balance, string owner, int id)
            : base(balance, owner, id)
        {
        }
        public decimal Fee
        {
            get
            {
                if (numXact > FREEXACT)
                    return fee;
                else
                    return 0.00m;
            }
        }
        override public string GetStatement()
        {
            string s = base.GetStatement();
            s += ", fee = " + Fee;
            return s;
        }
        override public void Post()
        {
            balance -= Fee;
        }
        override public string Prompt
        {
            get
            {
                return "C: ";
            }
        }
    }
}