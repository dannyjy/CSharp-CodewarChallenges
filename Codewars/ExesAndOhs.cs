namespace Codewars;

public static class ExesAndOhas
{
    public static bool XO(string input)
    {
        return input.ToLower().Count((c) => c == 'x') == input.ToLower().Count((c) => c == 'o');
  }
}