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
        public static string randomCode="";
        public static string to;
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
            Frm_login objlog = new Frm_login();
            objlog.Show();
            this.Hide();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            FrmLoginCodigo objcod = new FrmLoginCodigo();
            Cls_Login objClaseLogin = new Cls_Login();
            objClaseLogin.CompararCorreo(txtusuario.Text);
            if (objClaseLogin.comparacion==1)
            {
                string from, pass, messagebody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (txtusuario.Text).ToString();
                from = "18340425@itnogales.edu.mx";
                pass="Potros2020";
                messagebody = "Tu codigo de verificacion es " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "password reseting code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from,pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Codigo enviado con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
                objcod.Show();
            }
        }

        public string getRandomCode()
        {
            return randomCode;
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
