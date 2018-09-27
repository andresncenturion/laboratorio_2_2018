using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincia
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float valorRecaudado = 0;
            float valorTotal = 0;

            foreach (Llamada llamada in listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            valorRecaudado = ((Local)llamada).CostoLlamada;
                            valorTotal += valorRecaudado;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            valorRecaudado = ((Provincial)llamada).CostoLlamada;
                            valorTotal += valorRecaudado;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        valorRecaudado = valorTotal;
                        break;
                }
            }
            return valorRecaudado;
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Razon social: {0}  Ganancia total: {1}  Ganancia local: {2} Ganancia provincial: {3}", this.razonSocial, this.GananciasPorTotal, this.GananciasPorLocal, this.GananciasPorProvincia);
            foreach (Llamada llamada in Llamadas)
            {
                sb.AppendLine(llamada.Mostrar());
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            int orden = -1;
            Llamada aux = new Llamada(0, "", "");

            for (int i = 0; i < Llamadas.Count - 1; i++)
            {
                for (int j = 1; j < Llamadas.Count; j++)
                {
                    orden = Llamadas[i].OrdenarPorDuracion(Llamadas[i], Llamadas[j]);
                    if (orden == 1)
                    {
                        aux = Llamadas[i];
                        Llamadas[i] = Llamadas[j];
                        Llamadas[j] = aux;
                    }
                }                
            }
        }
    }
}
