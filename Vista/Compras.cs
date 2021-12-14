using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo; 

namespace Vista
{
    public partial class Compras : Form
    {
        private double total;

        public string getPago
        {
            get
            {
                return tPago.Text;
            }
        }

        public string getCambio
        {
            get
            {
                return tCambio.Text;
            }
        }

        public Compras(double total)
        {
            this.total = total;
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            tTotal.Text = "$" + this.total;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tPago_Enter(object sender, EventArgs e)
        {
            tPago.Text = "";
        }

        private void tPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (tPago.Text != "")
                {
                    try
                    {
                        double total = Convert.ToDouble(tTotal.Text.Substring(1));
                        double pago = Convert.ToDouble(tPago.Text);
                        if (pago >= total)
                        {
                            double cambio = pago - total;
                            cambio = Math.Round(cambio, 2);
                            tCambio.Text = "$" + cambio;
                            tPago.Text = "$" + tPago.Text;
                            bCobrar.Enabled = true;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("El Pago es Menor al Monto Total a Pagar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            
                        }
                    }
                    catch (Exception error)
                    {
                        DialogResult result1 = MessageBox.Show("Aviso", "Escriba un Monto Valido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    tPago.Text = "$0.00";
                }
            }
        }

        private void bCobrar_Click(object sender, EventArgs e)
        {
            float pago = float.Parse(tPago.Text.Substring(1));
            float total = float.Parse(tTotal.Text.Substring(1));
            if (tPago.Text != "$0.00" && pago >= total)
            {
                MessageBox.Show("El Cobro Fué Realizado Exitosamente");
            }
            else if (total > pago)
            {
                MessageBox.Show("El Total Aún no se Liquida por Completo");
            }
        }

        private void tTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            tPago.Text = "$0.00";
        }
    }
}
