// Hotel.cs – Step 2

using System;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Sample.HotelToString.Step3
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
            return city + " " + name;
        }
    }
}