using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres = 0;

        public PrestamoPesos(float monto, DateTime vencimiento, float interes) : base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) : this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {

        }

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        private float CalcularInteres()
        {
            float totalPrestamo;

            totalPrestamo = this.monto * (1 + porcentajeInteres / 100);

            return totalPrestamo;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            this.monto += (float)((this.porcentajeInteres/100 + 1.25) * (nuevoVencimiento - this.vencimiento).TotalDays);
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}", base.Mostrar());
            sb.AppendFormat("Porcentaje de interes: {0}", this.porcentajeInteres);
            sb.AppendFormat("Interes: ", this.Interes);
            return sb.ToString();
        }
    }
}
