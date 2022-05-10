namespace Proyecto_escuela
{
    partial class Frm_crear_usuario_alumno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_alumno = new System.Windows.Forms.Label();
            this.txt_matricula = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_correo = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_contraseña = new Proyecto_escuela.Textbox.Rjtextbox();
            this.btnregistrar = new Proyecto_escuela.Boton.RJButton();
            this.btn_cancelar = new Proyecto_escuela.Boton.RJButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txt_contraseña);
            this.groupBox1.Controls.Add(this.txt_correo);
            this.groupBox1.Controls.Add(this.txt_matricula);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.lbl_matricula);
            this.groupBox1.Controls.Add(this.lbl_contraseña);
            this.groupBox1.Controls.Add(this.lbl_alumno);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del usuario";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_cancelar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnregistrar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 308);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 57);
            this.tableLayoutPanel1.TabIndex = 113;
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.Location = new System.Drawing.Point(12, 32);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(220, 23);
            this.lbl_matricula.TabIndex = 111;
            this.lbl_matricula.Text = "Matricula del alumno";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.Location = new System.Drawing.Point(16, 201);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(244, 23);
            this.lbl_contraseña.TabIndex = 110;
            this.lbl_contraseña.Text = "Contraseña del alumno";
            // 
            // lbl_alumno
            // 
            this.lbl_alumno.AutoSize = true;
            this.lbl_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alumno.Location = new System.Drawing.Point(12, 112);
            this.lbl_alumno.Name = "lbl_alumno";
            this.lbl_alumno.Size = new System.Drawing.Size(196, 23);
            this.lbl_alumno.TabIndex = 108;
            this.lbl_alumno.Text = "Correo del alumno";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_matricula.BackColor = System.Drawing.SystemColors.Window;
            this.txt_matricula.BorderColor = System.Drawing.Color.DimGray;
            this.txt_matricula.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_matricula.BorderRadius = 10;
            this.txt_matricula.BorderSize = 2;
            this.txt_matricula.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_matricula.ForeColor = System.Drawing.Color.Black;
            this.txt_matricula.Location = new System.Drawing.Point(16, 59);
            this.txt_matricula.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matricula.Multiline = false;
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Padding = new System.Windows.Forms.Padding(7);
            this.txt_matricula.PasswordChar = false;
            this.txt_matricula.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_matricula.PlaceholderText = "Ej. 17340349";
            this.txt_matricula.Size = new System.Drawing.Size(355, 36);
            this.txt_matricula.TabIndex = 21;
            this.txt_matricula.Texts = "";
            this.txt_matricula.UnderlinedStyle = false;
            // 
            // txt_correo
            // 
            this.txt_correo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_correo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_correo.BorderColor = System.Drawing.Color.DimGray;
            this.txt_correo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_correo.BorderRadius = 10;
            this.txt_correo.BorderSize = 2;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_correo.ForeColor = System.Drawing.Color.Black;
            this.txt_correo.Location = new System.Drawing.Point(16, 145);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.Multiline = false;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Padding = new System.Windows.Forms.Padding(7);
            this.txt_correo.PasswordChar = false;
            this.txt_correo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_correo.PlaceholderText = "Ej. correo@gmail.com";
            this.txt_correo.Size = new System.Drawing.Size(354, 36);
            this.txt_correo.TabIndex = 114;
            this.txt_correo.Texts = "";
            this.txt_correo.UnderlinedStyle = false;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txt_contraseña.BorderColor = System.Drawing.Color.DimGray;
            this.txt_contraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_contraseña.BorderRadius = 10;
            this.txt_contraseña.BorderSize = 2;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_contraseña.ForeColor = System.Drawing.Color.Black;
            this.txt_contraseña.Location = new System.Drawing.Point(16, 235);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contraseña.Multiline = false;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Padding = new System.Windows.Forms.Padding(7);
            this.txt_contraseña.PasswordChar = false;
            this.txt_contraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_contraseña.PlaceholderText = "Ej. contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(354, 36);
            this.txt_contraseña.TabIndex = 115;
            this.txt_contraseña.Texts = "";
            this.txt_contraseña.UnderlinedStyle = false;
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnregistrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnregistrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnregistrar.BorderRadius = 15;
            this.btnregistrar.BorderSize = 0;
            this.btnregistrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnregistrar.FlatAppearance.BorderSize = 0;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnregistrar.ForeColor = System.Drawing.Color.White;
            this.btnregistrar.Location = new System.Drawing.Point(3, 3);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(183, 51);
            this.btnregistrar.TabIndex = 116;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.TextColor = System.Drawing.Color.White;
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.BackgroundColor = System.Drawing.Color.Red;
            this.btn_cancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cancelar.BorderRadius = 15;
            this.btn_cancelar.BorderSize = 0;
            this.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(192, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(183, 51);
            this.btn_cancelar.TabIndex = 116;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextColor = System.Drawing.Color.White;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Frm_crear_usuario_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 368);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_crear_usuario_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear usuario para alumno";
            this.Load += new System.EventHandler(this.Frm_crear_usuario_alumno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_alumno;
        public Textbox.Rjtextbox txt_contraseña;
        public Textbox.Rjtextbox txt_correo;
        public Textbox.Rjtextbox txt_matricula;
        private Boton.RJButton btn_cancelar;
        private Boton.RJButton btnregistrar;
    }
}