using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Armstrongseries
    {
        public void Arm() { 
        int n, r, temp;
        for (n = 1; n< 1000; n++)
        {
            temp = n;
            int sum = 0;
            while (temp > 0)
            {
                r = temp % 10;
                sum = sum + (r* r* r);
                temp = temp / 10;
            }
            if (sum == n)
            {
                Console.WriteLine("{0} is armstrong number.", n);

            }
        }
}
    }
}
