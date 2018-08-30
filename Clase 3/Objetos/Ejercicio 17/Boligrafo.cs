using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_170
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color = new ConsoleColor();
        private short tinta;

        public Boligrafo (short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            ConsoleColor color;

            color = this.color;

            return (color);
        }

        public short GetTinta()
        {
            short tinta;

            tinta = this.tinta;
            return (tinta);
        }

        public bool Pintar (int gasto, out string dibujo)
        {
            bool retorno = false;
            short nuevaTinta = -1;

            dibujo = " ";
            nuevaTinta = (short)(this.tinta - gasto);
            if (nuevaTinta > 0)
            {
                retorno = true;
                this.SetTinta(nuevaTinta);

                for (int i = 0; i < gasto; i++)
                {
                    dibujo += '*';
                }
            }
            return retorno;
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        private void SetTinta(short tinta)
        {
            int flag = 0;

            while (flag == 0)
            {
                if (tinta >= 0 && tinta <= cantidadTintaMaxima)
                {
                    flag = 1;
                    this.tinta = tinta;
                }
                else
                {
                    Console.Write("El valor ingresado no es valido. Intente nuevamente.");
                    tinta = short.Parse(Console.ReadLine());
                }
            }            
        }
    }
}
