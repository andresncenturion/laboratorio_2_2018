using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_170;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo azul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo(50, ConsoleColor.Red);
            string texto = " ";

            azul.Pintar(5, out texto);
            Console.BackgroundColor = azul.GetColor();
            Console.Write(texto);
            Console.ReadKey();
        }
    }
}
