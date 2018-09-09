using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad): this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion): this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro e;

            e = new Euro(d.GetCantidad(), Euro.GetCotizacion());

            return e;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos p;

            p = new Pesos(d.GetCantidad(), Pesos.GetCotizacion());

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

            if(((Euro)d).GetCantidad() == e.GetCantidad())
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

            if(((Pesos)d).GetCantidad() == p.GetCantidad())
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

            if (d1.GetCantidad() == d2.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
    }
}
