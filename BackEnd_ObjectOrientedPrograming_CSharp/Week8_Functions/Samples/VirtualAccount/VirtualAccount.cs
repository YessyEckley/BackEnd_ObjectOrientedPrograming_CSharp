// VirtualAccount.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Samples.VirtualAccount
{
    public class Account
    {
        public int balance = 100;
        virtual public void Show()
        {
            Console.WriteLine("I am an Account");
        }
    }

    public class CheckingAccount : Account
    {
        public int fee = 5;
        override public void Show()
        {
            Console.WriteLine("I am a CheckingAccount, fee = {0}", fee);
        }
    }
}