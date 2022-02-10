using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Clases
{
    class Cls_Login : Cls_conexion
    {
        public int a = 0;
        public void comparar_login(string usuario, string telefono,string contraseña)
        {
            string query = "SELECT Correo, Telefono, Contraseña from tb_registro Where Correo Like @Correo AND Contraseña Like @Contraseña OR Telefono Like @Telefono AND Contraseña Like @Contraseña";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.AddWithValue("@Correo", usuario);
            commandDatabase.Parameters.AddWithValue("@Telefono", telefono);
            commandDatabase.Parameters.AddWithValue("@Contraseña", contraseña);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Login exitoso");
                Frm_main objm = new Frm_main();
                Frm_login objlog = new Frm_login();
                a = 1;
                objm.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
            databaseConnection.Close();
        }
    }
}
