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

            while (a >= 0)
            {
                resto = a % 2;
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
            double retorno = double.MinValue;            

            for (int i = b.Length - 1; i >= 0 ; i--)
            {
                if (b[i] == '0' || b[i] == '1')
                {
                    double.TryParse(b, out retorno);
                }
            }
            return retorno;
        }
    }
}
