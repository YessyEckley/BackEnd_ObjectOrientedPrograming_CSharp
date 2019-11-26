// TestTime.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Lab.TimeException.Step2
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
                try
                {
                    Time t = (Time)str;
                    t.Show();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                str = iw.getString("time: ");
            }
            Console.WriteLine("Goodbye");
        }
    }
}