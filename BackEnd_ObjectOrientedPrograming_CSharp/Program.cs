using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week1Sample();
            //Week3Sample();
        }

        private static void Week1Sample()
        {
            Console.WriteLine("Hello World!");

            Week1_HelloWorld.SimpleCalc simpleCalc =
                new Week1_HelloWorld.SimpleCalc();

            simpleCalc.TestSimpleCalculator();
        }

        private static void Week3Sample()
        {
            Week3_ObjectOrientedProgramming
                        .Bank.TestAccount.BankTestAccounts();

            Week3_ObjectOrientedProgramming
            .ClassesAndObjects.TestOverride.TestTheOverride();

            var temp = new Week3_ObjectOrientedProgramming
                .ClassesAndObjects.SampleClass();
        }
    }
}
