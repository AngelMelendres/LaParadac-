using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODELO
{
    public class ClassConexion
    {
        static string servidor = "127.0.0.1";
        static string db = "parada";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";


        public string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + db + ';';
        public MySqlConnection conexion = new MySqlConnection();

        public ClassConexion()
        {
            conexion.ConnectionString = cadenaConexion;

        }



        //public MySqlConnection conectar()
        public void conectar()
        {
            try
            {
                conexion.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Conecion con Restaurante LA PARADA Fallo: " + e.ToString());
            }
        }

        public void cerrar()
        {
            conexion.Close();
        }
    }
}