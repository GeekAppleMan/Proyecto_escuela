using Proyecto_escuela.Empleados;
using Proyecto_escuela.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
            timer_fecha_hora.Enabled = true;
            timer_fecha_hora.Start();
            panel_barra_izquierda.Width = 150;
        }

        private void Frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer_fecha_hora.Stop();
            timer_fecha_hora.Enabled = false;
            Frm_Ajustes.color = Color.FromArgb(0, 122, 204);
            Frm_Ajustes.color_letra = Color.FromArgb(0, 122, 204);
            Frm_login obj_login = new Frm_login();
            obj_login.Show();
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_menu_Click_1(object sender, EventArgs e)
        {

            if (panel_barra_izquierda.Width == 150)
            {
                panel_barra_izquierda.Width = 50;
                btn_tutores.Text = "";
                btn_alumnos.Text = "";
                btn_usuarios.Text = "";
                btn_Empleados.Text = "";
                btn_salidas.Text = "";
                btn_cerrar_sesion.Text = "";
                btn_ajustes.Text = "";
                lbl_jane.Text = " JS";
                lbl_jane.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                panel_barra_izquierda.Width = 150;
                btn_tutores.Text = "Tutores";
                btn_alumnos.Text = "Alumnos";
                btn_usuarios.Text = "Usuarios";
                btn_Empleados.Text = "Empleados";
                btn_salidas.Text = "Salidas";
                btn_cerrar_sesion.Text = "Cerrar sesion";
                lbl_jane.Text = "Jane Software";
                btn_ajustes.Text = "Ajustes";
                lbl_jane.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void abrir_form(object formhijo)
        {
            if (this.panel_contenedor.Controls.Count == 0)
            {
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel_contenedor.Controls.Add(fh);
                this.panel_contenedor.Tag = fh;
                fh.Show();
            }
            else
            {
                this.panel_contenedor.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel_contenedor.Controls.Add(fh);
                this.panel_contenedor.Tag = fh;
                fh.Show();
            }
        }

        private void btn_tutores_Click(object sender, EventArgs e)
        {   
            abrir_form(new Frm_tutores());
            lbltitulo.Text = "Tutores";
            mostrar();
        }

        private void timer_fecha_hora_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString("d");
            lbl_hora.Text = DateTime.Now.ToString("t");
        }
        public static Panel panel_izquierda { get; set; }
        public static MenuStrip menu_arriba { get; set; }
        public static Label lbl_jane_2 { get; set; }
        public static Button btn_tutor { get; set; }
        public static Button btn_alumno { get; set; }
        public static Button btn_usuario { get; set; }
        public static Button btn_empleados { get; set; }
        public static Button btn_salidas_menu { get; set; }
        public static Button btn_cerrar { get; set; }
        public static Button btn_ajustes_menu { get; set; }
        public static ToolStripMenuItem btn_tutor_strip { get; set; }
        public static ToolStripMenuItem btn_alumno_strip { get; set; }
        public static ToolStripMenuItem btn_usuario_strip { get; set; }
        public static ToolStripMenuItem btn_empleados_strip { get; set; }
        public static ToolStripMenuItem btn_salidas_menu_strip { get; set; }
        public static ToolStripMenuItem btn_cerrar_strip { get; set; }
        public static ToolStripMenuItem btn_ajustes_menu_strip { get; set; }
        private void Frm_main_Load(object sender, EventArgs e)
        {
            lbl_jane_2 = lbl_jane;
            btn_tutor = btn_tutores;
            btn_alumno = btn_alumnos;
            btn_usuario = btn_usuarios;
            btn_empleados = btn_Empleados;
            btn_salidas_menu = btn_salidas;
            btn_cerrar = btn_cerrar_sesion;
            btn_ajustes_menu = btn_ajustes;
            btn_tutor_strip = tutoresToolStripMenuItem;
            btn_alumno_strip = alumnosToolStripMenuItem;
            btn_usuario_strip = usuariosToolStripMenuItem;
            btn_empleados_strip = empleadosToolStripMenuItem;
            btn_salidas_menu_strip = salidasToolStripMenuItem;
            btn_cerrar_strip = cerrarSesionToolStripMenuItem;
            btn_ajustes_menu_strip = izquierdaToolStripMenuItem;
            panel_izquierda = panel_barra_izquierda;
            menu_arriba = menuStrip1;
            abrir_form(new Frm_inicio());
            lbltitulo.Text = "Inicio";
            lbl_fecha.Visible = false;
            lbl_hora.Visible = false;
            pic_fecha.Visible = false;
            pic_hora.Visible = false;
        }
        private void mostrar()
        {
            lbl_fecha.Visible = true;
            lbl_hora.Visible = true;
            pic_fecha.Visible = true;
            pic_hora.Visible = true;
        }
        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_Alumnos());
            lbltitulo.Text = "Alumnos";
            mostrar();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_usuarios());
            lbltitulo.Text = "Usuarios";
            mostrar();
        }

        private void tutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_tutores());
            lbltitulo.Text = "Tutores";
            mostrar();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_Alumnos());
            lbltitulo.Text = "Alumnos";
            mostrar();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_usuarios());
            lbltitulo.Text = "Usuarios";
            mostrar();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_Empleados());
            lbltitulo.Text = "Empleados";
            mostrar();
        }

        private void izquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Ajustes().ShowDialog();
            //menuStrip1.Visible = false;
            //panel_barra_izquierda.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Frm_Ajustes().ShowDialog();
            //menuStrip1.Visible = true;
            //panel_barra_izquierda.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_Empleados());
            lbltitulo.Text = "Empleados";
            mostrar();
        }

        private void btn_salidas_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_salidas());
            lbltitulo.Text = "Salidas";
            mostrar();
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_salidas());
            lbltitulo.Text = "Salidas";
            mostrar();
        }
    }
}
