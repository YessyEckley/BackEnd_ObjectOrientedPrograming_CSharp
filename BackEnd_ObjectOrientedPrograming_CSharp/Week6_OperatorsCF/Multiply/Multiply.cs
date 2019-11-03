// Multiply.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.Multiply
{
    public class Multiply
    {
        public static int DisplayTest()
        {
            int x = 99999;
            int y = 99999;
            int z = x * y;
            Console.WriteLine("{0} * {1} = {2}", x, y, z);

            decimal dx = 99999;
            decimal dy = 99999;
            decimal dz = dx * dy;
            Console.WriteLine("{0} * {1} = {2}", dx, dy, dz);

            float f1 = 1.0E20f;
            float f2 = 1.0E20f;
            Console.WriteLine("{0} * {1} = {2}", f1, f2, f1 * f2);

            decimal d1 = 1.0E15m;
            decimal d2 = 1.0E15m;
            Console.WriteLine("{0} * {1} = {2}", d1, d2, d1 * d2);
            return 0;
        }
    }
}