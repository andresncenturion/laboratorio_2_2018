using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar verdes = new Dolar(100);
            Pesos violetas = new Pesos(1755);

            verdes = verdes + violetas;
            Console.WriteLine("Total de dolares: " + verdes);
            Console.ReadKey();
        }
    }
}
