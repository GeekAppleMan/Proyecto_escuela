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
    public partial class Frm_Alumnos : Form
    {
        Cls_Alumnos obj_alumnos = new Cls_Alumnos();
        Frm_modificar_alumno obj_modificar = new Frm_modificar_alumno();
        Frm_credencial_alumno obj_credencial = new Frm_credencial_alumno();
        public Frm_Alumnos()
        {
            InitializeComponent();
        }

        private void Frm_Alumnos_Load(object sender, EventArgs e)
        {
            cargar_alumno();
        }

        private void cargar_alumno()
        {
            obj_alumnos.cargar_alumnos(txt_alumno.Text,dgv_alumno);
        }

        private void txt_alumno_TextChanged(object sender, EventArgs e)
        {
            cargar_alumno();
        }

        private void dgv_alumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
                {
                    obj_credencial.lbl_matricula_alumno.Text = dgv_alumno[1, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_nombres_alumno.Text = dgv_alumno[2, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_apellidos_alumno.Text = dgv_alumno[3, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_fecha_alumno.Text = dgv_alumno[4, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_direccion_alumno.Text = dgv_alumno[5, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_grupo_alumno.Text = dgv_alumno[6, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_estatus_alumno.Text = dgv_alumno[7, e.RowIndex].Value.ToString();
                    string path = dgv_alumno[8, e.RowIndex].Value.ToString();
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
                    cargar_alumno();
                }
                if (e.ColumnIndex == 9)
                {
                    Cls_Alumnos.index = e.RowIndex;
                    obj_modificar.txt_matricula.Text = dgv_alumno[1, e.RowIndex].Value.ToString();
                    obj_modificar.txt_nombres.Text = dgv_alumno[2, e.RowIndex].Value.ToString();
                    obj_modificar.txt_apellidos.Text = dgv_alumno[3, e.RowIndex].Value.ToString();
                    obj_modificar.dtp_fecha_nacimiento.Text = dgv_alumno[4, e.RowIndex].Value.ToString();
                    obj_modificar.txt_direccion.Text = dgv_alumno[5, e.RowIndex].Value.ToString();
                    obj_modificar.combo_grupo.Text = dgv_alumno[6, e.RowIndex].Value.ToString();
                    obj_modificar.combo_estatus.Text = dgv_alumno[7, e.RowIndex].Value.ToString();
                    obj_modificar.ShowDialog();
                    cargar_alumno();
                }
                if (e.ColumnIndex == 10)
                {
                    Cls_Alumnos.index = e.RowIndex;
                    obj_alumnos.eliminar_alumno();
                    cargar_alumno();
                }
            }
        }

        private void btn_registrar_alumno_Click(object sender, EventArgs e)
        {
            Frm_registrar_alumno obj_registrar = new Frm_registrar_alumno();
            obj_registrar.ShowDialog();
            cargar_alumno();
        }

        private void dgv_alumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
