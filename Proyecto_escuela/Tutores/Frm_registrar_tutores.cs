using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela
{
    public partial class Frm_registrar_tutores : Form
    {
        private string path = @"C:\Users\Jaime\Desktop\Proyecto_escuela\Imagenes\";
        private FilterInfoCollection misdispositivos;
        private VideoCaptureDevice miwebcam;
        public Frm_registrar_tutores()
        {
            InitializeComponent();
        }

        private void Frm_registrar_tutores_Load(object sender, EventArgs e)
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
                MessageBox.Show("No hay dispositivos de video disponibles");
            }
        }

        private void cerrar_webcam()
        {
            if (miwebcam!=null && miwebcam.IsRunning)
            {
                miwebcam.SignalToStop();
                miwebcam = null;
            }
        }

        private void capturando (object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            picture_tiempo_real.Image = imagen;
        }

        private void Frm_registrar_tutores_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrar_webcam();
        }

        private void btn_enceder_Click(object sender, EventArgs e)
        {
            if (miwebcam!= null && miwebcam.IsRunning)
            {

            }
            else
            {
                int i = combo_dispositivos.SelectedIndex;
                string nombrevideo = misdispositivos[i].MonikerString;
                miwebcam = new VideoCaptureDevice(nombrevideo);
                miwebcam.NewFrame += new NewFrameEventHandler(capturando);
                miwebcam.Start();
            }  
        }

        private void Miwebcam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void btn_capturar_foto_Click(object sender, EventArgs e)
        {
            if (miwebcam != null && miwebcam.IsRunning)
            {
                picture_captura.Image = picture_tiempo_real.Image;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            picture_captura.Image.Save(path + txt_nombres.Text + "_" + txt_apellidos.Text + ".jpg", ImageFormat.Jpeg);
        }
    }
}
