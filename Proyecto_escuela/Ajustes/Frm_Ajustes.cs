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
    public partial class Frm_Ajustes : Form
    {
        public static Color color { get; set; }
        public static Color color_letra { get; set; }
        public Frm_Ajustes()
        {
            InitializeComponent();
        }

        private void cambiar_color_menu()
        {
            Frm_main.panel_izquierda.BackColor = color;
            Frm_main.menu_arriba.BackColor = color;
        }
        private void cambiar_color_letra()
        {
            Frm_main.menu_arriba.ForeColor = color_letra;
            Frm_main.btn_tutor.ForeColor = color_letra;
            Frm_main.btn_alumno.ForeColor = color_letra;
            Frm_main.btn_usuario.ForeColor = color_letra;
            Frm_main.btn_empleados.ForeColor = color_letra;
            Frm_main.btn_salidas_menu.ForeColor = color_letra;
            Frm_main.btn_cerrar.ForeColor = color_letra;
            Frm_main.btn_ajustes_menu.ForeColor = color_letra;
            Frm_main.btn_tutor_strip.ForeColor = color_letra;
            Frm_main.btn_alumno_strip.ForeColor = color_letra;
            Frm_main.btn_usuario_strip.ForeColor = color_letra;
            Frm_main.btn_empleados_strip.ForeColor = color_letra;
            Frm_main.btn_salidas_menu_strip.ForeColor = color_letra;
            Frm_main.btn_cerrar_strip.ForeColor = color_letra;
            Frm_main.btn_ajustes_menu_strip.ForeColor = color_letra;
            Frm_main.lbl_jane_2.ForeColor = color_letra;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rdb_izquierda.Checked = true;
            rdb_arriba.Checked = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rdb_izquierda.Checked = false;
            rdb_arriba.Checked = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_rojo_Click(object sender, EventArgs e)
        {
            colorDialog_menu.ShowDialog();
            if (colorDialog_menu.Color == null)
            {

            }
            else
            {
                color = colorDialog_menu.Color;
                btn_select_color_menu.BackColor = colorDialog_menu.Color;
                cambiar_color_menu();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog_letras.ShowDialog();
            if (colorDialog_letras.Color == null)
            {

            }
            else
            {
                color_letra = colorDialog_letras.Color;
                btn_select_color_letra.BackColor = colorDialog_letras.Color;
                cambiar_color_letra();
            }
        }
              
        private void rdb_izquierda_CheckedChanged(object sender, EventArgs e)
        {
            Frm_main.panel_izquierda.Visible = true;
            Frm_main.menu_arriba.Visible = false;
        }

        private void rdb_arriba_CheckedChanged(object sender, EventArgs e)
        {

            Frm_main.panel_izquierda.Visible = false;
            Frm_main.menu_arriba.Visible = true;
        }

        private void Frm_Ajustes_Load(object sender, EventArgs e)
        {
            try
            {
                if (color.Name == "0" && color_letra.Name == "0")
                {
                    btn_select_color_menu.BackColor = Color.FromArgb(0, 122, 204);
                    btn_select_color_letra.BackColor = Color.FromArgb(0, 122, 204);
                }
                else
                {
                    btn_select_color_menu.BackColor = color;
                    btn_select_color_letra.BackColor = color_letra;
                }
            }
            catch (Exception)
            {

            }
           
        }
    }
}
