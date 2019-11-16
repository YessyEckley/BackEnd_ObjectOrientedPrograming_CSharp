// TestVirtualAccount.cs
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Samples.VirtualAccount
{
    public class TestAccount
    {
        public static void DisplayTest()
        {
            Account acc = new Account();
            CheckingAccount chk = new CheckingAccount();
            acc.Show();
            chk.Show();
            acc = chk;
            acc.Show();         // now CheckingAccount.Show
        }
    }
}