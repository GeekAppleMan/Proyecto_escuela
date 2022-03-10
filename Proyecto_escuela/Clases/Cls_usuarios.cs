using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Clases
{
    class Cls_usuarios :Cls_conexion
    {
        public static DataGridView usuarios;
        public void cargar_usuarios(string matricula, DataGridView grid)
        {
            string estatus = "";
            if (matricula == "")
            {
                grid.Rows.Clear();
                string query = "SELECT eu.id_usuario,e.id_empleado,e.matricula,e.nombres,e.apellidos,r.correo,r.telefono FROM tb_empleados_usuarios eu INNER JOIN tb_empleados e ON e.id_empleado = eu.id_empleado inner JOIN tb_registro r ON r.id_usuario = eu.id_usuario WHERE e.estatus = 1;";
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
                        grid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5),reader.GetString(6));
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
                string query = "SELECT eu.id_usuario,e.id_empleado,e.matricula,e.nombres,e.apellidos,r.correo,r.telefono FROM tb_empleados_usuarios eu INNER JOIN tb_empleados e ON e.id_empleado = eu.id_empleado inner JOIN tb_registro r ON r.id_usuario = eu.id_usuario WHERE e.matricula LIKE " + "'%" + matricula + "%'" ; 
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
                        grid.Rows.Add(reader.GetString(0),reader.GetString(1),reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
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
        public void buscar_empleado(string id_empleado)
        {
            string query = "Select * From tb_empleados Where id_empleado = " + "'" + id_empleado + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();

            reader = commandDatabase.ExecuteReader();
            string resul_estatus = "";
            string resul_rol = "";
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    if (reader.GetString(10) == "1")
                    {
                        resul_estatus = "Activo";
                    }
                    if (reader.GetString(10) == "2")
                    {
                        resul_estatus = "Inactivo";
                    }
                    if (reader.GetString(9) == "1")
                    {
                        resul_rol = "Administrador";
                    }
                    if (reader.GetString(9) == "2")
                    {
                        resul_rol = "Basico";
                    }
                    Frm_credencial_usuario obj_credencial = new Frm_credencial_usuario();
                    obj_credencial.lbl_matricula_empleado.Text = "Matricula: " + reader.GetString(1);
                    obj_credencial.lbl_nombres_empleado.Text = "Nombres: " + reader.GetString(2);
                    obj_credencial.lbl_apellidos_empleado.Text = "Apellidos: " + reader.GetString(3);
                    obj_credencial.lbl_fecha_empleado.Text = "Nacimiento: " + reader.GetString(4);
                    obj_credencial.lbl_direccion_empleado.Text = "Direccion: " + reader.GetString(5);
                    obj_credencial.lbl_correo_empleado.Text = "Correo: " + reader.GetString(6);
                    obj_credencial.lbl_telefono_empleado.Text = "Telefono: " + reader.GetString(7);
                    try
                    {
                        obj_credencial.picture_imagen_perfil.Image = new Bitmap(reader.GetString(8));
                    }
                    catch (Exception)
                    {

                    }
                    obj_credencial.lbl_rol_empleado.Text = "Rol: " + resul_rol;
                    obj_credencial.lbl_estatus_empleado.Text = "Estatus: " + resul_estatus;
                    obj_credencial.ShowDialog();

                }
            }
            else
            {
                Console.WriteLine("No se encontro al empleado");
            }

            databaseConnection.Close();
        }
    }
}
