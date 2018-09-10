using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion): this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro e;

            e = new Euro(d.cantidad * Euro.GetCotizacion());

            return e;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos p;

            p = new Pesos(d.cantidad * Pesos.GetCotizacion());

            return p;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar dolar;

            dolar = new Dolar(d);

            return dolar;
        }

        public static bool operator == (Dolar d, Euro e)
        {
            bool retorno = false;

            if(d == (Dolar)e)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator == (Dolar d, Pesos p)
        {
            bool retorno = false;

            if(d == (Dolar)p)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator == (Dolar d1, Dolar d2)
        {
            bool retorno = false;

            if (d1.cantidad == d2.cantidad)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator + (Dolar d, Euro e)
        {
            Dolar resultado = new Dolar();

            resultado = d.cantidad + ((Dolar)e).cantidad;

            return resultado;
        }

        public static Dolar operator + (Dolar d, Pesos p)
        {
            Dolar resultado = new Dolar();

            resultado = d.cantidad + ((Dolar)p).cantidad;

            return resultado;
        }

        public static Dolar operator - (Dolar d, Euro e)
        {
            Dolar resultado = new Dolar();

            resultado = d.cantidad - ((Dolar)e).cantidad;

            return resultado;
        }

        public static Dolar operator - (Dolar d, Pesos p)
        {
            Dolar resultado = new Dolar();

            resultado = d.cantidad - ((Dolar)p).cantidad;

            return resultado;
        }
    }
}
