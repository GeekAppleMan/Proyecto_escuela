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
        public void cargar_usuarios(string matricula, DataGridView grid)
        {
            string estatus = "";
            if (matricula == "")
            {
                grid.Rows.Clear();
                string query = "select tb_empleados_usuarios.id_usuario,tb_empleados.matricula,tb_empleados.nombres,tb_empleados.apellidos,tb_registro.correo,tb_registro.telefono  from tb_empleados,tb_empleados_usuarios,tb_registro where tb_empleados.id_empleado = tb_empleados_usuarios.id_empleado AND tb_empleados.estatus = 1";
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
                        grid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
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
                string query = "select tb_empleados_usuarios.id_usuario,tb_empleados.matricula,tb_empleados.nombres,tb_empleados.apellidos,tb_registro.correo,tb_registro.telefono  from tb_empleados,tb_empleados_usuarios,tb_registro where tb_empleados.Matricula LIKE " + "'%" + matricula + "%'" ; 
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
                        grid.Rows.Add(reader.GetString(0),reader.GetString(1),reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
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
