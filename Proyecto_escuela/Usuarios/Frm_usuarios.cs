using Proyecto_escuela.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Usuarios
{
    public partial class Frm_usuarios : Form
    {
        Cls_Usuarios obj_usuarios = new Cls_Usuarios();
        public Frm_usuarios()
        {
            InitializeComponent();
        }

        private void btn_registrar_usuario_Click(object sender, EventArgs e)
        {
            Frm_registrar_usuarios obj_registrar = new Frm_registrar_usuarios();
            obj_registrar.ShowDialog();
            cargar_tutores();
        }

        private void Frm_tutores_Load(object sender, EventArgs e)
        {
            cargar_tutores();
        }

        private void cargar_tutores()
        {
            obj_usuarios.cargar_usuarios(txt_usuario.Text, dgv_usuario);
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            cargar_tutores();
        }


    }
}
