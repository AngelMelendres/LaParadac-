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
    
    public partial class MostrarEmpleado : Form
    {
        ClassEmpleados empleados = new ClassEmpleados();
        string cedula;
        public MostrarEmpleado(string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            mostrarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mostrarDatos()
        {
            object[] empleado = new object[8];
            empleado = empleados.mostrarEmpleadoId(cedula);
            lblCedula.Text = empleado[0].ToString();
            lblNombre.Text = empleado[1].ToString();
            lblApellido.Text = empleado[2].ToString();
            lblEdad.Text = empleado[3].ToString();
            lblDireccion.Text = empleado[4].ToString();
            lblCorreo.Text = empleado[5].ToString();
            lblCargo.Text = empleado[6].ToString();
            lblTelefono.Text = empleado[7].ToString();
        }

        private void MostrarEmpleado_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
