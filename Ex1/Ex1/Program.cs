using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool isfirst = true;
            Console.WriteLine("veuillez entrer un nombre");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    isfirst = false;
                
                break;
            }
            if (isfirst == true)
            Console.WriteLine("{0] est un nombre premier ",n);
            else
                Console.WriteLine("{0} n'est pas un nombre premier ",n);
        }
    }
}
