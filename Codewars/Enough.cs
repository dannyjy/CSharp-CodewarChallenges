public static class CarSpace
{
    public static int Enough(int cap, int on, int wait)
    {
        int answer = cap - (on + wait);
        return answer < 0 ? Math.Abs(answer) : 0;
    }
}