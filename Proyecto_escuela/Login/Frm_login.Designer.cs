
namespace Proyecto_escuela
{
    partial class Frm_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.line1 = new System.Windows.Forms.Panel();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.linkLabelregistrar = new System.Windows.Forms.LinkLabel();
            this.linkLabelcontraseña = new System.Windows.Forms.LinkLabel();
            this.btniniciarsesion = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.piccerrar = new System.Windows.Forms.PictureBox();
            this.picmin = new System.Windows.Forms.PictureBox();
            this.lbljane = new System.Windows.Forms.Label();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.panel_contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmin)).BeginInit();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_contenedor.Controls.Add(this.line2);
            this.panel_contenedor.Controls.Add(this.line1);
            this.panel_contenedor.Controls.Add(this.txtcontraseña);
            this.panel_contenedor.Controls.Add(this.txtusuario);
            this.panel_contenedor.Controls.Add(this.linkLabelregistrar);
            this.panel_contenedor.Controls.Add(this.linkLabelcontraseña);
            this.panel_contenedor.Controls.Add(this.btniniciarsesion);
            this.panel_contenedor.Controls.Add(this.lbltitulo);
            this.panel_contenedor.Controls.Add(this.lblerror);
            this.panel_contenedor.Controls.Add(this.piccerrar);
            this.panel_contenedor.Controls.Add(this.picmin);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(160, 0);
            this.panel_contenedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(446, 304);
            this.panel_contenedor.TabIndex = 39;
            // 
            // line2
            // 
            this.line2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.line2.BackColor = System.Drawing.Color.Gray;
            this.line2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line2.Location = new System.Drawing.Point(57, 150);
            this.line2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(339, 1);
            this.line2.TabIndex = 57;
            // 
            // line1
            // 
            this.line1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.line1.BackColor = System.Drawing.Color.Gray;
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line1.Location = new System.Drawing.Point(57, 111);
            this.line1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(339, 1);
            this.line1.TabIndex = 56;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcontraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtcontraseña.Location = new System.Drawing.Point(57, 125);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(338, 20);
            this.txtcontraseña.TabIndex = 3;
            this.txtcontraseña.Text = "Contraseña";
            this.txtcontraseña.Click += new System.EventHandler(this.txtcontraseña_Click);
            this.txtcontraseña.Enter += new System.EventHandler(this.txtcontraseña_Enter);
            this.txtcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontraseña_KeyPress);
            this.txtcontraseña.Leave += new System.EventHandler(this.txtcontraseña_Leave);
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.Gray;
            this.txtusuario.Location = new System.Drawing.Point(57, 86);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(338, 20);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.Text = "Correo";
            this.txtusuario.Click += new System.EventHandler(this.txtusuario_Click);
            this.txtusuario.Enter += new System.EventHandler(this.txtusuario_Enter);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            // 
            // linkLabelregistrar
            // 
            this.linkLabelregistrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabelregistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelregistrar.AutoSize = true;
            this.linkLabelregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelregistrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelregistrar.ForeColor = System.Drawing.Color.Black;
            this.linkLabelregistrar.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabelregistrar.Location = new System.Drawing.Point(127, 237);
            this.linkLabelregistrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelregistrar.Name = "linkLabelregistrar";
            this.linkLabelregistrar.Size = new System.Drawing.Size(208, 19);
            this.linkLabelregistrar.TabIndex = 5;
            this.linkLabelregistrar.TabStop = true;
            this.linkLabelregistrar.Text = "¿No tienes usuario? registrate";
            this.linkLabelregistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelregistrar_LinkClicked);
            // 
            // linkLabelcontraseña
            // 
            this.linkLabelcontraseña.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabelcontraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelcontraseña.AutoSize = true;
            this.linkLabelcontraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelcontraseña.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelcontraseña.ForeColor = System.Drawing.Color.Black;
            this.linkLabelcontraseña.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabelcontraseña.Location = new System.Drawing.Point(127, 262);
            this.linkLabelcontraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelcontraseña.Name = "linkLabelcontraseña";
            this.linkLabelcontraseña.Size = new System.Drawing.Size(216, 19);
            this.linkLabelcontraseña.TabIndex = 1;
            this.linkLabelcontraseña.TabStop = true;
            this.linkLabelcontraseña.Text = "¿Has olvidado la contraseña?";
            this.linkLabelcontraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelcontraseña_LinkClicked);
            // 
            // btniniciarsesion
            // 
            this.btniniciarsesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btniniciarsesion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btniniciarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniniciarsesion.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btniniciarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciarsesion.ForeColor = System.Drawing.Color.Black;
            this.btniniciarsesion.Location = new System.Drawing.Point(57, 190);
            this.btniniciarsesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btniniciarsesion.Name = "btniniciarsesion";
            this.btniniciarsesion.Size = new System.Drawing.Size(338, 32);
            this.btniniciarsesion.TabIndex = 4;
            this.btniniciarsesion.Text = "Iniciar Sesion";
            this.btniniciarsesion.UseVisualStyleBackColor = false;
            this.btniniciarsesion.Click += new System.EventHandler(this.btniniciarsesion_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Black;
            this.lbltitulo.Location = new System.Drawing.Point(182, 21);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(106, 21);
            this.lbltitulo.TabIndex = 50;
            this.lbltitulo.Text = "Iniciar sesion";
            // 
            // lblerror
            // 
            this.lblerror.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Century Gothic", 8.7F);
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(58, 120);
            this.lblerror.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            this.lblerror.TabIndex = 45;
            // 
            // piccerrar
            // 
            this.piccerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piccerrar.Image = global::Proyecto_escuela.Properties.Resources.cerrar;
            this.piccerrar.Location = new System.Drawing.Point(414, 10);
            this.piccerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.piccerrar.Name = "piccerrar";
            this.piccerrar.Size = new System.Drawing.Size(22, 24);
            this.piccerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piccerrar.TabIndex = 44;
            this.piccerrar.TabStop = false;
            this.piccerrar.Click += new System.EventHandler(this.piccerrar_Click);
            // 
            // picmin
            // 
            this.picmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picmin.Image = global::Proyecto_escuela.Properties.Resources.minimizar;
            this.picmin.Location = new System.Drawing.Point(387, 10);
            this.picmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picmin.Name = "picmin";
            this.picmin.Size = new System.Drawing.Size(22, 24);
            this.picmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picmin.TabIndex = 43;
            this.picmin.TabStop = false;
            this.picmin.Click += new System.EventHandler(this.picmin_Click);
            // 
            // lbljane
            // 
            this.lbljane.AutoSize = true;
            this.lbljane.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljane.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbljane.Location = new System.Drawing.Point(35, 284);
            this.lbljane.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbljane.Name = "lbljane";
            this.lbljane.Size = new System.Drawing.Size(94, 16);
            this.lbljane.TabIndex = 2;
            this.lbljane.Text = "JANE SOFTWARE";
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_logo.Controls.Add(this.picture_logo);
            this.panel_logo.Controls.Add(this.lbljane);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_logo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(160, 304);
            this.panel_logo.TabIndex = 27;
            // 
            // picture_logo
            // 
            this.picture_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture_logo.Image = global::Proyecto_escuela.Properties.Resources.colegioalfa;
            this.picture_logo.Location = new System.Drawing.Point(-7, 64);
            this.picture_logo.Margin = new System.Windows.Forms.Padding(2);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(178, 171);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_logo.TabIndex = 4;
            this.picture_logo.TabStop = false;
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(606, 304);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.panel_contenedor.ResumeLayout(false);
            this.panel_contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmin)).EndInit();
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.LinkLabel linkLabelregistrar;
        private System.Windows.Forms.Button btniniciarsesion;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.PictureBox piccerrar;
        private System.Windows.Forms.PictureBox picmin;
        private System.Windows.Forms.LinkLabel linkLabelcontraseña;
        private System.Windows.Forms.Label lbljane;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox picture_logo;
    }
}

