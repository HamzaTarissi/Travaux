using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i,isfirst;
            Console.WriteLine("veuillez entrer un nombre");
            n = Console.Read();
            isfirst = 1;
            for ( i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                    isfirst = 0;
                Console.WriteLine("ce nombre n'est pas premier ");
                break;
            }
                if (isfirst == 1)
                    Console.WriteLine("{0} est un nombre premier",n);
        } 
    }
}