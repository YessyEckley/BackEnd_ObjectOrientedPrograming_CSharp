using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week4_DataTypes_1
{
    public class Seven
    {
        public Seven()
        {
            char seven = '7';
            short number;
            //number = (short)seven; // This will convert to ACSII code Dex
            //Using Conver
            number = Convert.ToInt16(seven.ToString());
            //sbyte anSbyte;
            //SByte anotherSbyte;

            Console.WriteLine("seven = " + seven);
            Console.WriteLine("number = " + number);
        }
    }
}
