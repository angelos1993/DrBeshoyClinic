using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static string ToCommaAndSeperatedString(this IEnumerable<string> enumerable)
        {
            var list = enumerable as IList<string> ?? enumerable.ToList();
            if (!list.Any())
                return string.Empty;
            switch (list.Count)
            {
                case 1:
                    return list[0];
                case 2:
                    return $"{list[0]} and {list[1]}";
                default:
                    var result = new StringBuilder();
                    for (var i = 0; i < list.Count - 1; i++)
                        result.Append($"{list[i]}, ");
                    result.Append($"and {list[list.Count - 1]}");
                    return result.ToString();
            }
        }
    }
}