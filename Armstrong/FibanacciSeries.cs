using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class FibanacciSeries
    {
        public void Fibanacci()
        {
            //Adding line
            int a = 0, b = 1, c, n = 20;
            Console.WriteLine("----------------");
            Console.WriteLine("Fibanacci Series");
            Console.WriteLine("----------------");

            for (int i=2; i <= n; ++i)
            {
                c = a + b;
                Console.WriteLine("" + c);
                a = b;
                b = c;
            }
        }
    }
}
