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
            if (Clases.Cls_Login.rol == "1")
            {
                btn_baja.Enabled = true;
                btn_modificar.Enabled = true;
            }
            if (Clases.Cls_Login.rol == "2")
            {
                btn_baja.Enabled = false;
                btn_modificar.Enabled = false;

            }
            frm_credencial = this;
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            obj_empleados.eliminar_empleado();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_empleado obj_modificar = new Frm_Modificar_empleado();
            try
            {
                obj_modificar.txt_nombres.Texts =  dgv[2, rowindex].Value.ToString();
                obj_modificar.txt_apellidos.Texts =  dgv[3, rowindex].Value.ToString();
                obj_modificar.txt_direccion.Texts = dgv[5, rowindex].Value.ToString();
                obj_modificar.txt_telefono.Texts =  dgv[7, rowindex].Value.ToString();
                obj_modificar.txt_correo.Texts =  dgv[6, rowindex].Value.ToString();
                obj_modificar.dtp_fecha_nacimiento.Value = Convert.ToDateTime( dgv[4,rowindex].Value.ToString());
                obj_modificar.combo_parentesco.Text =  dgv[8, rowindex].Value.ToString();
                obj_modificar.combo_estatus.Text = dgv[9,rowindex].Value.ToString();
                obj_modificar.ShowDialog();
            }
            catch (Exception)
            {
                obj_modificar.ShowDialog();
            }
            
           
        }
    }
}
