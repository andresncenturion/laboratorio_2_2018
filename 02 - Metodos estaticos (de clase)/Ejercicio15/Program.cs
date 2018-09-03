using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.MinValue;
            double num2 = double.MinValue;           
            char op = ' ';
            char seguir = 's';
            int flagSeguir = 0;

            while (seguir == 's')
            {
                Console.WriteLine("--- CALCULADORA ---\n");
                Console.Write("Ingrese primer numero: ");
                num1 = Calculadora.ValidParse();
                Console.Write("Ingrese segundo numero: ");
                num2 = Calculadora.ValidParse();
                op = Calculadora.MostrarMenu();
                Calculadora.Mostrar(Calculadora.Calcular(num1, num2, op));                
                Console.Write("¿Desea realizar otra operacion? (s/n): ");
                seguir = char.Parse(Console.ReadLine());        
            }
        }
    }
}
