using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsola
{
    public class Problem
    {
        public int n;
        public int seed;
        public int c;
        public List<Item> items;
        public List<Item> plecak;

        public Problem(int number, int seed_num, int capacity)
        {
            n = number;
            seed = seed_num;
            c = capacity;
            items = new List<Item>();
            plecak = new List<Item>();
        }

        public void solveProblem()
        {
            foreach (Item item in items)
            {
                if (c - item.w >= 0)
                {
                    plecak.Add(item);
                    c -= item.w;
                }
            }

            Console.WriteLine("Pleacak zawiera następującą zawartość");
            for (int i = 0; i < plecak.Count(); i++)
            {
                Console.WriteLine(plecak[i]);
            }

            
        }

        public string solveProblemForGUI()
        {
            foreach (Item item in items)
            {
                if (c - item.w >= 0)
                {
                    plecak.Add(item);
                    c -= item.w;
                }
            }

            string s = "";

            s = "Pleacak zawiera następującą zawartość\r\n";
            for (int i = 0; i < plecak.Count(); i++)
            {
                s += plecak[i] + "\r\n";
            }

            return s; 
        }


        public override string ToString()
        {
            string s = "";
            for(int i = 0; i < n; i++)
            {
                s += Convert.ToString(items[i]);
                s += "\r\n";
            }
            return s;
        }

        public void generateSeedValues()
        {
            Random fixRand = new Random(seed);
            for(int i = 0; i < n; i++)
            {
                Item item = new Item(i + 1, (fixRand.Next() % 24 + 1), (fixRand.Next() % 24 + 1));
                items.Add(item);
            }
        }

    }
}
