using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week4_DataTypes_1
{
    public class CharacterLiterals
    {
        public CharacterLiterals()
        {
            //Console.Write('7');
            //Console.Write('\t');
            //Console.Write('\x0037');
            //Console.Write('\t');
            //Console.Write('\u0037');
            //Console.Write('\n');
            //Console.Write('\'');
            //Console.Write('7');
            //Console.Write('\'');
            //Console.WriteLine();


            string a = "hello";
            if (a.Equals("hello2"))
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }

            if (a == "hello2")
            {
                Console.WriteLine("operator equal");
            }

        }
    }
}
