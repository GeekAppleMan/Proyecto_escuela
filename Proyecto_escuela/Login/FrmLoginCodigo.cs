﻿using System;
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
    public partial class FrmLoginCodigo : Form
    {
        Frm_login log = new Frm_login();
        public FrmLoginCodigo()
        {
            InitializeComponent();
        }

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

        private void piccerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void linkLabelRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            log.Show();
        }

        private void FrmLoginCodigo_Load(object sender, EventArgs e)
        {

        }
    }
}
