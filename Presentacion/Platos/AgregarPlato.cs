using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;

namespace Presentacion.Platos
{
    public partial class AgregarPlato : Form
    {
        ClassPlatillos platillos= new ClassPlatillos();
        public AgregarPlato()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //subir la imgem
            Random r = new Random();
            string destino = Path.Combine(Application.StartupPath, string.Format("e:\\ProyectoBaseDatosParada\\" + r.Next(1, 999).ToString() + "{0}", Path.GetFileName(openFileDialog1.FileName)));
            File.Copy(openFileDialog1.FileName, destino);
            string img = destino.Replace("\\", "\\\\");


            object[] platillo = new object[6];
            platillo[0] = txtCodigo.Text.ToString();
            platillo[1] = txtNombre.Text.ToString();
            platillo[2] = txtPrecio.Text.ToString();
            platillo[3]= img;
            platillo[4] = txtDescripcion.Text.ToString();
            platillo[5] = cbxCategoria.Text.ToString();




            if (platillos.agregarPlatillo(platillo))
            {
                MessageBox.Show("Se ha guardado correctamente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string imagen = openFileDialog1.FileName;

                    pxbImagen.Image = Image.FromFile(imagen);
                }
                else { openFileDialog1.FileName = null; }
            }
            catch
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
