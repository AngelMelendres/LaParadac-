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

namespace Presentacion.Platos
{
    public partial class Platillos : Form
    {
        ClassPlatillos platillos= new ClassPlatillos();
        public Platillos()
        {
            InitializeComponent();
            cargarGrid();
            txtNombre.Text = "";
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

        public void cargarGrid()
        {
            gunaDataGridView1.Refresh();
            gunaDataGridView1.DataSource = platillos.mostrarTodosPlatillos();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gunaDataGridView1.CurrentRow.Cells[0].Value.ToString());

            if (MessageBox.Show("¿Está usted seguro que desea eliminar el Platillo selecionado?", "ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (platillos.eliminarPlatilloId(id))
                {
                    MessageBox.Show("Platillo eliminado correctamente", "ELINACION");
                    cargarGrid();
                }
            }
        }

        private void pbxAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new AgregarPlato());
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int idPlatillo = int.Parse(gunaDataGridView1.CurrentRow.Cells[0].Value.ToString());

            AbrirFormulariosHijos(new MostrarPlatillo(idPlatillo));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idPlatillo = int.Parse(gunaDataGridView1.CurrentRow.Cells[0].Value.ToString());

            AbrirFormulariosHijos(new EditarPlato(idPlatillo));
        }

        private void gunaDataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
            string busqueda = "%" + txtNombre.Text + "%";
            gunaDataGridView1.DataSource = null;
            gunaDataGridView1.DataSource = platillos.buscarPlatilloNombre(busqueda);

            
        }

        public void mostrarGrid2()
        {
         
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            string busqueda = "%" + txtNombre + "%";
            gunaDataGridView1.DataSource = null;
            gunaDataGridView1.DataSource = platillos.buscarPlatilloNombre(busqueda);
        }
    }
}
