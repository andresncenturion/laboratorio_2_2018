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
                
            }
        }

        public float GananciasPorProvincia
        {
            get
            {

            }
        }

        public float GananciasPorTotal
        {
            get
            {

            }
        }

        public List<Llamada> Llamadas
        {
            get
            {

            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float valorRecaudado;
            float valorTotal = 0;

            foreach (Llamada llamada in listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Local:
                        if (llamada is Local)
                        {
                            valorRecaudado = ((Local)llamada).CostoLlamada;
                            valorTotal += valorRecaudado;
                        }
                        break;
                    case Provincial:
                        if (llamada is Provincial)
                        {
                            valorRecaudado = ((Provincial)llamada).CostoLlamada;
                            valorTotal += valorRecaudado;
                        }
                        break;
                    case Todas:
                        valorRecaudado = valorTotal;
                        break;                        
                }                
            }
            return valorRecaudado;
        }

        public Centralita()
        {

        }

        public Centralita(string nombreEmpresa)
        {

        }

        public string Mostrar()
        {

        }

        public void OrdenarLlamadas()
        {

        }
    }
}
