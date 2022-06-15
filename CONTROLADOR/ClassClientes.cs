using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROLADOR
{
    public class ClassClientes
    {
        ClassConexion conexion;
        public ClassClientes()
        {
            conexion = new ClassConexion();
        }

        public DataTable mostrarTodosClientes()
        {
            conexion.conectar();
            DataTable table = new DataTable();
            try
            {

                string query = "SELECT cedula,nombre,apellido,edad,direccion,correo,telefono FROM `clientes`";
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

        public bool agregarCliente(object[] cliente)
        {
            conexion.conectar();
            try
            {
                if (validarDatosRegistroCliente(cliente))
                {
                    int result = 0;

                    string cedula = cliente[0].ToString();
                    string nombre = cliente[1].ToString();
                    string apellido = cliente[2].ToString();
                    int edad = int.Parse(cliente[3].ToString());
                    string direccion = cliente[4].ToString();
                    string correo = cliente[5].ToString();
                    string telefono = cliente[6].ToString();

                    string query = String.Format("INSERT INTO `clientes` " +
                        "( `cedula`, `nombre`, `apellido`, `edad`, `direccion`, `correo`, `telefono`) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",cedula, nombre, apellido, edad, direccion, correo,  telefono);

                    MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);

                    result = mycomand.ExecuteNonQuery();
                    conexion.cerrar();
                    if (result > 0) { return true; } else { return false; }

                }
                else { conexion.cerrar(); return false; }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + ex.ToString(), "ERROR DB");
                conexion.cerrar();
                return false;
            }

        }

        public object[] mostrarClienteId(string cedula)
        {
            conexion.conectar();
            object[] empleado = new object[7];
            try
            {
                int result = 0;
                string query = String.Format("SELECT cedula,nombre,apellido,edad,direccion,correo,telefono FROM `clientes` WHERE(cedula = '{0}')", cedula);
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();

                //if (reader.FieldCount == 0) { MessageBox.Show("No se encuentra el registro", "ERROR BUSQUEDA"); return null; }
                while (reader.Read())
                {
                    empleado[0] = reader.GetString(0);
                    empleado[1] = reader.GetString(1);
                    empleado[2] = reader.GetString(2);
                    empleado[3] = reader.GetString(3);
                    empleado[4] = reader.GetString(4);
                    empleado[5] = reader.GetString(5);
                    empleado[6] = reader.GetString(6);
                }
                //if(empleado[0] == null) { MessageBox.Show("No se encuentra el registro"); }
                conexion.cerrar();
                return empleado;
            }
            catch (MySqlException ex)
            {
                conexion.cerrar();
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + ex.ToString(), "ERROR BASE DATOS");
                empleado = null;
                return empleado;

            }
        }

        public bool eliminarclienteId(string cedula)
        {
            conexion.conectar();
            try
            {
                int result = 0;
                string query = string.Format("Delete FROM `clientes` WHERE `cedula`='{0}'", cedula);
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                result = mycomand.ExecuteNonQuery();
                if (result == 0) { return false; }
                conexion.cerrar();
                return true;
            }
            catch (MySqlException ex)
            {
                conexion.cerrar();
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + ex, "ERROR BASE DE DATOS");
                return false;

            }
        }

        public bool editarClienteId(object[] cliente, string _ci)
        {
            conexion.conectar();
            try
            {
                if (validarDatosRegistroCliente(cliente))
                {
                    int result = 0;

                    string cedula = cliente[0].ToString();
                    string nombre = cliente[1].ToString();
                    string apellido = cliente[2].ToString();
                    int edad = int.Parse(cliente[3].ToString());
                    string direccion = cliente[4].ToString();
                    string correo = cliente[5].ToString();
                    string telefono = cliente[6].ToString();

                    //string query = String.Format("UPDATE `clientes` set" +
                    //  "(`cedula`='{0}', `nombre`='{1}', `apellido`='{2}', `edad`='{3}', `direccion`='{4}', `correo`='{5}', `telefono`='{6}') where cedula='{7}' ", cedula, nombre, apellido,  edad, direccion, correo, telefono, _ci);

                    string query = string.Format("UPDATE `clientes` SET `cedula` = '{0}', `nombre` = '{1}', `apellido` = '{2}', `edad` = '{3}', `direccion` = '{4}', `correo` = '{5}', `telefono` = '{6}' WHERE `clientes`.`cedula` = '{7}';", cedula, nombre, apellido, edad, direccion, correo, telefono, _ci);

                    MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);

                    result = mycomand.ExecuteNonQuery();
                    conexion.cerrar();
                    if (result > 0) { return true; } else { return false; }

                }
                else { conexion.cerrar(); return false; }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + ex.ToString(), "ERROR DB");
                conexion.cerrar();
                return false;
            }
        }


        static bool validarDatosRegistroCliente(object[] cliente)
        {
            if (cliente[0].ToString() == "" || cliente[1].ToString() == "" || cliente[2].ToString() == "" || cliente[3].ToString() == "" || cliente[4].ToString() == "" || cliente[5].ToString() == "" || cliente[6].ToString() == "" ) { MessageBox.Show("Ingrese todos los datos", "Error de Ingreso"); return false; }
            if(cliente[3].ToString().All(char.IsDigit) == false) { MessageBox.Show("Ingrese una edad valida solo numeros positivos", "Error de ingreso de edad"); return false; }
            if (cliente[0].ToString().All(char.IsDigit) == false) { MessageBox.Show("El campo cedula solo lleva numeros", "ERROR DE INGRESO"); return false; }
            if (cliente[6].ToString().All(char.IsDigit) == false) { MessageBox.Show("El campo telefono solo lleva numeros", "ERROR DE INGRESO"); return false; }

            if (int.Parse(cliente[3].ToString()) <= 10 || int.Parse(cliente[3].ToString()) >= 70 ) { MessageBox.Show("Ingrese una edad valida", "Error de ingreso de edad"); return false; }
            if (cliente[0].ToString().Length != 10 || cliente[6].ToString().Length != 10) { MessageBox.Show("El campo telefono y cedula deben tener 10 numeros", "ERROR DE INGRESO"); return false; }
            return true;
        }

        public DataTable buscarclienteCedula(string cedula)
        {
            conexion.conectar();
            DataTable table = new DataTable();
            try
            {
                string query = string.Format("Select cedula,nombre,apellido,edad,direccion,correo,telefono From clientes Where cedula like ('{0}')", cedula);
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mycomand);
                adapter.Fill(table);
                conexion.cerrar();
                return table;
            }
            catch (MySqlException ex)
            {
                table = null;
                conexion.cerrar();
                return table;

            }
        }
    }
}
