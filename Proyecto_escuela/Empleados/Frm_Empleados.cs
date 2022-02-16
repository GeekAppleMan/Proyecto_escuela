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

namespace Proyecto_escuela.Empleados
{
    public partial class Frm_Empleados : Form
    {
        public Frm_Empleados()
        {
            InitializeComponent();
        }

        Cls_empleados objusuario = new Cls_empleados();
        private void cargar_usuario()
        {
            objusuario.cargar_usuarios(txt_empleado.Text, dgv_empleado);
        }

        private void Frm_usuarios_Load(object sender, EventArgs e)
        {
            cargar_usuario();
        }

        private void txt_empleado_TextChanged(object sender, EventArgs e)
        {
            cargar_usuario();
        }
    }
}
