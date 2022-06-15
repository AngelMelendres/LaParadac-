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
    public partial class EditarEmpleado : Form
    {
        ClassEmpleados empleados = new ClassEmpleados();
        public string cedula;
        public EditarEmpleado(string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            mostrarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            object[] empleado = new object[8];
            empleado[0] = txtCedula.Text.ToString();
            empleado[1] = txtNombre.Text.ToString();
            empleado[2] = txtApellido.Text.ToString();
            empleado[3] = txtEdad.Text.ToString();
            empleado[4] = txtDireccion.Text.ToString();
            empleado[5] = txtCorreo.Text.ToString();
            empleado[6] = cbxCargo.Text.ToString();
            empleado[7] = txtTelefono.Text.ToString();

            if (empleados.editarEmpleadoId(empleado,cedula))
            {
                MessageBox.Show("Se ha Actualizado correctamente", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        public void mostrarDatos()
        {

            object[] empleado = new object[8];
            empleado = empleados.mostrarEmpleadoId(cedula);
            txtCedula.Text = empleado[0].ToString();
            txtNombre.Text = empleado[1].ToString();
            txtApellido.Text = empleado[2].ToString();
            txtEdad.Text = empleado[3].ToString();
            txtDireccion.Text = empleado[4].ToString();
            txtCorreo.Text = empleado[5].ToString();
            cbxCargo.Text = empleado[6].ToString();
            txtTelefono.Text = empleado[7].ToString();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {
            mostrarDatos();
            labelTituloCi.Text = cedula;
        }
    }
}
