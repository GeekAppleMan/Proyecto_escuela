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
    public partial class Frm_credencial_tutor : Form
    {
        public Frm_credencial_tutor()
        {
            InitializeComponent();
        }

        private void Frm_credencial_tutor_Load(object sender, EventArgs e)
        {
          
        }

        private void Frm_credencial_tutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            picture_imagen_perfil.Image = null;
        }
    }
}
