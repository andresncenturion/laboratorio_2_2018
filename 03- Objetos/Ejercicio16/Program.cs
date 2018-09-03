using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno Alumno1 = new Alumno();
            Alumno Alumno2 = new Alumno();
            Alumno Alumno3 = new Alumno();

            Console.WriteLine("ALUMNO 1");
            Console.Write("Nombre: ");
            Alumno1.nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            Alumno1.apellido = Console.ReadLine();
            Console.Write("Legajo: ");
            Alumno1.legajo = int.Parse(Console.ReadLine());

            Console.WriteLine("ALUMNO 2");
            Console.Write("Nombre: ");
            Alumno2.nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            Alumno2.apellido = Console.ReadLine();
            Console.Write("Legajo: ");
            Alumno2.legajo = int.Parse(Console.ReadLine());

            Console.WriteLine("ALUMNO 3");
            Console.Write("Nombre: ");
            Alumno3.nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            Alumno3.apellido = Console.ReadLine();
            Console.Write("Legajo: ");
            Alumno3.legajo = int.Parse(Console.ReadLine());

            Alumno1.Estudiar(4, 5);
            Alumno2.Estudiar(7, 6);
            Alumno3.Estudiar(9, 7);

            Alumno1.CalcularFinal();
            Alumno2.CalcularFinal();
            Alumno3.CalcularFinal();

            Console.WriteLine(Alumno1.Mostrar());
            Console.WriteLine(Alumno2.Mostrar());
            Console.WriteLine(Alumno3.Mostrar());
            Console.ReadKey();
        }
    }
}
