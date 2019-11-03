// BreakSearch.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.BreakSearch
{
    public class BreakSearch
    {
        public static int DisplayTest()
        {
            int[] primes = { 2, 3, 5, 7, 11, 13 };
            foreach (int prime in primes)
                Console.Write("{0} ", prime);
            Console.WriteLine();
            int target = 7;
            int i;
            for (i = 0; i < primes.Length; i++)
            {
                if (target == primes[i])
                    break;
            }
            if (i == primes.Length)
                Console.WriteLine("{0} not found", target);
            else
                Console.WriteLine("{0} found at {1}", target, i);
            return 0;
        }
    }
}
