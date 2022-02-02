using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Clases
{
    class Cls_registro : Cls_conexion
    {
        public void registrarUsuarios(string correo, long telefono, string contraseña)
        {
            string query = "INSERT INTO `tb_registro`(`idUsuario`, `Correo`, `Telefono`, `Contraseña`) VALUES ('" + "" + "'," + "'" + correo + "'" + "," + "'" + telefono + "'" + "," + "'" + contraseña + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            databaseConnection.Close();
        }
    }
}
