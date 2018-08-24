using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int perfecto = 0;
            int cont1 = 0;            
            int acum = 0;
            int cont2 = 0;
            
            while(cont2 != 4)
            {
                perfecto++;
                for (int i = 1; i < perfecto ; i++)
                {
                    if (perfecto % i == 0)
                    {
                        cont1++;
                        acum += i;                        
                    }
                }
                if (cont1 > 2 && acum == perfecto)
                {
                    cont2++;
                    Console.WriteLine(perfecto);
                    Console.ReadKey();
                }
                cont1 = 0;
                acum = 0;
            }                        
        }
    }
}
