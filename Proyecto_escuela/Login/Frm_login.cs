using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_escuela.Clases;
using Proyecto_escuela.Login;

namespace Proyecto_escuela
{
    public partial class Frm_login : Form
    {
        Frm_main obj_main = new Frm_main();
        Cls_Login obj_Login = new Cls_Login();
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Frm_main().Show();
            //obj_Login.comparar_login(txtusuario.Text,txtusuario.Text, txtcontraseña.Text);
            //if (obj_Login.a==1)
            //{
            //    this.Hide();
            //}
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

        private void txtusuario_Click(object sender, EventArgs e)
        {
            txtusuario.SelectAll();
        }

        private void txtcontraseña_Click(object sender, EventArgs e)
        {
            txtcontraseña.SelectAll();
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.TextLength==0)
            {
                txtcontraseña.Text = "Contraseña";
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.TextLength==0)
            {
                txtusuario.Text = "Usuario";
            }
        }
    }
}
