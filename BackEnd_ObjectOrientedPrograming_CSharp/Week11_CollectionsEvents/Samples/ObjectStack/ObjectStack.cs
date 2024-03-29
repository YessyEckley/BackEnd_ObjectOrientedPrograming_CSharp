using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.ObjectStack
{
    public class ObjectStack
    {
        static void DisplayTest()
        {
            MyStack intstack = new MyStack(3);
            intstack.Push(5);
            intstack.Push(17);
            intstack.Push(33);
            intstack.Show();
            try
            {
                intstack.Push(77);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int n = (int)intstack.Pop();
            Console.WriteLine("{0} popped", n);
            Console.WriteLine("{0} popped", (int)intstack.Pop());
            Console.WriteLine("{0} popped", (int)intstack.Pop());
            try
            {
                Console.WriteLine("{0} popped", intstack.Pop());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
