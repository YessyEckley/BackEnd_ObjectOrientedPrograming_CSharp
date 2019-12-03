// SmallInterface.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week10_NamespacesInterface.Sample.SmallInterface
{
    public class SmallInterface
    {
        public static void DisplayTest()
        {
            Account acc = new Account(100);
            // Use a class reference
            Console.WriteLine("balance = {0}", acc.Balance);
            acc.Deposit(25);
            Console.WriteLine("balance = {0}", acc.Balance);
            // Use an interface reference
            IBasicAccount ifc = (IBasicAccount)acc;
            ifc.Deposit(25);
            Console.WriteLine("balance = {0}", ifc.Balance);

            // Now try same things with class not implementing IBasicAccount
            NoAccount acc2 = new NoAccount(500);
            // Use a class reference
            Console.WriteLine("balance = {0}", acc2.Balance);
            acc2.Deposit(25);
            Console.WriteLine("balance = {0}", acc2.Balance);
            // Try an interface pointer
            try
            {
                IBasicAccount ifc2 = (IBasicAccount)acc2;
                ifc2.Deposit(25);
                Console.WriteLine("balance = {0}", ifc2.Balance);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("IBasicAccount is not supported");
                Console.WriteLine(e.Message);
            }
        }
    }
}