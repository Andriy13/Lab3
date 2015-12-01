using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Money
    {
        public long code { get; set; }
        public double Count { get; private set; }
        public void Add(Money from, double count)
        {
            from.Sub(count);
            Count += count;
        }
        public void Sub(double count)
        {
            Count -= count;
        }
    }
}
