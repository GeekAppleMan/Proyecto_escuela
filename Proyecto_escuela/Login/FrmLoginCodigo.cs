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
    public partial class FrmLoginCodigo : Form
    {
        public FrmLoginCodigo()
        {
            InitializeComponent();
        }
        Frm_login frmlog = new Frm_login();
        Frm_Reestablecercontraseña frmr = new Frm_Reestablecercontraseña();
        FrmNuevaContra nueva = new FrmNuevaContra();

        private void txtusuario_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtcodigo.Text=="")
            {
                txtcodigo.Text = "Codigo";
                txtcodigo.ForeColor = Color.Gray;
            }
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            if (frmr.RandomCode==(txtcodigo.Text).ToString())
            {
                this.Close();
                nueva.Show();
            }
            else
            {
                MessageBox.Show("Coodigo incorrecto");
            }
        }

        private void linkLabelRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmlog.Show();
        }

        private void txtcodigo_Enter(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "Codigo")
            {
                txtcodigo.Text = "";
                txtcodigo.ForeColor = Color.Black;
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
    }
}
