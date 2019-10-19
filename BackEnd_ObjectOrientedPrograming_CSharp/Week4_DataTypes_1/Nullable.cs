using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week4_DataTypes_1
{
    public class Nullable
    {
        public Nullable()
        {
        }

        public void TestNullable()
        {
            int? number = null;
            ShowNumber(number);
            number = 37;
            ShowNumber(number);
        }

        private static void ShowNumber(int? number)
        {
            if (number.HasValue)
                Console.WriteLine(number);
            else
                Console.WriteLine("UNDEFINED");
        }
    }
}
