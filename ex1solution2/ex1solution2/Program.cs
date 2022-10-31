using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1solution2
{
    internal class Program
    {
            public static bool IsPrime(int nb)
            {
                if (nb < 0)
                    return IsPrime(-nb);
                else if (nb <= 3)
                    return true;
                else
                {
                    int sqrt_int = (int)Math.Sqrt(nb);
                    for (int i = 2; i <= sqrt_int; i++)
                    {
                        if (nb % i == 0)
                            return false;
                    }

                    return true;
                }
        }
        }
    }
}
