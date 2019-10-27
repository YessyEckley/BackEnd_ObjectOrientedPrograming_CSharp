using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week5_Classes.HotelCopy
{
    public enum BookingStatus : byte
    {
        HotelNotFound, //implicit value 0
        RoomsNotAvailable, //implicit value 1
        OK = 5 //explicit value
    }
}
