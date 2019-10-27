// Account.cs
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.ConstantAccount
{
    public class Account
    {
        public const decimal FEE = 5.00m;
        public readonly int FreeChecks;
        public Account(int num)
        {
            FreeChecks = num;
        }
    }
}