using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Llibreria
{
    public class ClFuncions
    {
        public bool EsPrimer(Int32 v1)
        {

            Int32 i = 2;
            Int32 resto = 0;
            while (i < v1)
            {
                resto = v1 % i;

                if (resto == 0)
                {

                    return false;

                }

                i++;
            }
            return true;

        }

        public Int32 EsMesGran(Int32 v1, Int32 v2)
        {
            if (v1 > v2) return v1;
            else return v2;
        }

        public Int32 EsMesPetit(Int32 v1, Int32 v2)
        {
            if (v1 < v2) return v1;
            else return v2;
        }

        public String Divisors(Int32 n)
        {
            String resultat = "1";

            Int32 i = 2;
            while (i <= n)
            {
                if(n % i == 0)
                {
                    resultat += "," + i;
                }
                i++;
            }
            return resultat;
        }

    }
}

