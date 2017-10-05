using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class PhanSo : Data
    {
        public void RutGon(ref int e , ref int f)
        {
            int ucln = UCLN(e ,f );
            e = e / ucln;
            f = f / ucln;
            
        }

        public String Cong(int a, int b , int c, int d)
        {
            int tu = (a * d + b * c);
            int mau = b * d;
            RutGon(ref tu ,ref mau);
            return (tu + "/" + mau);
        }

        public String Tru(int a, int b, int c, int d)
        {
            int tu = (a * d - b * c);
            int mau = b * d;
            RutGon(ref tu,ref mau);
            return tu + "/" + mau;
        }

        public String Nhan(int a, int b, int c, int d)
        {
            int tu = a * c;
            int mau = b * d;
            RutGon(ref tu,ref mau);
            return (tu + "/" + mau);
        }


        public String Chia(int a, int b, int c, int d)
        {
            int tu = a * d;
            int mau = b * c;
            RutGon(ref tu, ref mau);
            return (tu + "/" + mau);
        }
    }
}
