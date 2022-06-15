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
    public partial class MostrarCliente : Form
    {
        ClassClientes clientes;
        string cedula;
        public MostrarCliente(string cedula)
        {
            InitializeComponent();
            this.clientes = new ClassClientes();
            this.cedula = cedula;
            mostrarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mostrarDatos()
        {
            object[] cliente = new object[7];

            cliente = clientes.mostrarClienteId(cedula);
            lblCedula.Text = cliente[0].ToString();
            lblNombre.Text = cliente[1].ToString();
            lblApellido.Text = cliente[2].ToString();
            lblEdad.Text = cliente[3].ToString();
            lblDireccion.Text = cliente[4].ToString();
            lblCorreo.Text = cliente[5].ToString();
            lblTelefono.Text = cliente[6].ToString();
        }

        private void MostrarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
