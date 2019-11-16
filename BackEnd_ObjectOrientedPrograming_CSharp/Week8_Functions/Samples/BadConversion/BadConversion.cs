// BadConversion.cs
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Samples.BadConversion
{
    public class BadConversion
    {
        public static void DisplayTest()
        {
            Account acc = new Account();
            CheckingAccount chk = new CheckingAccount();
            acc.Show();
            chk.Show();
            chk = (CheckingAccount)acc;     // explicit cast
            decimal charge = chk.fee;           // this is bad
        }
    }
}