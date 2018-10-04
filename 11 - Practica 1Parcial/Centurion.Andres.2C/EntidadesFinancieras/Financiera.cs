using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }

        public float InteresesEnDolares
        {
            get
            {
                return this.CalcularInteresGanados(TipoDePrestamo.Dolares);
            }
        }

        public float InteresesEnPesos
        {
            get
            {
                return this.CalcularInteresGanados(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return this.CalcularInteresGanados(TipoDePrestamo.Todos);
            }
        }

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        private float CalcularInteresGanados(TipoDePrestamo tipoPrestamo)
        {
            float intereses = 0;            

            foreach (Prestamo prestamo in ListaDePrestamos)
            {
                switch(tipoPrestamo)
                {
                    case TipoDePrestamo.Dolares:
                        if (prestamo is PrestamoDolar)
                        {
                            intereses += ((PrestamoDolar)prestamo).Interes;
                        }                        
                        break;
                    case TipoDePrestamo.Pesos:
                        if (prestamo is PrestamoPesos)
                        {
                            intereses += ((PrestamoPesos)prestamo).Interes;
                        }
                        break;
                    case TipoDePrestamo.Todos:
                        {
                            intereses += ((PrestamoDolar)prestamo).Interes + ((PrestamoPesos)prestamo).Interes;
                        }
                        break;
                }
            }
            return intereses;
        }

        public string Mostrar()
        {
           
        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            

            sb.AppendFormat("Razon social: {0}", financiera.razonSocial);
            foreach (Prestamo prestamo in financiera.listaDePrestamos)
            {
                if(prestamo is PrestamoDolar)
                {

                }
            }        
            sb.AppendFormat("Intereses ganados: {1}", )
        }
    }
}
