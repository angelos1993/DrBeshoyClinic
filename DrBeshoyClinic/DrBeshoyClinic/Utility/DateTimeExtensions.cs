using System;

namespace DrBeshoyClinic.Utility
{
    public static class DateTimeExtensions
    {
        public static string ToListBoxDateString(this DateTime dateTime)
        {
            return dateTime.ToShortDateString();
        }
    }
}