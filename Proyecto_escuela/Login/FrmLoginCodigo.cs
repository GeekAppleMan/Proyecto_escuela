using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela.Login
{
    public partial class FrmLoginCodigo : Form
    {
        public FrmLoginCodigo()
        {
            InitializeComponent();
        }

        private void txtusuario_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtcodigo.Text=="")
            {
                txtcodigo.Text = "Codigo";
                txtcodigo.ForeColor = Color.Gray;
            }
        }
    }
}
