// CharCode.cs
//
// Shows some character codes

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week7_StringsArrays.Samples.CharCode
{
    public class CharCode
    {
        public static void DisplayTest()
        {
            char ch = '\u0041';
            Console.WriteLine($"Unicode char for {ch}.");

            Console.WriteLine("CharCodes for lower case char letters");
            byte na = (byte)'a';
            byte nz = (byte)'z';
            for (int i = na; i <= nz; i++)
            {
                Console.Write(i + "  ");
                Console.WriteLine((char)i);
            }

            Console.WriteLine("CharCodes for upper case char letters");
            byte nA = (byte)'A';
            byte nZ = (byte)'Z';
            for (int i = nA; i <= nZ; i++)
            {
                Console.Write(i + "  ");
                Console.WriteLine((char)i);
            }
        }
    }
}