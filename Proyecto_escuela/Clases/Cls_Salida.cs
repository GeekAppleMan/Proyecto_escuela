using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Clases
{
    class Cls_Salida : Cls_conexion
    {
        public int estatus1 = 0;
        public int estatus2 = 0;
        public int estatus3 = 0;
        public int estatus4 = 0;
        public void estatus()
        {
            string query = "SELECT id_estatus_salida from tb_salida";
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
                    if (reader.GetString(0)=="1")
                    {
                        estatus1 = 1;
                    }
                    if (reader.GetString(0) == "2")
                    {
                        estatus2 = 2;
                    }
                    if (reader.GetString(0) == "3")
                    {
                        estatus3 = 3;
                    }
                    if (reader.GetString(0)=="4")
                    {
                        estatus4 = 4;
                    }
                }
            }
            databaseConnection.Close();
        }
        public void CargarEnEspera(DataGridView grid)
        {
            grid.Rows.Clear();
            string query = "SELECT tb_alumnos.id_alumno, foto_perfil, matricula, nombres, apellidos FROM tb_alumnos Inner JOIN tb_salida on tb_alumnos.id_alumno=tb_salida.id_alumno WHERE id_estatus_salida='2' LIMIT 3";
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
                    string url = reader.GetString(1);
                    WebClient wc = new WebClient();
                    byte[] data = wc.DownloadData(url);

                    MemoryStream ms = new MemoryStream(data);
                    Image imagen = Image.FromStream(ms);
                    grid.Rows.Add(reader.GetString(0), imagen, reader.GetString(2), reader.GetString(3), reader.GetString(4));
                }
            }
            databaseConnection.Close();
        }

        public void CargarSalida(DataGridView grid)
        {
            grid.Rows.Clear();
            string query = "SELECT tb_alumnos.id_alumno, foto_perfil, matricula, nombres, apellidos FROM tb_alumnos Inner JOIN tb_salida on tb_alumnos.id_alumno=tb_salida.id_alumno WHERE id_estatus_salida='3' LIMIT 1";
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
                    string url = reader.GetString(1);
                    WebClient wc = new WebClient();
                    byte[] data = wc.DownloadData(url);

                    MemoryStream ms = new MemoryStream(data);
                    Image imagen = Image.FromStream(ms);


                    grid.Rows.Add(reader.GetString(0), imagen, reader.GetString(2), reader.GetString(3), reader.GetString(4));
                }
            }
            databaseConnection.Close();
        }

        public void Estatus4()
        {
            string query = "INSERT INTO tb_salida_bitacora SELECT * from tb_salida WHERE id_estatus_salida='4'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            databaseConnection.Close();

            string query2 = "DELETE FROM tb_salida WHERE id_estatus_salida='4'";
            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection);
            commandDatabase2.CommandTimeout = 60;
            MySqlDataReader reader2;
            databaseConnection.Open();
            reader2 = commandDatabase2.ExecuteReader();
            databaseConnection.Close();
        }
    }
}
