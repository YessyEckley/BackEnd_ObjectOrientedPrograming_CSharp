// OutputMath.cs
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Samples.OutputMath
{
    public class OutputMath
    {
        public static void Calculate(int x, int y, out int sum, out int prod)
        {
            sum = x + y;
            prod = x * y;
        }
    }
}