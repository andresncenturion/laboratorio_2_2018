using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado (double lado)
        {
            double area = -1;

            if (lado > 0)
            {
                area = lado * lado;
            }
            return area;
        }

        public static double CalcularTriangulo (double trianguloBase, double trianguloAltura)
        {
            double area = -1;

            if (trianguloBase > 0 && trianguloAltura > 0)
            {
                area = trianguloBase * trianguloAltura / 2;
            }
            return area;
        }

        public static double CalcularCirculo (double radio)
        {
            double area = -1;

            if (radio > 0)
            {
                area = Math.PI * Math.Pow(radio, 2);
            }
            return area;
        }
    }
}
