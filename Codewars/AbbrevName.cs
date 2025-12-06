namespace Codewars;

public class Abbrev
{
    public static string AbbrevName(string name) {
        string[] StrArr = name.ToUpper().Split(" ");
        return $"{StrArr[0][0]}.{StrArr[1][0]}";
    }
}