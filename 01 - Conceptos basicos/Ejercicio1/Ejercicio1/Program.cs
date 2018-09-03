using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = -1;
            int flagMax = 0;
            int flagMin = 0;
            int length = 5;
            int i;
            int max = int.MinValue;
            int min = int.MaxValue;
            float cont = 0;
            float acum = 0;
            float prom = -1;

            for (i = 0; i < length; i++)
            {
                Console.Write("Ingrese un numero: ");
                var = int.Parse(Console.ReadLine());
                cont++;
                acum += var;
                if (var > max || flagMax == 0)
                {
                    flagMax = 1;
                    max = var;
                }
                if (var < min || flagMin == 0)
                {
                    flagMin = 1;
                    min = var;
                }
            }
            prom = acum / cont;
            Console.Write("Maximo: ");
            Console.WriteLine(max);
            Console.Write("Minimo: ");
            Console.WriteLine(min);
            Console.Write("Promedio: ");
            Console.Write(prom);
            Console.ReadKey();
        }
    }
}
