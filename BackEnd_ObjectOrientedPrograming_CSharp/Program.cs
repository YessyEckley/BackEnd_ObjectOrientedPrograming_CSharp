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
            //Week5Sample();
            //Week6Sample();
            //Week7Sample();
            //Week8Sample();
            //Week9Sample();
            //Week10Sample();
            Week11Sample();
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

            //Week5_Classes.ImplicitType.ImplicitTypeClass.DisplayTest();

            //Homework coding work
            //Week5_Classes.Week5Labs.HotelStructArray.Step2.TestHotel.DisplayTest();
            //Week5_Classes.Week5Labs.HotelClassArray.TestHotel.DisplayTest();

            //Week5_Classes.Week5Labs.TestContact.Step1.TestContact.DisplayTest();
            //Week5_Classes.Week5Labs.TestContact.Step2.TestContact.DisplayTest();
            //Week5_Classes.Week5Labs.TestContact.Step3.TestContact.DisplayTest();
        }

        private static void Week6Sample()
        {
            ////Prefix and Sufix
            //int y = 1;
            //int x = 2;

            //Console.WriteLine($"Value Check -> y = {y} x = {x}");
            //y = ++x;
            //Console.WriteLine($"y = ++x -> y = {y} x = {x}");
            //y = x++;
            //Console.WriteLine($"y = x++ -> y = {y} x = {x}");

            //Console.WriteLine($"Value Check -> y = {y} x = {x}");
            //y = --x;
            //Console.WriteLine($"y = --x -> y = {y} x = {x}");
            //y = x--;
            //Console.WriteLine($"y = x-- -> y = {y} x = {x}");

            //Week6_OperatorsCF.Multiply.Multiply.DisplayTest();
            //Week6_OperatorsCF.IntegerDivision.IntegerDivision.DisplayTest();
            //Week6_OperatorsCF.Ira.Ira.DisplayTest();
            //Week6_OperatorsCF.Relational.Relational.DisplayTest();
            //Week6_OperatorsCF.ShortCircuit.ShortCircuit.DisplayTest();
            //Week6_OperatorsCF.AbsoluteValue.AbsoluteValue.DisplayTest();
            //Week6_OperatorsCF.Shift.Shift.DisplayTest();
            //Week6_OperatorsCF.Assign.Assign.DisplayTest();
            //Week6_OperatorsCF.Unchecked.Unchecked.DisplayTest();
            //Week6_OperatorsCF.Checked.Checked.DisplayTest();

            //Week6_OperatorsCF.LeapYear.LeapYear.DisplayTest();
            //Week6_OperatorsCF.Swap.Swap.DisplayTest();
            //Week6_OperatorsCF.LeapYearLoop.LeapYearLoop.DisplayTest();
            //Week6_OperatorsCF.ForUp.ForUp.DisplayTest();
            //Week6_OperatorsCF.ForDown.ForDown.DisplayTest();
            //Week6_OperatorsCF.Fibonacci.Fibonacci.DisplayTest();
            //Week6_OperatorsCF.ForEachLoop.ForEachLoop.DisplayTest();
            //Week6_OperatorsCF.BreakSearch.BreakSearch.DisplayTest();
            //Week6_OperatorsCF.ContinueLoop.ContinueLoop.DisplayTest();    
            //Week6_OperatorsCF.GoToSearch.GotoSearch.DisplayTest();
            //Week6_OperatorsCF.StructuredSearch.StructuredSearch.DisplayTest();
            //Week6_OperatorsCF.MultipleMethods.MultipleMethods.DisplayTest();
            //Week6_OperatorsCF.SwitchDemo.SwitchDemo.DisplayTest();

            ////Labs
            //Week6_OperatorsCF.Week6Labs.Contacts.Step1.TestContacts.DisplayTest();
            //Week6_OperatorsCF.Week6Labs.Contacts.Step2.TestContacts.DisplayTest();
            //Week6_OperatorsCF.Week6Labs.MortgagePayment.Step1.MortgagePayment.DisplayTest();
            //Week6_OperatorsCF.Week6Labs.MortgagePayment.Step2.MortgagePayment.DisplayTest();
        }

        private static void Week7Sample()
        {
            //// Class Demos
            //Week7_StringsArrays.Samples.CharCode.CharCode.DisplayTest();
            ////This is a parametized string example
            //int aNumber = 5;
            //string aParatemizedString = $"This is an integer: {aNumber}";
            //Week7_StringsArrays.Demo.StringDemo.StringDemo.DisplayTest();
            //Week7_StringsArrays.Demo.StringBuilderDemo.StringBuilderDemo.DisplayTest();
            //Week7_StringsArrays.Demo.ArrayDemo.ArrayDemo.DisplayTest();

            // Try Testing the Samples
            //Week7_StringsArrays.Samples
            //Week7_StringsArrays.Samples.StringCompare.StringCompare.DisplayTest();
            //Week7_StringsArrays.Samples.StringBuilderCompare.StringBuilderCompare.DisplayTest();

            // Try Testing the Labs
            //Week7_StringsArrays.Labs
        }

        private static void Week8Sample()
        {
        }

        private static void Week9Sample()
        {
            //Week9_FormatEx.Sample.NumberToString.NumberToString.DisplayTest();

            //Week9_FormatEx.Sample.HotelToString.Step1.HotelToString.DisplayTest();
            //Week9_FormatEx.Sample.HotelToString.Step2.HotelToString.DisplayTest();
            //Week9_FormatEx.Sample.HotelToString.Step3.HotelToString.DisplayTest();

            //Week9_FormatEx.Sample.PowerTwo.Step0.PowerTwo.DisplayTest();
            //Week9_FormatEx.Sample.PowerTwo.Step1.PowerTwo.DisplayTest();
            //Week9_FormatEx.Sample.PowerTwo.Step2.PowerTwo.DisplayTest();

            //Week9_FormatEx.Sample.PowerFormat.PowerFormat.DisplayTest();

            //Week9_FormatEx.Sample.MoneyPower.MoneyPower.DisplayTest();
            //Week9_FormatEx.Sample.MoneyReport.MoneyReport.DisplayTest();

            //Week9_FormatEx.Sample.MoneyConvert.MoneyConvert.DisplayTest();

            //Week9_FormatEx.Sample.AccountExceptionDemo.Step1.AccountExceptionDemo.DisplayTest();
            //Week9_FormatEx.Sample.AccountExceptionDemo.Step2.AccountExceptionDemo.DisplayTest();
            //Week9_FormatEx.Sample.AccountExceptionDemo.Step3.AccountExceptionDemo.DisplayTest();

            Week9_FormatEx.Sample.ArithmeticExceptionDemo.ArithmeticExceptionDemo.DisplayTest();
        }

        private static void Week10Sample()
        {
            //Week10_NamespacesInterface.Sample.SmallInterface.SmallInterface.DisplayTest();
            //Week10_NamespacesInterface.Sample.TryInterfaces.TryInterfaces.DisplayTest();
        }

        private static void Week11Sample()
        {
            Week11_CollectionsEvents.Samples.StringList.StringList.DisplayTest();
            Week11_CollectionsEvents.Samples.GenericStringList.StringList.DisplayTest();
            Week11_CollectionsEvents.Samples.ObjectInit.ObjectInit.DisplayTest();
            Week11_CollectionsEvents.Samples.CollectionInit.CollectionInit.DisplayTest();
            Week11_CollectionsEvents.Samples.DelegateDemo.DelegateDemo.DisplayTest();
            Week11_CollectionsEvents.Samples.Anonymous.NamedMethods.DisplayTest();
        }
    }
}
