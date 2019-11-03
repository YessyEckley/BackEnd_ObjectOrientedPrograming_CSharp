// MortgagePayment.cs
//
// Interactive program to compute a mortgage payment

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.Week6Labs.MortgagePayment.Step2
{
    public class MortgagePayment
    {
        public static int DisplayTest()
        {
            InputWrapper iw = new InputWrapper();
            decimal amount;  // amount of loan
            double rate;     // interest rate
            int months;      // number of periods
                             // Prompt for amount of loan, interest rate, and months
                             // Calculate monthly payment using payment() method
                             // Display this payment

            amount = iw.getDecimal("amount of loan: ");
            rate = iw.getDouble("interest rate: ");
            months = iw.getInt("months: ");
            decimal monthlyPayment = payment(amount, rate, months);
            Console.WriteLine("Monthly payment is ${0}", monthlyPayment);
            return 0;
        }
        /***************************************************************/
        /* payment -- calculate the payment on a loan                  */
        /* formula:                                                    */
        /*                                      -months                */
        /*        r = amount /((1 - (1+interest)        ) / interest)  */
        /***************************************************************/
        static decimal payment(decimal amount, double interest, int months)
        {
            decimal calcPymt = amount;
            double denominator = 1 + interest / 1200.0;
            denominator = Math.Pow(denominator, -months);
            denominator = 1 - denominator;
            denominator /= interest / 1200.0;
            calcPymt /= (decimal)denominator;
            return calcPymt;
        }
    }
}