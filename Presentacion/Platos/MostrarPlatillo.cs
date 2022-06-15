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
    public partial class MostrarPlatillo : Form
    {
        int idPlatillo;
        ClassPlatillos platillos= new ClassPlatillos();
        public MostrarPlatillo(int idPlatillo)
        {
            InitializeComponent();
            this.idPlatillo = idPlatillo;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarPlatillo_Load(object sender, EventArgs e)
        {
            object[] platillo = platillos.mostrarplatilloId(idPlatillo);

            lblCodigo.Text = platillo[0].ToString();
            lblNombre.Text = platillo[1].ToString();
            lblPrecio.Text = platillo[2].ToString();
            pxbImagen.Image=Image.FromFile(platillo[3].ToString());
            lblDescripcion.Text = platillo[4].ToString();
            lblCategoria.Text = platillo[5].ToString();
        }
    }
}
