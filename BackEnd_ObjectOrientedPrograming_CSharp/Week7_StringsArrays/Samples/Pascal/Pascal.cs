// Pascal.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week7_StringsArrays.Samples.Pascal
{
    public class Pascal
    {
        public static void DisplayTest()
        {
            int[][] binomial;
            int rows = 5;
            binomial = new int[rows][];
            binomial[0] = new int[1];
            binomial[0][0] = 1;
            if (rows > 1)
            {
                binomial[1] = new int[2];
                binomial[1][0] = 1;
                binomial[1][1] = 1;
            }
            for (int i = 2; i < rows; i++)
            {
                binomial[i] = new int[i + 1];
                binomial[i][0] = 1;
                binomial[i][i] = 1;
                for (int j = 1; j < i; j++)
                {
                    binomial[i][j] = binomial[i - 1][j - 1] + binomial[i - 1][j];
                }
            }
            Console.WriteLine("Pascal triangle via nested for loops");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0} ", binomial[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pascal triangle via nested foreach loop");
            foreach (int[] row in binomial)
            {
                foreach (int x in row)
                {
                    Console.Write("{0} ", x);
                }
                Console.WriteLine();
            }
        }
    }
}