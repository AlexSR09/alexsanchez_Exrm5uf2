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

    }
   
}

