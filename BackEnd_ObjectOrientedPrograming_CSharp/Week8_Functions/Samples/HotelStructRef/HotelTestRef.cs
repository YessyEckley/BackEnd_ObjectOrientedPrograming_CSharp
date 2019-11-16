// HotelTestRef.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Samples.HotelStructRef
{
    public class HotelTestRef
    {
        public static void DisplayTest()
        {
            Hotel ritz = new Hotel("Boston", "Ritz", 100, 200.00m);
            // The Ritz before and after
            Console.WriteLine("Before price hike");
            ritz.Show();
            RaisePrice(ref ritz, 50.00m);
            Console.WriteLine("After price hike");
            ritz.Show();
        }
        private static void RaisePrice(ref Hotel hotel, decimal delta)
        {
            hotel.cost += delta;
            Console.WriteLine("new cost = {0:C}", hotel.cost);
        }
    }
}