
namespace Proyecto_escuela
{
    partial class Frm_modificar_alumno
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
            this.btn_cancelar = new Proyecto_escuela.Boton.RJButton();
            this.btn_modificar = new Proyecto_escuela.Boton.RJButton();
            this.btn_capturar_foto = new Proyecto_escuela.Boton.RJButton();
            this.lbltoggle = new System.Windows.Forms.Label();
            this.Toggle_encender_camara = new Proyecto_escuela.RJToggleButton.RJToggleButton();
            this.rdb_conservar = new System.Windows.Forms.RadioButton();
            this.rdb_cambiar = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_dispositivos = new System.Windows.Forms.ComboBox();
            this.picture_captura = new System.Windows.Forms.PictureBox();
            this.picture_tiempo_real = new System.Windows.Forms.PictureBox();
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_direccion = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_apellidos = new Proyecto_escuela.Textbox.Rjtextbox();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.txt_nombres = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_matricula = new Proyecto_escuela.Textbox.Rjtextbox();
            this.combo_estatus = new System.Windows.Forms.ComboBox();
            this.lbl_alumno = new System.Windows.Forms.Label();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.combo_grupo = new System.Windows.Forms.ComboBox();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.lbl_grupo = new System.Windows.Forms.Label();
            this.gb_foto_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_captura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tiempo_real)).BeginInit();
            this.gb_datos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_foto_perfil
            // 
            this.gb_foto_perfil.Controls.Add(this.btn_cancelar);
            this.gb_foto_perfil.Controls.Add(this.btn_modificar);
            this.gb_foto_perfil.Controls.Add(this.btn_capturar_foto);
            this.gb_foto_perfil.Controls.Add(this.lbltoggle);
            this.gb_foto_perfil.Controls.Add(this.Toggle_encender_camara);
            this.gb_foto_perfil.Controls.Add(this.rdb_conservar);
            this.gb_foto_perfil.Controls.Add(this.rdb_cambiar);
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
            this.gb_foto_perfil.TabIndex = 85;
            this.gb_foto_perfil.TabStop = false;
            this.gb_foto_perfil.Text = "Capturar foto de perfil";
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
            this.btn_cancelar.Location = new System.Drawing.Point(40, 593);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(575, 40);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar registro";
            this.btn_cancelar.TextColor = System.Drawing.Color.White;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_modificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_modificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_modificar.BorderRadius = 15;
            this.btn_modificar.BorderSize = 0;
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(40, 548);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(575, 40);
            this.btn_modificar.TabIndex = 5;
            this.btn_modificar.Text = "Modificar alumno";
            this.btn_modificar.TextColor = System.Drawing.Color.White;
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
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
            this.btn_capturar_foto.Location = new System.Drawing.Point(40, 465);
            this.btn_capturar_foto.Name = "btn_capturar_foto";
            this.btn_capturar_foto.Size = new System.Drawing.Size(575, 40);
            this.btn_capturar_foto.TabIndex = 4;
            this.btn_capturar_foto.Text = "Capturar foto de perfil";
            this.btn_capturar_foto.TextColor = System.Drawing.Color.White;
            this.btn_capturar_foto.UseVisualStyleBackColor = false;
            this.btn_capturar_foto.Click += new System.EventHandler(this.btn_capturar_foto_Click);
            // 
            // lbltoggle
            // 
            this.lbltoggle.AutoSize = true;
            this.lbltoggle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoggle.Location = new System.Drawing.Point(390, 112);
            this.lbltoggle.Name = "lbltoggle";
            this.lbltoggle.Size = new System.Drawing.Size(108, 23);
            this.lbltoggle.TabIndex = 93;
            this.lbltoggle.Text = "Apagada";
            // 
            // Toggle_encender_camara
            // 
            this.Toggle_encender_camara.AutoSize = true;
            this.Toggle_encender_camara.Location = new System.Drawing.Point(339, 112);
            this.Toggle_encender_camara.MinimumSize = new System.Drawing.Size(45, 22);
            this.Toggle_encender_camara.Name = "Toggle_encender_camara";
            this.Toggle_encender_camara.OffBackColor = System.Drawing.Color.Gray;
            this.Toggle_encender_camara.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.Toggle_encender_camara.OnBackColor = System.Drawing.Color.Lime;
            this.Toggle_encender_camara.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.Toggle_encender_camara.Size = new System.Drawing.Size(45, 22);
            this.Toggle_encender_camara.TabIndex = 3;
            this.Toggle_encender_camara.UseVisualStyleBackColor = true;
            this.Toggle_encender_camara.CheckedChanged += new System.EventHandler(this.Toggle_encender_camara_CheckedChanged);
            // 
            // rdb_conservar
            // 
            this.rdb_conservar.AutoSize = true;
            this.rdb_conservar.Checked = true;
            this.rdb_conservar.Location = new System.Drawing.Point(231, 23);
            this.rdb_conservar.Name = "rdb_conservar";
            this.rdb_conservar.Size = new System.Drawing.Size(166, 24);
            this.rdb_conservar.TabIndex = 1;
            this.rdb_conservar.TabStop = true;
            this.rdb_conservar.Text = "Conservar imagen";
            this.rdb_conservar.UseVisualStyleBackColor = true;
            this.rdb_conservar.Click += new System.EventHandler(this.rdb_conservar_Click);
            // 
            // rdb_cambiar
            // 
            this.rdb_cambiar.AutoSize = true;
            this.rdb_cambiar.Location = new System.Drawing.Point(40, 23);
            this.rdb_cambiar.Name = "rdb_cambiar";
            this.rdb_cambiar.Size = new System.Drawing.Size(152, 24);
            this.rdb_cambiar.TabIndex = 0;
            this.rdb_cambiar.Text = "Cambiar imagen";
            this.rdb_cambiar.UseVisualStyleBackColor = true;
            this.rdb_cambiar.Click += new System.EventHandler(this.rdb_cambiar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(42, 140);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 1);
            this.panel7.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 83;
            this.label1.Text = "Seleccionar webcam";
            // 
            // combo_dispositivos
            // 
            this.combo_dispositivos.BackColor = System.Drawing.Color.White;
            this.combo_dispositivos.Enabled = false;
            this.combo_dispositivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.combo_dispositivos.FormattingEnabled = true;
            this.combo_dispositivos.Location = new System.Drawing.Point(42, 106);
            this.combo_dispositivos.Name = "combo_dispositivos";
            this.combo_dispositivos.Size = new System.Drawing.Size(278, 28);
            this.combo_dispositivos.TabIndex = 2;
            this.combo_dispositivos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_dispositivos_KeyPress);
            this.combo_dispositivos.MouseHover += new System.EventHandler(this.combo_dispositivos_MouseHover_1);
            // 
            // picture_captura
            // 
            this.picture_captura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_captura.Enabled = false;
            this.picture_captura.Location = new System.Drawing.Point(339, 152);
            this.picture_captura.Name = "picture_captura";
            this.picture_captura.Size = new System.Drawing.Size(278, 270);
            this.picture_captura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_captura.TabIndex = 1;
            this.picture_captura.TabStop = false;
            // 
            // picture_tiempo_real
            // 
            this.picture_tiempo_real.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_tiempo_real.Enabled = false;
            this.picture_tiempo_real.Location = new System.Drawing.Point(42, 152);
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
            this.gb_datos.TabIndex = 84;
            this.gb_datos.TabStop = false;
            this.gb_datos.Text = "Datos del alumno";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtp_fecha_nacimiento, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_direccion, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_apellidos, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_matricula, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_nombres, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_matricula, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.combo_estatus, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.lbl_alumno, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_estatus, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.combo_grupo, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lbl_apellidos, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_direccion, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_fecha_nacimiento, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_grupo, 0, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 632);
            this.tableLayoutPanel1.TabIndex = 137;
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(3, 411);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(265, 32);
            this.dtp_fecha_nacimiento.TabIndex = 4;
            this.dtp_fecha_nacimiento.Value = new System.DateTime(2021, 12, 28, 0, 0, 0, 0);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_direccion.BorderColor = System.Drawing.Color.DimGray;
            this.txt_direccion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_direccion.BorderRadius = 10;
            this.txt_direccion.BorderSize = 2;
            this.txt_direccion.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_direccion.ForeColor = System.Drawing.Color.Black;
            this.txt_direccion.Location = new System.Drawing.Point(4, 319);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Multiline = false;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Padding = new System.Windows.Forms.Padding(7);
            this.txt_direccion.PasswordChar = false;
            this.txt_direccion.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_direccion.PlaceholderText = "";
            this.txt_direccion.Size = new System.Drawing.Size(263, 36);
            this.txt_direccion.TabIndex = 3;
            this.txt_direccion.Texts = "";
            this.txt_direccion.UnderlinedStyle = false;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellidos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_apellidos.BorderColor = System.Drawing.Color.DimGray;
            this.txt_apellidos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_apellidos.BorderRadius = 10;
            this.txt_apellidos.BorderSize = 2;
            this.txt_apellidos.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_apellidos.ForeColor = System.Drawing.Color.Black;
            this.txt_apellidos.Location = new System.Drawing.Point(4, 229);
            this.txt_apellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidos.Multiline = false;
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Padding = new System.Windows.Forms.Padding(7);
            this.txt_apellidos.PasswordChar = false;
            this.txt_apellidos.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_apellidos.PlaceholderText = "";
            this.txt_apellidos.Size = new System.Drawing.Size(263, 36);
            this.txt_apellidos.TabIndex = 2;
            this.txt_apellidos.Texts = "";
            this.txt_apellidos.UnderlinedStyle = false;
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.Location = new System.Drawing.Point(3, 11);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(265, 23);
            this.lbl_matricula.TabIndex = 132;
            this.lbl_matricula.Text = "Matricula del alumno";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombres.BorderColor = System.Drawing.Color.DimGray;
            this.txt_nombres.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_nombres.BorderRadius = 10;
            this.txt_nombres.BorderSize = 2;
            this.txt_nombres.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_nombres.ForeColor = System.Drawing.Color.Black;
            this.txt_nombres.Location = new System.Drawing.Point(4, 139);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombres.Multiline = false;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Padding = new System.Windows.Forms.Padding(7);
            this.txt_nombres.PasswordChar = false;
            this.txt_nombres.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_nombres.PlaceholderText = "";
            this.txt_nombres.Size = new System.Drawing.Size(263, 36);
            this.txt_nombres.TabIndex = 1;
            this.txt_nombres.Texts = "";
            this.txt_nombres.UnderlinedStyle = false;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_matricula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_matricula.BorderColor = System.Drawing.Color.DimGray;
            this.txt_matricula.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_matricula.BorderRadius = 10;
            this.txt_matricula.BorderSize = 2;
            this.txt_matricula.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_matricula.ForeColor = System.Drawing.Color.Black;
            this.txt_matricula.Location = new System.Drawing.Point(4, 49);
            this.txt_matricula.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matricula.Multiline = false;
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Padding = new System.Windows.Forms.Padding(7);
            this.txt_matricula.PasswordChar = false;
            this.txt_matricula.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_matricula.PlaceholderText = "";
            this.txt_matricula.Size = new System.Drawing.Size(263, 36);
            this.txt_matricula.TabIndex = 0;
            this.txt_matricula.Texts = "";
            this.txt_matricula.UnderlinedStyle = false;
            // 
            // combo_estatus
            // 
            this.combo_estatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_estatus.BackColor = System.Drawing.Color.White;
            this.combo_estatus.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.combo_estatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.combo_estatus.FormattingEnabled = true;
            this.combo_estatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.combo_estatus.Location = new System.Drawing.Point(3, 593);
            this.combo_estatus.Name = "combo_estatus";
            this.combo_estatus.Size = new System.Drawing.Size(265, 31);
            this.combo_estatus.TabIndex = 6;
            this.combo_estatus.Text = "Activo";
            this.combo_estatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_dispositivos_KeyPress);
            // 
            // lbl_alumno
            // 
            this.lbl_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_alumno.AutoSize = true;
            this.lbl_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alumno.Location = new System.Drawing.Point(3, 101);
            this.lbl_alumno.Name = "lbl_alumno";
            this.lbl_alumno.Size = new System.Drawing.Size(265, 23);
            this.lbl_alumno.TabIndex = 123;
            this.lbl_alumno.Text = "Nombres del alumno";
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus.Location = new System.Drawing.Point(3, 551);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(265, 23);
            this.lbl_estatus.TabIndex = 135;
            this.lbl_estatus.Text = "Estatus";
            // 
            // combo_grupo
            // 
            this.combo_grupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.combo_grupo.Location = new System.Drawing.Point(3, 502);
            this.combo_grupo.Name = "combo_grupo";
            this.combo_grupo.Size = new System.Drawing.Size(265, 31);
            this.combo_grupo.TabIndex = 5;
            this.combo_grupo.Text = "1:A";
            this.combo_grupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_dispositivos_KeyPress);
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(3, 191);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(265, 23);
            this.lbl_apellidos.TabIndex = 125;
            this.lbl_apellidos.Text = "Apellidos del alumno";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(3, 281);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(265, 23);
            this.lbl_direccion.TabIndex = 127;
            this.lbl_direccion.Text = "Direccion";
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(3, 371);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(265, 23);
            this.lbl_fecha_nacimiento.TabIndex = 129;
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento";
            // 
            // lbl_grupo
            // 
            this.lbl_grupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_grupo.AutoSize = true;
            this.lbl_grupo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupo.Location = new System.Drawing.Point(3, 461);
            this.lbl_grupo.Name = "lbl_grupo";
            this.lbl_grupo.Size = new System.Drawing.Size(265, 23);
            this.lbl_grupo.TabIndex = 130;
            this.lbl_grupo.Text = "grupo";
            // 
            // Frm_modificar_alumno
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
            this.Name = "Frm_modificar_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Alumno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_modificar_alumno_FormClosed);
            this.Load += new System.EventHandler(this.Frm_modificar_alumno_Load);
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
        private System.Windows.Forms.RadioButton rdb_conservar;
        private System.Windows.Forms.RadioButton rdb_cambiar;
        public System.Windows.Forms.GroupBox gb_datos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_matricula;
        public System.Windows.Forms.ComboBox combo_estatus;
        private System.Windows.Forms.Label lbl_alumno;
        private System.Windows.Forms.Label lbl_estatus;
        public System.Windows.Forms.ComboBox combo_grupo;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_grupo;
        private System.Windows.Forms.Label lbltoggle;
        private RJToggleButton.RJToggleButton Toggle_encender_camara;
        private Boton.RJButton btn_cancelar;
        private Boton.RJButton btn_modificar;
        private Boton.RJButton btn_capturar_foto;
        public Textbox.Rjtextbox txt_direccion;
        public Textbox.Rjtextbox txt_apellidos;
        public Textbox.Rjtextbox txt_nombres;
        public Textbox.Rjtextbox txt_matricula;
        public System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
    }
}