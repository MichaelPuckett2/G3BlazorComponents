using System.Text.RegularExpressions;

namespace G3BlazorComponents
{
    public static class StringExtensions
    {
        public static string SplitCamelCase(this string value, string splitValue = " ")
        {
            return Regex.Replace(value, "(\\B[A-Z])", $"{splitValue}$1");
        }
    }
}
