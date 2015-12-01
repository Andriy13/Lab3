using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard cc = new CreditCard();
            Money bank = new Money();
            Money me = new Money();
            me.Add(bank,1000000);
            Console.WriteLine(bank.Count);
            Console.WriteLine(me.Count);
        }
    }
}
