// HotelToString.cs

using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Sample.HotelToString.Step2
{

    public class HotelToString
    {
        public static void DisplayTest()
        {
            Hotel alpha = new Hotel("Atlanta", "Dixie");
            Hotel beta = new Hotel("Boston", "Yankee");
            Console.WriteLine(alpha);
            Console.WriteLine(beta.ToString());
        }
    }
}