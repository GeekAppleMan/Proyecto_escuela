using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Clases
{
    class Cls_empleados : Cls_conexion
    {
        private string path = Application.StartupPath + @"\Imagenes\";
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
                        grid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), resul_rol, resul_estatus, reader.GetString(8),reader.GetString(11));
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
                        grid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), resul_rol, resul_estatus, reader.GetString(8),reader.GetString(11));
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
        public void registrar_empleados(string matricula, string nombres, string apellidos, string fecha_nacimiento, string direccion, string correo, string telefono, string rol, PictureBox pic_captura, Form principal)
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
                    registrar_empleados(matricula, nombres, apellidos, fecha_nacimiento, direccion, correo, telefono, rol, pic_captura, principal);
                }
                else if (verificar == false)
                {
                    string resul_rol = "";
                    switch (rol)
                    {
                        case "Administrador":
                            resul_rol = "1";
                            break;
                        case "Basico":
                            resul_rol = "2";
                            break;
                        default:
                            break;
                    }
                    string imagen_bd = @"http://189.204.133.38:8081/imagenes_escuela/imagenes_empleados/" + codigo_imagen + ".jpg";
                    string path_save = path + codigo_imagen + ".jpg";
                    string query = "INSERT INTO `tb_empleados`(`id_empleado`, `matricula`, `nombres`, `apellidos`, `fecha_nacimiento`, `direccion`, `correo`, `telefono`, `foto_perfil`, `rol`, `estatus`,`codigo_imagen`)VALUES ('" + "" + "'," + "'" + matricula + "'," + "'" + nombres + "'," + "'" + apellidos + "'," + "'" + fecha_nacimiento + "'," + "'" + direccion + "'," + "'" + correo + "'," + "'" + telefono + "'," + "'" + imagen_bd + "'," + "'" + resul_rol + "'," + "'" + "1"  + "'" + "," + "'" + codigo_imagen + "')";
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    try
                    {
                        pic_captura.Image.Save(path_save, ImageFormat.Jpeg);
                        byte[] data;
                        using (Image image = Image.FromFile(path_save))
                        {
                            using (MemoryStream m = new MemoryStream())
                            {
                                image.Save(m, image.RawFormat);
                                data = m.ToArray();
                            }
                        }
                        FTPHelpler fTPHelper = new FTPHelpler("ftp://189.204.133.38/imagenes_empleados", "escuela", "escuela2022");
                        fTPHelper.Upload(new MemoryStream(data), codigo_imagen + ".jpg");
                        MessageBox.Show("Se registro al empleado correctamente");
                        File.Delete(path_save);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("se registro al empleado pero ocurrio un problema al guardar la imagen, comuniquese con el equipo de sistemas");
                    }
                    principal.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }

        }
        private bool verificar_codigo_imagen(string codigo)
        {
            bool verificar = false;
            try
            {
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
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
            return verificar;
        }
        public void eliminar_empleado()
        {
            try
            {
                string query = "UPDATE `tb_empleados` SET `estatus` = '2' WHERE id_empleado = " + "'" + empleados[0, index].Value.ToString() + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Se elimino al tutor");
                Frm_credencial_empleado.frm_credencial.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }

        }
        public void modificar_empleados(string nombres, string apellidos, string direcciones, string telefono, string correo, string fecha_nacimiento, string rol, string estatus, PictureBox pic_captura, Form principal, bool verificar)
        {
            try
            {
                string resul_estatus = "";
                string id_empleado = empleados[0, index].Value.ToString();
                if (conservar_modificar_imagen == true)
                {
                    string resul_rol = "";
                    switch (rol)
                    {
                        case "Administrador":
                            resul_rol = "1";
                            break;
                        case "Basico":
                            resul_rol = "2";
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
                    string query = "UPDATE `tb_empleados` SET `nombres`= " + "'" + nombres + "'," + "`apellidos`= " + "'" + apellidos + "'," + "`direccion`= " + "'" + direcciones + "'," + "`telefono`= " + "'" + telefono + "'," + "`correo`= " + "'" + correo + "'," + "`fecha_nacimiento`= " + "'" + fecha_nacimiento + "'," + "`rol`= " + "'" + resul_rol + "'," + "`estatus`= " + "'" + resul_estatus + "'" + "WHERE id_empleado = " + "'" + id_empleado + "'";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Se modifico al empleado correctamente");
                    buscar_id_usuario(id_empleado, correo, telefono);
                    principal.Close();
                    Frm_credencial_empleado.frm_credencial.Close();

                }
                else if (conservar_modificar_imagen == false)
                {
                    if (pic_captura.Image == null)
                    {
                        MessageBox.Show("No se a tomado la nueva foto, tome la nueva foto para poder continuar. \nsi quiere conservar la imagen que tiene el empleado, seleccione conservar imagen.");
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
                            modificar_empleados(nombres, apellidos, direcciones, telefono, correo, fecha_nacimiento, rol, estatus, pic_captura, principal, verificar);
                        }
                        else if (verificar_codigo == false)
                        {
                            string imagen_bd = @"http://189.204.133.38:8081/imagenes_escuela/imagenes_empleados/" + codigo_imagen + ".jpg";
                            string path_save = path + codigo_imagen + ".jpg";
                            string resul_rol = "";
                            switch (rol)
                            {
                                case "Administrador":
                                    resul_rol = "1";
                                    break;
                                case "Basico":
                                    resul_rol = "2";
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
                            string query = "UPDATE `tb_empleados` SET `nombres`= " + "'" + nombres + "'," + "`apellidos`= " + "'" + apellidos + "'," + "`direccion`= " + "'" + direcciones + "'," + "`telefono`= " + "'" + telefono + "'," + "`correo`= " + "'" + correo + "'," + "`fecha_nacimiento`= " + "'" + fecha_nacimiento + "'," + "`rol`= " + "'" + resul_rol + "'," + "`estatus`= " + "'" + resul_estatus + "'," + "`foto_perfil`= " + "'" + imagen_bd + "'" + "," + "`codigo_imagen`= " + "'" + codigo_imagen + "'" + "WHERE id_empleado = " + "'" + id_empleado + "'";
                            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                            commandDatabase.CommandTimeout = 60;
                            MySqlDataReader reader;
                            databaseConnection.Open();
                            reader = commandDatabase.ExecuteReader();
                            try
                            {
                                pic_captura.Image.Save(path_save, ImageFormat.Jpeg);
                                byte[] data;
                                using (Image image = Image.FromFile(path_save))
                                {
                                    using (MemoryStream m = new MemoryStream())
                                    {
                                        image.Save(m, image.RawFormat);
                                        data = m.ToArray();
                                    }
                                }
                                FTPHelpler fTPHelper = new FTPHelpler("ftp://189.204.133.38/imagenes_empleados", "escuela", "escuela2022");
                                fTPHelper.Upload(new MemoryStream(data), codigo_imagen + ".jpg");
                                fTPHelper.Delete(empleados[11, index].Value.ToString() + ".jpg");
                                File.Delete(path_save);
                                MessageBox.Show("Se modifico al empleado correctamente");
                                buscar_id_usuario(id_empleado, correo, telefono);
                                principal.Close();
                                Frm_credencial_empleado.frm_credencial.Close();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("se modifico al empleado pero ocurrio un problema al guardar la imagen, comuniquese con el equipo de sistemas");
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
        private void buscar_id_usuario(string id_empleado, string correo, string telefono)
        {
            string query = "Select id_usuario From tb_empleados_usuarios WHERE id_empleado = " + "'" + id_empleado + "'";
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
                    modificar_usuario(reader.GetString(0), correo, telefono);
                }
            }
            else
            {
                Console.WriteLine("No se encontro al empleado");
            }

            databaseConnection.Close();
        }  

        private void modificar_usuario(string id_usuario, string correo, string telefono)
        {
            try
            {
                string query = "UPDATE `tb_registro` SET `correo`= " + "'" + correo + "'," + "`telefono`= " + "'" + telefono + "'" + "WHERE id_usuario = " + "'" + id_usuario + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
            }
            catch (Exception)
            {
            }
          
        }
    }
}
