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
        public Frm_credencial_empleado()
        {
            InitializeComponent();
        }

        private void Frm_credencial_empleado_Load(object sender, EventArgs e)
        {

        }
    }
}
