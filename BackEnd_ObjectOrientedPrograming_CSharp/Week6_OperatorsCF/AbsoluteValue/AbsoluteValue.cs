// AbsoluteValue.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.AbsoluteValue
{
    public class AbsoluteValue
    {
        public static int DisplayTest()
        {
            int x = 5;
            int abs = (x < 0) ? -x : x;
            Console.WriteLine("x = {0}, abs = {1}", x, abs);
            x = -x;
            abs = (x < 0) ? -x : x;
            Console.WriteLine("x = {0}, abs = {1}", x, abs);
            return 0;
        }
    }
}