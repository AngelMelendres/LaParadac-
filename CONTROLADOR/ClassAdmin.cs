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
    public class ClassAdmin
    {

        ClassConexion conexion;
        public ClassAdmin()
        {
            conexion = new ClassConexion();
            conexion.conectar();

        }

        public bool validarIngreso(string password,string usuario)
        {
            DataTable table = new DataTable();
            try
            {
                if (password == "" || usuario == "") { return false; }

                //string query = "SELECT * FROM administradores WHERE (cedula = '"+usuario+"') AND (contrasena = '"+password+"')";
                string query = "SELECT* FROM administradores " +
                    "WHERE(cedula = '0605019124') AND(contrasena = '1234')";

                MySqlCommand mycomand = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mycomand);
                adapter.Fill(table);

                if (table.Rows.Count > 0) { return true; }
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR EN LA CONSULTA");
                return false;
            }
            
        }


    }
}
