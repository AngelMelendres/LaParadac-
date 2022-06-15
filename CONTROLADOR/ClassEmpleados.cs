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
    public class ClassEmpleados
    {
        ClassConexion conexion;
        public ClassEmpleados()
        {
            conexion = new ClassConexion();
        }

        public DataTable mostrarTodosEmpleados()
        {
            conexion.conectar();
            DataTable table = new DataTable();
            try
            {

                string query = "SELECT cedula,nombre,apellido,edad,direccion,correo,cargo,telefono FROM `empleados`";
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

        public bool agregarEmpleado(object[] empleado)
        {
            conexion.conectar();
            try
            {
                if (validarDatosRegistroEmpleado(empleado))
                {
                    int result = 0;

                    string cedula = empleado[0].ToString();
                    string nombre = empleado[1].ToString();
                    string apellido = empleado[2].ToString();
                    string edad = empleado[3].ToString();
                    string direccion = empleado[4].ToString();
                    string correo = empleado[5].ToString();
                    string cargo = empleado[6].ToString();
                    string telefono = empleado[7].ToString();

                    string query = String.Format("INSERT INTO `empleados` " +
                        "(`cedula`,`nombre`, `apellido`, `edad`, `direccion`, `correo`, `cargo`, `telefono`) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');", cedula, nombre,apellido,edad,direccion,correo,cargo,telefono);

                    MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);

                    result = mycomand.ExecuteNonQuery();
                    conexion.cerrar();
                    if (result > 0) { return true; } else { return false;}
                   
                }
                else { conexion.cerrar(); return false; }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS: "+ex.ToString(), "ERROR DB");
                conexion.cerrar();
                return false;
            }
            
        }

        public object[] mostrarEmpleadoId(string cedula)
        {
            conexion.conectar();
            object[] empleado=new object[8];
            try
            {

                string query = String.Format("SELECT cedula,nombre,apellido,edad,direccion,correo,cargo,telefono FROM `empleados` WHERE(cedula = '{0}')",cedula);
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();

                if(reader.FieldCount == 0) { MessageBox.Show("No se encuentra el registro", "ERROR BUSQUEDA");return null; }
                
                while (reader.Read())
                {
                    empleado[0] = reader.GetString(0);
                    empleado[1] = reader.GetString(1);
                    empleado[2] = reader.GetString(2);
                    empleado[3] = reader.GetString(3);
                    empleado[4] = reader.GetString(4);
                    empleado[5] = reader.GetString(5);
                    empleado[6] = reader.GetString(6);
                    empleado[7] = reader.GetString(7);
                }
                conexion.cerrar();
                return empleado;
            }
            catch (MySqlException ex)
            {
                conexion.cerrar();
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + ex.ToString(),"ERROR BASE DATOS");
                empleado = null;
                return empleado;

            }
        }

        public bool eliminarEmpleadoId(string cedula)
        {
            conexion.conectar();
            try
            {
                int result = 0;
                string query = string.Format("Delete FROM empleados WHERE cedula={0}", cedula);
                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                result=mycomand.ExecuteNonQuery();
                if (result == 0) { return false; }
                conexion.cerrar();
                return true;
            }
            catch (MySqlException ex)
            {
                conexion.cerrar();
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + ex,"ERROR BASE DE DATOS");
                return false;
                
            }
        }

        public bool editarEmpleadoId(object[] empleado, string _ci)
        {
            conexion.conectar();
            try
            {
                if (validarDatosRegistroEmpleado(empleado))
                {
                    int result = 0;

                    string cedula = empleado[0].ToString();
                    string nombre = empleado[1].ToString();
                    string apellido = empleado[2].ToString();
                    string edad =     empleado[3].ToString();
                    string direccion = empleado[4].ToString();
                    string correo = empleado[5].ToString();
                    string cargo = empleado[6].ToString();
                    string telefono = empleado[7].ToString();

                    string query = string.Format("UPDATE `empleados` SET `cedula` = '{0}', `nombre` = '{1}', `apellido` = '{2}', `edad` = '{3}', `direccion` = '{4}', `correo` = '{5}',`cargo` = '{6}', `telefono` = '{7}' WHERE `empleados`.`cedula` = '"+_ci+"';", cedula, nombre, apellido, edad, direccion, correo,cargo, telefono);

                    MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);

                    result = mycomand.ExecuteNonQuery();
                    conexion.cerrar();
                    if (result > 0) { return true; } else { return false; }

                }
                else { conexion.cerrar();  return false; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + ex.ToString(), "ERROR DB");
                conexion.cerrar();
                return false;
            }
        }


        static bool validarDatosRegistroEmpleado(object[] empleado)
        {
            if (empleado[0].ToString()==""|| empleado[1].ToString() == "" || empleado[2].ToString() == "" || empleado[3].ToString() == "" || empleado[4].ToString() == "" || empleado[5].ToString() == "" || empleado[6].ToString() == "" || empleado[7].ToString() == "") { MessageBox.Show("Ingrese todos los datos", "Error de Ingreso"); return false; }
            if (empleado[3].ToString().All(char.IsDigit) == false) { MessageBox.Show("El campo edad solo lleva numeros enteros positivos", "ERROR DE INGRESO"); return false; }
            if (empleado[0].ToString().All(char.IsDigit) == false) { MessageBox.Show("El campo cedula solo lleva numeros", "ERROR DE INGRESO"); return false; }
            if (empleado[7].ToString().All(char.IsDigit) == false) { MessageBox.Show("El campo telefono solo lleva numeros", "ERROR DE INGRESO"); return false; }
            if (int.Parse (empleado[3].ToString())<=10 || int.Parse(empleado[3].ToString()) >= 70 ) { MessageBox.Show("Ingrese una edad valida mayor a 10 y menor a 70", "Error de ingreso de edad"); return false; }
            
            if (empleado[0].ToString().Length!=10 || empleado[7].ToString().Length != 10) { MessageBox.Show("El campo telefono y cedula deben tener 10 numeros", "ERROR DE INGRESO"); return false; }
            return true;
        }


        public DataTable buscarEmpleadoCedula(string cedula)
        {
            conexion.conectar();
            DataTable table=new DataTable();
            try
            {
                string query = string.Format("Select cedula,nombre,apellido,edad,direccion,correo,cargo,telefono From empleados Where cedula like ('{0}')", cedula);
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
