// BalanceException.cs

using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Sample.AccountExceptionDemo.Step3
{

    public class BalanceException : Exception
    {
        private decimal shortage;
        public BalanceException(string message, decimal shortage)
            : base(message)
        {
            this.shortage = shortage;
        }
        public decimal Shortage
        {
            get
            {
                return shortage;
            }
        }
    }

}