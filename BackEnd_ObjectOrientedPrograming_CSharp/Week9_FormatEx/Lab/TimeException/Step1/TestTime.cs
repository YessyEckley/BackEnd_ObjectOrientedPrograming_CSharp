// TestTime.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Lab.TimeException.Step1
{
    public class TestTime
    {
        static void DisplayTest()
        {
            Console.WriteLine("Enter time in format hh:mm");
            Console.WriteLine("Press carriage return to quit");
            InputWrapper iw = new InputWrapper();
            string str = iw.getString("time: ");
            while (str != "")
            {
                Time t = (Time)str;
                t.Show();
                str = iw.getString("time: ");
            }
            Console.WriteLine("Goodbye");
        }
    }
}