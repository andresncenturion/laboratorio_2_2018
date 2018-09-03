using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 0;
            int i;
            int j;
            int cont = 0;
          
            Console.Write("Ingrese un numero: ");
            var = int.Parse(Console.ReadLine());

            for (i = 1; i <= var; i++)
            {
                for (j = 1 ; j <= var; j++)
                {                    
                    if (i % j == 0)
                    {
                        cont++;
                        Console.WriteLine(j);
                    }
                    if (cont == 3)
                    {
                        break;
                    }
                }                
            }       
            Console.ReadKey();
        }
    }
}
