using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Pesos()
        {
            cotizRespectoDolar = 17.55F;
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
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

        public static explicit operator Dolar(Pesos p)
        {
            Dolar d;

            d = new Dolar(p.GetCantidad(), Dolar.GetCotizacion());

            return d;
        }

        public static explicit operator Euro(Pesos p)
        {
            Euro e;

            e = new Euro(p.GetCantidad(), Euro.GetCotizacion());

            return e;
        }

        public static implicit operator Pesos(double d)
        {
            Pesos p;

            p = new Pesos(d);

            return p;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            bool retorno = false;

            if (((Dolar)p).GetCantidad() == d.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            bool retorno = false;

            if (((Euro)p).GetCantidad() == e.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool retorno = false;

            if(p1.GetCantidad() == p2.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
    }
}
