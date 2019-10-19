using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week4_DataTypes_1
{
    public class Bytes
    {
        public Bytes()
        {
        }

        public static void TestBytes_1()
        {
            int kilo = 1024;
            int mega = kilo * kilo;
            int giga = kilo * mega;
            int tera = kilo * giga;

            Console.WriteLine("1 kilobyte = " + kilo + " bytes");
            Console.WriteLine("1 megabyte = " + mega + " bytes");
            Console.WriteLine("1 gigabyte = " + giga + " bytes");
            Console.WriteLine("1 terabyte = " + tera + " bytes");

            //Output
            //1 kilobyte = 1024 bytes
            //1 megabyte = 1048576 bytes
            //1 gigabyte = 1073741824 bytes
            //1 terabyte = 0 bytes
        }

        public static void TestBytes_2()
        {
            int kilo = 1024;
            int mega = kilo * kilo;
            long giga = kilo * mega;
            long tera = kilo * giga;

            Console.WriteLine("1 kilobyte = " + kilo + " bytes");
            Console.WriteLine("1 megabyte = " + mega + " bytes");
            Console.WriteLine("1 gigabyte = " + giga + " bytes");
            Console.WriteLine("1 terabyte = " + tera + " bytes");

            //1 kilobyte = 1024 bytes
            //1 megabyte = 1048576 bytes
            //1 gigabyte = 1073741824 bytes
            //1 terabyte = 1099511627776 bytes

        }
    }
}
