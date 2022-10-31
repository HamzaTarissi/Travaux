using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            bool isfirst = true;
            Console.WriteLine("veuillez entrer un nombre");
            n = Convert.ToInt32(Console.ReadLine()); 
            isfirst = true;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                    isfirst = false;
                
                break;
            }
            if (isfirst == true)
            Console.WriteLine("ce nombre est premier");
            else
                Console.WriteLine("ce nombre n'est pas premier ");
        } 
    }
}