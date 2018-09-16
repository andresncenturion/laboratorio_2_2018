using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Euro()
        {
            Euro.cotizRespectoDolar = 1/1.3642F;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro p)
        {
            Dolar d;

            d = new Dolar(p.cantidad/Euro.GetCotizacion());

            return d;
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dolar)e);
        }

        public static implicit operator Euro(double d)
        {            
            return new Euro(d);
        }

        public static bool operator == (Euro e, Dolar d)
        {
            bool retorno = false;

            if(e == (Euro)d)
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

            if(e == (Euro)p)
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

            if(e1 == e2)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator + (Euro e, Dolar d)
        {
            Euro resultado = new Euro(e.cantidad + ((Euro)d).cantidad);

            return resultado;
        }

        public static Euro operator + (Euro e, Pesos p)
        {
            Euro resultado = new Euro(e.cantidad + ((Euro)p).cantidad);

            return resultado;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro resultado = new Euro(e.cantidad - ((Euro)d).cantidad);

            return resultado;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro resultado = new Euro(e.cantidad - ((Euro)p).cantidad);

            return resultado;
        }
    }
}
