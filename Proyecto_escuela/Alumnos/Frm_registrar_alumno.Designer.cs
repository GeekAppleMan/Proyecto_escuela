
namespace Proyecto_escuela
{
    partial class Frm_registrar_alumno
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
            this.gb_foto_perfil = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_dispositivos = new System.Windows.Forms.ComboBox();
            this.picture_captura = new System.Windows.Forms.PictureBox();
            this.picture_tiempo_real = new System.Windows.Forms.PictureBox();
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_alumno = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.combo_grupo = new System.Windows.Forms.ComboBox();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.lbl_grupo = new System.Windows.Forms.Label();
            this.btn_capturar = new Proyecto_escuela.Boton.RJButton();
            this.btn_registrar_alumno = new Proyecto_escuela.Boton.RJButton();
            this.btn_cancelar = new Proyecto_escuela.Boton.RJButton();
            this.lbltoggle = new System.Windows.Forms.Label();
            this.Toggle_encender_camara = new Proyecto_escuela.RJToggleButton.RJToggleButton();
            this.txt_matricula = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_nombres = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_apellidos = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_direccion = new Proyecto_escuela.Textbox.Rjtextbox();
            this.rjdatetime1 = new Proyecto_escuela.Datetime.Rjdatetime();
            this.gb_foto_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_captura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tiempo_real)).BeginInit();
            this.gb_datos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_foto_perfil
            // 
            this.gb_foto_perfil.Controls.Add(this.lbltoggle);
            this.gb_foto_perfil.Controls.Add(this.Toggle_encender_camara);
            this.gb_foto_perfil.Controls.Add(this.btn_cancelar);
            this.gb_foto_perfil.Controls.Add(this.btn_registrar_alumno);
            this.gb_foto_perfil.Controls.Add(this.btn_capturar);
            this.gb_foto_perfil.Controls.Add(this.panel7);
            this.gb_foto_perfil.Controls.Add(this.label1);
            this.gb_foto_perfil.Controls.Add(this.combo_dispositivos);
            this.gb_foto_perfil.Controls.Add(this.picture_captura);
            this.gb_foto_perfil.Controls.Add(this.picture_tiempo_real);
            this.gb_foto_perfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_foto_perfil.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gb_foto_perfil.Location = new System.Drawing.Point(277, 0);
            this.gb_foto_perfil.Name = "gb_foto_perfil";
            this.gb_foto_perfil.Size = new System.Drawing.Size(661, 657);
            this.gb_foto_perfil.TabIndex = 83;
            this.gb_foto_perfil.TabStop = false;
            this.gb_foto_perfil.Text = "Capturar foto de perfil";
            this.gb_foto_perfil.Enter += new System.EventHandler(this.gb_foto_perfil_Enter);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(42, 90);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 1);
            this.panel7.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 83;
            this.label1.Text = "Seleccionar webcam";
            // 
            // combo_dispositivos
            // 
            this.combo_dispositivos.BackColor = System.Drawing.Color.White;
            this.combo_dispositivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.combo_dispositivos.FormattingEnabled = true;
            this.combo_dispositivos.Location = new System.Drawing.Point(42, 56);
            this.combo_dispositivos.Name = "combo_dispositivos";
            this.combo_dispositivos.Size = new System.Drawing.Size(278, 28);
            this.combo_dispositivos.TabIndex = 0;
            this.combo_dispositivos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_grupo_KeyPress);
            this.combo_dispositivos.MouseHover += new System.EventHandler(this.combo_dispositivos_MouseHover);
            // 
            // picture_captura
            // 
            this.picture_captura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_captura.Location = new System.Drawing.Point(339, 116);
            this.picture_captura.Name = "picture_captura";
            this.picture_captura.Size = new System.Drawing.Size(278, 270);
            this.picture_captura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_captura.TabIndex = 1;
            this.picture_captura.TabStop = false;
            // 
            // picture_tiempo_real
            // 
            this.picture_tiempo_real.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_tiempo_real.Location = new System.Drawing.Point(42, 116);
            this.picture_tiempo_real.Name = "picture_tiempo_real";
            this.picture_tiempo_real.Size = new System.Drawing.Size(278, 270);
            this.picture_tiempo_real.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_tiempo_real.TabIndex = 0;
            this.picture_tiempo_real.TabStop = false;
            // 
            // gb_datos
            // 
            this.gb_datos.Controls.Add(this.tableLayoutPanel1);
            this.gb_datos.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_datos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gb_datos.Location = new System.Drawing.Point(0, 0);
            this.gb_datos.Name = "gb_datos";
            this.gb_datos.Size = new System.Drawing.Size(277, 657);
            this.gb_datos.TabIndex = 82;
            this.gb_datos.TabStop = false;
            this.gb_datos.Text = "Datos del alumno";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rjdatetime1, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_direccion, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_apellidos, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_matricula, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_nombres, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_matricula, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_alumno, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_apellidos, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_direccion, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.combo_grupo, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lbl_fecha_nacimiento, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_grupo, 0, 10);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 632);
            this.tableLayoutPanel1.TabIndex = 104;
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.Location = new System.Drawing.Point(3, 29);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(265, 23);
            this.lbl_matricula.TabIndex = 102;
            this.lbl_matricula.Text = "Matricula del alumno";
            // 
            // lbl_alumno
            // 
            this.lbl_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_alumno.AutoSize = true;
            this.lbl_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alumno.Location = new System.Drawing.Point(3, 133);
            this.lbl_alumno.Name = "lbl_alumno";
            this.lbl_alumno.Size = new System.Drawing.Size(265, 23);
            this.lbl_alumno.TabIndex = 82;
            this.lbl_alumno.Text = "Nombres del alumno";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(3, 237);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(265, 23);
            this.lbl_apellidos.TabIndex = 85;
            this.lbl_apellidos.Text = "Apellidos del alumno";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(3, 341);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(265, 23);
            this.lbl_direccion.TabIndex = 88;
            this.lbl_direccion.Text = "Direccion";
            // 
            // combo_grupo
            // 
            this.combo_grupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_grupo.BackColor = System.Drawing.Color.White;
            this.combo_grupo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.combo_grupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.combo_grupo.FormattingEnabled = true;
            this.combo_grupo.Items.AddRange(new object[] {
            "1:A",
            "2:A",
            "3:A",
            "4:A",
            "5:A",
            "6:A"});
            this.combo_grupo.Location = new System.Drawing.Point(3, 575);
            this.combo_grupo.Name = "combo_grupo";
            this.combo_grupo.Size = new System.Drawing.Size(265, 31);
            this.combo_grupo.TabIndex = 5;
            this.combo_grupo.Text = "1:A";
            this.combo_grupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_grupo_KeyPress);
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(3, 445);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(265, 23);
            this.lbl_fecha_nacimiento.TabIndex = 96;
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento";
            // 
            // lbl_grupo
            // 
            this.lbl_grupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_grupo.AutoSize = true;
            this.lbl_grupo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupo.Location = new System.Drawing.Point(3, 549);
            this.lbl_grupo.Name = "lbl_grupo";
            this.lbl_grupo.Size = new System.Drawing.Size(265, 23);
            this.lbl_grupo.TabIndex = 98;
            this.lbl_grupo.Text = "grupo";
            // 
            // btn_capturar
            // 
            this.btn_capturar.BackColor = System.Drawing.Color.Green;
            this.btn_capturar.BackgroundColor = System.Drawing.Color.Green;
            this.btn_capturar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_capturar.BorderRadius = 15;
            this.btn_capturar.BorderSize = 0;
            this.btn_capturar.FlatAppearance.BorderSize = 0;
            this.btn_capturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capturar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capturar.ForeColor = System.Drawing.Color.White;
            this.btn_capturar.Location = new System.Drawing.Point(42, 438);
            this.btn_capturar.Name = "btn_capturar";
            this.btn_capturar.Size = new System.Drawing.Size(575, 40);
            this.btn_capturar.TabIndex = 1;
            this.btn_capturar.Text = "Capturar foto de perfil";
            this.btn_capturar.TextColor = System.Drawing.Color.White;
            this.btn_capturar.UseVisualStyleBackColor = false;
            this.btn_capturar.Click += new System.EventHandler(this.btn_capturar_foto_Click);
            // 
            // btn_registrar_alumno
            // 
            this.btn_registrar_alumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_registrar_alumno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_registrar_alumno.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_registrar_alumno.BorderRadius = 15;
            this.btn_registrar_alumno.BorderSize = 0;
            this.btn_registrar_alumno.FlatAppearance.BorderSize = 0;
            this.btn_registrar_alumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_alumno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_alumno.ForeColor = System.Drawing.Color.White;
            this.btn_registrar_alumno.Location = new System.Drawing.Point(42, 521);
            this.btn_registrar_alumno.Name = "btn_registrar_alumno";
            this.btn_registrar_alumno.Size = new System.Drawing.Size(575, 40);
            this.btn_registrar_alumno.TabIndex = 2;
            this.btn_registrar_alumno.Text = "Registrar alumno";
            this.btn_registrar_alumno.TextColor = System.Drawing.Color.White;
            this.btn_registrar_alumno.UseVisualStyleBackColor = false;
            this.btn_registrar_alumno.Click += new System.EventHandler(this.btn_registrar_Click_1);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.BackgroundColor = System.Drawing.Color.Red;
            this.btn_cancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cancelar.BorderRadius = 15;
            this.btn_cancelar.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(42, 566);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(575, 40);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar registro";
            this.btn_cancelar.TextColor = System.Drawing.Color.White;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // lbltoggle
            // 
            this.lbltoggle.AutoSize = true;
            this.lbltoggle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoggle.Location = new System.Drawing.Point(390, 61);
            this.lbltoggle.Name = "lbltoggle";
            this.lbltoggle.Size = new System.Drawing.Size(108, 23);
            this.lbltoggle.TabIndex = 93;
            this.lbltoggle.Text = "Apagada";
            // 
            // Toggle_encender_camara
            // 
            this.Toggle_encender_camara.AutoSize = true;
            this.Toggle_encender_camara.Location = new System.Drawing.Point(339, 61);
            this.Toggle_encender_camara.MinimumSize = new System.Drawing.Size(45, 22);
            this.Toggle_encender_camara.Name = "Toggle_encender_camara";
            this.Toggle_encender_camara.OffBackColor = System.Drawing.Color.Gray;
            this.Toggle_encender_camara.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.Toggle_encender_camara.OnBackColor = System.Drawing.Color.Lime;
            this.Toggle_encender_camara.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.Toggle_encender_camara.Size = new System.Drawing.Size(45, 22);
            this.Toggle_encender_camara.TabIndex = 92;
            this.Toggle_encender_camara.UseVisualStyleBackColor = true;
            this.Toggle_encender_camara.CheckedChanged += new System.EventHandler(this.Toggle_encender_camara_CheckedChanged);
            // 
            // txt_matricula
            // 
            this.txt_matricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_matricula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_matricula.BorderColor = System.Drawing.Color.DimGray;
            this.txt_matricula.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_matricula.BorderRadius = 10;
            this.txt_matricula.BorderSize = 2;
            this.txt_matricula.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_matricula.ForeColor = System.Drawing.Color.Black;
            this.txt_matricula.Location = new System.Drawing.Point(4, 56);
            this.txt_matricula.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matricula.Multiline = false;
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Padding = new System.Windows.Forms.Padding(7);
            this.txt_matricula.PasswordChar = false;
            this.txt_matricula.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_matricula.PlaceholderText = "Matricula";
            this.txt_matricula.Size = new System.Drawing.Size(263, 36);
            this.txt_matricula.TabIndex = 0;
            this.txt_matricula.Texts = "";
            this.txt_matricula.UnderlinedStyle = false;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombres.BorderColor = System.Drawing.Color.DimGray;
            this.txt_nombres.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_nombres.BorderRadius = 10;
            this.txt_nombres.BorderSize = 2;
            this.txt_nombres.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_nombres.ForeColor = System.Drawing.Color.Black;
            this.txt_nombres.Location = new System.Drawing.Point(4, 160);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombres.Multiline = false;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Padding = new System.Windows.Forms.Padding(7);
            this.txt_nombres.PasswordChar = false;
            this.txt_nombres.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nombres.PlaceholderText = "Nombres";
            this.txt_nombres.Size = new System.Drawing.Size(263, 36);
            this.txt_nombres.TabIndex = 1;
            this.txt_nombres.Texts = "";
            this.txt_nombres.UnderlinedStyle = false;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellidos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_apellidos.BorderColor = System.Drawing.Color.DimGray;
            this.txt_apellidos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_apellidos.BorderRadius = 10;
            this.txt_apellidos.BorderSize = 2;
            this.txt_apellidos.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_apellidos.ForeColor = System.Drawing.Color.Black;
            this.txt_apellidos.Location = new System.Drawing.Point(4, 264);
            this.txt_apellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidos.Multiline = false;
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Padding = new System.Windows.Forms.Padding(7);
            this.txt_apellidos.PasswordChar = false;
            this.txt_apellidos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_apellidos.PlaceholderText = "Apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(263, 36);
            this.txt_apellidos.TabIndex = 2;
            this.txt_apellidos.Texts = "";
            this.txt_apellidos.UnderlinedStyle = false;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_direccion.BorderColor = System.Drawing.Color.DimGray;
            this.txt_direccion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_direccion.BorderRadius = 10;
            this.txt_direccion.BorderSize = 2;
            this.txt_direccion.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_direccion.ForeColor = System.Drawing.Color.Black;
            this.txt_direccion.Location = new System.Drawing.Point(4, 368);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Multiline = false;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Padding = new System.Windows.Forms.Padding(7);
            this.txt_direccion.PasswordChar = false;
            this.txt_direccion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_direccion.PlaceholderText = "Direccion";
            this.txt_direccion.Size = new System.Drawing.Size(263, 36);
            this.txt_direccion.TabIndex = 3;
            this.txt_direccion.Texts = "";
            this.txt_direccion.UnderlinedStyle = false;
            // 
            // rjdatetime1
            // 
            this.rjdatetime1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjdatetime1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.rjdatetime1.BorderSize = 2;
            this.rjdatetime1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjdatetime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjdatetime1.Location = new System.Drawing.Point(3, 471);
            this.rjdatetime1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjdatetime1.Name = "rjdatetime1";
            this.rjdatetime1.Size = new System.Drawing.Size(265, 35);
            this.rjdatetime1.SkinColor = System.Drawing.Color.Transparent;
            this.rjdatetime1.TabIndex = 4;
            this.rjdatetime1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            // 
            // Frm_registrar_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(938, 657);
            this.Controls.Add(this.gb_foto_perfil);
            this.Controls.Add(this.gb_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_registrar_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar alumno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_registrar_alumno_FormClosed);
            this.Load += new System.EventHandler(this.Frm_registrar_alumno_Load);
            this.gb_foto_perfil.ResumeLayout(false);
            this.gb_foto_perfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_captura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tiempo_real)).EndInit();
            this.gb_datos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_foto_perfil;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_dispositivos;
        private System.Windows.Forms.PictureBox picture_captura;
        private System.Windows.Forms.PictureBox picture_tiempo_real;
        private System.Windows.Forms.GroupBox gb_datos;
        private System.Windows.Forms.Label lbl_grupo;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.ComboBox combo_grupo;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_alumno;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Boton.RJButton btn_capturar;
        private Boton.RJButton btn_registrar_alumno;
        private Boton.RJButton btn_cancelar;
        private System.Windows.Forms.Label lbltoggle;
        private RJToggleButton.RJToggleButton Toggle_encender_camara;
        private Textbox.Rjtextbox txt_matricula;
        private Textbox.Rjtextbox txt_nombres;
        private Textbox.Rjtextbox txt_apellidos;
        private Textbox.Rjtextbox txt_direccion;
        private Datetime.Rjdatetime rjdatetime1;
    }
}