using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 0;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese un numero: ");
            var = int.Parse(Console.ReadLine());
            if (var > 0)
            {
                cuadrado = Math.Pow(var, 2);
                Console.Write("Cuadrado: ");
                Console.WriteLine(cuadrado);
                cubo = Math.Pow(var, 3);
                Console.Write("Cubo: ");
                Console.WriteLine(cubo);
            }
            else
            {
                Console.Write("ERROR. ¡Reingresar numero!");
            }

            Console.ReadKey();
        }
    }
}
