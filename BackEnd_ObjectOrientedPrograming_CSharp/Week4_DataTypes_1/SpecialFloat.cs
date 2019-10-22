using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week4_DataTypes_1
{
    public class SpecialFloat
    {
        public SpecialFloat()
        {
        }

        public static int TestSpecialFloat()
        {
            //Console.WriteLine("1.0/0.0 = " + 1.0 / 0.0);
            //Console.WriteLine("0.0/0.0 = " + 0.0 / 0.0);

            //Console.WriteLine($"Decimal Min Value: {Decimal.MinValue}");
            //Console.WriteLine($"Decimal Max Value: {Decimal.MaxValue}");

            float aFloatNumber = 4567;
            Console.WriteLine("This is an implicit conversion "
                + aFloatNumber);

            //Cannot convert
            //double thisIsADouble = (decimal)4567;

            float pi = (float)3.141529;

            return 0;
        }
    }
}
