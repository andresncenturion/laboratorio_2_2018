using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class Calculadora
    {
        public static double Calcular (double num1, double num2, char op)
        {
            double resultado = double.MinValue;

            switch (op)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (Calculadora.Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. No se puede dividir por 0.");
                        Console.ReadKey();
                    }
                    break;
            }
            return resultado;
        }

        private static bool Validar (double num)
        {
            bool retorno = false;

            if (num != 0)
            {
                retorno = true;
            }
            return retorno;
        }

        public static void Mostrar (double resultado)
        {
            Console.WriteLine("Resultado de la operacion: "+resultado);           
        }

        public static double ValidParse ()
        {
            double num = double.MinValue;
            int flag = 0;

            while (flag == 0)
            {
                if (double.TryParse(Console.ReadLine(), out num))
                {
                    flag = 1;
                }
                else
                {
                    Console.WriteLine("El dato ingresado no es valido. Intente nuevamente.");
                }
            }
            return num;
        }

        public static char MostrarMenu ()
        {
            char opcion = ' ';
            int flag = 0;

            while (flag == 0)
            {
                Console.WriteLine("+: Suma");
                Console.WriteLine("-: Resta");
                Console.WriteLine("*: Multiplicacion");
                Console.WriteLine("/: Division");
                Console.Write("Seleccione operacion deseada: ");
                if (char.TryParse(Console.ReadLine(), out opcion))
                {
                    if (opcion == '+' | opcion == '-' | opcion == '/' | opcion == '*')
                    {
                        flag = 1;
                    }
                }
                else
                {
                    Console.WriteLine("La opcion ingresada no es valida. Intente nuevamente.");
                }
            }
            return opcion;
        }
    }
}
