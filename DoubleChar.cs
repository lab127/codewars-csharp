/**
Given a string, you have to return a string in which each character (case-sensitive) is repeated once.

Examples (Input -> Output):
* "String"      -> "SSttrriinngg"
* "Hello World" -> "HHeelllloo  WWoorrlldd"
* "1234!_ "     -> "11223344!!__  "
*/

public class DoubleChar
{
    public static string DoubleIt(string s)
    {
        string str = "";
        for (int i = 0; i < s.Length; i++)
        {
            str += $"{s[i]}{s[i]}";
        }
        return str;
    }
}