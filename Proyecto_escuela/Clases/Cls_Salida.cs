using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Clases
{
    class Cls_Salida : Cls_conexion
    {
        public int estatu = 0;
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
                        estatu = 1;
                    }
                    if (reader.GetString(0) == "2")
                    {
                        estatu = 2;
                    }
                    if (reader.GetString(0) == "3")
                    {
                        estatu = 3;
                    }
                }
            }
            databaseConnection.Close();
        }
        public void CargarEnEspera(DataGridView grid)
        {
            grid.Rows.Clear();
            string query = "SELECT tb_alumnos.id_alumno, matricula, nombres, apellidos FROM tb_alumnos Inner JOIN tb_salida on tb_alumnos.id_alumno=tb_salida.id_alumno LIMIT 3";
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
                    grid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
            }
            databaseConnection.Close();
        }

        public void CargarSalida(DataGridView grid)
        {
            grid.Rows.Clear();
            string query = "SELECT tb_alumnos.id_alumno, matricula, nombres, apellidos FROM tb_alumnos Inner JOIN tb_salida on tb_alumnos.id_alumno=tb_salida.id_alumno LIMIT 1";
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
                    grid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
            }
            databaseConnection.Close();
        }

        public void Estatus3()
        {
            string query = "INSERT INTO tb_salida_bitacora SELECT * from tb_salida WHERE id_estatus_salida='3'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            databaseConnection.Close();

            string query2 = "DELETE FROM tb_salida WHERE id_estatus_salida='3'";
            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection);
            commandDatabase2.CommandTimeout = 60;
            MySqlDataReader reader2;
            databaseConnection.Open();
            reader2 = commandDatabase2.ExecuteReader();
            databaseConnection.Close();
        }
    }
}
