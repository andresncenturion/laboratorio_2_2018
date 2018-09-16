using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Pesos()
        {
            Pesos.cotizRespectoDolar = 17.55F;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            Dolar d;

            d = new Dolar(p.cantidad / Pesos.GetCotizacion());

            return d;
        }

        public static explicit operator Euro(Pesos p)
        {
            Euro e;

            e =  (Euro)(Dolar)p;

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

            if (p == (Pesos)d)
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

            if (p == (Pesos)e)
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

            if(p1 == p2)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator + (Pesos p, Dolar d)
        {
            Pesos resultado = new Pesos(p.cantidad + ((Pesos)d).cantidad);
            return resultado;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos resultado = new Pesos(p.cantidad + ((Pesos)e).cantidad);
            return resultado;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos resultado = new Pesos(p.cantidad - ((Pesos)d).cantidad);
            return resultado;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos resultado = new Pesos(p.cantidad - ((Pesos)e).cantidad);
            return resultado;
        }
    }
}
