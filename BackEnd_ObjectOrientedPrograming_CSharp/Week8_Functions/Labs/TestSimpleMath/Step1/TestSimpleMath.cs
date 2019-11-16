// TestSimpleMath.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Labs.TestSimpleMath.Step1
{
    public class TestSimpleMath
    {
        public static void DisplayTest()
        {
            int sum = SimpleMath.Add(5, 7);
            int product = SimpleMath.Multiply(5, 7);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("product = {0}", product);
        }
    }
}