class Solution
{
    public static int[,] MultiplicationTable(int size)
    {
        int[,] arr = new int[size,size];
        for(int i = 0; i <= arr.GetLength(0) - 1; i++)
        {
            for(int j = 0; j <= arr.GetLength(1) - 1; j++)
            {
                arr[i,j] = (i+1) * (j+1);
            }
        }
        return arr;
    }
}