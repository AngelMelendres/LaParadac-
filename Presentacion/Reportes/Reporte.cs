using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;

namespace Presentacion.Reportes
{
    public partial class Reporte : Form
    {
        ClassReportes reportes= new ClassReportes();
        public Reporte()
        {
            InitializeComponent();
            mostrarCantidades();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            totalEmpleados objTEmpleados = new totalEmpleados();
            objTEmpleados.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            totalClientes objTClientes = new totalClientes();
            objTClientes.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            totalProductos oblTProductos = new totalProductos();
            oblTProductos.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            TotalVentas objTVentas = new TotalVentas();
            objTVentas.Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            clientesRiobamba objRiobamba = new clientesRiobamba();
            objRiobamba.Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            TotalAlmuerzo objAlmuerzo = new TotalAlmuerzo();
            objAlmuerzo.Show();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            mostrarCantidades();
        }

        public void mostrarCantidades()
        {
            lblNumClientes.Text = reportes.getCantidadClientes().ToString();
            lblnumEmpleados.Text = reportes.getCantidadEmpleados().ToString();
            lblNumPlatos.Text = reportes.getCantidadProductos().ToString();
            lblNumVentas.Text = reportes.getCantidadFacturas().ToString();
            lblNumClientesR.Text = reportes.getCantidadClientes().ToString();
            lblNumPlatillosA.Text = reportes.getCantidadClientes().ToString();
        }
    }
}
