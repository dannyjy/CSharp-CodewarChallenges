namespace Codewars;

class SumArray
{
    public static int SumArrayValues(int[] arr) => arr.Aggregate((acc,val) => acc + val);
}