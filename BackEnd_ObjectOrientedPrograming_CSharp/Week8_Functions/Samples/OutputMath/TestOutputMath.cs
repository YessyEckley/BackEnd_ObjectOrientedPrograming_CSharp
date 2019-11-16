// TestOutputMath.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Samples.OutputMath
{
    public class TestOutputMath
    {
        public static void DisplayTest()
        {
            int sum, product;
            OutputMath.Calculate(5, 7, out sum, out product);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("product = {0}", product);
        }
    }
}