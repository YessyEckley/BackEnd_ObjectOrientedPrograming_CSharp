// InitialAccount.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.InitialAccount.Step3
{
    public class InitialAccount
    {
        public static void DisplayTest()
        {
            Account acc1 = new Account(1, 100);
            Console.WriteLine("balance of {0} is {1}", acc1.GetId(), acc1.GetBalance());
            Account acc2 = new Account(2, 200);
            Console.WriteLine("balance of {0} is {1}", acc2.GetId(), acc2.GetBalance());
            Account acc3 = new Account();
            Console.WriteLine("balance of {0} is {1}", acc3.GetId(), acc3.GetBalance());
        }
    }
}