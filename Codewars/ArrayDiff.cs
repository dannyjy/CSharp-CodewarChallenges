using System.Collections.Generic;
using System.Linq;

public class ArrayDifference
{
    //First alternative
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        var UniqueArr = new List<int>();
        a.ToList().ForEach((v) => UniqueArr.Add(v));
        b.ToList().ForEach((v) => {
            if (UniqueArr.Contains(v))
                UniqueArr.RemoveAll((r) => r == v);
        });

        return UniqueArr.ToArray();
    }
}