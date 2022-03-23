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
using System.Net;
using System.Net.Mail;

namespace Proyecto_escuela.Login
{
    public partial class Frm_Reestablecercontraseña : Form
    {
        
        public Frm_Reestablecercontraseña()
        {
            InitializeComponent();
        }
        public string correo;
        public string RandomCode;
        public static string para;
        
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
            Frm_login objlog = new Frm_login();
            objlog.Show();
            this.Hide();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            FrmLoginCodigo objcod = new FrmLoginCodigo();
            Cls_Login objClaseLogin = new Cls_Login();
            correo = txtusuario.Text;
            objClaseLogin.CompararCorreo(txtusuario.Text);
            if (objClaseLogin.comparacion == 1)
            {
                string de, pass, messagebody;
                Random rand = new Random();
                RandomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                para = (txtusuario.Text).ToString();
                de = "18340425@itnogales.edu.mx";
                pass = "Potros2020";
                messagebody = "Tu codigo de verificacion es" + RandomCode;
                message.To.Add(para);
                message.From = new MailAddress(de);
                message.Body = messagebody;
                message.Subject = "Codigo de reestablecimiento de contraseña";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(de, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Codigo enviado de manera exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
                objcod.Show();
            }
        }

        private void txtusuario_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Correo de usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;
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
