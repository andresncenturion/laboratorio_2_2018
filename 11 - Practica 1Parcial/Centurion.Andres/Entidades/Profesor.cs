using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad
        {
            get
            {                                
                return (int)(DateTime.Now - fechaIngreso).TotalDays;
            }
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}. Fecha de ingreso: {1}", base.ExponerDatos(), this.fechaIngreso);
            return base.ExponerDatos();
        }

        public Profesor(string nombre, string apellido, string documento) : this(nombre, apellido, documento, DateTime.Now)
        {
            
        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : base(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            return true;
        }
    }
}
