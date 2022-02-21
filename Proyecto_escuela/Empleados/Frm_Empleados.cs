﻿using Proyecto_escuela.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Empleados
{
    public partial class Frm_Empleados : Form
    {
        public Frm_Empleados()
        {
            InitializeComponent();
        }

        Cls_empleados objusuario = new Cls_empleados();
        private void cargar_empleado()
        {
            objusuario.cargar_empleados(txt_empleado.Text, dgv_empleado);
        }

        private void txt_empleado_TextChanged(object sender, EventArgs e)
        {
            cargar_empleado();
        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            cargar_empleado();
        }

        private void btn_registar_empleado_Click(object sender, EventArgs e)
        {
            Frm_registrar_empleado obj_registrar = new Frm_registrar_empleado();
            obj_registrar.ShowDialog();
            cargar_empleado();
        }
    }
}
