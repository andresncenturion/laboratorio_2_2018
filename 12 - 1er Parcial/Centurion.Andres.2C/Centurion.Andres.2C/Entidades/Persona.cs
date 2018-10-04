using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Posicion
    {
        Arquero, Defensor, Central, Delantero
    }

    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Apellido: {0}  Nombre: {1}  Edad: {2}  DNI: {3}", this.apellido, this.nombre, this.edad, this.dni);

            return sb.ToString();
        }

        public abstract bool ValidarAptitud();        
    }
}
