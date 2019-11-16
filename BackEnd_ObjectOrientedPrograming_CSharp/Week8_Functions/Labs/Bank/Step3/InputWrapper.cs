// InputWrapper.cs
//
// Class to wrap simple stream input
// Datatypes supported:
//      int
//      double
//      decimal
//      string

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Labs.Bank.Step3
{
    class InputWrapper
    {
        public int getInt(string prompt)
        {
            Console.Write(prompt);
            string buf = Console.ReadLine();
            return Convert.ToInt32(buf);
        }
        public double getDouble(string prompt)
        {
            Console.Write(prompt);
            string buf = Console.ReadLine();
            return Convert.ToDouble(buf);
        }
        public decimal getDecimal(string prompt)
        {
            Console.Write(prompt);
            string buf = Console.ReadLine();
            return Convert.ToDecimal(buf);
        }
        public string getString(string prompt)
        {
            Console.Write(prompt);
            string buf = Console.ReadLine();
            return buf;
        }
    }
}