using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio16
{
    public class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            this._notaFinal = -1;
            Random numero = new Random();

            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                this._notaFinal = numero.Next(4, 10);
            }
        }

        public void Estudiar(byte NotaUno, byte NotaDos)
        {
            this._nota1 = NotaUno;
            this._nota2 = NotaDos;
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder("Nota final: ");

            if (this._notaFinal != -1)
            {
                mensaje.Append(this._notaFinal);
            }
            else
            {
                mensaje.Append("Alumno desaprobado");
            }            
            return mensaje.ToString();
        }

        public Alumno()
        {
           
        }
    }
}
