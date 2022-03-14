using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę n:");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Podaj seed:");
            int seed = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(seed);
            Console.WriteLine("Podaj pojemność plecaka:");
            int c = Convert.ToInt16(Console.ReadLine());
            Problem p = new Problem(n, seed, c);


            Console.WriteLine(p.ToString());

        }
    }
}
