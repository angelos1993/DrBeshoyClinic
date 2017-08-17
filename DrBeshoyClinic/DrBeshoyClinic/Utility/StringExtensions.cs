using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DrBeshoyClinic.Utility
{
    public static class StringExtensions
    {
        public static string FullTrim(this string str)
        {
            return Regex.Replace(str.TrimStart().TrimEnd().Trim(), @"\s+", " ");
        }

        public static bool IsNullOrEmptyOrWhiteSpace(this string str)
        {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }

        public static string ToCommaSeperatedString(this IEnumerable<string> list)
        {
            return string.Join(", ", list);
        }
    }
}