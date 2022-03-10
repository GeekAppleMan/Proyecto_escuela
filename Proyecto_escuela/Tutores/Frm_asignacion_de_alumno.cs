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
    public partial class Frm_Asignacion_de_alumno : Form
    {
        public static string Id_tutor { get; set; }
        public static Form asignacion { get; set; }
        public Frm_Asignacion_de_alumno()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Asignacion_de_alumno_Load(object sender, EventArgs e)
        {
            asignacion = this;
        }

        private void btn_asignar_alumno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_matricula.Text))
            {
                MessageBox.Show("Debe ingresar la matricula antes de continuar");
            }
            else
            {
                new Cls_tutores().asignar_alumno(txt_matricula.Text, dgv_tutor, txt_matricula);
            }
        }

        private void dgv_tutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                dgv_tutor.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (dgv_tutor.Rows.Count == 0)
            {
                MessageBox.Show("debe agregar alumnos antes de continuar");
            }
            else
            {
                new Cls_tutores().registrar_asignacion_alumno();
            }
        }
    }
}
