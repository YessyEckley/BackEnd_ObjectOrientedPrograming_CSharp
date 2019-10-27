// Hotel.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.Week5Labs.HotelStructArray.Step2
{
    public struct Hotel
    {
        public void init(string city, string name, int rooms, decimal cost)
        {
            city_ = city;
            name_ = name;
            rooms_ = rooms;
            cost_ = cost;
        }
        public void Show()
        {
            Console.WriteLine("{0} {1} {2} {3:C}", city_, name_, rooms_, cost_);
        }
        private string city_;
        private string name_;
        private int rooms_;
        private decimal cost_;
    }
}
