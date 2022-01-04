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
    public partial class Frm_Alumnos : Form
    {
        Cls_Alumnos obj_alumnos = new Cls_Alumnos();
        public Frm_Alumnos()
        {
            InitializeComponent();
        }

        private void Frm_Alumnos_Load(object sender, EventArgs e)
        {
            cargar_alumno();
        }

        private void cargar_alumno()
        {
            obj_alumnos.cargar_alumnos(txt_alumno.Text,dgv_alumno);
        }

        private void txt_alumno_TextChanged(object sender, EventArgs e)
        {
            cargar_alumno();
        }

        private void dgv_alumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                Frm_modificar_alumno obj_modificar = new Frm_modificar_alumno();
                obj_modificar.ShowDialog();
            }
            if (e.ColumnIndex == 9)
            {
                MessageBox.Show("eliminar");
            }
        }

        private void btn_registrar_alumno_Click(object sender, EventArgs e)
        {
            Frm_registrar_alumno obj_registrar = new Frm_registrar_alumno();
            obj_registrar.ShowDialog();
        }
    }
}
