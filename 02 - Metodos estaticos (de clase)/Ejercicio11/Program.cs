using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            int min = -100;
            int max = 100;
            int valor = int.MinValue;
            int valorMin = int.MaxValue;
            int valorMax = int.MinValue;
            bool valido = false;
            float cont = 0;
            float acum = 0;
            int flagMax = 0;
            int flagMin = 0;
            float prom = -1;

            for (int i = 0; i < length; i++)
            {                
                do
                {
                    Console.Write("Ingrese un numero entero entre -100 y 100: ");
                    if (int.TryParse(Console.ReadLine(), out int conversion))
                    {
                        valor = conversion;
                        valido = Validacion.Validar(valor, min, max);
                        if (!valido)
                        {
                            Console.WriteLine("El dato ingresado no es valido. Intente nuevamente");
                        }
                        else
                        {
                            Console.WriteLine("Numero ingresado.");
                        }
                    }
                    else
                    {
                        valido = false;
                        Console.WriteLine("El dato ingresado no es valido. Intente nuevamente");
                    }
                } while (!valido);                               
                if (valido)
                {
                    cont++;
                    acum += valor;
                    if (valor > valorMax || flagMax == 0)
                    {
                        flagMax = 1;
                        valorMax = valor;
                    }
                    if (valor < valorMin || flagMin == 0)
                    {
                        flagMin = 1;
                        valorMin = valor;
                    }
                }
            }            
            prom = acum / cont;
            Console.Write("Minimo: ");
            Console.WriteLine(valorMin);
            Console.Write("Maximo: ");
            Console.WriteLine(valorMax);
            Console.Write("Promedio: ");
            Console.WriteLine(prom);
            Console.ReadKey();
        }
    }
}
