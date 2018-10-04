using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}  Peso: {1}  Altura: {2}  Posicion: {3}", base.Mostrar(), this.peso, this.altura, this.posicion);

            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            bool valido = false;
            float imc = 0;

            imc = this.peso / (this.altura * this.altura);
            if (imc >= 18.5 && imc <= 25)
            {
                valido = true;
            }

            return valido;
        }

        public override bool ValidarAptitud()
        {
            bool valido = false;

            if(this.Edad <= 40 && this.ValidarEstadoFisico() == true)
            {
                valido = true;
            }

            return valido;
        }
    }
}
