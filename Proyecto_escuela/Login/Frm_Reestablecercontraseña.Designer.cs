
namespace Proyecto_escuela.Login
{
    partial class Frm_Reestablecercontraseña
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbljane = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelRegresar = new System.Windows.Forms.LinkLabel();
            this.line1 = new System.Windows.Forms.Panel();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.piccerrar = new System.Windows.Forms.PictureBox();
            this.picmin = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btniniciarsesion = new Proyecto_escuela.Boton.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.lbljane);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 327);
            this.panel1.TabIndex = 0;
            // 
            // lbljane
            // 
            this.lbljane.AutoSize = true;
            this.lbljane.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljane.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbljane.Location = new System.Drawing.Point(12, 153);
            this.lbljane.Name = "lbljane";
            this.lbljane.Size = new System.Drawing.Size(167, 23);
            this.lbljane.TabIndex = 3;
            this.lbljane.Text = "JANE SOFTWARE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btniniciarsesion);
            this.panel2.Controls.Add(this.linkLabelRegresar);
            this.panel2.Controls.Add(this.line1);
            this.panel2.Controls.Add(this.txtusuario);
            this.panel2.Controls.Add(this.piccerrar);
            this.panel2.Controls.Add(this.picmin);
            this.panel2.Controls.Add(this.lbltitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 327);
            this.panel2.TabIndex = 1;
            // 
            // linkLabelRegresar
            // 
            this.linkLabelRegresar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabelRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelRegresar.AutoSize = true;
            this.linkLabelRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelRegresar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegresar.ForeColor = System.Drawing.Color.Black;
            this.linkLabelRegresar.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabelRegresar.Location = new System.Drawing.Point(482, 297);
            this.linkLabelRegresar.Name = "linkLabelRegresar";
            this.linkLabelRegresar.Size = new System.Drawing.Size(82, 21);
            this.linkLabelRegresar.TabIndex = 59;
            this.linkLabelRegresar.TabStop = true;
            this.linkLabelRegresar.Text = "Regresar";
            this.linkLabelRegresar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegresar_LinkClicked);
            // 
            // line1
            // 
            this.line1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.line1.BackColor = System.Drawing.Color.Gray;
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line1.Location = new System.Drawing.Point(65, 186);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(451, 1);
            this.line1.TabIndex = 58;
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.Gray;
            this.txtusuario.Location = new System.Drawing.Point(65, 155);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(451, 25);
            this.txtusuario.TabIndex = 57;
            this.txtusuario.Text = "Correo de usuario";
            this.txtusuario.Click += new System.EventHandler(this.txtusuario_Click);
            this.txtusuario.Enter += new System.EventHandler(this.txtusuario_Enter);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            // 
            // piccerrar
            // 
            this.piccerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piccerrar.Image = global::Proyecto_escuela.Properties.Resources.cerrar;
            this.piccerrar.Location = new System.Drawing.Point(534, 12);
            this.piccerrar.Name = "piccerrar";
            this.piccerrar.Size = new System.Drawing.Size(30, 30);
            this.piccerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piccerrar.TabIndex = 53;
            this.piccerrar.TabStop = false;
            this.piccerrar.Click += new System.EventHandler(this.piccerrar_Click);
            // 
            // picmin
            // 
            this.picmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picmin.Image = global::Proyecto_escuela.Properties.Resources.minimizar;
            this.picmin.Location = new System.Drawing.Point(498, 12);
            this.picmin.Name = "picmin";
            this.picmin.Size = new System.Drawing.Size(30, 30);
            this.picmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picmin.TabIndex = 52;
            this.picmin.TabStop = false;
            this.picmin.Click += new System.EventHandler(this.picmin_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Black;
            this.lbltitulo.Location = new System.Drawing.Point(162, 95);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(259, 23);
            this.lbltitulo.TabIndex = 51;
            this.lbltitulo.Text = "Reestablecer contraseña";
            // 
            // btniniciarsesion
            // 
            this.btniniciarsesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btniniciarsesion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btniniciarsesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btniniciarsesion.BorderRadius = 20;
            this.btniniciarsesion.BorderSize = 0;
            this.btniniciarsesion.FlatAppearance.BorderSize = 0;
            this.btniniciarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciarsesion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciarsesion.ForeColor = System.Drawing.Color.White;
            this.btniniciarsesion.Location = new System.Drawing.Point(65, 223);
            this.btniniciarsesion.Name = "btniniciarsesion";
            this.btniniciarsesion.Size = new System.Drawing.Size(451, 47);
            this.btniniciarsesion.TabIndex = 61;
            this.btniniciarsesion.Text = "Restablecer contraseña";
            this.btniniciarsesion.TextColor = System.Drawing.Color.White;
            this.btniniciarsesion.UseVisualStyleBackColor = false;
            this.btniniciarsesion.Click += new System.EventHandler(this.btniniciarsesion_Click);
            // 
            // Frm_Reestablecercontraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 327);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Reestablecercontraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reestablecer contraseña";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbljane;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox piccerrar;
        private System.Windows.Forms.PictureBox picmin;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.LinkLabel linkLabelRegresar;
        private Boton.RJButton btniniciarsesion;
    }
}