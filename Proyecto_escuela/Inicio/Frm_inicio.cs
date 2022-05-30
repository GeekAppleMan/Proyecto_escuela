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
    public partial class Frm_inicio : Form
    {
        public static Label lbl_empleado { get; set; }
        public Frm_inicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString("d");
            lbl_hora.Text = DateTime.Now.ToString("t");
        }

        private void Frm_inicio_Load(object sender, EventArgs e)
        {
            lbl_empleado = lbl_nombre_usuario;
            //picturebox1.LoadAsync(@"http://189.204.133.38:8081/imagenes_escuela/imagenes_empleados/19B15I0G6B12D13G.jpg");
        }

        private void picturebox1_Click(object sender, EventArgs e)
        {

        }
    }
}
