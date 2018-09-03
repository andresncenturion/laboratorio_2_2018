using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {        
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
        }

        public float Area()
        {
            float area;            
            
            Math.Abs()

            return area;
        }

        public float Perimetro()
        {
            float perimetro;
            float baseRectangulo;
            float altura;

            baseRectangulo = Math.Abs(vertice1, vertice3);
            altura = Math.Abs(vertice1, vertice2);
            perimetro = altura * 2 + baseRectangulo * 2;

            return perimetro;
        }
    }
}
