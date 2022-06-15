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
    public partial class EditarCliente : Form
    {
        string cedula;
        ClassClientes clientes;
        public EditarCliente(string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            this.clientes = new ClassClientes();
            mostrarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            object[] cliente = new object[7];

            cliente[0] = txtCedula.Text.ToString();
            cliente[1] = txtNombre.Text.ToString();
            cliente[2] = txtApellido.Text.ToString();
            cliente[3] = txtEdad.Text.ToString();
            cliente[4] = txtDireccion.Text.ToString();
            cliente[5] = txtCorreo.Text.ToString();
            cliente[6] = txtTelefono.Text.ToString();

            if (clientes.editarClienteId(cliente, cedula))
            {
                MessageBox.Show("Se ha Actualizado correctamente", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mostrarDatos()
        {

            object[] empleado = new object[7];
            empleado = clientes.mostrarClienteId(cedula);

            txtCedula.Text = empleado[0].ToString();
            txtNombre.Text = empleado[1].ToString();
            txtApellido.Text = empleado[2].ToString();
            txtEdad.Text = empleado[3].ToString();
            txtDireccion.Text = empleado[4].ToString();
            txtCorreo.Text = empleado[5].ToString();
            txtTelefono.Text = empleado[6].ToString();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
