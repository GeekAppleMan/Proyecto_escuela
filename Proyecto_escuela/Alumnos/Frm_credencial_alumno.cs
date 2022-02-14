using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela
{
    public partial class Frm_credencial_alumno : Form
    {
        Cls_Alumnos obj_alumnos = new Cls_Alumnos();
        Frm_modificar_alumno obj_modificar = new Frm_modificar_alumno();
        public static int rowindex { get; set; }
        public static DataGridView dgv { get; set; }

        public Frm_credencial_alumno()
        {
            InitializeComponent();
        }

        private void Frm_credencial_alumno_Load(object sender, EventArgs e)
        {

        }

        private void Frm_credencial_alumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            picture_imagen_perfil.Image = null;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Cls_Alumnos.index = rowindex;
            obj_modificar.txt_matricula.Text = dgv[1, rowindex].Value.ToString();
            obj_modificar.txt_nombres.Text = dgv[2, rowindex].Value.ToString();
            obj_modificar.txt_apellidos.Text = dgv[3, rowindex].Value.ToString();
            obj_modificar.dtp_fecha_nacimiento.Text = dgv[4, rowindex].Value.ToString();
            obj_modificar.txt_direccion.Text = dgv[5, rowindex].Value.ToString();
            obj_modificar.combo_grupo.Text = dgv[6, rowindex].Value.ToString();
            obj_modificar.combo_estatus.Text = dgv[7, rowindex].Value.ToString();
            obj_modificar.ShowDialog();
          
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            Cls_Alumnos.index = rowindex;
            obj_alumnos.eliminar_alumno();
            this.Close();
        }

        private void btn_Asignar_tutor_Click(object sender, EventArgs e)
        {
            new Frm_tutores_asignados().ShowDialog();
        }
    }
}
