using System;

public class Sum
{
    public static int PositiveSum(int[] arr) => arr.Where(x => x > 0).Sum();
}
