// MoneyReport.cs

using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Sample.MoneyReport
{

    public class MoneyReport
    {
        public static void DisplayTest()
        {
            decimal amount = CalculateAmount();
            Console.WriteLine(CreateReport(amount));
        }
        public static decimal CalculateAmount()
        {
            decimal power = .01m;
            decimal total = 0m;
            for (int i = 1; i <= 64; i++)
            {
                total += power;
                power *= 2;
            }
            return total;
        }

        public static string CreateReport(decimal amount)
        {
            string str = "Dear Your Majesty,\n\t" +
                string.Format
                   ("You owe me {0,30:C}", amount) +
                "\nSincerely, Your Humble Servant";

            return str;
        }
    }
}