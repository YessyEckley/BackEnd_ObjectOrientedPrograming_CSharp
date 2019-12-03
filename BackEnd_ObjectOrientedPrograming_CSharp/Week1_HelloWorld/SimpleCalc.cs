using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week1_HelloWorld
{
    public class SimpleCalc
    {
        public SimpleCalc()
        {
        }

        public void TestSimpleCalculator()
        {
            int width = 20;
            int height = 5;
            int area;
            area = width * height;
            Console.WriteLine("area = {0}", area);
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
