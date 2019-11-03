// ShortCircuit.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.ShortCircuit
{
    public class ShortCircuit
    {
        public static int DisplayTest()
        {
            int x = 4;
            int y = 5;
            Console.WriteLine("x = {0}, y = {1}", x, y);
            bool result = true || (++x == y);
            Console.WriteLine("result = {0}", result);
            Console.WriteLine("x = {0}, y = {1}", x, y);

            result = true && (++x == y);
            Console.WriteLine("result = {0}", result);
            Console.WriteLine("x = {0}, y = {1}", x, y);

            y = ~x;
            bool a = true;
            bool b = false;
            result = a ^ b;

            return 0;
        }
    }
}