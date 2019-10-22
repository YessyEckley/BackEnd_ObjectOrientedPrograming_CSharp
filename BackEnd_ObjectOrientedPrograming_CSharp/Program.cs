using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //How to write comments
            //Comment #1
            /*
            Comment #2

            Everything in between the (*) is a comment
             */

            //Week1Sample();
            //Week3Sample();
            Week4Sample();
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

        private static void Week4Sample()
        {
            //Week4_DataTypes_1
            //Week4_DataTypes_1.LabAndDemo
            //var dataTypes = new Week4_DataTypes_1.DataTypes();
            //var seven = new Week4_DataTypes_1.Seven();

            //Week4_DataTypes_1.IntegerRange.TestIntegerRange();

            //Week4_DataTypes_1.SpecialFloat.TestSpecialFloat();

            //var aDecimalLiteral = new Week4_DataTypes_1
            //    .DecimalLiterals();

            //var characterLiterals = new Week4_DataTypes_1
            //    .CharacterLiterals();

            //Console.WriteLine(Convert.ToBoolean("false"));
            ////This one doesn't work and throws an error
            ////Console.Write(Convert.ToBoolean("1"));
            //Console.WriteLine(Convert.ToBoolean(1));

            
        }
    }
}
