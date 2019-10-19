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
            Console.WriteLine("1.0/0.0 = " + 1.0 / 0.0);
            Console.WriteLine("0.0/0.0 = " + 0.0 / 0.0);

            return 0;
        }
    }
}
