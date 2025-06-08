using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(BreakCamelCaseLinq("camelCasing"));
    }

    public static string BreakCamelCase(string str)
    {
        if (string.IsNullOrEmpty(str)) return string.Empty;
        var sb = new StringBuilder();
        foreach (var c in str)
        {
            if (char.IsUpper(c))
            {
                sb.Append($" {c}");
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }

    public static string BreakCamelCaseLinq(string str)
    {
        if (string.IsNullOrEmpty(str)) return string.Empty;

        return string.Join("", str.Select(c =>
        {
            if (char.IsUpper(c))
            {
                return $" {c}";
            }
            return $"{c}";
        }));
    }
}