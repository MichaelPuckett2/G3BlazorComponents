using System.Text.RegularExpressions;

namespace G3BlazorComponents;

public static partial class StringExtensions
{
    public static string SplitCamelCase(this string value, string splitValue = " ")
    {
        return MyRegex().Replace(value, $"{splitValue}$1");
    }

    [GeneratedRegex("(\\B[A-Z])")]
    private static partial Regex MyRegex();
}
