using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsola
{
    class Problem
    {
        public int n;
        public int seed;
        public int c;
        public int[] v_list;
        public int[] w_list;

        public Problem(int number, int seed_num, int capacity)
        {
            n = number;
            seed = seed_num;
            c = capacity;
            v_list = new int[n];
            w_list = new int[n];
        }

        public void solve_problem()
        {
            
        }

        public override string ToString()
        {
            return "Hello There!";
        }
    }
}
