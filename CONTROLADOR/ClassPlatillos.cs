using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using MySql.Data.MySqlClient;

namespace CONTROLADOR
{
    public class ClassPlatillos
    {
        ClassConexion conexion;
        public ClassPlatillos()
        {
            conexion = new ClassConexion();

        }

        public DataTable mostrarTodosPlatillos()
        {
            conexion.conectar();
            DataTable table = new DataTable();
            try
            {

                string query = "SELECT idPlatillo,codigo,nombre,precio,imagen,descripcion,categoria FROM `platillos`";
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

        public bool agregarPlatillo(object[] platillo)
        {
            conexion.conectar();
           

            try
            {
                if (validarDatosRegistroPlatillo(platillo))
                {
                    int result = 0;

                    string codigo = platillo[0].ToString();
                    string nombre = platillo[1].ToString();
                    string precio = platillo[2].ToString();
                    string imagen=platillo[3].ToString();
                    string descripcion = platillo[4].ToString();
                    string categoria = platillo[5].ToString();

                    string query = String.Format("INSERT INTO `platillos` " +
                        "(`idPlatillo`,`codigo`, `nombre`, `precio`, `imagen`, `descripcion`, `categoria`) " +
                        "VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",codigo, nombre, precio, imagen, descripcion, categoria);

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

        public object[] mostrarplatilloId(int id)
        {
            conexion.conectar();
            object[] platillo = new object[6];
            try
            {

                string query = String.Format("SELECT codigo,nombre,precio,imagen,descripcion,categoria FROM `platillos` WHERE(idPlatillo = '{0}')", id);
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();

                if (reader.FieldCount == 0) { MessageBox.Show("No se encuentra el registro", "ERROR BUSQUEDA"); return null; }

                while (reader.Read())
                {
                    platillo[0] = reader.GetString(0);
                    platillo[1] = reader.GetString(1);
                    platillo[2] = reader.GetString(2);
                    platillo[3] = reader.GetString(3);
                    platillo[4] = reader.GetString(4);
                    platillo[5] = reader.GetString(5);
                }
                conexion.cerrar();
                return platillo;
            }
            catch (MySqlException ex)
            {
                conexion.cerrar();
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + ex.ToString(), "ERROR BASE DATOS");
                platillo = null;
                return platillo;

            }
        }

        public bool eliminarPlatilloId(int id)
        {
            conexion.conectar();
            try
            {
                int result = 0;
                string query = string.Format("Delete FROM platillos WHERE idPlatillo={0}", id);
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

        public object[] getPlatilloNombre(string nombre)
        {
            conexion.conectar();
            object[] plato = new object[7];
            try
            {
                int result = 0;
                string query = String.Format("SELECT * FROM `platillos` WHERE(nombre = '{0}')", nombre);
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();

                //if (reader.FieldCount == 0) { MessageBox.Show("No se encuentra el registro", "ERROR BUSQUEDA"); return null; }
                while (reader.Read())
                {
                    plato[0] = reader.GetString(0);
                    plato[1] = reader.GetString(1);
                    plato[2] = reader.GetString(2);
                    plato[3] = reader.GetString(3);
                    plato[4] = reader.GetString(4);
                    plato[5] = reader.GetString(5);
                    plato[6] = reader.GetString(6);
                }
                //if(empleado[0] == null) { MessageBox.Show("No se encuentra el registro"); }
                conexion.cerrar();
                return plato;
            }
            catch (MySqlException ex)
            {
                conexion.cerrar();
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + ex.ToString(), "ERROR BASE DATOS");
                plato = null;
                return plato;

            }
        }

        public bool editarPlatilloId(object[] platillo, int id)
        {
            conexion.conectar();
            try
            {
                if (validarDatosRegistroPlatillo(platillo))
                {
                    int result = 0;

                    string codigo = platillo[0].ToString();
                    string nombre = platillo[1].ToString();
                    string precio = platillo[2].ToString();
                    string descripcion = platillo[3].ToString();
                    string categoria = platillo[4].ToString();

                    string query = string.Format("UPDATE `platillos` SET `codigo` = '{0}', `nombre` = '{1}', `precio` = '{2}', `descripcion` = '{3}', `categoria` = '{4}' WHERE `platillos`.`idPlatillo` = {5};", codigo, nombre, precio,descripcion,categoria,id);

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


        static bool validarDatosRegistroPlatillo(object[] platillo)
        {
            if (platillo[0].ToString() == "" || platillo[1].ToString() == "" || platillo[2].ToString() == "" || platillo[3].ToString() == "" || platillo[4].ToString() == "" ) { MessageBox.Show("Ingrese todos los datos", "Error de Ingreso"); return false; }
            if (platillo[2].ToString().All(char.IsDigit) == false) { MessageBox.Show("El campo precio solo ingrese numeros positivos", "ERROR DE INGRESO"); return false; }
            if (float.Parse(platillo[2].ToString()) <=0 || float.Parse(platillo[2].ToString()) >= 9999 ) { MessageBox.Show("Ingrese un precio valido", "Error de ingreso"); return false; }
            return true;
        }

        public DataTable buscarPlatilloNombre(string nombre)
        {
            conexion.conectar();
            DataTable table = new DataTable();
            try
            {
                string query = string.Format("Select idPlatillo,codigo,nombre,precio,imagen,descripcion,categoria From platillos Where nombre like ('{0}')", nombre);
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
    }
}
