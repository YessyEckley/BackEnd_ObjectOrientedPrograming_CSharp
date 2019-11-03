// Assign.cs

using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.Assign
{
    public class Assign
    {
        public static int DisplayTest()
        {
            int x = 30;
            int y = 5;
            int z = 1;
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
            x = (y = z++) + 60;
            Console.WriteLine("After x = (y = z++) + 60;");
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
            return 0;
        }
    }
}