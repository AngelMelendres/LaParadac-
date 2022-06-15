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
    public partial class RegistroEmpleado : Form
    {
        ClassEmpleados empleados = new ClassEmpleados();
        public RegistroEmpleado()
        {
            InitializeComponent();
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

            if (empleados.agregarEmpleado(empleado))
            {
                MessageBox.Show("Se ha guardado correctamente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
