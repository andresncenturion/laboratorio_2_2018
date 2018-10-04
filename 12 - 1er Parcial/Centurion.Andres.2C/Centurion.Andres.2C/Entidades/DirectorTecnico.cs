using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}  Años Experiencia: {1}", base.Mostrar(), this.añosExperiencia);            

            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            bool valido = false;

            if(this.Edad < 65 && this.añosExperiencia >= 2)
            {
                valido = true;
            }

            return valido;
        }
    }
}
