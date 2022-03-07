using Proyecto_escuela.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Empleados
{
    public partial class Frm_Empleados : Form
    {
        Cls_empleados obj_empleados = new Cls_empleados();
        Frm_credencial_empleado obj_credencial = new Frm_credencial_empleado();
        //Frm_modificar_alumno obj_modificar = new Frm_modificar_alumno();
      
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
            if (Cls_Login.rol == "1")
            {
                btn_registar_empleado.Visible = true;
            }
            if (Cls_Login.rol == "2")
            {
                btn_registar_empleado.Visible = false;
            }
            cargar_empleado();
        }

        private void btn_registar_empleado_Click(object sender, EventArgs e)
        {
            Frm_registrar_empleado obj_registrar = new Frm_registrar_empleado();
            obj_registrar.ShowDialog();
            cargar_empleado();
        }

        private void dgv_empleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {

            }
            else
            {
                //Frm_tutores_asignados.id_alumno = dgv_empleado[0, e.RowIndex].Value.ToString();
                if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9)
                {
                    Cls_empleados.empleados = dgv_empleado;
                    Cls_empleados.index = e.RowIndex;
                    obj_credencial.lbl_matricula_empleado.Text = dgv_empleado[1, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_nombres_empleado.Text = dgv_empleado[2, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_apellidos_empleado.Text = dgv_empleado[3, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_fecha_empleado.Text = dgv_empleado[4, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_direccion_empleado.Text = dgv_empleado[5, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_correo_empleado.Text = dgv_empleado[6, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_telefono_empleado.Text = dgv_empleado[7, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_rol_empleado.Text = dgv_empleado[8, e.RowIndex].Value.ToString();
                    obj_credencial.lbl_estatus_empleado.Text = dgv_empleado[9, e.RowIndex].Value.ToString();
                    Frm_credencial_empleado.rowindex = e.RowIndex;
                    Frm_credencial_empleado.dgv = dgv_empleado;
                    string path = dgv_empleado[10, e.RowIndex].Value.ToString();
                    if (path == "")
                    {
                        obj_credencial.picture_imagen_perfil.Image = null;
                    }
                    else
                    {
                        try
                        {
                            var request = WebRequest.Create(path);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                obj_credencial.picture_imagen_perfil.Image = Bitmap.FromStream(stream);
                                System.Drawing.Image img = obj_credencial.picture_imagen_perfil.Image;
                                //img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                obj_credencial.picture_imagen_perfil.Image = img;
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                    obj_credencial.ShowDialog();
                    cargar_empleado();
                }
            }
        }
    }
}
