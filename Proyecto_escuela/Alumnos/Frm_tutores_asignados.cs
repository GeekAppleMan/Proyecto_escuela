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
    public partial class Frm_tutores_asignados : Form
    {
        Cls_Alumnos obj_alumnos = new Cls_Alumnos();
        public static string id_alumno { get; set; } 
        public Frm_tutores_asignados()
        {
            InitializeComponent();
        }

        private void Frm_tutores_asignados_Load(object sender, EventArgs e)
        {
            obj_alumnos.tutores_asignados(id_alumno);
            obj_alumnos.cargar_tutores_asignados(dgv_tutor);
        }

        private void dgv_tutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                lbl_nombres_tutor.Text = dgv_tutor[0, e.RowIndex].Value.ToString();
                lbl_apellidos_tutor.Text = dgv_tutor[1, e.RowIndex].Value.ToString();
                lbl_direccion_tutor.Text = dgv_tutor[2, e.RowIndex].Value.ToString();
                lbl_telefono_tutor.Text = dgv_tutor[3, e.RowIndex].Value.ToString();
                lbl_correo_tutor.Text = dgv_tutor[4, e.RowIndex].Value.ToString();
                lbl_fecha_tutor.Text = dgv_tutor[5, e.RowIndex].Value.ToString();
                lbl_parentesco_tutor.Text = dgv_tutor[6, e.RowIndex].Value.ToString();
                lbl_estatus_tutor.Text = dgv_tutor[7, e.RowIndex].Value.ToString();
                string path = dgv_tutor[9, e.RowIndex].Value.ToString();
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
