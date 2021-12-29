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
    public partial class Frm_tutores : Form
    {
        public Frm_tutores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_registrar_tutores obj_registrar = new Frm_registrar_tutores();
            obj_registrar.ShowDialog();
        }
    }
}
