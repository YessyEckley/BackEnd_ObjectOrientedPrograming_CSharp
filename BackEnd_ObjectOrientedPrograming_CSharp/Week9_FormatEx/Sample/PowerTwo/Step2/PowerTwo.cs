// PowerTwo.cs - Step 2

using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Sample.PowerTwo.Step2
{

    public class PowerTwo
    {
        public static void DisplayTest()
        {
            decimal power = 1;
            string header1 = "Num";
            string header2 = "Power";
            string header = header1.PadRight(4) + header2.PadLeft(30);
            Console.WriteLine(header);
            for (int i = 0; i < 64; i++)
            {
                Console.WriteLine("{0,-4}{1,30:N0}", i, power);
                power *= 2;
            }
        }
    }
}