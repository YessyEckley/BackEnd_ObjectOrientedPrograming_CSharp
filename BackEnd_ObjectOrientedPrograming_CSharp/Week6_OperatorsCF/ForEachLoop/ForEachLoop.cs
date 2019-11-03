// ForEachLoop.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.ForEachLoop
{
    public class ForEachLoop
    {
        public static int DisplayTest()
        {
            int[] primes = { 2, 3, 5, 7, 11, 13 };
            int sum = 0;
            foreach (int prime in primes)
            {
                Console.Write("{0} ", prime);
                sum += prime;
            }
            Console.WriteLine();
            Console.WriteLine("sum = {0}", sum);
            return 0;
        }
    }
}