// ForDown.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.ForDown
{
    public class ForDown
    {
        public static int DisplayTest()
        {
            int sum = 0;
            int i;
            for (i = 100; i >= 1; i--)
            {
                sum += i;
            }
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("i = {0}", i);
            // i is defined outside the for loop
            return 0;
        }
    }
}