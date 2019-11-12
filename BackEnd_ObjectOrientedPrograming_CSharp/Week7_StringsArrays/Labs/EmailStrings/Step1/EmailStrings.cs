// EmailStrings.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week7_StringsArrays.Labs.EmailStrings.Step1
{
    public class EmailStrings
    {
        public static void DisplayTest()
        {
            InputWrapper iw = new InputWrapper();
            char[] seps = { '@', '.' };
            string[] pieces;
            Console.WriteLine("Enter a string, empty string to terminate");
            string email = iw.getString("email: ");
            while (!email.Equals(""))
            {
                //Console.WriteLine(email);
                pieces = email.Split(seps);
                foreach (string part in pieces)
                    Console.WriteLine(part);
                email = iw.getString("email: ");
            }
        }
    }
}