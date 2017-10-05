using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Data
    {
        protected int a = 0, b = 0;

        public void nhap()
        {
            
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }

        public int UCLN(int a, int b)
        {
            int c = a, d = b;
            while (c != d)
            {
                if (c > d)
                    c = c - d;
                else
                    d = d - c;
            }
            return c;
        }

        public float BCNN(int c, int d)
        {
            return (float) a*b/UCLN(c, d);
        }
    }
}
