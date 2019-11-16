// HotelTest.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Labs.HotelClass.Step2
{
    public class HotelDemo
    {
        public static void DisplayTest()
        {
            Hotel ritz = new Hotel("Boston", "Ritz", 100, 100.00m);
            Console.WriteLine("Original values");
            ritz.Show();
            // Assign many rooms and high cost
            ritz.Rooms = 1000;
            ritz.Cost = 1000M;
            Console.WriteLine("After high values assigned");
            ritz.Show();
            // Assign few rooms and low cost
            ritz.Rooms = 5;
            ritz.Cost = 5M;
            Console.WriteLine("After low values assigned");
            ritz.Show();
        }
        private static void RaisePrice(Hotel hotel, decimal delta)
        {
            hotel.Cost += delta;
            Console.WriteLine("new cost = {0:C}", hotel.Cost);
        }
    }
}