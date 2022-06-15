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

namespace Presentacion.Ventas
{
    public partial class ListadoVentas : Form
    {
        ClassVentas ventas;
        public ListadoVentas()
        {
            InitializeComponent();
            ventas= new ClassVentas();
            cargarGrid();
        }
        //Abrir formularios hijos en panel contenedor

        private Form formularioActivo = null;
        private void AbrirFormulariosHijos(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlFondo.Controls.Add(formularioHijo);
            pnlFondo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void pnlFondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Vender());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new ListadoVentas());
        }

        private void txtCedula_KeyUp(object sender, KeyEventArgs e)
        {
            string busqueda="%"+txtCedula.Text+"%";
            gunaDataGridView1.DataSource=null;
            gunaDataGridView1.DataSource=ventas.buscarFacturaCedula(busqueda);
        }

        public void cargarGrid()
        {
            gunaDataGridView1.Refresh();
            gunaDataGridView1.DataSource = ventas.mostrarTodosFacturas();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int numFactura = int.Parse(gunaDataGridView1.CurrentRow.Cells[0].Value.ToString());
            BuscarFactura fact= new BuscarFactura(numFactura);
            fact.Show();
        }
    }
}
