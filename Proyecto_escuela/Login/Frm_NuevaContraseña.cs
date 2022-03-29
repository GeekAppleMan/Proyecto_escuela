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
    public partial class Frm_NuevaContraseña : Form
    {
        Frm_login objlog = new Frm_login();
        Cls_Login objL = new Cls_Login();
        Frm_Reestablecercontraseña ree = new Frm_Reestablecercontraseña();
        public Frm_NuevaContraseña()
        {
            InitializeComponent();
        }

        private void piccerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabelRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            objlog.Show();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            if (txt1.Text==txt2.Text)
            {
                objL.CambiarContra(ree.getEmail(),txt1.Text);
                MessageBox.Show("Contraseña cambiada con exito");
                this.Close();
                objlog.Show();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden, vuelvalo a intentar");
            }
        }
    }
}
