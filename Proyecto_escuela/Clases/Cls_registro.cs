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
        private static string id_usuario { get; set; } 
        private static string id_empleado { get; set; }
        public void buscar_empleado(string matricula, string correo, string telefono, string contraseña)
        {
            try
            {
                string query = "SELECT * from tb_empleados Where matricula = " + "'" + matricula+ "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    if (buscar_usuario_registrado(reader.GetString(0)) == true)
                    {
                        MessageBox.Show("El usuario con matricula: " + matricula + " ya tiene un usuario registrado");
                    }
                    else
                    {
                        id_empleado = reader.GetString(0);
                        if (buscar_correo_telefono_registrado(correo, telefono) == true)
                        {
                            MessageBox.Show("Correo o telefono ya se encuentra registrado, intente con otro");
                        }
                        else
                        {
                            registrarUsuarios(matricula, correo, telefono, contraseña);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro al empleado con la matricula: " + matricula + " verifique la matricula");
                }
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con el equipo de sistemas");
            }

        }
        public bool buscar_usuario_registrado(string id)
        {
            bool encontrado = false;
            try
            {
                string query = "SELECT * from tb_empleados_usuarios Where id_empleado = " + "'" + id + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    encontrado = true;
                }
                else
                {
                    encontrado = false;
                }
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con el equipo de sistemas");
            }
            return encontrado;
        }

        public bool buscar_correo_telefono_registrado(string correo, string telefono)
        {
            bool encontrado = false;
            try
            {
                string query = "SELECT * from tb_registro Where correo = " + "'" + correo + "'" + "OR telefono = " + "'" + telefono + "'" ;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    encontrado = true;
                    id_usuario = reader.GetString(0);
                }
                else
                {
                    encontrado = false;
                }
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con el equipo de sistemas");
            }
            return encontrado;
        }
        public void registrarUsuarios(string matricula,string correo, string telefono, string contraseña)
        {
            try
            {
                string query = "INSERT INTO `tb_registro`(`id_usuario`, `correo`, `telefono`, `contraseña`) VALUES ('" + "" + "'," + "'" + correo + "'" + "," + "'" + telefono + "'" + "," + "'" + contraseña + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                buscar_correo_telefono_registrado(correo, telefono);
                registrar_relacion();
                MessageBox.Show("Se registro correctamente");
                Login.Frm_Registro.frm_registro.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con el equipo de sistemas");
            }
            
        }

        public void registrar_relacion()
        {
            try
            {
                string query = "INSERT INTO `tb_empleados_usuarios`(`id_usuario`, `id_empleado`) VALUES ('" + id_usuario + "'," + "'" + id_empleado + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con el equipo de sistemas");
            }

        }
    }
}
