﻿using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week3_ObjectOrientedProgramming.Bank
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

        //public string GetStatement()
        //{
        //    string s = base.GetStatement();
        //    s += ", fee = " + Fee;
        //    return s;
        //}
        //public new string GetStatement()
        //{
        //    string s = base.GetStatement();
        //    s += ", fee = " + Fee;
        //    return s;
        //}
        public override string GetStatement()
        {
            string s = base.GetStatement();
            s += ", fee = " + Fee;
            return s;
        }

        public void Post()
        {
            _balance -= Fee;
            numXact = 0;
        }
    }

}
