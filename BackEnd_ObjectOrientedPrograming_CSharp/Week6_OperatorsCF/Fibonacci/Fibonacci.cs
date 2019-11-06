// Fibonacci.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.Fibonacci
{
    public class Fibonacci
    {
        public static int DisplayTest()
        {
            int[] fib;
            fib = new int[10];
            fib[0] = fib[1] = 1;
            // fib[0] = 0; fib[1] = 1;
            for (int i = 2; i < 10; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", fib[i]);
            }
            Console.WriteLine();

            for (int i = 9; i >= 0; i--)
            {
                Console.Write("{0} ", fib[i]);
            }
            Console.WriteLine();
            return 0;
        }
    }
}