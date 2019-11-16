// ReferenceMath.cs
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Samples.ReferenceMath
{
    public class ReferenceMath
    {
        public static void Calculate(int x, int y, ref int sum, ref int prod)
        {
            sum = x + y;
            prod = x * y;
        }
    }
}