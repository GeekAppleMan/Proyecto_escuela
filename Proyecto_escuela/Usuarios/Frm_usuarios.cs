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

namespace Proyecto_escuela.Usuarios
{
    public partial class Frm_usuarios : Form
    {
        public Frm_usuarios()
        {
            InitializeComponent();
        }
        Cls_usuarios objusuario = new Cls_usuarios();
        private void cargar_usuario()
        {
            objusuario.cargar_usuarios(txt_usuario.Text,txt_usuario.Text, dgv_usuario);
        }
        private void txt_tutor_TextChanged(object sender, EventArgs e)
        {
            cargar_usuario();
        }

        private void Frm_usuarios_Load(object sender, EventArgs e)
        {
            cargar_usuario();
        }
    }
}
