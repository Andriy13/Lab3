using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class CreditCard
    {
        int balance;
        public CreditCard()
        {
            Random r = new Random();
            balance = r.Next();
            Console.WriteLine(balance);
        }
    }
}
