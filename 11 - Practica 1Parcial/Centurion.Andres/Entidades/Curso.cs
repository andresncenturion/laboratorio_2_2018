using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}º{1}.\n", this.anio, this.division);
                return sb.ToString();
            }
        }

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();

            
                sb.AppendFormat("Año y Division: {0}  Profesor: {1}\n", c.AnioDivision, c.profesor.ExponerDatos());

                foreach (Alumno alumno in c.alumnos)
                {
                    sb.AppendFormat("{0}", alumno.ExponerDatos() + "\n");
                }
                      
            return sb.ToString();
        }

        public static bool operator == (Curso c, Alumno a)
        {
            bool retorno = false;

            if(!ReferenceEquals(c, null) && !ReferenceEquals(a, null))
            {
                if (a.AnioDivision == c.AnioDivision)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator != (Curso c, Alumno a)
        {
            return !(c == a);            
        }

        public static Curso operator + (Curso c, Alumno a)
        {            
            if (!ReferenceEquals(c, null) && !ReferenceEquals(a, null))
            {
                if (c == a)
                {
                    c.alumnos.Add(a);
                }
            }
            return c;
        }
    }
}
