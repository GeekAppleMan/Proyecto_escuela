using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela
{
    class Cls_Alumnos : Cls_conexion
    {
        private string path = @"C:\Users\Jaime\Desktop\Proyecto_escuela\Imagenes\";
        public static DataTable tabla_id = new DataTable();
        public static bool conservar_modificar_imagen { get; set; }
        private Random objrandom = new Random();
        private char letrarandom;
        public static int index { get; set; }
        public void cargar_alumnos(string matricula, DataGridView grid)
        {
            string estatus = "";
            if (matricula == "")
            {
                if (tabla_id.Columns.Count == 0)
                {
                    tabla_id.Columns.Add("id_tutor");
                    tabla_id.Columns.Add("imagen");
                }
                tabla_id.Rows.Clear();
                grid.Rows.Clear();
                string query = "SELECT * FROM tb_alumnos WHERE estatus = '1'";
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
                        if (reader.GetString(7) == "1")
                        {
                            estatus = "Activo";
                        }
                        if (reader.GetString(7) == "2")
                        {
                            estatus = "Inactivo";
                        }
                        grid.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), estatus, reader.GetString(8));
                        tabla_id.Rows.Add(reader.GetString(0), reader.GetString(9));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro al alumno");
                }

                databaseConnection.Close();
            }
            else
            {
                tabla_id.Rows.Clear();
                grid.Rows.Clear();
                string query = "SELECT * FROM tb_alumnos WHERE matricula LIKE " + "'%" + matricula + "%'";
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
                        if (reader.GetString(7) == "1")
                        {
                            estatus = "Activo";
                        }
                        if (reader.GetString(7) == "2")
                        {
                            estatus = "Inactivo";
                        }
                        grid.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), estatus, reader.GetString(8));
                        tabla_id.Rows.Add(reader.GetString(0), reader.GetString(9));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el alumno");
                }

                databaseConnection.Close();
            }

        }
    }
}
