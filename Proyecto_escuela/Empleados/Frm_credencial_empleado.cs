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
    public partial class Frm_credencial_empleado : Form
    {
        public static int rowindex { get; set; }
        public static DataGridView dgv { get; set; }

        Clases.Cls_empleados obj_empleados = new Clases.Cls_empleados();
        public static Form frm_credencial { get; set; }
        public Frm_credencial_empleado()
        {
            InitializeComponent();
        }

        private void Frm_credencial_empleado_Load(object sender, EventArgs e)
        {
            frm_credencial = this;
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            obj_empleados.eliminar_empleado();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_empleado obj_modificar = new Frm_Modificar_empleado();
            obj_modificar.txt_nombres.Text = lbl_nombres_empleado.Text;
            obj_modificar.txt_apellidos.Text = lbl_apellidos_empleado.Text;
            obj_modificar.txt_direccion.Text = lbl_direccion_empleado.Text;
            obj_modificar.txt_telefono.Text = lbl_telefono_empleado.Text;
            obj_modificar.txt_correo.Text = lbl_correo_empleado.Text;
            obj_modificar.dtp_fecha_nacimiento.Value = Convert.ToDateTime(lbl_fecha_empleado.Text);
            obj_modificar.combo_parentesco.Text = lbl_rol_empleado.Text;
            obj_modificar.combo_estatus.Text = lbl_estatus_empleado.Text;
            obj_modificar.ShowDialog();
        }
    }
}
