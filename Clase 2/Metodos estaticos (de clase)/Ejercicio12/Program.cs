using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = false;
            bool entero = false;
            int acum = 0;            

            do
            {
                do
                {
                    Console.Write("Ingrese un numero entero: ");
                    if (int.TryParse(Console.ReadLine(), out int aux))
                    {
                        entero = true;
                        acum += aux;
                    }
                    else
                    {
                        entero = false;
                        Console.WriteLine("El dato ingresado no es valido. Ingrese nuevamente");
                    }
                } while (!entero);
                Console.Write("¿Continuar? (S/N): ");                
                continuar = ValidarRespuesta.ValidaS_N(char.Parse(Console.ReadLine()));                                
            } while (continuar);  
        }
    }
}
