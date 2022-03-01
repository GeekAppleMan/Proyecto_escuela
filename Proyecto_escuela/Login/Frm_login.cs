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
        public static Form frm_login { get; set; }
        Cls_Login obj_Login = new Cls_Login();
        public Frm_login()
        {
            InitializeComponent();
            frm_login = this;
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            iniciar_sesion();
        }

        private void iniciar_sesion()
        {
            if (string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(txtcontraseña.Text) || txtusuario.Text == "Usuario" || txtcontraseña.Text == "Contraseña")
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                obj_Login.comparar_login(txtusuario.Text, txtusuario.Text, txtcontraseña.Text);
            }
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
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "Contraseña";
                txtcontraseña.ForeColor = Color.Gray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Correo";
                txtusuario.ForeColor = Color.Gray;
            }
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Correo")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "Contraseña")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.Black;
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                iniciar_sesion();
            }
        }
    }
}
