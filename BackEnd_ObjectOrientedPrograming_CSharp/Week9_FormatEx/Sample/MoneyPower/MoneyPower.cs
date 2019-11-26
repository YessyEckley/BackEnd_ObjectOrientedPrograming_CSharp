// MoneyPower.cs

using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Sample.MoneyPower
{

    public class MoneyPower
    {
        public static void DisplayTest()
        {
            decimal power = .01m;
            decimal total = 0m;
            for (int i = 1; i <= 64; i++)
            {
                total += power;
                Console.WriteLine("{0,-3} {1,30:C}", i, total);
                power *= 2;
            }
        }
    }
}