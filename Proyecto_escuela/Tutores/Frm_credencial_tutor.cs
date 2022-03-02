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
        public static string id_tutor { get; set; }
        public static int rowindex { get; set; }
        public static DataGridView dgv { get; set; }
        public static Form frm_credencial { get; set; }
        public Frm_credencial_tutor()
        {
            InitializeComponent();
        }

        private void Frm_credencial_tutor_Load(object sender, EventArgs e)
        {
            if (Clases.Cls_Login.rol == "1")
            {
                btn_baja.Enabled = true;
                btn_modificar.Enabled = true;
                btn_alumnos.Enabled = true; 
                btn_Asignar_alumno.Enabled = true;
            }
            if (Clases.Cls_Login.rol == "2")
            {
                btn_baja.Enabled = false;
                btn_modificar.Enabled = false;
                btn_alumnos.Enabled = true;
                btn_Asignar_alumno.Enabled=false;
            }
            frm_credencial = this;
        }

        private void Frm_credencial_tutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            picture_imagen_perfil.Image = null;
        }

        private void btn_Asignar_alumno_Click(object sender, EventArgs e)
        {
            new Frm_Asignacion_de_alumno().ShowDialog();
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

        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            new Frm_alumnos_asignados().ShowDialog();
        }
    }
}
