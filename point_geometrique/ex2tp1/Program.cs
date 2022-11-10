using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ex2tp1
{
    internal class Program
    {
        public class point_geometrique
        {
            private int x, y;
            public void setx (int p)
            {
                x = p;
            }
            public void sety( int p2)
            {
                y = p2;
            }
            public int getx()
            {
                return x;
            }
            public int gety()
            {
                return y;
            }
            public class testpoint
            {
                static void Main(string args [] )
                {
                    point_geometrique p = new point_geometrique();
                    p.setx(1);
                    p.sety(2);
                    Console.WriteLine(p.getx());
                    Console.WriteLine(p.gety());
                }
            }
     } 
    }
}
