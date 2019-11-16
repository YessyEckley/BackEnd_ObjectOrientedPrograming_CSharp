// TestClock.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Samples.ClockOverload
{
    public class TestClock
    {
        public static void DisplayTest()
        {
            Clock c1 = new Clock(17);
            Console.WriteLine("c1 = {0}", c1.Hour);
            Clock c2 = new Clock(10);
            Console.WriteLine("c2 = {0}", c2.Hour);
            Clock c3 = c1 + c2;
            Console.WriteLine("c3 = {0}", c3.Hour);
            c3 += 1;
            Console.WriteLine("c3 + 1 = {0}", c3.Hour);
        }
    }
}