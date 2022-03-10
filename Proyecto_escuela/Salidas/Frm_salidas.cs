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

        private void cargar_salidadgv1()
        {
            obj_salida.Cargar(dataGridView1);
        }

        private void cargarsalidadgv_alumno()
        {
            obj_salida.Cargar(dgv_alumno);
        }

        private void Frm_salidas_Load(object sender, EventArgs e)
        {
            obj_salida.estatus();
            if (obj_salida.estatu==2)
            {
                cargar_salidadgv1();
            }
            else if (obj_salida.estatu==3)
            {
                cargarsalidadgv_alumno();
                obj_salida.Estatus3();
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            obj_salida.estatus();
            if (obj_salida.estatu == 2)
            {
                cargar_salidadgv1();
            }
            else if (obj_salida.estatu == 3)
            {
                cargarsalidadgv_alumno();
                obj_salida.Estatus3();
            }
        }
    }
}
