
public static class ArraysInversion
{
    public static int[] InvertValues(int[] input) => input.Select(x => -(x)).ToArray();
}