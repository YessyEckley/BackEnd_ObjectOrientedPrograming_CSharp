using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week4_DataTypes_1.LabAndDemo
{
    public class CalculatingBytes
    {
        public CalculatingBytes() { }

        /*
         * In the Program.cs call CalculatingBytesTest and run.
         * Watch out for the output.
         * This excercise is supposed to fail.
         * 
         * What do you need to do to fix this code?
         *
         * If in doubt, the nswer in on the file Bytes.cs.
         * But give it a try before taking a peek.
         */

        public static void CalculatingBytesTest()
        {
            int kilo = 1024;
            int mega = kilo * kilo;
            int giga = kilo * mega;
            int tera = kilo * giga;

            Console.WriteLine("1 kilobyte = " + kilo + " bytes");
            Console.WriteLine("1 megabyte = " + mega + " bytes");
            Console.WriteLine("1 gigabyte = " + giga + " bytes");
            Console.WriteLine("1 terabyte = " + tera + " bytes");
        }
    }
}
