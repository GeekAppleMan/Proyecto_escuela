using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Clases
{
    class Cls_usuarios :Cls_conexion
    {
        private string path = @"C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/";
        public static bool conservar_modificar_imagen { get; set; }
        private Random objrandom = new Random();
        private char letrarandom;
        public static int index { get; set; }
        public static DataGridView usuarios;

        public void cargar_usuarios(string telefono, string correo, DataGridView grid)
        {
            string estatus = "";
            if (telefono == "" || correo == "")
            {
                grid.Rows.Clear();
                string query = "SELECT IdUsuario, Correo, Telefono from tb_registro";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        grid.Rows.Add(reader.GetString(0), reader.GetString(1),reader.GetString(2));
                        usuarios = grid;
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro al usuario");
                }

                databaseConnection.Close();
            }
            else
            {
                grid.Rows.Clear();
                string query = "SELECT IdUsuario, Correo, Telefono FROM tb_registro WHERE telefono LIKE " + "'%" + telefono + "%' OR Correo LIKE " + "'%" + correo + "%'" ; 
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        grid.Rows.Add(reader.GetString(0), reader.GetString(1),reader.GetString(2));
                        usuarios = grid;
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el Usuario");
                }

                databaseConnection.Close();
            }
        }
    }
}
