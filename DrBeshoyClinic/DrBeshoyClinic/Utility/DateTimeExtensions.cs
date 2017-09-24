using System;

namespace DrBeshoyClinic.Utility
{
    public static class DateTimeExtensions
    {
        public static string ToListBoxDateString(this DateTime dateTime)
        {
            return dateTime.ToCustomShortDateString();
        }

        public static string ToCustomShortDateString(this DateTime dateTime)
        {
            return dateTime.ToString("dd / MM / yyyy");
        }

        public static string ToCustomFormattedShortDateString(this DateTime dateTime)
        {
            return dateTime.ToString("MMM dd, yyyy");
        }

        public static string ToCustomFormattedLongDateString(this DateTime dateTime)
        {
            return dateTime.ToString("MMMM dd, yyyy");
        }
    }
}