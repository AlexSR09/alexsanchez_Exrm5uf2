using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Llibreria
{
    public class ClFuncions
    {
        public bool EsPrimer(int v1)
        {

            int i = 2;
            int resto = 0;
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

    }
   
}

