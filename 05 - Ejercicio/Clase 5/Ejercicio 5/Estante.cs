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
            productos = new Producto[capacidad];
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
            StringBuilder retorno = null;
            string retornoString;

            retorno.Append("Ubicacion estante: ");
            retorno.Append(e.ubicacionEstante);

            for (int i = 0; i < e.productos.Length ; i++)
            {
                retorno.Append(Producto.MostrarProducto(e.productos[i]));
            }
            
            retornoString = retorno.ToString();

            return retornoString;
        }

        public static bool operator == (Estante e, Producto p)
        {
            bool retorno = false;

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (p == e.productos[i])
                {
                    retorno = true;
                    break;
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

            for (int i = 0; i < e.productos.Length; i++)
            {                
                if (e.productos[i] is null)
                {
                    for (int j = 0; j < e.productos.Length; j++)
                    {
                        if (e.productos[j] == p)
                        {
                            flag = 1;
                        }
                    }
                    if (flag != 1)
                    {
                        e.productos[i] = p;
                        break;
                    }
                }
            }            
            return retorno;
        }

        public static Estante operator - (Estante e, Producto p)
        {
            Estante auxiliar = null;

            if (e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    auxiliar.productos[i] = e.productos[i];
                    auxiliar.ubicacionEstante = e.ubicacionEstante;
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;                        
                    }
                }
            }
            return auxiliar;
        }

    }
}
