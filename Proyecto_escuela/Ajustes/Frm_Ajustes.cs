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
    public partial class Frm_Ajustes : Form
    {
        public Frm_Ajustes()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (rdb_izquierda.Checked == true)
            {
                Frm_main.panel_izquierda.Visible = true;
                Frm_main.menu_arriba.Visible = false;
                this.Close();
            }
            if (rdb_arriba.Checked == true)
            {
                Frm_main.panel_izquierda.Visible = false;
                Frm_main.menu_arriba.Visible = true;
                this.Close();
            }
        }
    }
}
