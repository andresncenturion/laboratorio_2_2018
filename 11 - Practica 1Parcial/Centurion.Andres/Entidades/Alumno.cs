using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public string AnioDivision
        {
            get
            {
                return this.anio + "º" + this.division;
            }
        }

        public Alumno (string nombre, string apellido, string documento, short anio, Divisiones division) : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {            
            return base.ExponerDatos();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;

            if(doc.ElementAt(2) == '-' && doc.ElementAt(7) == '-' && doc.Length == 9)
            {
                retorno = true;
                doc.TrimStart('-', '-');
                foreach (char numero in doc)
                {
                    if(!int.TryParse(numero.ToString(), out int num))
                    {
                        retorno = false;
                    }
                }
            }         
            return retorno;
        }
    }
}
