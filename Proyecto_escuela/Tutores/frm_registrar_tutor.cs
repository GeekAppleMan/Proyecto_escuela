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

        private void btn_capturar_foto_Click_1(object sender, EventArgs e)
        {
            picture_captura.Image = picture_tiempo_real.Image;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombres.Texts) || string.IsNullOrEmpty(txt_apellidos.Texts) || string.IsNullOrEmpty(txt_direccion.Texts) || string.IsNullOrEmpty(txt_telefono.Texts) || string.IsNullOrEmpty(txt_correo.Texts) || string.IsNullOrEmpty(combo_dispositivos.Text) || string.IsNullOrEmpty(combo_parentesco.Text) || txt_nombres.Texts == "Nombres" || txt_apellidos.Texts == "Apellidos" || txt_direccion.Texts == "Direccion" || txt_correo.Texts == "Correo" || txt_telefono.Texts == "Telefono")
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                obj_tutores.registrar_tutores(txt_nombres.Texts, txt_apellidos.Texts, txt_direccion.Texts, txt_telefono.Texts, txt_correo.Texts, rjdatetime1.Value.ToString("d"), combo_parentesco.Text, picture_captura, this);
            }
        }
    }
}
