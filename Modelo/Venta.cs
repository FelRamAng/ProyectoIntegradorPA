using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Venta
    {
        private int idVenta;
        private int idEmpleado;
        private string fecha;
        private string hora;
        private float totalVta;
        private float totalPago;

        public Venta()
        {

        }
        public Venta(int idVenta, int idEmpleado, string fecha, string hora, float totalVta, float totalPago)
        {
            this.idVenta = idVenta;
            this.idEmpleado = idEmpleado;
            this.fecha = fecha;
            this.hora = hora;
            this.totalVta = totalVta;
            this.totalPago = totalPago;
        }

        public void setIdVenta(int idVenta)
        {
            this.idVenta = idVenta;
        }

        public int getIdVenta()
        {
            return idVenta;
        }

        public void setIdEmpleado(int idEmpleado)
        {
            this.idEmpleado = idEmpleado;
        }

        public int getIdEmpleado()
        {
            return idEmpleado;
        }

        public void setFecha(string fecha)
        {
            this.fecha = fecha;
        }

        public string getFecha()
        {
            return fecha;
        }

        public void setHora(string hora)
        {
            this.hora = hora;
        }

        public string getHora()
        {
            return hora;
        }

        public void setTotalVta(float totalVta)
        {
            this.totalVta = totalVta;
        }

        public float getTotalVta()
        {
            return totalVta;
        }

        public void setTotalPago(float totalPago)
        {
            this.totalPago = totalPago;
        }

        public float getTotalPago()
        {
            return totalPago;
        }

        public override string ToString()
        {
            return "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" +
            "ID Venta: " + idVenta +
            "ID Empleado: " + idEmpleado +
            "Fecha: " + fecha +
            "Hora: " + hora +
            "Total Venta: $" + totalVta +
            "Total Pago: $" + totalPago;
        }
    }
}
