using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        private int x;
        private int y;

        public int GetX()
        {
            int x;

            x = this.x;
            return x;
        }

        public int GetY()
        {
            int y;

            y = this.y;
            return y;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
