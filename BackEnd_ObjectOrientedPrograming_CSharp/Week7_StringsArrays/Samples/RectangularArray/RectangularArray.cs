// RectangularArray.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week7_StringsArrays.Samples.RectangularArray
{
    public class RectangularArray
    {
        public static void DisplayTest()
        {
            int rows = 5;
            Console.WriteLine("Multiplication Table");
            int[,] MultTable = new int[rows, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    MultTable[i, j] = i * j;
                    Console.Write("{0}   ", MultTable[i, j]);
                }
                Console.WriteLine();
            }
            // Now show the raw data
            // Observe that it is stored in "row major" order
            foreach (int x in MultTable)
                Console.Write("{0} ", x);
            Console.WriteLine();
        }
    }
}