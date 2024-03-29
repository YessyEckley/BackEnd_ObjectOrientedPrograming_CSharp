// AccountDefinitions.cs - Step 6
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week10_NamespacesInterface.Sample.Bank.Step6
{
    interface IAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal Balance { get; }
        string Owner { get; set; }
        int Id { get; }
    }

    interface IStatement
    {
        string FormatBalance();
        string GetStatement();
        int Transactions { get; }
        void Post();
        void MonthEnd();
        string Prompt { get; }
    }

    interface IChecking
    {
        decimal Fee { get; }
    }

    interface ISavings
    {
        decimal Interest { get; }
        decimal Rate { get; set; }
    }
}