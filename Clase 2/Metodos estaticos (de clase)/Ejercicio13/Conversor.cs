using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Conversor
    {
        public static string DecimalBinario(double aux)
        {
            string retorno = "";            

            if (aux > 0)
            {
                do
                {                    
                    if (aux % 2)
                    {
                        retorno += '1';
                    }
                    else
                    {
                        retorno += '0';
                    }
                } while (aux >= 2);
            }
            return retorno;
        }

        public static double BinarioDecimal(string aux)
        {
            double retorno;


        }
    }
}
