// LeapYearLoop.cs
//
// Loop to read in years and determine whether year
// entered is a leap year.
// -1 is entered to terminate the program

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.LeapYearLoop
{
    public class LeapYearLoop
    {
        public static int DisplayTest()
        {
            InputWrapper iw = new InputWrapper();
            Console.WriteLine("Enter -1 to terminate the program");
            int year = iw.getInt("year: ");
            while (year != -1)
            {
                if ((year % 4 == 0) &&
                    ((year % 400 == 0) || (year % 100 != 0)))
                    Console.WriteLine("{0} is a leap year", year);
                else
                    Console.WriteLine("{0} is not a leap year", year);
                year = iw.getInt("year: ");
            }
            return 0;
        }
    }
}