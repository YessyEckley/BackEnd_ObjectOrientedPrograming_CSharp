// Relational.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.Relational
{
    public class Relational
    {
        public static int DisplayTest()
        {
            int x = 17;
            int y = 5;
            //bool result = (x = y);
            Console.WriteLine("{0} == {1} = {2}", x, y, x == y);
            Console.WriteLine("{0} != {1} = {2}", x, y, x != y);
            Console.WriteLine("{0} < {1} = {2}", x, y, x < y);
            Console.WriteLine("{0} <= {1} = {2}", x, y, x <= y);
            Console.WriteLine("{0} > {1} = {2}", x, y, x > y);
            Console.WriteLine("{0} >= {1} = {2}", x, y, x >= y);
            return 0;
        }
    }
}