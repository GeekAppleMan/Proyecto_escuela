using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela
{
    class Cls_Alumnos : Cls_conexion
    {
        private string path = @"C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/";
        public static bool conservar_modificar_imagen { get; set; }
        private Random objrandom = new Random();
        private char letrarandom;
        public static int index { get; set; }
        public static DataGridView alumnos;
        public void cargar_alumnos(string matricula, DataGridView grid)
        {
            string estatus = "";
            if (matricula == "")
            {
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
                        grid.Rows.Add(reader.GetString(0),reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), estatus, reader.GetString(8));
                        alumnos = grid;
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
                        grid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), estatus, reader.GetString(8));
                        alumnos = grid;
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el alumno");
                }

                databaseConnection.Close();
            }

        }
        public void registrar_alumnos(string matricula,string nombres, string apellidos, string direccion,string fecha_nacimiento, string grupo, PictureBox pic_captura, Form principal)
        {
            string codigo_imagen = "";
            letrarandom = ' ';
            int num = 0;
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    num = objrandom.Next(20);
                    letrarandom = (char)(((int)'A') + objrandom.Next(9));
                    codigo_imagen += num.ToString() + letrarandom.ToString();
                }
                bool verificar = verificar_codigo_imagen(codigo_imagen);
                if (verificar == true)
                {
                    registrar_alumnos(matricula,nombres,apellidos,direccion,fecha_nacimiento,grupo,pic_captura,principal);
                }
                else if (verificar == false)
                {
                    string imagen_bd = @"C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/" + codigo_imagen + ".jpg";
                    string path_save = path + codigo_imagen + ".jpg";
                    string query = "INSERT INTO `tb_alumnos`(`matricula`, `nombres`, `apellidos`, `fecha_nacimiento`, `direccion`, `grupo`, `estatus`,`foto_perfil`) VALUES ('" + matricula + "'," + "'" + nombres + "'" + "," + "'" + apellidos + "'" + "," + "'" + fecha_nacimiento + "'" + "," + "'" + direccion + "'" + "," + "'" + grupo + "'" + "," + "'" + "1" + "'" + "," + "'" + imagen_bd + "')";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    try
                    {
                        pic_captura.Image.Save(path_save, ImageFormat.Jpeg);
                        MessageBox.Show("Se registro al alumno correctamente");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("se registro al alumno pero ocurrio un problema al guardar la imagen, comuniquese con el equipo de sistemas");
                    }
                    principal.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }

        }
        public void modificar_alumno(string matricula,string nombre,string apellidos,string direccion,string fecha,string grupo,string estatus, PictureBox pic_captura,Form principal)
        {
            try
            {
                string resul_parentesco = "";
                string resul_estatus = "";
                string id_alumno = alumnos[0, index].Value.ToString();
                if (conservar_modificar_imagen == true)
                {
                   
                    if (estatus == "Activo")
                    {
                        resul_estatus = "1";
                    }
                    if (estatus == "Inactivo")
                    {
                        resul_estatus = "2";
                    }
                    string query = "UPDATE `tb_alumnos` SET `matricula`= " + "'" + matricula + "'," + "`nombres`= " + "'" + nombre + "'," + "`apellidos`= " + "'" + apellidos + "'," + "`direccion`= " + "'" + direccion + "',"  + "`fecha_nacimiento`= " + "'" + fecha + "'," + "`grupo`= " + "'" + grupo + "'," + "`estatus`= " + "'" + resul_estatus + "'" + "WHERE id_alumno = " + "'" + id_alumno + "'";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Se modifico al alumno correctamente");
                    principal.Close();

                }
                else if (conservar_modificar_imagen == false)
                {
                    if (pic_captura.Image == null)
                    {
                        MessageBox.Show("No se a tomado la nueva foto, tome la nueva foto para poder continuar. \nsi quiere conservar la imagen que tiene el tutor, seleccione conservar imagen.");
                    }
                    else
                    {
                        string codigo_imagen = "";
                        letrarandom = ' ';
                        int num = 0;
                        for (int i = 0; i < 6; i++)
                        {
                            num = objrandom.Next(20);
                            letrarandom = (char)(((int)'A') + objrandom.Next(9));
                            codigo_imagen += num.ToString() + letrarandom.ToString();
                        }
                        bool verificar_codigo = verificar_codigo_imagen(codigo_imagen);
                        if (verificar_codigo == true)
                        {
                            modificar_alumno(matricula,nombre, apellidos, direccion, fecha, grupo, estatus, pic_captura, principal);
                        }
                        else if (verificar_codigo == false)
                        {
                            string imagen_bd = @"C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/" + codigo_imagen + ".jpg";
                            string path_save = path + codigo_imagen + ".jpg";
                            if (estatus == "Activo")
                            {
                                resul_estatus = "1";
                            }
                            if (estatus == "Inactivo")
                            {
                                resul_estatus = "2";
                            }
                            string query = "UPDATE `tb_alumnos` SET `matricula`= " + "'" + matricula + "'," + "`nombres`= " + "'" + nombre + "'," + "`apellidos`= " + "'" + apellidos + "'," + "`direccion`= " + "'" + direccion + "'," + "`fecha_nacimiento`= " + "'" + fecha + "'," + "`grupo`= " + "'" + grupo + "'," + "`estatus`= " + "'" + resul_estatus + "'" + "," + "`foto_perfil`= " + "'" + imagen_bd + "'" + "WHERE id_alumno = " + "'" + id_alumno + "'";
                            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                            commandDatabase.CommandTimeout = 60;
                            MySqlDataReader reader;
                            databaseConnection.Open();
                            reader = commandDatabase.ExecuteReader();
                            try
                            {
                                File.Delete(alumnos[8, index].Value.ToString());
                                pic_captura.Image.Save(path_save, ImageFormat.Jpeg);
                                MessageBox.Show("Se modifico al alumno correctamente");
                            }
                            catch (Exception)
                            {

                                MessageBox.Show("se modifico al alumno pero ocurrio un problema al guardar la imagen, comuniquese con el equipo de sistemas");
                            }
                            principal.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
        }
        public void eliminar_alumno()
        {
            try
            {
                string query = "UPDATE `tb_alumnos` SET `estatus` = '2' WHERE id_alumno = " + "'" + alumnos[0, index].Value.ToString() + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Se elimino al alumno");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
        }
        private bool verificar_codigo_imagen(string codigo)
        {
            bool verificar = false;
            string query = "SELECT * FROM tb_padres WHERE foto_perfil =" + "'" + codigo + "'";
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
                    verificar = true;
                }
            }

            return verificar;
        }

        public void tutores_asignados()
        {
            string query = "SELECT * FROM tb_padres WHERE estatus = '1'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();               
        }
    }
}
