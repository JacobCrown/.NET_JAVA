using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsola
{
    class Item
    {
        public int number;
        public int val;
        public int w;
        public Item(int n, int v, int wei)
        {
            number = n;
            val = v;
            w = wei;
        }
        public override string ToString()
        {
            return number.ToString() + ": Value: " + val.ToString() + " Weight: " + w.ToString() + " v*w: " + (w*val).ToString();
        }
    }
}
