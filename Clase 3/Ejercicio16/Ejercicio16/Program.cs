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

            Alumno1.nombre = Console.ReadLine();
            Alumno1.apellido = Console.ReadLine();
            Alumno1.legajo = Console.ReadLine();

            Alumno2.nombre = Console.ReadLine();
            Alumno2.apellido = Console.ReadLine();
            Alumno2.legajo = Console.ReadLine();

            Alumno3.nombre = Console.ReadLine();
            Alumno3.apellido = Console.ReadLine();
            Alumno3.legajo = Console.ReadLine();            

            Alumno1.Estudiar(4, 5);
            Alumno2.Estudiar(7, 6);
            Alumno3.Estudiar(9, 7);

            Alumno1.CalcularFinal();
            Alumno2.CalcularFinal();
            Alumno3.CalcularFinal();

            Alumno1.Mostrar();
            Alumno2.Mostrar();
            Alumno3.Mostrar();
        }
    }
}
