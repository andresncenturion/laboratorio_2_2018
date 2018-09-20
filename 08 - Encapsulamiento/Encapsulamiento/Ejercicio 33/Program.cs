using System;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            public List<string> sieteMares = new List<string>();
            // Agrego items de a uno
            sieteMares.Add("Golfo Pérsico");
            sieteMares.Add("Negro");
            sieteMares.Add("Caspio");
            sieteMares.Add("Rojo");
            sieteMares.Add("Mediterráneo");
            sieteMares.Add("Adriático");
            sieteMares.Add("de Arabia");
            // Itero la lista y muestro los 7 mares
            Console.WriteLine("Los 7 mares:");
            for (int i = 0; i < sieteMares.Count; i++)
            {
                Console.Write(sieteMares[i] + ", ");
            }
            // Freno y luego limpio la pantalla
            Console.ReadKey();
            Console.Clear();
        }
    }
}
