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

namespace Proyecto_escuela
{
    public partial class Frm_salidas : Form
    {
        Cls_Salida obj_salida = new Cls_Salida();
        public Frm_salidas()
        {
            InitializeComponent();
        }

        private void cargar_salida()
        {
            obj_salida.Cargar(dataGridView1);
        }

        private void Frm_salidas_Load(object sender, EventArgs e)
        {
            cargar_salida();
        }
    }
}
