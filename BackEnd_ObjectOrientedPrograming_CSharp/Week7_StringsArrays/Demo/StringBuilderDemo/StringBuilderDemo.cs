// StringBuilderDemo.cs

using System;
using System.Text;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week7_StringsArrays.Demo.StringBuilderDemo
{
    public class StringBuilderDemo
    {
        public static void DisplayTest()
        {
            //This show an example of how StrinBuilder dynamically increases
            //its capacity depending on the length of the string it is trying
            //to build
            StringBuilder build = new StringBuilder();

            Console.WriteLine("build.Length = {0}", build.Length);
            Console.WriteLine("capacity = {0}", build.Capacity);

            build.Append("This is the first sentence.\n");
            Console.WriteLine("build.Length = {0}", build.Length);
            Console.WriteLine("capacity = {0}", build.Capacity);

            build.Append("This is the second sentence.\n");
            Console.WriteLine("build.Length = {0}", build.Length);
            Console.WriteLine("capacity = {0}", build.Capacity);

            build.Append("This is the second to last sentence.\n");
            Console.WriteLine("build.Length = {0}", build.Length);
            Console.WriteLine("capacity = {0}", build.Capacity);

            build.Append("This is the last sentence.\n");
            Console.WriteLine("build.Length = {0}", build.Length);
            Console.WriteLine("capacity = {0}", build.Capacity);

            string str = build.ToString();
            Console.Write(str);
        }
    }
}