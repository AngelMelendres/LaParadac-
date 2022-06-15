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

namespace Presentacion.Ventas
{
    public partial class Vender : Form
    {
        string numFact;
        Random r = new Random();
        float iva = 0.12f;
        ClassClientes clientes;
        ClassPlatillos platillos;
        ClassVentas ventas = new ClassVentas();

        List<ClassDetalle> detalles = new List<ClassDetalle>();


        public Vender()
        {
            InitializeComponent();
            clientes = new ClassClientes();
            platillos = new ClassPlatillos();
            txtNombreProducto.Enabled = false;
            this.numFact = r.Next(10000,999999999).ToString();
            lblIVA.Text=iva.ToString();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new ListadoVentas());
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Clientes.AgregarCliente());
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Vender());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new ListadoVentas());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            object[] cliente = new object[7];
            cliente = clientes.mostrarClienteId(txtCedula.Text);

            if (cliente[0] == null) { MessageBox.Show("No encontramos al cliente. Puedes agregar un nuevo cliente !","CLIENTE NO ENCONTRADO"); }
            else
            {
                txtCedula.Enabled = false;
                txtNombreProducto.Enabled = true;
                lblNombre.Text = cliente[1].ToString();
                lblApellido.Text=cliente[2].ToString();
                lblCorreo.Text= cliente[5].ToString();
                lblTelefono.Text= cliente[6].ToString();
            }
           
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            object[] producto = new object[7];
            producto = platillos.getPlatilloNombre(txtNombreProducto.Text);

            if (producto[0] == null) { MessageBox.Show("No encontramos al producto. busca de nuevo", "PRODUCTO NO ENCONTRADO"); }
            else
            {
                lblPrecio.Text = producto[3].ToString();
                lblStock.Text = producto[6].ToString();
                pictureBoxImagenProducto.Image = Image.FromFile(producto[4].ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ClassDetalle detalle= new ClassDetalle();
            
            object[] producto = new object[7];
            producto = platillos.getPlatilloNombre(txtNombreProducto.Text);
            if (producto[0]==null) { MessageBox.Show("Ingrese algun producto"); return; }

            detalle.NombreProducto = producto[2].ToString();
            detalle.Precio= float.Parse(producto[3].ToString());
            detalle.Cantidad = int.Parse (txtCantidad.Value.ToString());
            detalle.NumFactura = numFact;
            detalle.calcularSub();
            detalle.IdPlatillo = int.Parse(producto[0].ToString());
            detalles.Add(detalle);
            cargarGirdDetalles();
            calcularTotal(detalle);


        }

        public void cargarGirdDetalles()
        {
            float sub=0;
            gunaDataGridView1.Rows.Clear();
            gunaDataGridView1.Refresh();
            for (int i = 0; i < detalles.Count; i++)
            {
                gunaDataGridView1.Rows.Add();
                gunaDataGridView1.Rows[i].Cells[0].Value = detalles[i].NombreProducto;
                gunaDataGridView1.Rows[i].Cells[1].Value = detalles[i].Cantidad;
                gunaDataGridView1.Rows[i].Cells[2].Value = detalles[i].Precio;
                gunaDataGridView1.Rows[i].Cells[3].Value = detalles[i].SubTotal;
                sub += detalles[i].SubTotal;
            }
            lblSubTotal.Text = sub.ToString();
        }

        public void calcularTotal( ClassDetalle detalle)
        {
            lblTotal.Text = (float.Parse(lblSubTotal.Text) + (float.Parse(lblSubTotal.Text) * iva)).ToString(); 
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (gunaDataGridView1.RowCount <= 1) { MessageBox.Show("No se registraron productos ... ","Alerta"); return; }
            object[] venta = new object[4];
            venta[0] = numFact;
            venta[1] = lblTotal.Text;
            venta[2] = lblIVA.Text;
            venta[3]=txtCedula.Text;

            if(ventas.registrarVenta(detalles, venta))
            {
                MessageBox.Show("Venta Registrada exitosamente", "VENTA");
                BuscarFactura fact = new BuscarFactura(int.Parse(numFact));
                fact.Show();

            }
            else { MessageBox.Show("Error la venta no se concreto", "VENTA"); }

           
            this.Close();
            
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "Cédula")
            {
                txtCedula.Text = "";
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Cédula";
            }
        }

        private void txtNombreProducto_Enter(object sender, EventArgs e)
        {

            if (txtNombreProducto.Text == "Nombre del Producto")
            {
                txtNombreProducto.Text = "";
            }
        }

        private void txtNombreProducto_Leave(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "")
            {
                txtNombreProducto.Text = "Nombre del Producto";
            }
        }
    }
}
