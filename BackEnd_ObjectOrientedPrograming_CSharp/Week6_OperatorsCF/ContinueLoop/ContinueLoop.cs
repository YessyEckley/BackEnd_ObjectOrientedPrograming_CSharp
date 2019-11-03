using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.ContinueLoop
{
    public class ContinueLoop
    {
        public static void DisplayTest()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int num in numbers)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            Console.Write("Odd numbers: ");
            int index = 0;
            while (++index < numbers.Length)
            {
                if (numbers[index] % 2 == 0)
                {
                    continue;
                }
                Console.Write("{0} ", numbers[index]);
            }
            Console.WriteLine();
        }
    }
}
