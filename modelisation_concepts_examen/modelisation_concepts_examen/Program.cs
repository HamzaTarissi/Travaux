using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelisation_concepts_examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[100];
            for (int i = 0; i < tableau.Length; i += 2)
            {
                tableau[i] = i;
            }
            for (int i = 0; i < tableau.Length; i+=2)
            {
                Console.WriteLine(i + " : " + tableau[i-1]);
            }
        }
    }
}
