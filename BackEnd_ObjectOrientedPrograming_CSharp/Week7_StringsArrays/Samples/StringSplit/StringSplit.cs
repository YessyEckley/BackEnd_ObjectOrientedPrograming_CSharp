// StringSplit.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week7_StringsArrays.Samples.StringSplit
{
    public class StringSplit
    {
        public static void DisplayTest()
        {
            string all = "San Francisco\tHilton\t150\t89.95";
            char[] seps = { '\t' };
            string[] pieces = all.Split(seps);
            foreach (string piece in pieces)
                Console.WriteLine(piece);
        }
    }
}