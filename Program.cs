using Codewars;

namespace Challenges
{
    class Program{
        public static void Main(string[] args)
        {
            int a = Paper.Paperwork(5,5);
            // Console.WriteLine(a);
            string b = Abbrev.AbbrevName("gorge coloney");
            // Console.WriteLine(b);

            int c = CarSpace.Enough(20,15,0);
            // Console.WriteLine(c);

            bool d = HeroSurvive.Hero(7,4);
            // Console.WriteLine(d);

            int e = AngleTriangle.OtherAngle(60,100);
            // Console.WriteLine(e);

            var arr = ArrayDifference.ArrayDiff(new int[] {1,2,2}, new int[] {1});
            // Console.WriteLine(Even.IsEven(1));

            var f = StringExt.ToAlternatingCase("Feasd WoN");
            Console.WriteLine(f);

            Console.WriteLine(Sum.PositiveSum([-1, -2, -3, -4, -5]));
            var g = ArraysInversion.InvertValues([-1, 2, -3, -4, 5]);

            var arr2 = CountX.CountBy(2,5);
            string h = BooleanString.BooleanToString(false);
            Console.WriteLine(h);
        }
    }
}