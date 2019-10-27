// HotelCopy.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.HotelCopy
{
    public class HotelCopy
    {
        public static void DisplayTest()
        {
            Hotel ritz = new Hotel("Boston", "Ritz", 100, 200.00m);
            Console.Write("ritz: ");
            ritz.Show();
            Hotel flop = ritz;                  // #1
            Console.Write("flop: ");
            flop.Show();
            // Change price of flop
            flop.cost = 10.00m;
            Console.Write("flop: ");
            flop.Show();
            Console.Write("ritz: ");
            ritz.Show();
            Hotel fancy = new Hotel(ritz);      // #2
            Console.Write("fancy: ");
            fancy.Show();
        }
    }
}