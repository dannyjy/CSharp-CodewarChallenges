namespace Codewars;

public class Reverse
{
    public int ReverseNumber(int n) {
        var numChars = Math.Abs(n).ToString().ToCharArray();
        Array.Reverse(numChars);
        var reversed = int.Parse(string.Join("",numChars));
        return n > 0 ? reversed : -reversed;
    }
}