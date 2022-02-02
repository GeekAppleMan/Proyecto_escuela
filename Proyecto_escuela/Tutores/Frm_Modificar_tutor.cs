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
    public partial class Frm_Modificar_tutor : Form
    {
        Cls_tutores obj_tutores = new Cls_tutores();
        private FilterInfoCollection misdispositivos;
        private VideoCaptureDevice miwebcam;
        private bool captura = false;
        public Frm_Modificar_tutor()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_tutor_Load(object sender, EventArgs e)
        {
            cargar_dispositivo();
            Cls_tutores.conservar_modificar_imagen = true;
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
                picture_captura.Image = null;
                picture_tiempo_real.Image = null;
            }
        }

        private void capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            picture_tiempo_real.Image = imagen;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {  
            obj_tutores.modificar_tutores(txt_nombres.Text, txt_apellidos.Text, txt_direccion.Text, txt_telefono.Text, txt_correo.Text, dtp_fecha_nacimiento.Value.ToString("d"), combo_parentesco.Text, combo_estatus.Text, picture_captura, this,captura);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Modificar_tutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrar_webcam();
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

        private void combo_estatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_dispositivos_MouseHover_1(object sender, EventArgs e)
        {
            cargar_dispositivo();
        }

        private void rdb_conservar_Click(object sender, EventArgs e)
        {
            cerrar_webcam();
            picture_tiempo_real.Enabled = false;
            combo_dispositivos.Enabled = false;
            btn_enceder.Enabled = false;
            picture_captura.Enabled = false;
            btn_capturar_foto.Enabled = false;
            Cls_tutores.conservar_modificar_imagen = true;
        }

        private void rdb_modificar_Click(object sender, EventArgs e)
        {
            Cls_tutores.conservar_modificar_imagen = false;
            picture_tiempo_real.Enabled = true;
            combo_dispositivos.Enabled = true;
            btn_enceder.Enabled = true;
            btn_capturar_foto.Enabled = true;
            picture_captura.Enabled = true;
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
    }
}
