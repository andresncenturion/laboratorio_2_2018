using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        private Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float valorLlamada;
            float costoAux;

            switch(franjaHoraria)
            {
                case Franja.Franja_1:
                    costoAux = 0.99F;
                    break;
                case Franja.Franja_2:
                    costoAux = 1.25F;
                    break;
                case Franja.Franja_3:
                    costoAux = 0.66F;
                    break;
                default:
                    costoAux = 0;
                    break;
            }
            valorLlamada = this.duracion * costoAux;
            return valorLlamada;
        }

        public string Mostrar()
        {

        }
    }
}
