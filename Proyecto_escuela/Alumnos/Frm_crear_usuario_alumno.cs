using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela
{
    public partial class Frm_crear_usuario_alumno : Form
    {
       
        public Frm_crear_usuario_alumno()
        {
            InitializeComponent();
        }

        private void Frm_crear_usuario_alumno_Load(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_matricula.Texts) || string.IsNullOrEmpty(txt_contraseña.Texts) || string.IsNullOrEmpty(txt_contraseña.Texts) || txt_matricula.Texts == "Matricula" || txt_correo.Texts == "Correo"  || txt_contraseña.Texts == "Contraseña")
            {
                MessageBox.Show("Debe ingresar todos los datos antes de continuar");
            }
            else
            {
                new Cls_Alumnos().registrar_usuario_alumno(txt_matricula.Texts, txt_correo.Texts, txt_contraseña.Texts);
                this.Close();
            }
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

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (txt_correo.Text == "")
            {
                txt_correo.Text = "Correo";
                txt_correo.ForeColor = Color.Gray;
            }
        }

        private void txt_correo_Enter(object sender, EventArgs e)
        {
            if (txt_correo.Text == "Correo")
            {
                txt_correo.Text = "";
                txt_correo.ForeColor = Color.Black;
            }
        }

        private void txt_contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "")
            {
                txt_contraseña.Text = "Contraseña";
                txt_contraseña.ForeColor = Color.Gray;
            }
        }

        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "Contraseña")
            {
                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.Black;
            }
        }

        private void txt_matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
