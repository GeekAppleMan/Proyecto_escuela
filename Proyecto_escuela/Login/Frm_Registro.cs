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
    public partial class Frm_Registro : Form
    {
        public Frm_Registro()
        {
            InitializeComponent();
        }
        Cls_registro obj_registro = new Cls_registro();

        private void piccerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabelregistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_login objlogin = new Frm_login();
            objlogin.Show();
            this.Hide();
        }
        private void txtcontraseña_Click(object sender, EventArgs e)
        {
            txtcontraseña.SelectAll();
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text.Length==0)
            {
                txtcontraseña.UseSystemPasswordChar = false;
                txtcontraseña.Text = "Contraseña";
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtcontraseña.UseSystemPasswordChar = true;
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.TextLength==0)
            {
                txtusuario.Text = "Numero de télefono";
            }
        }

        private void txtusuario_Click(object sender, EventArgs e)
        {
            txtusuario.SelectAll();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.UseSystemPasswordChar = false;
                textBox1.Text = "Confirmar contraseña";
            }
        }

        private void Frm_Registro_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Correo";
            }
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.Text!=textBox1.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else if (textBox2.Text.Length==0)
            {
                MessageBox.Show("Introduzca un correo valido");
            }
            else if (txtusuario.Text.Length<10)
            {
                MessageBox.Show("Introduzca un numero de telefono valido");
            }
            else
            {
                obj_registro.registrarUsuarios(textBox2.Text,txtusuario.Text, txtcontraseña.Text);
                MessageBox.Show("Registrado exitosamente");
            }
        }
    }
}
