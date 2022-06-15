using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;

namespace Presentacion
{
    public partial class Login : Form
    {
        ClassAdmin admin = new ClassAdmin();

        public Login()
        {
            InitializeComponent();
            crearPath();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            crearPath();
        }
        public void crearPath()
        {
            string folderPath = @"e:\\ProyectoBaseDatosParada";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (admin.validarIngreso(txtCedula.Text, txtContraseña.Text))
            {
                Program.login.Hide();
                Administrador objAdmin = new Administrador();
                objAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña no son validos", "Alerta");
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "Cédula")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.Gainsboro;
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Cédula";
                txtCedula.ForeColor = Color.Gainsboro;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Gainsboro;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Gainsboro;
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCedula.Text == "")
                {
                    MessageBox.Show("Ingrese su número de cédula por favor");
                    txtCedula.Focus();
                }
                else
                {
                    txtContraseña.Focus();
                }
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (txtContraseña.Text == "")
                {
                    MessageBox.Show("Ingrese su contraseña por favor");
                    txtContraseña.Focus();
                }
            }
        }
    }
}
