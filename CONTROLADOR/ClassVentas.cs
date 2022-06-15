using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using MySql.Data.MySqlClient;

namespace CONTROLADOR
{
    public class ClassVentas
    {
        ClassConexion conexion;
        

        public ClassVentas()
        {
            conexion=new ClassConexion();
        }


        public DataTable mostrarTodosFacturas()
        {
            conexion.conectar();
            DataTable table = new DataTable();
            try
            {

                string query = "SELECT numFactura,total,fecha,cedulaCliente FROM `facturas`";
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mycomand);
                adapter.Fill(table);
                conexion.cerrar();
                return table;
            }
            catch (Exception ex)
            {
                conexion.cerrar();
                MessageBox.Show(ex.ToString());
                table = null;
                conexion.cerrar();
                return table;

            }
        }

        public DataTable getFacturaId(string cedula)
        {
            conexion.conectar();
            DataTable table = new DataTable();
            try
            {

                string query = "SELECT numFactura,total,fecha,cedulaCliente FROM `facturas`";
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mycomand);
                adapter.Fill(table);
                conexion.cerrar();
                return table;
            }
            catch (Exception ex)
            {
                conexion.cerrar();
                MessageBox.Show(ex.ToString());
                table = null;
                conexion.cerrar();
                return table;

            }
        }

     





        public DataTable buscarFacturaCedula(string cedula)
        {
            conexion.conectar();
            DataTable table = new DataTable();
            try
            {
                string query = String.Format("SELECT numFactura,total,fecha,cedulaCliente FROM `facturas` WHERE cedulaCliente like '{0}' ", cedula);
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mycomand);
                adapter.Fill(table);
                conexion.cerrar();
                return table;
            }
            catch 
            {
                table = null;
                conexion.cerrar();
                return table;

            }
        }


        public bool registrarVenta(List<ClassDetalle> detalles, object[] info)
        {
            DateTime dt = new DateTime(2042, 12, 24, 18, 42, 0);

            conexion.conectar();
            try
            {
                int result = 0;

                string numFactura = info[0].ToString();
                string total=info[1].ToString();
                string iva=info[2].ToString();
                string fecha = dt.ToString("d");
                string cedula = info[3].ToString();
                

                string query = String.Format("INSERT INTO `facturas` (`numFactura`, `total`, `iva`, `fecha`, `cedulaCliente`) VALUES ('{0}', '{1}', '{2}', '2022-06-15', '{3}');",numFactura,total,iva,cedula);

                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);

                result = mycomand.ExecuteNonQuery();
                conexion.cerrar();
                registrarDetalles(detalles,info);
                if (result > 0) { return true; } else { return false; }

                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + ex.ToString(), "ERROR DB");
                conexion.cerrar();
                return false;
            }
        }

        public void registrarDetalles(List<ClassDetalle> detalles, object[] info)
        {
            string numFactura = info[0].ToString();
            string total = info[1].ToString();
            string iva = info[2].ToString();
            string cedula = info[3].ToString();

            foreach(ClassDetalle detalle in detalles)
            {
                try
                {
                    conexion.conectar();
                    string query = string.Format("INSERT INTO `detalles_factura` " +
                    "(`numFactura`, `idPlatillo`, `cantidad`, `subTotal`, `nombrePlatillo`, `precioPlatillo`) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", numFactura, detalle.IdPlatillo, detalle.Cantidad, detalle.SubTotal, detalle.NombreProducto, detalle.Precio);
                    MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                    mycomand.ExecuteNonQuery();
                    conexion.cerrar();
                }
                catch
                {
                    MessageBox.Show("error, se registra en mismo producto");
                }
               
            }


            
        }


        public DataTable mostrarDetallesFacturaId(int numFactura)
        {
            DataTable table = new DataTable();

            try
            {
                string query = string.Format("SELECT * FROM `detalles_factura` WHERE numFactura = '{}';", numFactura);
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mycomand);
                adapter.Fill(table);
                conexion.cerrar();
                return table;
            }
            catch
            {
                MessageBox.Show("NO SE PUEDE CARGAR LOS DETALLES ESPERE ...  ", "ERROR DB");
                table = null;
                conexion.cerrar();
                return table;
            }
            




        }


    }
}
