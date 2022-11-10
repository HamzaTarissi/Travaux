using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sur__tableautrié
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = new int[10];
            int i, n, p = 0, inval;
            Console.WriteLine("Insérer une nouvelle valeur dans le tableau trié :\n");
            Console.Write("insérer la taille du tableau : ");
            n = (Console.Read());
            Console.WriteLine("Entrez {0} éléments dans le tableau dans l'ordre croissant :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("element - {0} : ", i);
                tab1[i] = (Console.Read());
            }
            Console.WriteLine("Entrer la valeur a insérer : \n");
            inval = (Console.Read());
            Console.Write("La liste des tableaux existants est : \n ");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", tab1[i]);

            for (i = 0; i < n; i++)
                if (inval < tab1[i])
                {
                    p = i;
                    break;
                }

            for (i = n; i >= p; i--)
                tab1[i] = tab1[i - 1];

            tab1[p] = inval;

            Console.WriteLine("Liste apres insertion est : \n ");
            for (i = 0; i <= n; i++)
                Console.WriteLine("{0} ", tab1[i]);

        }
    }
}
