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
    public partial class frm_registrar_tutor : Form
    {
        Cls_tutores obj_tutores = new Cls_tutores();
        private FilterInfoCollection misdispositivos;
        private VideoCaptureDevice miwebcam;
        public frm_registrar_tutor()
        {
            InitializeComponent();
            cargar_dispositivo();
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
                    btn_capturar_foto.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique que la camara este conectada y seleccionada");
                }
            }
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
        private void cerrar_webcam()
        {
            if (miwebcam != null && miwebcam.IsRunning)
            {
                miwebcam.SignalToStop();
                miwebcam = null;
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
                btn_registrar.Enabled = true;
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombres.Text) || string.IsNullOrEmpty(txt_apellidos.Text) || string.IsNullOrEmpty(txt_direccion.Text) || string.IsNullOrEmpty(txt_telefono.Text) || string.IsNullOrEmpty(txt_correo.Text) || string.IsNullOrEmpty(combo_dispositivos.Text) || string.IsNullOrEmpty(combo_parentesco.Text) || txt_nombres.Text == "Nombres" || txt_apellidos.Text == "Apellidos" || txt_direccion.Text == "Direccion" || txt_correo.Text == "Correo" || txt_telefono.Text == "Telefono")
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                obj_tutores.registrar_tutores(txt_nombres.Text, txt_apellidos.Text, txt_direccion.Text, txt_telefono.Text, txt_correo.Text, rjdatetime1.Value.ToString("d"), combo_parentesco.Text, picture_captura, this);
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

        private void txt_telefono_Leave(object sender, EventArgs e)
        {
            if (txt_telefono.Text == "")
            {
                txt_telefono.Text = "Telefono";
                txt_telefono.ForeColor = Color.Gray;
            }
        }

        private void txt_telefono_Enter(object sender, EventArgs e)
        {
            if (txt_telefono.Text == "Telefono")
            {
                txt_telefono.Text = "";
                txt_telefono.ForeColor = Color.Black;
            }
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (txt_correo.Text == "")
            {
                txt_correo.Text = "Correo";
                txt_correo.ForeColor = Color.Gray;
            }
        }

        private void txt_correo_Enter(object sender, EventArgs e)
        {
            if (txt_correo.Text == "Correo")
            {
                txt_correo.Text = "";
                txt_correo.ForeColor = Color.Black;
            }
        }

        private void combo_parentesco_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_dispositivos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void combo_dispositivos_MouseHover(object sender, EventArgs e)
        {
            cargar_dispositivo();
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

        private void frm_registrar_tutor_Load(object sender, EventArgs e)
        {
            cargar_dispositivo();
        }

        private void frm_registrar_tutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrar_webcam();
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
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
