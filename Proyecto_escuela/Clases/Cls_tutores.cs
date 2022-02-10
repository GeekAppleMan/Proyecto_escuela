using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging;
using System.IO;

namespace Proyecto_escuela
{
    class Cls_tutores : Cls_conexion
    {
        private string path = @"C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/";
        public static bool conservar_modificar_imagen { get; set; }
        public static DataGridView tutores;
        private Random objrandom = new Random();
        private char letrarandom;
        public static int index { get; set; }
        public void cargar_tutores(string nombre, DataGridView grid)
        {
            string tutor = "";
            string estatus = "";
            if (nombre == "")
            {
                grid.Rows.Clear();
                string query = "SELECT * FROM tb_padres WHERE estatus = '1'";
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
                            tutor = "Padre";
                        }
                        if (reader.GetString(7) == "2")
                        {
                            tutor = "Madre";
                        }
                        if (reader.GetString(7) == "3")
                        {
                            tutor = "Tutor";
                        }
                        if (reader.GetString(8) == "1")
                        {
                            estatus = "Activo";
                        }
                        if (reader.GetString(8) == "2")
                        {
                            estatus = "Inactivo";
                        }
                        grid.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),reader.GetString(5),reader.GetString(6),tutor,estatus, reader.GetString(0), reader.GetString(9));
                        tutores = grid;
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro al tutor");
                }

                databaseConnection.Close();
            }
            else
            {
                grid.Rows.Clear();
                string query = "SELECT * FROM tb_padres WHERE nombres LIKE " + "'%" + nombre + "%'";
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
                            tutor = "Padre";
                        }
                        if (reader.GetString(7) == "2")
                        {
                            tutor = "Madre";
                        }
                        if (reader.GetString(7) == "3")
                        {
                            tutor = "Tutor";
                        }
                        if (reader.GetString(8) == "1")
                        {
                            estatus = "Activo";
                        }
                        if (reader.GetString(8) == "2")
                        {
                            estatus = "Inactivo";
                        }
                        grid.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), tutor, estatus, reader.GetString(0), reader.GetString(9));
                        tutores = grid;
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro el alumno");
                }

                databaseConnection.Close();
            }

        }
        public void registrar_tutores(string nombres, string apellidos, string direcciones, string telefono, string correo, string fecha_nacimiento, string parentesco,PictureBox pic_captura,Form principal)
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
                    registrar_tutores(nombres, apellidos, direcciones, telefono, correo, fecha_nacimiento, parentesco, pic_captura, principal);
                }
                else if(verificar == false)
                {
                    string resul_parentesco = "";
                    switch (parentesco)
                    {
                        case "Padre":
                            resul_parentesco = "1";
                            break;
                        case "Madre":
                            resul_parentesco = "2";
                            break;
                        case "Tutor":
                            resul_parentesco = "3";
                            break;
                        default:
                            break;
                    }
                    string imagen_bd = @"C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/" + codigo_imagen + ".jpg";
                    string path_save = path + codigo_imagen + ".jpg";
                    string query = "INSERT INTO `tb_padres`(`id_tutor`, `nombres`, `apellidos`, `direccion`, `telefono`, `correo`, `fecha_nacimiento`, `parentesco`, `estatus` ,`foto_perfil`) VALUES ('" + "" + "'," + "'" + nombres + "'" + "," + "'" + apellidos + "'" + "," + "'" + direcciones + "'" + "," + "'" + telefono + "'" + "," + "'" + correo + "'" + "," + "'" + fecha_nacimiento + "'" + "," + "'" + resul_parentesco + "'" + "," + "'1'" + "," + "'" + imagen_bd + "')";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    try
                    {
                        pic_captura.Image.Save(path_save, ImageFormat.Jpeg);
                        MessageBox.Show("Se registro al tutor correctamente");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("se registro al tutor pero ocurrio un problema al guardar la imagen, comuniquese con el equipo de sistemas");
                    }
                    principal.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
           
        }
        public void modificar_tutores(string nombres, string apellidos, string direcciones, string telefono, string correo, string fecha_nacimiento, string parentesco,string estatus, PictureBox pic_captura, Form principal, bool verificar)
        {
            try
            {
                string resul_parentesco = "";
                string resul_estatus = "";
                string id_tutor = tutores[8,index].Value.ToString();
                if (conservar_modificar_imagen == true)
                {
                    switch (parentesco)
                    {
                        case "Padre":
                            resul_parentesco = "1";
                            break;
                        case "Madre":
                            resul_parentesco = "2";
                            break;
                        case "Tutor":
                            resul_parentesco = "3";
                            break;
                        default:
                            break;
                    }
                    if (estatus == "Activo")
                    {
                        resul_estatus = "1";
                    }
                    if (estatus == "Inactivo")
                    {
                        resul_estatus = "2";
                    }
                    string query = "UPDATE `tb_padres` SET `nombres`= " + "'" + nombres + "'," + "`apellidos`= " + "'" + apellidos + "'," + "`direccion`= " + "'" + direcciones + "'," + "`telefono`= " + "'" + telefono + "'," + "`correo`= " + "'" + correo + "'," + "`fecha_nacimiento`= " + "'" + fecha_nacimiento + "'," + "`parentesco`= " + "'" + resul_parentesco + "'," + "`estatus`= " + "'" + resul_estatus + "'" + "WHERE id_tutor = " + "'" + id_tutor + "'";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Se modifico al tutor correctamente");
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
                            modificar_tutores(nombres, apellidos, direcciones, telefono, correo, fecha_nacimiento, parentesco, estatus, pic_captura, principal, verificar);
                        }
                        else if (verificar_codigo == false)
                        {
                            string imagen_bd = @"C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/" + codigo_imagen + ".jpg";
                            string path_save = path + codigo_imagen + ".jpg";
                            switch (parentesco)
                            {
                                case "Padre":
                                    resul_parentesco = "1";
                                    break;
                                case "Madre":
                                    resul_parentesco = "2";
                                    break;
                                case "Tutor":
                                    resul_parentesco = "3";
                                    break;
                                default:
                                    break;
                            }
                            if (estatus == "Activo")
                            {
                                resul_estatus = "1";
                            }
                            if (estatus == "Inactivo")
                            {
                                resul_estatus = "2";
                            }
                            string query = "UPDATE `tb_padres` SET `nombres`= " + "'" + nombres + "'," + "`apellidos`= " + "'" + apellidos + "'," + "`direccion`= " + "'" + direcciones + "'," + "`telefono`= " + "'" + telefono + "'," + "`correo`= " + "'" + correo + "'," + "`fecha_nacimiento`= " + "'" + fecha_nacimiento + "'," + "`parentesco`= " + "'" + resul_parentesco + "'," + "`estatus`= " + "'" + resul_estatus + "'," + "`foto_perfil`= " + "'" + imagen_bd + "'" + "WHERE id_tutor = " + "'" + id_tutor + "'";
                            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                            commandDatabase.CommandTimeout = 60;
                            MySqlDataReader reader;
                            databaseConnection.Open();
                            reader = commandDatabase.ExecuteReader();
                            try
                            {
                                File.Delete(tutores[9, index].Value.ToString());
                                pic_captura.Image.Save(path_save, ImageFormat.Jpeg);
                                MessageBox.Show("Se modifico al tutor correctamente");
                            }
                            catch (Exception)
                            {

                                MessageBox.Show("se modifico al tutor pero ocurrio un problema al guardar la imagen, comuniquese con el equipo de sistemas");
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
        public void eliminar_tutor()
        {
            try
            {
                string query = "UPDATE `tb_padres` SET `estatus` = '2' WHERE id_tutor = " + "'" + tutores[8, index].Value.ToString() + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Se elimino al tutor");
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
    }
}
