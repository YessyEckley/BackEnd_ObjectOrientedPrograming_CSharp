// PowerTwo.cs - Step 0

using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Sample.PowerTwo.Step0
{

    public class PowerTwo
    {
        public static void DisplayTest()
        {
            long power = 1;
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine("{0} {1}", i, power);
                power *= 2;
            }
        }
    }
}