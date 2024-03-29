// Concat.cs
//
// Demonstrates string literals and concatenation

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week7_StringsArrays.Samples.Concat
{
    public class Concat
    {
        public static void DisplayTest()
        {
            string s1 = "bat";
            Console.WriteLine("s1 = {0}", s1);
            string s2 = "man";
            Console.WriteLine("s2 = {0}", s2);
            s1 += s2;
            Console.WriteLine(s1);
            string path1 = "c:\\OIC\\CSharp\\Chap10\\Concat";
            Console.WriteLine("path1 = {0}", path1);
            string path = @"c:\OIC\CSharp\Chap10\Concat\";
            string file = "Concat.cs";
            path = path + file;
            Console.WriteLine(path);
            string greeting = @"""Hello, world""";
            Console.WriteLine(greeting);

            string concat1 = "This " + "is " + "concat!";
            concat1 += " Hello Concat!";
        }
    }
}