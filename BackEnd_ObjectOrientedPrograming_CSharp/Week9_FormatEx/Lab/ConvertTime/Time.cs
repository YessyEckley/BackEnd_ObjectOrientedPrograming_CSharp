// Time.cs

using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week9_FormatEx.Lab.ConvertTime
{
    public class Time
    {
        private int hour;
        private int minute;
        public Time(int h, int m)
        {
            hour = h;
            minute = m;
        }
        public static explicit operator Time(string str)
        {
            char[] seps = { ':' };
            string[] pieces = str.Split(seps);
            int hour = Convert.ToInt32(pieces[0]);
            int minute = Convert.ToInt32(pieces[1]);
            Time t = new Time(hour, minute);
            return t;
        }
        public static implicit operator string(Time t)
        {
            return t.hour + ":" + t.minute;
        }
    }
}