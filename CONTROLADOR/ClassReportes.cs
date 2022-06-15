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
    public class ClassReportes
    {
        ClassConexion conexion;

        public ClassReportes()
        {
            this.conexion = new ClassConexion();
        }



        public DataTable getEmpleados()
        {
            conexion.conectar();
            DataTable data= new DataTable();
            try
            {

                string query = "SELECT * FROM `empleados`";
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mycomand);
                adapter.Fill(data);
                conexion.cerrar();
                return data;
            }
            catch (Exception ex)
            {
                conexion.cerrar();
                MessageBox.Show(ex.ToString());
                data = null;
                conexion.cerrar();
                return data;

            }
        }
        public DataTable getClientes()
        {
            conexion.conectar();
            DataTable data = new DataTable();
            try
            {

                string query = "SELECT * FROM `clientes`";
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mycomand);
                adapter.Fill(data);
                conexion.cerrar();
                return data;
            }
            catch (Exception ex)
            {
                conexion.cerrar();
                MessageBox.Show(ex.ToString());
                data = null;
                conexion.cerrar();
                return data;

            }
        }
        public DataTable getFacturas()
        {
            conexion.conectar();
            DataTable data = new DataTable();
            try
            {

                string query = "SELECT * FROM `facturas`";
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mycomand);
                adapter.Fill(data);
                conexion.cerrar();
                return data;
            }
            catch (Exception ex)
            {
                conexion.cerrar();
                MessageBox.Show(ex.ToString());
                data = null;
                conexion.cerrar();
                return data;

            }
        }
        public DataTable getProductos()
        {
            conexion.conectar();
            DataTable data = new DataTable();
            try
            {

                string query = "SELECT * FROM `platillos`";
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mycomand);
                adapter.Fill(data);
                conexion.cerrar();
                return data;
            }
            catch (Exception ex)
            {
                conexion.cerrar();
                MessageBox.Show(ex.ToString());
                data = null;
                conexion.cerrar();
                return data;

            }
        }

        public DataTable getDetallesIdFactura(int numFacura)
        {
            conexion.conectar();
            DataTable data = new DataTable();
            try
            {

                string query = String.Format( "SELECT * FROM `detalles_factura` Where numFactura= {0}",numFacura);
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mycomand);
                adapter.Fill(data);
                conexion.cerrar();
                return data;
            }
            catch (Exception ex)
            {
                conexion.cerrar();
                MessageBox.Show(ex.ToString());
                data = null;
                conexion.cerrar();
                return data;

            }
        }
        //mustra la cantidad de registros por cada tabla de la db
        public int getCantidadEmpleados()
        {
            int cantidad = 0;
            try
            {
                conexion.conectar();
                string query = string.Format("SELECT COUNT(*) FROM empleados");
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();
                while (reader.Read())
                {
                    cantidad= int.Parse(reader.GetString(0));
                }
                conexion.cerrar();
                return cantidad;
            }
            catch { conexion.cerrar(); return 0; } 

        }
        public int getCantidadClientes()
        {
            int cantidad = 0;
            try
            {
                conexion.conectar();
                string query = string.Format("SELECT COUNT(*) FROM clientes");
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();
                while (reader.Read())
                {
                    cantidad = int.Parse(reader.GetString(0));
                }
                conexion.cerrar();
                return cantidad;
            }
            catch { conexion.cerrar(); return 0; }

        }
        public int getCantidadProductos()
        {
            int cantidad = 0;
            try
            {
                conexion.conectar();
                string query = string.Format("SELECT COUNT(*) FROM platillos");
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();
                while (reader.Read())
                {
                    cantidad = int.Parse(reader.GetString(0));
                }
                conexion.cerrar();
                return cantidad;
            }
            catch { conexion.cerrar(); return 0; }

        }
        public int getCantidadFacturas()
        {
            int cantidad = 0;
            try
            {
                conexion.conectar();
                string query = string.Format("SELECT COUNT(*) FROM facturas");
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();
                while (reader.Read())
                {
                    cantidad = int.Parse(reader.GetString(0));
                }
                conexion.cerrar();
                return cantidad;
            }
            catch { conexion.cerrar(); return 0; }

        }
        public int getCantidadClientesRiobamba()
        {
            int cantidad = 0;
            try
            {
                conexion.conectar();
                string query = string.Format("SELECT COUNT(*) FROM empleados");
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();
                while (reader.Read())
                {
                    cantidad = int.Parse(reader.GetString(0));
                }
                conexion.cerrar();
                return cantidad;
            }
            catch { conexion.cerrar(); return 0; }

        }
        public int getCantidadProductos2()
        {
            int cantidad = 0;
            try
            {
                conexion.conectar();
                string query = string.Format("SELECT COUNT(*) FROM empleados");
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();
                while (reader.Read())
                {
                    cantidad = int.Parse(reader.GetString(0));
                }
                conexion.cerrar();
                return cantidad;
            }
            catch { conexion.cerrar(); return 0; }

        }


    }
}
