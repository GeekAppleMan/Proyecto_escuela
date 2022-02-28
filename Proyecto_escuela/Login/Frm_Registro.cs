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
        Cls_registro obj_registro = new Cls_registro();
        public static Frm_Registro frm_registro { get; set; }
        public Frm_Registro()
        {
            InitializeComponent();
            frm_registro = this;
        }
    
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
            this.Close();
        }

        private void Frm_Registro_Load(object sender, EventArgs e)
        {

        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_matricula.Text) || string.IsNullOrEmpty(txtcorreo.Text) || string.IsNullOrEmpty(txttelefono.Text) || string.IsNullOrEmpty(txtcontraseña.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos correctamente");
            }
            else
            {
                if (txtcontraseña.Text != txt_confirmar_contraseña.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden por favor verifique que esten correctas");
                }
                else
                {
                    obj_registro.buscar_empleado(txt_matricula.Text, txtcorreo.Text, txttelefono.Text, txtcontraseña.Text);
                }
            }
        }

        private void Frm_Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_login.frm_login.Show();
        }

        private void txt_matricula_Leave(object sender, EventArgs e)
        {
            if (txt_matricula.Text == "")
            {
                txt_matricula.Text = "Matricula";
                txt_matricula.ForeColor = Color.Gray;
            }
        }

        private void txt_matricula_Enter(object sender, EventArgs e)
        {
            if (txt_matricula.Text == "Matricula")
            {
                txt_matricula.Text = "";
                txt_matricula.ForeColor = Color.Black;
            }
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "")
            {
                txtcorreo.Text = "Correo";
                txtcorreo.ForeColor = Color.Gray;
            }
        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "Correo")
            {
                txtcorreo.Text = "";
                txtcorreo.ForeColor = Color.Black;
            }
        }

        private void txttelefono_Leave(object sender, EventArgs e)
        {
            if (txttelefono.Text == "")
            {
                txttelefono.Text = "Numero de télefono";
                txttelefono.ForeColor = Color.Gray;
            }
        }

        private void txttelefono_Enter(object sender, EventArgs e)
        {
            if (txttelefono.Text == "Numero de télefono")
            {
                txttelefono.Text = "";
                txttelefono.ForeColor = Color.Black;
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "Contraseña";
                txtcontraseña.ForeColor = Color.Gray;
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

        private void txt_confirmar_contraseña_Leave(object sender, EventArgs e)
        {

            if (txt_confirmar_contraseña.Text == "")
            {
                txt_confirmar_contraseña.Text = "Confirmar contraseña";
                txt_confirmar_contraseña.ForeColor = Color.Gray;
            }
        }

        private void txt_confirmar_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_confirmar_contraseña.Text == "Confirmar contraseña")
            {
                txt_confirmar_contraseña.Text = "";
                txt_confirmar_contraseña.ForeColor = Color.Black;
            }
        }
    }
}
