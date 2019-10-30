﻿using System;

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
            //Week4Sample();
            Week5Sample();
            //Week6Sample();
            //Week7Sample();
            //Week8Sample();
            //Week9Sample();
            //Week10Sample();
            //Week11Sample();
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
            var dataTypes = new Week4_DataTypes_1.DataTypes();
            var seven = new Week4_DataTypes_1.Seven();

            Week4_DataTypes_1.IntegerRange.TestIntegerRange();

            Week4_DataTypes_1.SpecialFloat.TestSpecialFloat();

            var aDecimalLiteral = new Week4_DataTypes_1
                .DecimalLiterals();

            var characterLiterals = new Week4_DataTypes_1
                .CharacterLiterals();

            Console.WriteLine(Convert.ToBoolean("false"));
            //This one doesn't work and throws an error
            //Console.Write(Convert.ToBoolean("1"));
            Console.WriteLine(Convert.ToBoolean(1));

        }

        private static void Week5Sample()
        {
            /* Week5_Classes */

            //Week5_Classes.TestAccount.Step1.TestAccount.DisplayTest();
            //Week5_Classes.TestAccount.Step2.TestAccount.DisplayTest();
            //Week5_Classes.TestAccount.Step3.TestAccount.DisplayTest();

            //Week5_Classes.InitialAccount.Step1.InitialAccount.DisplayTest();
            //Week5_Classes.InitialAccount.Step2.InitialAccount.DisplayTest();
            //Week5_Classes.InitialAccount.Step3.InitialAccount.DisplayTest();

            //Week5_Classes.StaticAccount.StaticAccount.DisplayTest();

            //Week5_Classes.ConstantAccount.ConstantAccount.DisplayTest();

            //Week5_Classes.StaticConstructor.StaticConstructor.DisplayTest();

            //Week5_Classes.HotelCreate.HotelCreate.DisplayTest();

            //Week5_Classes.HotelCopy.HotelCopy.DisplayTest();

            ////string
            //string sampleString1 = "Hello World!";
            //string sampleString2 = "How are you?";
            //sampleString2 = sampleString1;

            ////Array
            //Week5_Classes.TestAccount.Step1.TestAccount[] sampleTestAccountArray =
            //    new Week5_Classes.TestAccount.Step1.TestAccount[2];
            //sampleTestAccountArray[0] = new Week5_Classes.TestAccount.Step1.TestAccount();
            //sampleTestAccountArray[1] = new Week5_Classes.TestAccount.Step1.TestAccount();

            ////Boxing and unboxing
            //int x = 5;
            //object o = x; // boxing
            //x = (int)o; // unboxing

            Week5_Classes.ImplicitType.ImplicitTypeClass.DisplayTest();

            //Homework coding work
            //Week5_Classes.Week5Labs.HotelStructArray.Step2.TestHotel.DisplayTest();
            //Week5_Classes.Week5Labs.HotelClassArray.TestHotel.DisplayTest();

            //Week5_Classes.Week5Labs.TestContact.Step1.TestContact.DisplayTest();
            //Week5_Classes.Week5Labs.TestContact.Step2.TestContact.DisplayTest();
            //Week5_Classes.Week5Labs.TestContact.Step3.TestContact.DisplayTest();
        }

        private static void Week6Sample()
        {
        }

        private static void Week7Sample()
        {
        }

        private static void Week8Sample()
        {
        }

        private static void Week9Sample()
        {
        }

        private static void Week10Sample()
        {
        }

        private static void Week11Sample()
        {
        }
    }
}
