namespace Codewars;

class FindName
{
    public static string FindNameInArray(string name,string[] names) => names.First((n) => n == name);
}