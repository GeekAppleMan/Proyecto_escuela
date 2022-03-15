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

        private void cargar_EnEspera()
        {
            obj_salida.CargarEnEspera(dataGridView1);
        }

        private void cargarsalidadgv()
        {
            obj_salida.CargarSalida(dgv_alumno);
        }

        private void Frm_salidas_Load(object sender, EventArgs e)
        {
            obj_salida.estatus();
            if (obj_salida.estatus2==2)
            {
                cargar_EnEspera();
            }
            if (obj_salida.estatus3==3)
            {
                cargarsalidadgv();
            }
            if(obj_salida.estatus4==4)
            {
                obj_salida.Estatus4();
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            obj_salida.estatus();
            if (obj_salida.estatus2 == 2)
            {
                cargar_EnEspera();
            }
            if (obj_salida.estatus3 == 3)
            {
                cargarsalidadgv();
            }
            if (obj_salida.estatus4 == 4)
            {
                obj_salida.Estatus4();
            }
        }
    }
}
