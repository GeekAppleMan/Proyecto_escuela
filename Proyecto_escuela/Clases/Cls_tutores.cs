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
using System.Drawing;

namespace Proyecto_escuela
{
    class Cls_tutores : Cls_conexion
    {
        private string path = Application.StartupPath + @"\Imagenes\";
        public static bool conservar_modificar_imagen { get; set; }
        public static DataGridView tutores;
        private Random objrandom = new Random();
        private char letrarandom;
        public static int index { get; set; }
        public static DataGridView alumnos { get; set; }
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
                        grid.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),reader.GetString(5),reader.GetString(6),tutor,estatus, reader.GetString(0), reader.GetString(9),reader.GetString(10));
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
                        grid.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), tutor, estatus, reader.GetString(0), reader.GetString(9),reader.GetString(10));
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
                    string imagen_bd = @"http://189.204.133.38:8081/imagenes_escuela/imagenes_tutores/" + codigo_imagen + ".jpg";
                    string path_save = path + codigo_imagen + ".jpg";
                    string query = "INSERT INTO `tb_padres`(`id_tutor`, `nombres`, `apellidos`, `direccion`, `telefono`, `correo`, `fecha_nacimiento`, `parentesco`, `estatus` ,`foto_perfil`,`codigo_imagen`) VALUES ('" + "" + "'," + "'" + nombres + "'" + "," + "'" + apellidos + "'" + "," + "'" + direcciones + "'" + "," + "'" + telefono + "'" + "," + "'" + correo + "'" + "," + "'" + fecha_nacimiento + "'" + "," + "'" + resul_parentesco + "'" + "," + "'1'" + "," + "'" + imagen_bd + "'" + "," + "'" + codigo_imagen + "')";
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
                        FTPHelpler fTPHelper = new FTPHelpler("ftp://189.204.133.38/imagenes_tutores", "escuela", "escuela2022");
                        fTPHelper.Upload(new MemoryStream(data), codigo_imagen + ".jpg");
                        MessageBox.Show("Se registro al tutor correctamente");
                        File.Delete(path_save);
                        buscar_id_tutor(correo,telefono);
                        principal.Close();
                        new Frm_Asignacion_de_alumno().ShowDialog();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("se registro al tutor pero ocurrio un problema al guardar la imagen, comuniquese con el equipo de sistemas");
                        principal.Close();
                        buscar_id_tutor(correo, telefono);
                        new Frm_Asignacion_de_alumno().ShowDialog();
                    }
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El numero de telefono no puede ser uno ya asignado a otro tutor,si el error persiste comuniquese con el equipo de sistemas");
            }
           
        }
        public void buscar_id_tutor(string correo, string telefono)
        {
            string query = "SELECT * FROM tb_padres WHERE correo = " + "'" + correo + "'" + "AND telefono= " + "'" + telefono + "'";
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
                    Frm_Asignacion_de_alumno.Id_tutor = reader.GetString(0);
                }
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
                    Frm_credencial_tutor.frm_credencial.Close();

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
                            string imagen_bd = @"http://189.204.133.38:8081/imagenes_escuela/imagenes_tutores/" + codigo_imagen + ".jpg";
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
                            string query = "UPDATE `tb_padres` SET `nombres`= " + "'" + nombres + "'," + "`apellidos`= " + "'" + apellidos + "'," + "`direccion`= " + "'" + direcciones + "'," + "`telefono`= " + "'" + telefono + "'," + "`correo`= " + "'" + correo + "'," + "`fecha_nacimiento`= " + "'" + fecha_nacimiento + "'," + "`parentesco`= " + "'" + resul_parentesco + "'," + "`estatus`= " + "'" + resul_estatus + "'," + "`foto_perfil`= " + "'" + imagen_bd + "'" + "," + "`codigo_imagen`= " + "'" + codigo_imagen + "'" + "WHERE id_tutor = " + "'" + id_tutor + "'";
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
                                FTPHelpler fTPHelper = new FTPHelpler("ftp://189.204.133.38/imagenes_tutores", "escuela", "escuela2022");
                                fTPHelper.Upload(new MemoryStream(data), codigo_imagen + ".jpg");
                                fTPHelper.Delete(tutores[10, index].Value.ToString() + ".jpg");
                                File.Delete(path_save);
                                MessageBox.Show("Se modifico al tutor correctamente");
                            }
                            catch (Exception)
                            {

                                MessageBox.Show("se modifico al tutor pero ocurrio un problema al guardar la imagen, comuniquese con el equipo de sistemas");
                            }
                            principal.Close();
                            Frm_credencial_tutor.frm_credencial.Close();
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
                string query = "UPDATE `tb_padres` SET `estatus` = '2' WHERE id_tutor = " + "'" + Frm_credencial_tutor.id_tutor + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Se elimino al tutor");
                Frm_credencial_tutor.frm_credencial.Close();
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
        public void asignar_alumno(string matricula,DataGridView asignacion,TextBox matricula2)
        {
            try
            {
                string query = "SELECT * FROM tb_alumnos WHERE matricula = " + "'" + matricula + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();
                bool verificar_alumno_grid = false;
                bool verificar_alumno_bd = false;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        verificar_alumno_bd = verificar_asignacion_alumno(reader.GetString(0));
                        for (int i = 0; i < asignacion.Rows.Count; i++)
                        {
                            if (reader.GetString(0) == asignacion[0, i].Value.ToString())
                            {
                                verificar_alumno_grid = true;
                            }
                        }
                        if (verificar_alumno_grid == true)
                        {
                            MessageBox.Show("Ya agrego a su lista al alumno");
                        }
                        if (verificar_alumno_bd == true)
                        {
                            MessageBox.Show("Ya tiene asignado a este alumno");
                        }
                        else if(verificar_alumno_grid != true && verificar_alumno_bd != true)
                        {
                            asignacion.Rows.Add(reader.GetString(0), Frm_Asignacion_de_alumno.Id_tutor, reader.GetString(2), reader.GetString(3));
                            alumnos = asignacion;
                        }
                    }
                    matricula2.Text = "";
                }
                else
                {
                    MessageBox.Show("No se encontro al alumno verifica la matricula");
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
           
        }
        public bool verificar_asignacion_alumno(string id_alumno)
        {
            bool verificar = false;
            string query = "SELECT * FROM tb_relacion_tutor_alumno WHERE Tutor = " + "'" + Frm_Asignacion_de_alumno.Id_tutor + "'" + " AND Alumno = " + "'" + id_alumno + "'";
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
            databaseConnection.Close();
            return verificar;
        }
        public void registrar_asignacion_alumno()
        {
            try
            {
                for (int i = 0; i < alumnos.Rows.Count; i++)
                {
                    string tutor = alumnos[1, i].Value.ToString();
                    string alumno2 = alumnos[0, i].Value.ToString();
                    string query = "INSERT INTO `tb_relacion_tutor_alumno`(`Tutor`, `Alumno`) VALUES (" + "'" + tutor + "'" + ',' + "'" + alumno2 + "')";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                }
                MessageBox.Show("Se asignaron a los alumnos");
                alumnos.Rows.Clear();
                Frm_Asignacion_de_alumno.asignacion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }
        }

        private static DataTable ids_alumnos = new DataTable();
        public void alumnos_asignados(string tutor)
        {
            try
            {
                if (ids_alumnos.Columns.Count == 0)
                {
                    ids_alumnos.Columns.Add("id_alumno");
                }
                ids_alumnos.Rows.Clear();
                string query = "SELECT * FROM tb_relacion_tutor_alumno WHERE Tutor = " + "'" + tutor + "'";
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
                        ids_alumnos.Rows.Add(reader.GetString(2));
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }

        }

        public void cargar_alumnos_asignados(DataGridView alumnos)
        {
            try
            {
                string estatus = "";
                for (int i = 0; i < ids_alumnos.Rows.Count; i++)
                {
                    string query = "SELECT * FROM tb_alumnos WHERE id_alumno = " + "'" + ids_alumnos.Rows[i]["id_alumno"].ToString() + "'";
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
                            alumnos.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), estatus, reader.GetString(8));
                        }
                    }
                    databaseConnection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comuniquese con el equipo de sistemas");
            }

        }
    }

}
