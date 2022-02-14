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
    public partial class Frm_credencial_tutor : Form
    {
        Cls_tutores obj_tutores = new Cls_tutores();
        Frm_Modificar_tutor obj_modificar = new Frm_Modificar_tutor();
        public static int rowindex { get; set; }
        public static DataGridView dgv { get; set; }
        public Frm_credencial_tutor()
        {
            InitializeComponent();
        }

        private void Frm_credencial_tutor_Load(object sender, EventArgs e)
        {
          
        }

        private void Frm_credencial_tutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            picture_imagen_perfil.Image = null;
        }

        private void btn_Asignar_alumno_Click(object sender, EventArgs e)
        {
            new Frm_Asignacion_de_tutor().ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Cls_tutores.index = rowindex;
            obj_modificar.txt_nombres.Text = dgv[0, rowindex].Value.ToString();
            obj_modificar.txt_apellidos.Text = dgv[1, rowindex].Value.ToString();
            obj_modificar.txt_direccion.Text = dgv[2, rowindex].Value.ToString();
            obj_modificar.txt_telefono.Text = dgv[3, rowindex].Value.ToString();
            obj_modificar.txt_correo.Text = dgv[4, rowindex].Value.ToString(); 
            obj_modificar.dtp_fecha_nacimiento.Text = dgv[5, rowindex].Value.ToString();
            obj_modificar.combo_parentesco.Text = dgv[6, rowindex].Value.ToString();
            obj_modificar.combo_estatus.Text = dgv[7, rowindex].Value.ToString();
            obj_modificar.ShowDialog();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            Cls_tutores.index = rowindex;
            obj_tutores.eliminar_tutor();
            this.Close();
        }
    }
}
