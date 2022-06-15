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
    public partial class EditarPlato : Form
    {
        int idPlatillo;
        ClassPlatillos platillos = new ClassPlatillos();
        public EditarPlato(int idPlatillo)
        {
            InitializeComponent();
            this.idPlatillo = idPlatillo;
            mostrarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            object[] platillo = new object[5];
            platillo[0] = txtCodigo.Text.ToString();
            platillo[1] = txtNombre.Text.ToString();
            platillo[2] = txtPrecio.Text.ToString();
            platillo[3] = txtDescripcion.Text.ToString();
            platillo[4] = cbxCategoria.Text.ToString();

            if (platillos.editarPlatilloId(platillo,idPlatillo))
            {
                MessageBox.Show("Se ha Actualizado correctamente", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        public void mostrarDatos()
        {

            object[] platillo = new object[6];
            platillo = platillos.mostrarplatilloId(idPlatillo);

            txtCodigo.Text = platillo[0].ToString();
            txtNombre.Text = platillo[1].ToString();
            txtPrecio.Text = platillo[2].ToString();
            pxbImagen.Image = Image.FromFile(platillo[3].ToString());
            txtDescripcion.Text = platillo[4].ToString();
            cbxCategoria.Text = platillo[5].ToString();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarPlato_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
