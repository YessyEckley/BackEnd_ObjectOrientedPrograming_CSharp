// HotelClass.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week8_Functions.Labs.HotelClass.Step1
{
    public class Hotel
    {
        public Hotel(string city, string name, int rooms, decimal cost)
        {
            Console.WriteLine("Hotel class instance");
            this.city = city;
            this.name = name;
            this.rooms = rooms;
            this.cost = cost;
        }
        public void Show()
        {
            Console.WriteLine("{0} {1} {2} {3:C}", city, name, rooms, cost);
        }
        public string city;
        public string name;
        public int rooms;
        public decimal cost;
    }
}