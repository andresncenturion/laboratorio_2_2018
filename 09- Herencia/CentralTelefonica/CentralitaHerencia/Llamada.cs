﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {            
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Duracion: {0} Destino: {1} Origen: {2}", this.duracion, this.nroDestino, this.nroOrigen);
            
            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if(llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            
            return retorno;
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }


}
