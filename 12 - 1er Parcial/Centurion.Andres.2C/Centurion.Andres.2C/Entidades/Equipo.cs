using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud() == true)
                {
                    this.directorTecnico = value;
                }                
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--- DATOS DEL EQUIPO ---");
            sb.AppendLine("Nombre: " + e.nombre);
            if (ReferenceEquals(e.directorTecnico, null))
            {
                sb.AppendLine("Director Tecnico: Sin DT asignado");
            }
            else
            {
                sb.AppendLine("Director Tecnico: " + e.directorTecnico.Mostrar());                
            }                        

            foreach (Jugador j in e.jugadores)
            {
                sb.AppendLine(j.Mostrar());
            }

            return sb.ToString();
        }

        public static bool operator == (Equipo e, Jugador j)
        {
            bool existe = false;

            if(e.jugadores.Contains(j))
            {
                existe = true;
            }

            return existe;
        }

        public static bool operator != (Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator + (Equipo e, Jugador j)
        {
            if(e.jugadores.Count <= cantidadMaximaJugadores)
            {
                if (!e.jugadores.Contains(j) && j.ValidarAptitud() == true)
                {
                    e.jugadores.Add(j);
                }
            }
            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool valido = false;
            int arquero = 0;
            int central = 0;
            int defensor = 0;
            int delantero = 0;

            if(!ReferenceEquals(e.directorTecnico, null) && e.jugadores.Count == cantidadMaximaJugadores)
            {
                foreach(Jugador j in e.jugadores)
                {
                    switch(j.Posicion)
                    {
                        case Posicion.Arquero:
                            arquero++;
                            break;
                        case Posicion.Central:
                            central++;
                            break;
                        case Posicion.Defensor:
                            defensor++;
                            break;
                        case Posicion.Delantero:
                            delantero++;
                            break;
                    }
                }

                if(arquero == 1 && central != 0 && defensor != 0 && delantero != 0)
                {
                    valido = true;
                }
            }
            return valido;
        }
    }
}
