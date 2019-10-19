using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week4_DataTypes_1
{
    public class LargeSmall
    {
        public LargeSmall()
        {
        }

        public static int TestLargeSmall()
        {
            float largestFloat = Single.MaxValue;
            Console.WriteLine("The largest float is {0}", largestFloat);

            decimal smallestDecimal = Decimal.MinValue;
            Console.WriteLine("The smallest decimal is {0}", smallestDecimal);

            double smallestDouble = Double.MinValue;
            Console.WriteLine("The smallest double is {0}", smallestDouble);

            return 0;
        }
    }
}
