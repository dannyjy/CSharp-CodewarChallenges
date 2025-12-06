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
            Console.WriteLine(c);

            bool d = HeroSurvive.Hero(7,4);
            Console.WriteLine(d);

            int e = AngleTriangle.OtherAngle(60,100);
            Console.WriteLine(e);
        }
    }
}