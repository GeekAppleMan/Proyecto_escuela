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
    public partial class FrmNuevaContra : Form
    {
        Frm_login log = new Frm_login();
        Cls_Login objlog = new Cls_Login();
        Frm_Reestablecercontraseña ree = new Frm_Reestablecercontraseña();
        public FrmNuevaContra()
        {
            InitializeComponent();
        }

        private void linkLabelRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            log.Show();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            if (txtc1.Text==txtc2.Text)
            {
                objlog.CambiarContraseña(txtc1.Text,ree.correo);
            }
        }

        private void picmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void piccerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
