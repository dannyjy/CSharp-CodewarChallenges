namespace Codewars;

public class MultiplesOf
{
    public static List<int> FindMultiples(int n, int limit)
    {
        List<int> multiples = new List<int>();
        int numberValue = n;
        int multiplier = 2;
        while(limit >= n)
        {
            multiples.Add(n);
            n = numberValue * multiplier;
            multiplier++;
        }
        return multiples;
    }
}