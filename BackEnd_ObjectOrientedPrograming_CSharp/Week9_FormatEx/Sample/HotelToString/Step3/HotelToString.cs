// HotelToString.cs - Step 3

using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Sample.HotelToString.Step3
{

    public class HotelToString
    {
        public static void DisplayTest()
        {
            Hotel alpha = new Hotel("Atlanta", "Dixie");
            Hotel beta = new Hotel("Boston", "Yankee");
            Console.WriteLine("Hotel alpha is {0}", alpha);
            Console.WriteLine("Hotel beta is {0}", beta);
        }
    }
}