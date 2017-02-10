using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Circle
    {
        public Dot center { get; set; }
        public int radius { get; set; }
        public Circle(Dot center, int radius)
        {
            this.center = center;
            this.radius = radius;
        }
        public static bool HasIntersection(Circle c1, Circle c2)
        {
            if (Dot.GetDistance(c1.center, c2.center) <= (c1.radius + c2.radius))
            {
                return true;
            }
            else return false;
            
        }
    }
    public class Dot
    {
        public int x { get; set; }
        public int y { get; set; }
        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static double GetDistance(Dot d1, Dot d2)
        {
            double dis;
            dis = Math.Sqrt((d1.x - d2.x) * (d1.x - d2.x) + (d1.y - d2.y) * (d1.y - d2.y));
            return dis;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dotString = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var dot2String = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Circle c1 = new Circle(new Dot(dotString[0], dotString[1]), dotString[2]);
            Circle c2 = new Circle(new Dot(dot2String[0], dot2String[1]), dot2String[2]);
            if (Circle.HasIntersection(c1, c2))
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }
    }
}
