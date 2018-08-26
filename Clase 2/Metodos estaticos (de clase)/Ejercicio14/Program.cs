using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {            
            int flag = 0;
            double area = -1;

            Console.WriteLine("--- CALCULO DE AREA ---");
            Console.WriteLine();
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Rectangulo");
            Console.WriteLine("3. Circulo");
            Console.Write("Seleccione figura: ");
            while (flag == 0)
            {
                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    flag = 1;
                    switch (opcion)
                    {
                        case 1:
                            do
                            {
                                Console.Write("Lado: ");
                                if (double.TryParse(Console.ReadLine(),out double lado))
                                {
                                    area = CalculoDeArea.CalcularCuadrado(lado);                                  
                                }
                                else
                                {
                                    Console.WriteLine("El dato ingresado no es valido. Intente nuevamente.");
                                }
                            } while (area < 0);
                            break;
                        case 2:
                            do
                            {
                                Console.Write("Base: ");
                                if (double.TryParse(Console.ReadLine(), out double trianguloBase))
                                {
                                    Console.Write("Altura: ");
                                    if (double.TryParse(Console.ReadLine(), out double trianguloAltura))
                                    {
                                        area = CalculoDeArea.CalcularTriangulo(trianguloBase, trianguloAltura);
                                    }
                                    else
                                    {
                                        Console.WriteLine("El dato ingresado no es valido. Intente nuevamente.");
                                    }
                                    while (trianguloAltura < 0) ;
                                }
                                else
                                {
                                    Console.WriteLine("El dato ingresado no es valido. Intente nuevamente.");
                                }
                            } while (area < 0);                            
                            break;
                        case 3:
                            do
                            {
                                Console.Write("Radio: ");
                                if (double.TryParse(Console.ReadLine(), out double radio))
                                {
                                    area = CalculoDeArea.CalcularCirculo(radio);
                                }
                                else
                                {
                                    Console.WriteLine("El dato ingresado no es valido. Intente nuevamente.");
                                }
                            } while (area < 0);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("El dato ingresado no es valido. Intente nuevamente.");
                }
            }
            Console.Write("Area calculada: " + area);
            Console.ReadKey();
        }
    }
}
