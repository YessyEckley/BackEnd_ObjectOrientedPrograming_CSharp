// Hotel.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.HotelCreate
{
    public struct Hotel
    {
        public string city;
        public string name;
        public int rooms;
        public decimal cost;

        public Hotel(string city, string name, int rooms, decimal cost)
        {
            Console.WriteLine("Hotel struct instance");
            this.city = city;
            this.name = name;
            this.rooms = rooms;
            this.cost = cost;
        }
        public void Show()
        {
            Console.WriteLine("{0} {1} {2} {3:C}", city, name, rooms, cost);
        }
    }
}
