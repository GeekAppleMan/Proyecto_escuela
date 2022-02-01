using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_escuela.Login;

namespace Proyecto_escuela
{
    public partial class Frm_login : Form
    {
        Frm_main obj_main = new Frm_main();
        
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            obj_main.Show();
            this.Hide();
        }

        private void piccerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabelcontraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Reestablecercontraseña objreestablecer = new Frm_Reestablecercontraseña();
            objreestablecer.Show();
            this.Hide();
        }

        private void linkLabelregistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Registro objregistrar = new Frm_Registro();
            objregistrar.Show();
            this.Hide();
        }
    }
}
