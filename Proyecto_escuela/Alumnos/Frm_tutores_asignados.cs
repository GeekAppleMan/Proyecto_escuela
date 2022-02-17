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
    public partial class Frm_tutores_asignados : Form
    {
        Cls_Alumnos obj_alumnos = new Cls_Alumnos();
        public static string id_alumno { get; set; } 
        public Frm_tutores_asignados()
        {
            InitializeComponent();
        }

        private void Frm_tutores_asignados_Load(object sender, EventArgs e)
        {
            obj_alumnos.tutores_asignados(id_alumno);
            obj_alumnos.cargar_tutores_asignados(dgv_tutor);
        }
    }
}
