using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double a)
        {            
            string binario = "";
            double resto = -1;

            while (a >= 1)
            {
                resto = a % 2;
                a /= 2;
                if (resto == 1)
                {
                    binario = "1" + binario;
                }
                else
                {
                    binario = "0" + binario;
                }
            }            

            return binario;
        }

        public static double BinarioDecimal (string b)
        {
            double retorno = 0;
            int j = 7;

            for (int i = 0; i < b.Length ; i++)
            {
                retorno += double.Parse(b[j].ToString()) * Math.Pow(2, i);
                j--;
            }

            return retorno;
        }
    }
}
