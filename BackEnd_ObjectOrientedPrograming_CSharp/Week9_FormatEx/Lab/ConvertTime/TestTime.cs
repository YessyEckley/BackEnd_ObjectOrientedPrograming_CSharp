// TestTime.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Lab.ConvertTime
{
    public class TestTime
    {
        static void DisplayTest()
        {
            Time t = new Time(12, 15);
            string str = t;
            Console.WriteLine(str);
            t = (Time)"8:30";
            Console.WriteLine((string)t);
        }
    }
}