using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            AbrirFormulariosHijos(new InicioDash.InicioDashborard());
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
            MessageBox.Show("¿Està seguro de elimnar los datos del empleado?", "!ALERTA¡", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Empleados.Empleado());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Clientes.Cliente());
        }

        private void btnPlatillos_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Platos.Platillos());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Ventas.ListadoVentas());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new InicioDash.InicioDashborard());
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Program.login.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Reportes.Reporte());
        }
    }
}
