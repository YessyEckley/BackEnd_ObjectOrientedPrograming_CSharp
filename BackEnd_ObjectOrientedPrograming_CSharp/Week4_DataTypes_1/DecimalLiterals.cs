using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week4_DataTypes_1
{
    public class DecimalLiterals
    {
        public DecimalLiterals()
        {
            double pi = 3.14;
            float e = 2.72F;
            double earthFromSun = 9.3E7;
            decimal mySalary = 199.50M;
            decimal nationalDebit = 7E12M;

            Console.WriteLine("pi = " + pi);
            Console.WriteLine("e = " + e);
            Console.WriteLine("earthFromSun = " + earthFromSun);
            Console.WriteLine("mySalary = " + mySalary);
            Console.WriteLine("nationalDebit = " + nationalDebit);
        }
    }
}
