﻿using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week4_DataTypes_1
{
    public class IntegerRange
    {
        public IntegerRange()
        {
        }

        public static int TestIntegerRange()
        {
            Console.WriteLine("min sbyte = " + SByte.MinValue);
            Console.WriteLine("max sbyte = " + SByte.MaxValue);
            Console.WriteLine("min byte = " + Byte.MinValue);
            Console.WriteLine("max byte = " + Byte.MaxValue);
            Console.WriteLine("min short = " + Int16.MinValue);
            Console.WriteLine("max short = " + Int16.MaxValue);
            Console.WriteLine("min ushort = " + UInt16.MinValue);
            Console.WriteLine("max ushort = " + UInt16.MaxValue);
            Console.WriteLine("min int = " + Int32.MinValue);
            Console.WriteLine("max int = " + Int32.MaxValue);
            Console.WriteLine("min uint = " + UInt32.MinValue);
            Console.WriteLine("max uint = " + UInt32.MaxValue);
            Console.WriteLine("min long = " + Int64.MinValue);
            Console.WriteLine("max long = " + Int64.MaxValue);
            Console.WriteLine("min ulong = " + UInt64.MinValue);
            Console.WriteLine("max ulong = " + UInt64.MaxValue);

            //long aLongVarible = 100LU;

            return 0;
        }
    }
}
