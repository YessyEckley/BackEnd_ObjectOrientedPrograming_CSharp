// EchoArguments.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week7_StringsArrays.Samples.EchoArguments
{
    public class EchoArguments
    {
        // Pass the Program.cs Main string args
        public static void DisplayTest(string[] args)
        {
            foreach (string arg in args)
                Console.WriteLine(arg);
        }
    }
}