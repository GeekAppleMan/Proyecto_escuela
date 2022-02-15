using Proyecto_escuela.Empleados;
using Proyecto_escuela.Usuarios;
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
        }

        private void timer_fecha_hora_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString("d");
            lbl_hora.Text = DateTime.Now.ToString("t");
        }
        private void Frm_main_Load(object sender, EventArgs e)
        {
            //abrir_form(new Frm_inicio());
            //lbltitulo.Text = "Inicio";
        }
        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_Alumnos());
            lbltitulo.Text = "Alumnos";
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_usuarios());
            lbltitulo.Text = "Usuarios";
        }

        private void tutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_tutores());
            lbltitulo.Text = "Tutores";
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_Alumnos());
            lbltitulo.Text = "Alumnos";
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_usuarios());
            lbltitulo.Text = "Usuarios";
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            abrir_form(new Frm_Empleados());
            lbltitulo.Text = "Empleados";
        }
    }
}
