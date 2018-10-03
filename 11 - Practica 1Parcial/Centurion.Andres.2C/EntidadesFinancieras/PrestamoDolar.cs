using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        protected PeriodicidadDePagos periodicidad;

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad) : base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad) : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {

        }

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }

        private float CalcularInteres()
        {
            double totalPrestamo = -1;

            switch(this.periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    totalPrestamo = this.monto * 1.25;
                    break;
                case PeriodicidadDePagos.Bimestral:
                    totalPrestamo = this.monto * 1.35;
                    break;
                case PeriodicidadDePagos.Trimestral:
                    totalPrestamo = this.monto * 1.4;
                    break;
            }
            return (float)totalPrestamo;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            this.monto += (float)(2.5 * ((nuevoVencimiento - this.vencimiento).TotalDays));
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}", base.Mostrar());
            sb.AppendFormat("Periodicidad de pago: {0}", this.periodicidad);
            sb.AppendFormat("Interes: ", this.Interes);
            return sb.ToString();
        }
    }
}
