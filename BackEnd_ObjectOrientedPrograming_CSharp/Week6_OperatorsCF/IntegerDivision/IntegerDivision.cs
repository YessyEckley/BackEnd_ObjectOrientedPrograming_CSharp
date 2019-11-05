// IntegerDivision.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.IntegerDivision
{
    public class IntegerDivision
    {
        public static int DisplayTest()
        {
            Console.WriteLine("{0} / {1} = {2}", 17, 5, 17 / 5);
            Console.WriteLine("{0} / {1} = {2}", 17, -5, 17 / -5);
            int zero = 0;
            Console.Write("{0} / {1} = ", 17, zero);
            Console.WriteLine("{0}", 17 / zero);
            return 0;
        }
    }
}