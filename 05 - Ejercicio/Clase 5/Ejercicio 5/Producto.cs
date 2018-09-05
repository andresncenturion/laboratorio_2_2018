using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder retorno = null;
            string retornoString;

            retorno.Append("Codigo de barras: ");
            retorno.Append(p.codigoDeBarra);
            retorno.Append("Marca: ");
            retorno.Append(p.GetMarca());
            retorno.Append("Precio: ");
            retorno.Append(p.GetPrecio());

            retornoString = retorno.ToString();

            return retornoString;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public static bool operator == (Producto p, string marca)
        {
            bool retorno = false;

            if (p.GetMarca() == marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator != (Producto p, string marca)
        {            
            return !(p == marca);
        }

        public static bool operator == (Producto p1, Producto p2)
        {
            bool retorno = false;

            if (p1.GetMarca() == p2.GetMarca() && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator != (Producto p1, Producto p2)
        {
           return !(p1 == p2);
        }
    }
}
