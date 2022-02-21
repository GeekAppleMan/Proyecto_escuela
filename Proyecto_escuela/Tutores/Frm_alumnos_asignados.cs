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
    public partial class Frm_alumnos_asignados : Form
    {
        Cls_tutores obj_tutores = new Cls_tutores();
        public Frm_alumnos_asignados()
        {
            InitializeComponent();
        }

        private void Frm_alumnos_asignados_Load(object sender, EventArgs e)
        {
            obj_tutores.alumnos_asignados(Frm_credencial_tutor.id_tutor);
            obj_tutores.cargar_alumnos_asignados(dgv_alumno);
        }

        private void dgv_alumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                lbl_matricula_alumno.Text = dgv_alumno[1, e.RowIndex].Value.ToString();
                lbl_nombres_alumno.Text = dgv_alumno[2, e.RowIndex].Value.ToString();
                lbl_apellidos_alumno.Text = dgv_alumno[3, e.RowIndex].Value.ToString();
                lbl_fecha_alumno.Text = dgv_alumno[4, e.RowIndex].Value.ToString();
                lbl_direccion_alumno.Text = dgv_alumno[5, e.RowIndex].Value.ToString();
                lbl_grupo_alumno.Text = dgv_alumno[6, e.RowIndex].Value.ToString();
                lbl_estatus_alumno.Text = dgv_alumno[7, e.RowIndex].Value.ToString();
                string path = dgv_alumno[8, e.RowIndex].Value.ToString();
                if (path == "")
                {
                    picture_imagen_perfil.Image = null;
                }
                else
                {
                    try
                    {
                        var request = WebRequest.Create(path);
                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            picture_imagen_perfil.Image = Bitmap.FromStream(stream);
                            System.Drawing.Image img = picture_imagen_perfil.Image;
                            //img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            picture_imagen_perfil.Image = img;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }
}
