// Hotel.cs � Step 2

using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Sample.HotelToString.Step2
{

    public class Hotel
    {
        private string city;
        private string name;
        public Hotel(string city, string name)
        {
            this.city = city;
            this.name = name;
        }
        override public string ToString()
        {
            return "This is the city: " + city + "of the hotel: " + name;
        }
    }
}