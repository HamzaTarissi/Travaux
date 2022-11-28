using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointgeomatrique
{
    internal class Point
    {
        private int x;
        private int y;
 
        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;

            this.y = y;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public int GetX()
        {
            return x;
        }
        public void SetY(int y)

        {
            this.y = y;
        }

        public int GetY()

        {
            return y;
        }
        public double Distance(Point p)

        {
            return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
        }

        public bool Egalite(Point p)

        {
            return x == p.x && y == p.y;
        }
        public void Translation(int dx, int dy)

        {
            y += dx;
            x += dy;
        }
        public static bool Linearite(Point P1, Point P2, Point P3)

        {
            return (P2.x - P1.x) * (P3.y - P1.y) == (P3.x - P1.x) * (P2.y - P1.y);
        }
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(2, 3);
            Point p3 = new Point(3, 4);
            Console.WriteLine("the distance is : " + p1.Distance(p2));
        }
    }
}

