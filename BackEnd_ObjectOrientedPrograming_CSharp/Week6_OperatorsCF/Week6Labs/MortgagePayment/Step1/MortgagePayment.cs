// MortgagePayment.cs
//
// Interactive program to compute a mortgage payment

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week6_OperatorsCF.Week6Labs.MortgagePayment.Step1
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
            return 0.0m; //stub code, sub this code
        }
    }
}