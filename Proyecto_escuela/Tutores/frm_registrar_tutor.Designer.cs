namespace Proyecto_escuela
{
    partial class frm_registrar_tutor
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
            this.combo_dispositivos = new System.Windows.Forms.ComboBox();
            this.lbltoggle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picture_captura = new System.Windows.Forms.PictureBox();
            this.picture_tiempo_real = new System.Windows.Forms.PictureBox();
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.combo_parentesco = new System.Windows.Forms.ComboBox();
            this.lbl_tutor = new System.Windows.Forms.Label();
            this.lbl_parentesco = new System.Windows.Forms.Label();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Toggle_encender_camara = new Proyecto_escuela.RJToggleButton.RJToggleButton();
            this.btn_capturar_foto = new Proyecto_escuela.Boton.RJButton();
            this.btn_registrar = new Proyecto_escuela.Boton.RJButton();
            this.btn_cancelar = new Proyecto_escuela.Boton.RJButton();
            this.txt_correo = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_telefono = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_direccion = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_apellidos = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_nombres = new Proyecto_escuela.Textbox.Rjtextbox();
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
            this.gb_foto_perfil.Controls.Add(this.combo_dispositivos);
            this.gb_foto_perfil.Controls.Add(this.lbltoggle);
            this.gb_foto_perfil.Controls.Add(this.Toggle_encender_camara);
            this.gb_foto_perfil.Controls.Add(this.btn_capturar_foto);
            this.gb_foto_perfil.Controls.Add(this.btn_registrar);
            this.gb_foto_perfil.Controls.Add(this.btn_cancelar);
            this.gb_foto_perfil.Controls.Add(this.label1);
            this.gb_foto_perfil.Controls.Add(this.picture_captura);
            this.gb_foto_perfil.Controls.Add(this.picture_tiempo_real);
            this.gb_foto_perfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_foto_perfil.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gb_foto_perfil.Location = new System.Drawing.Point(287, 0);
            this.gb_foto_perfil.Name = "gb_foto_perfil";
            this.gb_foto_perfil.Size = new System.Drawing.Size(651, 657);
            this.gb_foto_perfil.TabIndex = 87;
            this.gb_foto_perfil.TabStop = false;
            this.gb_foto_perfil.Text = "Capturar foto de perfil";
            // 
            // combo_dispositivos
            // 
            this.combo_dispositivos.BackColor = System.Drawing.Color.White;
            this.combo_dispositivos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_dispositivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.combo_dispositivos.FormattingEnabled = true;
            this.combo_dispositivos.Location = new System.Drawing.Point(42, 56);
            this.combo_dispositivos.Name = "combo_dispositivos";
            this.combo_dispositivos.Size = new System.Drawing.Size(278, 28);
            this.combo_dispositivos.TabIndex = 92;
            this.combo_dispositivos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_dispositivos_KeyPress);
            this.combo_dispositivos.MouseHover += new System.EventHandler(this.combo_dispositivos_MouseHover);
            // 
            // lbltoggle
            // 
            this.lbltoggle.AutoSize = true;
            this.lbltoggle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoggle.Location = new System.Drawing.Point(390, 61);
            this.lbltoggle.Name = "lbltoggle";
            this.lbltoggle.Size = new System.Drawing.Size(108, 23);
            this.lbltoggle.TabIndex = 91;
            this.lbltoggle.Text = "Apagada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 83;
            this.label1.Text = "Seleccionar webcam";
            // 
            // picture_captura
            // 
            this.picture_captura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_captura.Location = new System.Drawing.Point(339, 101);
            this.picture_captura.Name = "picture_captura";
            this.picture_captura.Size = new System.Drawing.Size(278, 254);
            this.picture_captura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_captura.TabIndex = 1;
            this.picture_captura.TabStop = false;
            // 
            // picture_tiempo_real
            // 
            this.picture_tiempo_real.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_tiempo_real.Location = new System.Drawing.Point(42, 101);
            this.picture_tiempo_real.Name = "picture_tiempo_real";
            this.picture_tiempo_real.Size = new System.Drawing.Size(278, 254);
            this.picture_tiempo_real.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_tiempo_real.TabIndex = 0;
            this.picture_tiempo_real.TabStop = false;
            // 
            // gb_datos
            // 
            this.gb_datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_datos.Controls.Add(this.tableLayoutPanel1);
            this.gb_datos.Controls.Add(this.panel8);
            this.gb_datos.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_datos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gb_datos.Location = new System.Drawing.Point(0, 0);
            this.gb_datos.Name = "gb_datos";
            this.gb_datos.Size = new System.Drawing.Size(287, 657);
            this.gb_datos.TabIndex = 86;
            this.gb_datos.TabStop = false;
            this.gb_datos.Text = "Datos del tutor";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.combo_parentesco, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.rjdatetime1, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.txt_correo, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_telefono, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_direccion, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_apellidos, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tutor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_parentesco, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.lbl_fecha_nacimiento, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lbl_correo, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_telefono, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_direccion, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_apellidos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_nombres, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 632);
            this.tableLayoutPanel1.TabIndex = 103;
            // 
            // combo_parentesco
            // 
            this.combo_parentesco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_parentesco.BackColor = System.Drawing.Color.White;
            this.combo_parentesco.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_parentesco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.combo_parentesco.FormattingEnabled = true;
            this.combo_parentesco.Items.AddRange(new object[] {
            "Padre",
            "Madre",
            "Tutor"});
            this.combo_parentesco.Location = new System.Drawing.Point(3, 588);
            this.combo_parentesco.Name = "combo_parentesco";
            this.combo_parentesco.Size = new System.Drawing.Size(275, 29);
            this.combo_parentesco.TabIndex = 106;
            this.combo_parentesco.Text = "Padre";
            this.combo_parentesco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_dispositivos_KeyPress);
            // 
            // lbl_tutor
            // 
            this.lbl_tutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tutor.AutoSize = true;
            this.lbl_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tutor.Location = new System.Drawing.Point(3, 11);
            this.lbl_tutor.Name = "lbl_tutor";
            this.lbl_tutor.Size = new System.Drawing.Size(275, 23);
            this.lbl_tutor.TabIndex = 82;
            this.lbl_tutor.Text = "Nombres del tutor";
            // 
            // lbl_parentesco
            // 
            this.lbl_parentesco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_parentesco.AutoSize = true;
            this.lbl_parentesco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parentesco.Location = new System.Drawing.Point(3, 551);
            this.lbl_parentesco.Name = "lbl_parentesco";
            this.lbl_parentesco.Size = new System.Drawing.Size(275, 23);
            this.lbl_parentesco.TabIndex = 98;
            this.lbl_parentesco.Text = "parentesco";
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(3, 461);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(275, 23);
            this.lbl_fecha_nacimiento.TabIndex = 96;
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento";
            // 
            // lbl_correo
            // 
            this.lbl_correo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(3, 371);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(275, 23);
            this.lbl_correo.TabIndex = 94;
            this.lbl_correo.Text = "Correo";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(3, 281);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(275, 23);
            this.lbl_telefono.TabIndex = 91;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(3, 191);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(275, 23);
            this.lbl_direccion.TabIndex = 88;
            this.lbl_direccion.Text = "Direccion";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(3, 101);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(275, 23);
            this.lbl_apellidos.TabIndex = 85;
            this.lbl_apellidos.Text = "Apellidos del tutor";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(20, 691);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(238, 1);
            this.panel8.TabIndex = 103;
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
            this.Toggle_encender_camara.TabIndex = 90;
            this.Toggle_encender_camara.UseVisualStyleBackColor = true;
            this.Toggle_encender_camara.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // btn_capturar_foto
            // 
            this.btn_capturar_foto.BackColor = System.Drawing.Color.Green;
            this.btn_capturar_foto.BackgroundColor = System.Drawing.Color.Green;
            this.btn_capturar_foto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_capturar_foto.BorderRadius = 15;
            this.btn_capturar_foto.BorderSize = 0;
            this.btn_capturar_foto.FlatAppearance.BorderSize = 0;
            this.btn_capturar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capturar_foto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capturar_foto.ForeColor = System.Drawing.Color.White;
            this.btn_capturar_foto.Location = new System.Drawing.Point(42, 393);
            this.btn_capturar_foto.Name = "btn_capturar_foto";
            this.btn_capturar_foto.Size = new System.Drawing.Size(575, 40);
            this.btn_capturar_foto.TabIndex = 87;
            this.btn_capturar_foto.Text = "Capturar foto de perfil";
            this.btn_capturar_foto.TextColor = System.Drawing.Color.White;
            this.btn_capturar_foto.UseVisualStyleBackColor = false;
            this.btn_capturar_foto.Click += new System.EventHandler(this.btn_capturar_foto_Click_1);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_registrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_registrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_registrar.BorderRadius = 15;
            this.btn_registrar.BorderSize = 0;
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(41, 519);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(575, 40);
            this.btn_registrar.TabIndex = 86;
            this.btn_registrar.Text = "Registrar tutor";
            this.btn_registrar.TextColor = System.Drawing.Color.White;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click_1);
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
            this.btn_cancelar.Location = new System.Drawing.Point(41, 565);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(575, 40);
            this.btn_cancelar.TabIndex = 85;
            this.btn_cancelar.Text = "Cancelar registro";
            this.btn_cancelar.TextColor = System.Drawing.Color.White;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_correo.BorderColor = System.Drawing.Color.DimGray;
            this.txt_correo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_correo.BorderRadius = 10;
            this.txt_correo.BorderSize = 2;
            this.txt_correo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_correo.ForeColor = System.Drawing.Color.Black;
            this.txt_correo.Location = new System.Drawing.Point(4, 409);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.Multiline = false;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Padding = new System.Windows.Forms.Padding(7);
            this.txt_correo.PasswordChar = false;
            this.txt_correo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_correo.PlaceholderText = "Correo";
            this.txt_correo.Size = new System.Drawing.Size(273, 36);
            this.txt_correo.TabIndex = 105;
            this.txt_correo.Texts = "";
            this.txt_correo.UnderlinedStyle = false;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_telefono.BorderColor = System.Drawing.Color.DimGray;
            this.txt_telefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_telefono.BorderRadius = 10;
            this.txt_telefono.BorderSize = 2;
            this.txt_telefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_telefono.ForeColor = System.Drawing.Color.Black;
            this.txt_telefono.Location = new System.Drawing.Point(4, 319);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefono.Multiline = false;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Padding = new System.Windows.Forms.Padding(7);
            this.txt_telefono.PasswordChar = false;
            this.txt_telefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_telefono.PlaceholderText = "Telefono";
            this.txt_telefono.Size = new System.Drawing.Size(273, 36);
            this.txt_telefono.TabIndex = 104;
            this.txt_telefono.Texts = "";
            this.txt_telefono.UnderlinedStyle = false;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_direccion.BorderColor = System.Drawing.Color.DimGray;
            this.txt_direccion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_direccion.BorderRadius = 10;
            this.txt_direccion.BorderSize = 2;
            this.txt_direccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_direccion.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_direccion.ForeColor = System.Drawing.Color.Black;
            this.txt_direccion.Location = new System.Drawing.Point(4, 229);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Multiline = false;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Padding = new System.Windows.Forms.Padding(7);
            this.txt_direccion.PasswordChar = false;
            this.txt_direccion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_direccion.PlaceholderText = "Direccion";
            this.txt_direccion.Size = new System.Drawing.Size(273, 36);
            this.txt_direccion.TabIndex = 103;
            this.txt_direccion.Texts = "";
            this.txt_direccion.UnderlinedStyle = false;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_apellidos.BorderColor = System.Drawing.Color.DimGray;
            this.txt_apellidos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_apellidos.BorderRadius = 10;
            this.txt_apellidos.BorderSize = 2;
            this.txt_apellidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_apellidos.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_apellidos.ForeColor = System.Drawing.Color.Black;
            this.txt_apellidos.Location = new System.Drawing.Point(4, 139);
            this.txt_apellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidos.Multiline = false;
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Padding = new System.Windows.Forms.Padding(7);
            this.txt_apellidos.PasswordChar = false;
            this.txt_apellidos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_apellidos.PlaceholderText = "Apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(273, 36);
            this.txt_apellidos.TabIndex = 102;
            this.txt_apellidos.Texts = "";
            this.txt_apellidos.UnderlinedStyle = false;
            this.txt_apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellidos_KeyPress);
            // 
            // txt_nombres
            // 
            this.txt_nombres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombres.BorderColor = System.Drawing.Color.DimGray;
            this.txt_nombres.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_nombres.BorderRadius = 10;
            this.txt_nombres.BorderSize = 2;
            this.txt_nombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_nombres.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_nombres.ForeColor = System.Drawing.Color.Black;
            this.txt_nombres.Location = new System.Drawing.Point(4, 49);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombres.Multiline = false;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Padding = new System.Windows.Forms.Padding(7);
            this.txt_nombres.PasswordChar = false;
            this.txt_nombres.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nombres.PlaceholderText = "Nombres";
            this.txt_nombres.Size = new System.Drawing.Size(273, 36);
            this.txt_nombres.TabIndex = 101;
            this.txt_nombres.Texts = "";
            this.txt_nombres.UnderlinedStyle = false;
            this.txt_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombres_KeyPress);
            // 
            // rjdatetime1
            // 
            this.rjdatetime1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjdatetime1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.rjdatetime1.BorderSize = 2;
            this.rjdatetime1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjdatetime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjdatetime1.Location = new System.Drawing.Point(3, 498);
            this.rjdatetime1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjdatetime1.Name = "rjdatetime1";
            this.rjdatetime1.Size = new System.Drawing.Size(275, 35);
            this.rjdatetime1.SkinColor = System.Drawing.Color.Transparent;
            this.rjdatetime1.TabIndex = 88;
            this.rjdatetime1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            // 
            // frm_registrar_tutor
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
            this.Name = "frm_registrar_tutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar tutor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_registrar_tutor_FormClosed);
            this.Load += new System.EventHandler(this.frm_registrar_tutor_Load);
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
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox picture_captura;
        private System.Windows.Forms.PictureBox picture_tiempo_real;
        private System.Windows.Forms.GroupBox gb_datos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_tutor;
        private System.Windows.Forms.Label lbl_parentesco;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Panel panel8;
        private Textbox.Rjtextbox txt_correo;
        private Textbox.Rjtextbox txt_telefono;
        private Textbox.Rjtextbox txt_direccion;
        private Textbox.Rjtextbox txt_apellidos;
        private Textbox.Rjtextbox txt_nombres;
        private Boton.RJButton btn_capturar_foto;
        private Boton.RJButton btn_registrar;
        private Boton.RJButton btn_cancelar;
        private System.Windows.Forms.Label lbltoggle;
        private RJToggleButton.RJToggleButton Toggle_encender_camara;
        private System.Windows.Forms.ComboBox combo_dispositivos;
        private System.Windows.Forms.ComboBox combo_parentesco;
        private Datetime.Rjdatetime rjdatetime1;
    }
}