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

namespace Presentacion.Clientes
{

    public partial class Cliente : Form
    {
        ClassClientes clientes = new ClassClientes();

        public Cliente()
        {
            InitializeComponent();
            cargarGrid();
            txtCedula.Text = "";
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cedula = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Está usted seguro que desea eliminar el cliente selecionado?", "ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clientes.eliminarclienteId(cedula))
                {
                    MessageBox.Show("Cliente eliminado correctamente", "ELINACION");
                    cargarGrid();
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            string cedula = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString();

            AbrirFormulariosHijos(new MostrarCliente(cedula));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string cedula = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString();

            AbrirFormulariosHijos(new EditarCliente(cedula));
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new AgregarCliente());
        }
      

        public void cargarGrid()
        {
            gunaDataGridView1.Refresh();
            gunaDataGridView1.DataSource = clientes.mostrarTodosClientes();

        }

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            string busqueda = "%" + txtCedula.Text + "%";
            gunaDataGridView1.DataSource = null;
            gunaDataGridView1.DataSource = clientes.buscarclienteCedula(busqueda);

        }
    }
}
