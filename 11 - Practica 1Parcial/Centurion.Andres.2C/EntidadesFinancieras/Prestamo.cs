using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public enum PeriodicidadDePagos
    {
        Mensual, Bimestral, Trimestral
    }

    public enum TipoDePrestamo
    {
        Pesos, Dolares, Todos
    }

    public abstract class Prestamo
    {        
        protected float monto;
        protected DateTime vencimiento;

        public float Monto
        {
            get
            {
                return this.monto;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }            
            set
            {
                if(value >= DateTime.Today)
                {
                    this.vencimiento =  value;
                }
            }
        }        

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }
       
        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            int orden = 0;

            if(p1.vencimiento > p2.Vencimiento)
            {
                orden = 1;
            }
            return orden;
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);        

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Monto: {0}  Vencimiento: {1}", this.Monto, this.Vencimiento);
            return sb.ToString();
        }
    }
}
