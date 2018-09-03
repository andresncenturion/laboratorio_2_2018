using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador prueba = new Sumador();
            Sumador prueba2 = new Sumador();
            long resultado;
            string mensaje;
            bool andaPipe;

            prueba.Suma(5);            
            prueba.Suma();
            resultado = prueba.Sumar(14, 15);
            mensaje = prueba.Sumar("putos", "todos");

            Console.WriteLine(resultado);
            Console.WriteLine(mensaje);
            Console.ReadKey();
            
            
            resultado = prueba + prueba2;
            andaPipe = prueba | prueba2;
        }
    }
}
