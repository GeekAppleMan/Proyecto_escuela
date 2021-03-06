using MySql.Data.MySqlClient;
using Proyecto_escuela.Login;
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
        public static string rol { get; set; }

        public int comparacion=0;
        public int comparacioncontraseña = 0;
        public void comparar_login(string usuario, string telefono,string contraseña)
        {
            try
            {
                string query = "SELECT * from tb_registro Where correo = " + "'" + usuario + "'" + "AND contraseña = " + "'" + contraseña + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    id_usuario = reader.GetString(0);
                    buscar_id_empleado();
                    if (buscar_nombre_empleado() == true)
                    {
                        Frm_login.frm_login.Hide();
                        new Frm_main().Show();
                        new FormPantalladeCarga().Close();
                        Frm_inicio.lbl_empleado.Text = nombre_empleado;
                    }
                    else
                    {
                        MessageBox.Show("El usuario esta dado de baja, no podra iniciar sesion");
                    }
                    
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
                string query = "SELECT * from tb_empleados_usuarios Where id_usuario = " + "'" + id_usuario + "'";
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

        public bool buscar_nombre_empleado()
        {
            bool estatus = false;
            try
            {
                string query = "SELECT * from tb_empleados Where id_empleado = " + "'" + id_empleado + "'" + " AND estatus = '1'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    nombre_empleado = reader.GetString(2) + " " + reader.GetString(3);
                    rol = reader.GetString(9);
                    estatus = true;
                }
                else
                {
                    estatus = false;
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return estatus;
        }

        public void CompararCorreo(string correo)
        {
            string query = "SELECT correo from tb_registro Where correo = " + "'" + correo +"'" ;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            if (reader.Read())
            {
                comparacion = 1;
            }
            else
            {
                MessageBox.Show("Intoduzca un correo electronico registrado valido");
            }
            databaseConnection.Close();
        }

        public void CambiarContra(string correo, string contraseña)
        {
            string query = "Update tb_registro SET contraseña = '" + contraseña +"' WHERE correo = '" + correo + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            databaseConnection.Close();
        }

        public void CompararContra(string contraseña)
        {
            string query = "SELECT * FROM tb_registro WHERE contraseña = '" + contraseña + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            if (reader.Read())
            {
                comparacioncontraseña = 1;
                MessageBox.Show("No puede poner esta contraseña porque esta es su contraseña actual");
            }
            databaseConnection.Close();
        }
    }
}
