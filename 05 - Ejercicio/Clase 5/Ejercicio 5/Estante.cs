using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion):this(capacidad)
        {            
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder retorno = new StringBuilder();
            string retornoString;

            retorno.AppendLine("Ubicacion estante: " + e.ubicacionEstante);
            retorno.AppendLine("Capacidad: " + e.productos.Length);
            retorno.AppendLine("Productos: ");
            foreach (Producto p in e.productos)
            {
                retorno.Append(Producto.MostrarProducto(p));
            }
            
            retornoString = retorno.ToString();

            return retornoString;
        }

        public static bool operator == (Estante e, Producto p)
        {
            bool retorno = false;

            for (int i = 0 ; i < e.productos.Length; i++)
            {
                if (!object.ReferenceEquals(e.productos[i], null))
                {
                    if (p == e.productos[i])
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator != (Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator + (Estante e, Producto p)
        {
            bool retorno = false;
            int flag = 0;

            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (object.ReferenceEquals(e.productos[i], null))
                    {
                        e.productos[i] = p;
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static Estante operator - (Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if(!object.ReferenceEquals(e.productos[i], null))
                {
                    if (p == e.productos[i])
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            }
            return e;
        }

    }
}
