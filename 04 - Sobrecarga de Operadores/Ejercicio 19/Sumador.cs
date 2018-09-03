using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas;

        public void Suma(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public void Suma()
        {
            this.Suma(0);
        }

        public long Sumar(long a, long b)
        {
            long resultado;

            this.cantidadSumas++;
            resultado = a + b;

            return resultado;
        }

        public string Sumar(string a, string b)
        {
            string mensaje;

            this.cantidadSumas++;
            mensaje = a + b;

            return mensaje;
        }

        public static explicit operator int (Sumador s)
        {            
            return s.cantidadSumas;
        }

        public static long operator + (Sumador s1, Sumador s2)
        {
            long retorno = s1.cantidadSumas + s2.cantidadSumas;
            return retorno;
        }

        public static bool operator | (Sumador s1, Sumador s2)
        {
            bool retorno = false;

            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
