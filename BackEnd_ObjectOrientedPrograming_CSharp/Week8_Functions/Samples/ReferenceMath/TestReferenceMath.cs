// TestReferenceMath.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Samples.ReferenceMath
{
    public class TestReferenceMath
    {
        public static void DisplayTest()
        {
            int sum = 0, product = 0;
            ReferenceMath.Calculate(5, 7, ref sum, ref product);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("product = {0}", product);
        }
    }
}