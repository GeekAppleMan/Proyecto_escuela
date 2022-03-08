using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela
{
    public partial class Frm_tutores : Form
    {
        Cls_tutores obj_tutores = new Cls_tutores();
        Frm_credencial_tutor obj_credencial = new Frm_credencial_tutor();
        Frm_Modificar_tutor obj_modificar = new Frm_Modificar_tutor();
        public Frm_tutores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_registrar_tutores obj_registrar = new Frm_registrar_tutores();
            obj_registrar.ShowDialog();
            cargar_tutores();
        }

        private void Frm_tutores_Load(object sender, EventArgs e)
        {
            if (Clases.Cls_Login.rol == "1")
            {
                btn_registrar_tutor.Visible = true;
            }
            if (Clases.Cls_Login.rol == "2")
            {
                btn_registrar_tutor.Visible = false;
            }
            cargar_tutores();
        }

        private void cargar_tutores()
        {
            obj_tutores.cargar_tutores(txt_tutor.Text,dgv_tutor);
        }

        private void txt_tutor_TextChanged(object sender, EventArgs e)
        {
            cargar_tutores();
        }

        private void dgv_tutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_credencial_tutor.dgv = dgv_tutor;
            if (e.RowIndex == -1)
            {

            }
            else
            {
                if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
                {
                    Frm_credencial_tutor.id_tutor = dgv_tutor[8, e.RowIndex].Value.ToString();
                    Frm_Asignacion_de_alumno.Id_tutor = dgv_tutor[8, e.RowIndex].Value.ToString();
                    Frm_credencial_tutor.rowindex = e.RowIndex;
                    obj_credencial.lbl_nombres_tutor.Text = "Nombres: " + dgv_tutor[0, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_apellidos_tutor.Text = "Apellidos: " + dgv_tutor[1, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_direccion_tutor.Text = "Direccion: " + dgv_tutor[2, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_telefono_tutor.Text = "Telefono: " + dgv_tutor[3, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_correo_tutor.Text = "Correo: " + dgv_tutor[4, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_fecha_tutor.Text = "Nacimiento: " + dgv_tutor[5, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_parentesco_tutor.Text = "Parentesco: " + dgv_tutor[6, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_estatus_tutor.Text = "Estatus: " + dgv_tutor[7, e.RowIndex].Value.ToString();
                    string path = dgv_tutor[9, e.RowIndex].Value.ToString();
                    if (path == "")
                    {
                        obj_credencial.picture_imagen_perfil.Image = null;
                    }
                    else
                    {
                        try
                        {
                            var request = WebRequest.Create(path);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                obj_credencial.picture_imagen_perfil.Image = Bitmap.FromStream(stream);
                                System.Drawing.Image img = obj_credencial.picture_imagen_perfil.Image;
                                //img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                obj_credencial.picture_imagen_perfil.Image = img;
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                    obj_credencial.ShowDialog();
                    cargar_tutores();
                }
                //if (e.ColumnIndex == 10)
                //{
                //    Cls_tutores.index = e.RowIndex;
                //    obj_modificar.txt_nombres.Text = dgv_tutor[0, e.RowIndex].Value.ToString();
                //    obj_modificar.txt_apellidos.Text = dgv_tutor[1, e.RowIndex].Value.ToString();
                //    obj_modificar.txt_direccion.Text = dgv_tutor[2, e.RowIndex].Value.ToString();
                //    obj_modificar.txt_telefono.Text = dgv_tutor[3, e.RowIndex].Value.ToString();
                //    obj_modificar.txt_correo.Text = dgv_tutor[4, e.RowIndex].Value.ToString();
                //    obj_modificar.dtp_fecha_nacimiento.Text = dgv_tutor[5, e.RowIndex].Value.ToString();
                //    obj_modificar.combo_parentesco.Text = dgv_tutor[6, e.RowIndex].Value.ToString();
                //    obj_modificar.combo_estatus.Text = dgv_tutor[7, e.RowIndex].Value.ToString();
                //    obj_modificar.ShowDialog();
                //    cargar_tutores();
                //}
                //if (e.ColumnIndex == 11)
                //{
                //    Cls_tutores.index = e.RowIndex;
                //    obj_tutores.eliminar_tutor();
                //    cargar_tutores();
                //}
            }
           
        }
    }
}
