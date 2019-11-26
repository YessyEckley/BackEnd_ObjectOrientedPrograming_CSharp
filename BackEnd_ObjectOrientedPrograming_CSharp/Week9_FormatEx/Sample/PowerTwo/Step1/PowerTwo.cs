// PowerTwo.cs - Step 1

using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Sample.PowerTwo.Step1
{

    public class PowerTwo
    {
        public static void DisplayTest()
        {
            long power = 1;
            for (int i = 0; i < 16; i++)
            {
                // Negative value for left justification
                Console.WriteLine("{0,-3} {1,10}", i, power);
                power *= 2;
            }
        }
    }
}