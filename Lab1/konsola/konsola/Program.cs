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
            Console.WriteLine("Podaj pojemność plecaka:");
            int c = Convert.ToInt16(Console.ReadLine());
            Problem p = new Problem(n, seed, c);
            p.generateSeedValues();
            Console.WriteLine("Przed sortowaniem:");
            Console.WriteLine(p);
            Console.WriteLine("Po sortowaniu:");
            p.items.Sort(delegate (Item x, Item y)
            {
                return (y.w * y.val).CompareTo(x.w * x.val);
            });
            Console.WriteLine(p);
            p.solveProblem();

         }
    }
}
