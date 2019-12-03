// NumberToString.cs

using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Sample.NumberToString
{

    public class NumberToString
    {
        public static void DisplayTest()
        {
            int number = 444;
            Console.WriteLine(number);
            //string str = number;		// illegal
            string str = number.ToString();
            Console.WriteLine(str);
            Console.WriteLine("number = " + number);
            Console.WriteLine(444.ToString());

            string aNewString = Convert.ToString(number);
        }
    }
}