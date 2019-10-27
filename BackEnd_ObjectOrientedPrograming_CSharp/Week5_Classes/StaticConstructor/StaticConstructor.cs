// StaticConstructor.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.StaticConstructor
{
    public class StaticConstructor
    {
        public static void DisplayTest()
        {
            Account acc1, acc2, acc3; //This is where the static constructor gets called
            acc1 = new Account(100);
            acc2 = new Account(200);
            acc3 = new Account();
            WriteAccount(acc1);
            WriteAccount(acc2);
            WriteAccount(acc3);
        }
        private static void WriteAccount(Account acc)
        {
            Console.WriteLine("balance of {0} is {1}", acc.GetId(), acc.GetBalance());
        }
    }
}