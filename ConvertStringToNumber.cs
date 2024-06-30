class ConvertStringToNumber
{
    public static int StringToNumber(string str)
    {
        return Convert.ToInt32(str);
    }

    public static int ParseStrToNum(string str)
    {
        return int.Parse(str);
    }

    public static int TryParseStrToNum(string str)
    {
        int n;
        int.TryParse(str, out n);
        return n;
    }
}