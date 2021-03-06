using AForge.Video;
using AForge.Video.DirectShow;
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
    public partial class Frm_modificar_alumno : Form
    {
        Cls_Alumnos obj_alumnos = new Cls_Alumnos();
        private FilterInfoCollection misdispositivos;
        private VideoCaptureDevice miwebcam;
        private bool captura = false;
        public Frm_modificar_alumno()
        {
            InitializeComponent();
        }

        private void Frm_modificar_alumno_Load(object sender, EventArgs e)
        {
            cargar_dispositivo();
            Cls_Alumnos.conservar_modificar_imagen = true;
        }

        private void txt_matricula_Leave(object sender, EventArgs e)
        {
            if (txt_matricula.Text == "")
            {
                txt_matricula.Text = "Matricula";
                txt_matricula.ForeColor = Color.Gray;
            }
        }

        private void txt_matricula_Enter(object sender, EventArgs e)
        {
            if (txt_matricula.Text == "Matricula")
            {
                txt_matricula.Text = "";
                txt_matricula.ForeColor = Color.Black;
            }
        }
        private void txt_nombres_Leave(object sender, EventArgs e)
        {
            if (txt_nombres.Text == "")
            {
                txt_nombres.Text = "Nombres";
                txt_nombres.ForeColor = Color.Gray;
            }
        }

        private void txt_nombres_Enter(object sender, EventArgs e)
        {
            if (txt_nombres.Text == "Nombres")
            {
                txt_nombres.Text = "";
                txt_nombres.ForeColor = Color.Black;
            }
        }

        private void txt_apellidos_Leave(object sender, EventArgs e)
        {
            if (txt_apellidos.Text == "")
            {
                txt_apellidos.Text = "Apellidos";
                txt_apellidos.ForeColor = Color.Gray;
            }
        }

        private void txt_apellidos_Enter(object sender, EventArgs e)
        {
            if (txt_apellidos.Text == "Apellidos")
            {
                txt_apellidos.Text = "";
                txt_apellidos.ForeColor = Color.Black;
            }
        }

        private void txt_direccion_Leave(object sender, EventArgs e)
        {
            if (txt_direccion.Text == "")
            {
                txt_direccion.Text = "Direccion";
                txt_direccion.ForeColor = Color.Gray;
            }
        }

        private void txt_direccion_Enter(object sender, EventArgs e)
        {
            if (txt_direccion.Text == "Direccion")
            {
                txt_direccion.Text = "";
                txt_direccion.ForeColor = Color.Black;
            }
        }
        private void txt_matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void combo_dispositivos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_dispositivos_MouseHover(object sender, EventArgs e)
        {
            cargar_dispositivo();
        }

        private void cargar_dispositivo()
        {
            combo_dispositivos.Items.Clear();
            misdispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (misdispositivos.Count > 0)
            {
                for (int i = 0; i < misdispositivos.Count; i++)
                {
                    combo_dispositivos.Items.Add(misdispositivos[i].Name.ToString());
                    combo_dispositivos.Text = misdispositivos[0].Name.ToString();
                }
            }
            else
            {
                combo_dispositivos.Text = "";
            }
        }

        private void btn_enceder_Click(object sender, EventArgs e)
        {
            if (miwebcam != null && miwebcam.IsRunning)
            {

            }
            else
            {
                try
                {
                    int i = combo_dispositivos.SelectedIndex;
                    string nombrevideo = misdispositivos[i].MonikerString;
                    miwebcam = new VideoCaptureDevice(nombrevideo);
                    miwebcam.NewFrame += new NewFrameEventHandler(capturando);
                    miwebcam.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique que la camara este conectada y seleccionada");
                }
            }
        }
        private void cerrar_webcam()
        {
            if (miwebcam != null && miwebcam.IsRunning)
            {
                miwebcam.SignalToStop();
                miwebcam = null;
                picture_captura.Image = null;
                picture_tiempo_real.Image = null;
            }
        }

        private void capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            picture_tiempo_real.Image = imagen;
        }

        private void btn_capturar_foto_Click(object sender, EventArgs e)
        {
            if (miwebcam != null && miwebcam.IsRunning)
            {
                picture_captura.Image = picture_tiempo_real.Image;
                captura = true;
            }
            else
            {
                captura = false;
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            obj_alumnos.modificar_alumno(txt_matricula.Texts, txt_nombres.Texts, txt_apellidos.Texts, txt_direccion.Texts, dtp_fecha_nacimiento.Value.ToString("d"), combo_grupo.Text, combo_estatus.Text, picture_captura, this);
        }

        private void Frm_modificar_alumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrar_webcam();
            rdb_conservar.Checked = true;
            rdb_cambiar.Checked = false;
            cerrar_webcam();
            picture_tiempo_real.Enabled = false;
            combo_dispositivos.Enabled = false;
            Toggle_encender_camara.Checked = false;
            picture_captura.Enabled = false;
            btn_capturar_foto.Enabled = false;
            Cls_Alumnos.conservar_modificar_imagen = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdb_cambiar_Click(object sender, EventArgs e)
        {
            Cls_Alumnos.conservar_modificar_imagen = false;
            picture_tiempo_real.Enabled = true;
            combo_dispositivos.Enabled = true;
            Toggle_encender_camara.Checked = true;
            btn_capturar_foto.Enabled = true;
            picture_captura.Enabled = true;
        }

        private void rdb_conservar_Click(object sender, EventArgs e)
        {
            cerrar_webcam();
            picture_tiempo_real.Enabled = false;
            combo_dispositivos.Enabled = false;
            Toggle_encender_camara.Checked = false;
            picture_captura.Enabled = false;
            btn_capturar_foto.Enabled = false;
            Cls_Alumnos.conservar_modificar_imagen = true;
        }

        private void combo_dispositivos_MouseHover_1(object sender, EventArgs e)
        {
            cargar_dispositivo();
        }

        private void Toggle_encender_camara_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle_encender_camara.Checked == false)
            {
                cerrar_webcam();
                lbltoggle.Text = "Apagada";
            }
            else
            {
                if (miwebcam != null && miwebcam.IsRunning)
                {

                }
                else
                {
                    try
                    {
                        int i = combo_dispositivos.SelectedIndex;
                        string nombrevideo = misdispositivos[i].MonikerString;
                        miwebcam = new VideoCaptureDevice(nombrevideo);
                        miwebcam.NewFrame += new NewFrameEventHandler(capturando);
                        miwebcam.Start();
                        btn_capturar_foto.Enabled = true;
                        lbltoggle.Text = "Encendida";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Verifique que la camara este conectada y seleccionada");
                        Toggle_encender_camara.Checked = false;
                        lbltoggle.Text = "Apagada";
                    }
                }
            }
        }
    }
}
