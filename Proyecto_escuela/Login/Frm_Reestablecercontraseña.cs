using Proyecto_escuela.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Login
{
    public partial class Frm_Reestablecercontraseña : Form
    {
        Frm_login objlog = new Frm_login();
        Cls_Login objClaseLogin = new Cls_Login();
        FrmLoginCodigo objcod = new FrmLoginCodigo();
        public Frm_Reestablecercontraseña()
        {
            InitializeComponent();
        }

        private void picmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void piccerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objlog.Show();
            this.Hide();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            objClaseLogin.CompararCorreo(txtusuario.Text);
            if (objClaseLogin.comparacion==1)
            {

            }
        }

        private void txtusuario_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Correo")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Gray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text=="")
            {
                txtusuario.Text = "Correo de usuario";
                txtusuario.ForeColor = Color.Gray;
            }
        }
    }
}
