using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Euro()
        {
            cotizRespectoDolar = 0.73303F;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
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

        public static explicit operator Dolar(Euro p)
        {
            Dolar d;

            d = new Dolar(p.GetCantidad(), Dolar.GetCotizacion());

            return d;
        }

        public static explicit operator Pesos(Euro e)
        {
            Pesos p;

            p = new Pesos(e.GetCantidad(), Pesos.GetCotizacion());

            return p;
        }

        public static implicit operator Euro(double d)
        {
            Euro e;

            e = new Euro(d);

            return e;
        }

        public static bool operator == (Euro e, Dolar d)
        {
            bool retorno = false;

            if(((Dolar)e).GetCantidad() == d.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator == (Euro e, Pesos p)
        {
            bool retorno = false;

            if(((Pesos)e).GetCantidad() == p.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator == (Euro e1, Euro e2)
        {
            bool retorno = false;

            if(e1.GetCantidad() == e2.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
    }
}
