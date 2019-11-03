// ForUp.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.ForUp
{
    public class ForUp
    {
        public static int DisplayTest()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum = {0}", sum);
            // Console.WriteLine("i = {0}", i);
            // i is not defined outside the for loop
            return 0;
        }
    }
}