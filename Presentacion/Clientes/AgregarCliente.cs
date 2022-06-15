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
    public partial class AgregarCliente : Form
    {
        ClassClientes clientes = new ClassClientes();
        public AgregarCliente()
        {
            InitializeComponent();
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

            if (clientes.agregarCliente(cliente))
            {
                MessageBox.Show("Se ha guardado correctamente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
