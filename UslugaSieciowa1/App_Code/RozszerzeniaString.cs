public static class RozszerzeniaString
{
    public static string Do10Znakow(this string input)
    {
        return input.Length >= 10 ? input.Substring(0, 10) : input.PadRight(10, 'X');
    }
}
