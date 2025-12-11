using System;

public static class CountX
{
    public static int[] CountBy(int x, int n)
    {
        int[] z = new int[n];
        int valueOfValue = x;
        for (int i = 0; i < z.Length; i++)
        {
                z[i] = x;
                x=x + valueOfValue;
        }
        return z;
    }
}