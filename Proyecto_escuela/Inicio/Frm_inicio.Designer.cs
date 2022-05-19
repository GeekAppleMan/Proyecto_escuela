namespace Proyecto_escuela
{
    partial class Frm_inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_inicio));
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic_hora = new System.Windows.Forms.PictureBox();
            this.pic_fecha = new System.Windows.Forms.PictureBox();
            this.panel2 = new Proyecto_escuela.panel.panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.Label();
            this.picturebox1 = new Proyecto_escuela.picturebox.picturebox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fecha)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbl_bienvenida.Location = new System.Drawing.Point(499, 420);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(180, 37);
            this.lbl_bienvenida.TabIndex = 0;
            this.lbl_bienvenida.Text = "Bienvenido";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbl_hora.Location = new System.Drawing.Point(88, 27);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(86, 37);
            this.lbl_hora.TabIndex = 1;
            this.lbl_hora.Text = "Hora";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbl_fecha.Location = new System.Drawing.Point(965, 27);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(108, 37);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nombre_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre_usuario.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(329, 478);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(532, 37);
            this.lbl_nombre_usuario.TabIndex = 4;
            this.lbl_nombre_usuario.Text = "Empleado";
            this.lbl_nombre_usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picture_logo
            // 
            this.picture_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture_logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_logo.Image")));
            this.picture_logo.Location = new System.Drawing.Point(329, 81);
            this.picture_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(532, 313);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_logo.TabIndex = 3;
            this.picture_logo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pic_hora
            // 
            this.pic_hora.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_hora.Image = global::Proyecto_escuela.Properties.Resources.reloj;
            this.pic_hora.Location = new System.Drawing.Point(28, 20);
            this.pic_hora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_hora.Name = "pic_hora";
            this.pic_hora.Size = new System.Drawing.Size(53, 57);
            this.pic_hora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_hora.TabIndex = 15;
            this.pic_hora.TabStop = false;
            // 
            // pic_fecha
            // 
            this.pic_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_fecha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_fecha.Image = global::Proyecto_escuela.Properties.Resources.calendario;
            this.pic_fecha.Location = new System.Drawing.Point(904, 20);
            this.pic_fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_fecha.Name = "pic_fecha";
            this.pic_fecha.Size = new System.Drawing.Size(55, 57);
            this.pic_fecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_fecha.TabIndex = 18;
            this.pic_fecha.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Nombre);
            this.panel2.Controls.Add(this.matricula);
            this.panel2.Controls.Add(this.picturebox1);
            this.panel2.Location = new System.Drawing.Point(114, 81);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 20;
            this.panel2.Size = new System.Drawing.Size(976, 321);
            this.panel2.TabIndex = 21;
            this.panel2.Thickness = 5F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "SALIENDO AHORA";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(315, 145);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(527, 40);
            this.Nombre.TabIndex = 25;
            this.Nombre.Text = "Jaime Alberto Sanchez Martinez";
            // 
            // matricula
            // 
            this.matricula.AutoSize = true;
            this.matricula.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricula.Location = new System.Drawing.Point(315, 94);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(161, 40);
            this.matricula.TabIndex = 24;
            this.matricula.Text = "17340346";
            // 
            // picturebox1
            // 
            this.picturebox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picturebox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.picturebox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.picturebox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picturebox1.BorderSize = 5;
            this.picturebox1.GradientAngle = 50F;
            this.picturebox1.Location = new System.Drawing.Point(3, 4);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(312, 312);
            this.picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox1.TabIndex = 23;
            this.picturebox1.TabStop = false;
            // 
            // Frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1179, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pic_fecha);
            this.Controls.Add(this.pic_hora);
            this.Controls.Add(this.lbl_nombre_usuario);
            this.Controls.Add(this.picture_logo);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_bienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_inicio";
            this.Load += new System.EventHandler(this.Frm_inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fecha)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic_hora;
        private System.Windows.Forms.PictureBox pic_fecha;
        public System.Windows.Forms.Label lbl_nombre_usuario;
        private panel.panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label matricula;
        private picturebox.picturebox picturebox1;
    }
}