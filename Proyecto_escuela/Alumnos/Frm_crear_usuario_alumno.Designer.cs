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
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_alumno = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Panel();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.lbl_matricula);
            this.groupBox1.Controls.Add(this.txt_matricula);
            this.groupBox1.Controls.Add(this.lbl_contraseña);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txt_contraseña);
            this.groupBox1.Controls.Add(this.lbl_alumno);
            this.groupBox1.Controls.Add(this.line1);
            this.groupBox1.Controls.Add(this.txt_correo);
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
            this.tableLayoutPanel1.Controls.Add(this.btnregistrar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btncancelar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 308);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 57);
            this.tableLayoutPanel1.TabIndex = 113;
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnregistrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnregistrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnregistrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnregistrar.Location = new System.Drawing.Point(3, 3);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(183, 51);
            this.btnregistrar.TabIndex = 1;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Red;
            this.btncancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btncancelar.Location = new System.Drawing.Point(192, 3);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(183, 51);
            this.btncancelar.TabIndex = 0;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(16, 98);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(354, 1);
            this.panel8.TabIndex = 112;
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
            // txt_matricula
            // 
            this.txt_matricula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_matricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matricula.Enabled = false;
            this.txt_matricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricula.ForeColor = System.Drawing.Color.Gray;
            this.txt_matricula.Location = new System.Drawing.Point(16, 67);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(354, 25);
            this.txt_matricula.TabIndex = 104;
            this.txt_matricula.Text = "Matricula";
            this.txt_matricula.Enter += new System.EventHandler(this.txt_matricula_Enter);
            this.txt_matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_matricula_KeyPress);
            this.txt_matricula.Leave += new System.EventHandler(this.txt_matricula_Leave);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(20, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 1);
            this.panel1.TabIndex = 109;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.Color.Gray;
            this.txt_contraseña.Location = new System.Drawing.Point(20, 241);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(354, 25);
            this.txt_contraseña.TabIndex = 106;
            this.txt_contraseña.Text = "Contraseña";
            this.txt_contraseña.Enter += new System.EventHandler(this.txt_contraseña_Enter);
            this.txt_contraseña.Leave += new System.EventHandler(this.txt_contraseña_Leave);
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
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Gray;
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line1.Location = new System.Drawing.Point(16, 184);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(354, 1);
            this.line1.TabIndex = 107;
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.Gray;
            this.txt_correo.Location = new System.Drawing.Point(16, 151);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(354, 25);
            this.txt_correo.TabIndex = 105;
            this.txt_correo.Text = "Correo";
            this.txt_correo.Enter += new System.EventHandler(this.txt_correo_Enter);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
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
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label lbl_alumno;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.TextBox txt_correo;
        public System.Windows.Forms.TextBox txt_matricula;
    }
}