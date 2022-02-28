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
        private static string id_usuario { get; set; }
        private static string id_empleado { get; set; }
        private static string nombre_empleado { get; set; } 
        public void comparar_login(string usuario, string telefono,string contraseña)
        {
            try
            {
                string query = "SELECT * from tb_registro Where Correo = " + "'" + usuario + "'" + "AND Contraseña = " + "'" + contraseña + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                //commandDatabase.Parameters.AddWithValue("@Correo", usuario);
                //commandDatabase.Parameters.AddWithValue("@Telefono", telefono);
                //commandDatabase.Parameters.AddWithValue("@Contraseña", contraseña);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Se inicio sesion correctamente");
                    id_usuario = reader.GetString(0);
                    buscar_id_empleado();
                    buscar_nombre_empleado();
                    Frm_login.frm_login.Hide();
                    new Frm_main().Show();
                    Frm_inicio.lbl_empleado.Text = nombre_empleado;
                   
                }
                else
                {
                    MessageBox.Show("No se encontro al usuario, verifique los datos");
                }
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con el equipo de sistemas");
            }
           
        }

        public void buscar_id_empleado()
        {
            try
            {
                string query = "SELECT * from tb_empleados_usuarios Where IdUsuario = " + "'" + id_usuario + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    id_empleado = reader.GetString(1);
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
           
        }

        public void buscar_nombre_empleado()
        {
            try
            {
                string query = "SELECT * from tb_empleados Where IdEmpleado = " + "'" + id_empleado + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    nombre_empleado = reader.GetString(2) + " " + reader.GetString(3);
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }

        }
    }
}
