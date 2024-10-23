using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Vehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AutoNafta miNaftero;
        AutoHibrido miHibrido;

        double auxTipo = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearNaftero_Click(object sender, EventArgs e)
        {
            //public AutoNafta(string Marca, string Modelo, double CapacidadTanque, double ConsumoKmPorLitro) 

            miNaftero = new AutoNafta(txtMarca.Text, txtModelo.Text, Convert.ToDouble(txtTanque.Text), Convert.ToDouble(txtConsumoNafta.Text));

            auxTipo = 1;

            RefrescarDatos(auxTipo);
        }

        private void RefrescarDatos(double auxTipo)
        {
            if (auxTipo == 1)
            {
                lblCombustible.Text = miNaftero.CapacidadActualTanque.ToString();
                lblKmsRecorridos.Text = Convert.ToString(miNaftero.KmRecorridos);
            } else if (auxTipo == 2)
            {
                lblCombustible.Text = Convert.ToString(miHibrido.CapacidadActualTanque);
                lblKmsRecorridos.Text = Convert.ToString(miHibrido.KmRecorridos);
            }
            
        }

        private void btnCrearHibrido_Click(object sender, EventArgs e)
        {
            miHibrido = new AutoHibrido(txtMarca.Text, txtModelo.Text, Convert.ToDouble(txtTanque.Text), Convert.ToDouble(txtConsumoNafta.Text), Convert.ToDouble(txtConsumoBateria.Text));

            auxTipo = 2;

            RefrescarDatos(auxTipo);
        }

        private void btnViajar_Click(object sender, EventArgs e)
        {
            if (auxTipo == 1)
            {
                string auxMensaje = miNaftero.SimularViaje(Convert.ToDouble(txtKms.Text));
                MessageBox.Show(auxMensaje, "Simular Viaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos(auxTipo);
            } else if (auxTipo == 2)
            {
                string auxMensaje = miHibrido.SimularViaje(Convert.ToDouble(txtKms.Text));
                MessageBox.Show(auxMensaje, "Simular Viaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarDatos(auxTipo);
            }
        }
    }
}
