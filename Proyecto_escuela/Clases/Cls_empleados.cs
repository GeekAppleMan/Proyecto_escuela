using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Clases
{
    class Cls_empleados :Cls_conexion
    {
        private string path = @"C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/";
        public static bool conservar_modificar_imagen { get; set; }
        private Random objrandom = new Random();
        private char letrarandom;
        public static int index { get; set; }
        public static DataGridView empleados;

        public void cargar_empleados(string matricula, DataGridView grid)
        {
            string estatus = "";
            if (matricula == "")
            {
                grid.Rows.Clear();
                string query = "Select * From tb_empleados WHERE tb_empleados.estatus = 1";
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
                        grid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(9), reader.GetString(10), reader.GetString(8));
                        empleados = grid;
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro al empleado");
                }

                databaseConnection.Close();
            }
            else
            {
                grid.Rows.Clear();
                string query = "Select * From tb_empleados Where matricula LIKE " + "'%" + matricula + "%'";
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
                        grid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(9), reader.GetString(10), reader.GetString(8));
                        empleados = grid;
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro al empleado");
                }

                databaseConnection.Close();
            }
        }

        public void registrar_empleados(string matricula, string nombres, string apellidos, string fecha_nacimiento, string direccion, string correo, string telefono, PictureBox pic_captura, Form principal,string rol)
        {

        }
    }
}
