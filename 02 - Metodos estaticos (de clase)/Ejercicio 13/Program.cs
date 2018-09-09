using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {        
        static void Main(string[] args)
        {
            double dec;
            string bin;

            Console.Write("Ingrese un numero decimal: ");
            dec = double.Parse(Console.ReadLine());
            bin = Conversor.DecimalBinario(dec);
            Console.WriteLine("El numero {0} en binario es {1}", dec, bin);
            Console.ReadKey();

            Console.Write("Ingrese un numero binario: ");
            bin = Console.ReadLine();
            dec = Conversor.BinarioDecimal(bin);
            Console.Write("El numero {0} en decimal es {1}", bin, dec);
            Console.ReadKey();
        }
    }
}
