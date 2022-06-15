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
namespace Presentacion.Empleados
{
    public partial class Empleado : Form
    {
        ClassEmpleados empleados = new ClassEmpleados();
        public Empleado()
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
            
            if (MessageBox.Show("¿Está usted seguro que desea eliminar el empleado selecionado?", "ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (empleados.eliminarEmpleadoId(cedula))
                {
                    MessageBox.Show("Empleado eliminado correctamente", "ELINACION");
                    cargarGrid();
                }
            }

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            string cedula = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString();

            AbrirFormulariosHijos(new MostrarEmpleado(cedula));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string cedula = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString();

            AbrirFormulariosHijos(new EditarEmpleado(cedula));
        }

        private void pbxIngreso_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new RegistroEmpleado());
        }

    

        public void cargarGrid()
        {
            gunaDataGridView1.Refresh();
            gunaDataGridView1.DataSource = empleados.mostrarTodosEmpleados();
       
        }

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            string busqueda="%"+txtCedula.Text+"%";
            gunaDataGridView1.DataSource=null;
            gunaDataGridView1.DataSource=empleados.buscarEmpleadoCedula(busqueda);

        }

       
    }
}
