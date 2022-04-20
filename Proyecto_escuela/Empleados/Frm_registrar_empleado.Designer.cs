
namespace Proyecto_escuela.Empleados
{
    partial class Frm_registrar_empleado
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
            this.btn_registrar = new Proyecto_escuela.Boton.RJButton();
            this.btn_capturar_foto = new Proyecto_escuela.Boton.RJButton();
            this.lbltoggle = new System.Windows.Forms.Label();
            this.Toggle_encender_camara = new Proyecto_escuela.RJToggleButton.RJToggleButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_dispositivos = new System.Windows.Forms.ComboBox();
            this.picture_captura = new System.Windows.Forms.PictureBox();
            this.picture_tiempo_real = new System.Windows.Forms.PictureBox();
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rjdatetime1 = new Proyecto_escuela.Datetime.Rjdatetime();
            this.txt_telefono = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_Correo = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_direccion = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_apellidos = new Proyecto_escuela.Textbox.Rjtextbox();
            this.combo_rol = new System.Windows.Forms.ComboBox();
            this.txt_nombres = new Proyecto_escuela.Textbox.Rjtextbox();
            this.txt_matricula = new Proyecto_escuela.Textbox.Rjtextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.gb_foto_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_captura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tiempo_real)).BeginInit();
            this.gb_datos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_foto_perfil
            // 
            this.gb_foto_perfil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_foto_perfil.Controls.Add(this.btn_cancelar);
            this.gb_foto_perfil.Controls.Add(this.btn_registrar);
            this.gb_foto_perfil.Controls.Add(this.btn_capturar_foto);
            this.gb_foto_perfil.Controls.Add(this.lbltoggle);
            this.gb_foto_perfil.Controls.Add(this.Toggle_encender_camara);
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
            this.btn_cancelar.Location = new System.Drawing.Point(42, 541);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(575, 40);
            this.btn_cancelar.TabIndex = 98;
            this.btn_cancelar.Text = "Cancelar registro";
            this.btn_cancelar.TextColor = System.Drawing.Color.White;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_registrar.Location = new System.Drawing.Point(42, 496);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(575, 40);
            this.btn_registrar.TabIndex = 97;
            this.btn_registrar.Text = "Registrar empleado";
            this.btn_registrar.TextColor = System.Drawing.Color.White;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
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
            this.btn_capturar_foto.Location = new System.Drawing.Point(42, 413);
            this.btn_capturar_foto.Name = "btn_capturar_foto";
            this.btn_capturar_foto.Size = new System.Drawing.Size(575, 40);
            this.btn_capturar_foto.TabIndex = 96;
            this.btn_capturar_foto.Text = "Capturar foto de perfil";
            this.btn_capturar_foto.TextColor = System.Drawing.Color.White;
            this.btn_capturar_foto.UseVisualStyleBackColor = false;
            this.btn_capturar_foto.Click += new System.EventHandler(this.btn_capturar_foto_Click);
            // 
            // lbltoggle
            // 
            this.lbltoggle.AutoSize = true;
            this.lbltoggle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoggle.Location = new System.Drawing.Point(390, 73);
            this.lbltoggle.Name = "lbltoggle";
            this.lbltoggle.Size = new System.Drawing.Size(108, 23);
            this.lbltoggle.TabIndex = 95;
            this.lbltoggle.Text = "Apagada";
            // 
            // Toggle_encender_camara
            // 
            this.Toggle_encender_camara.AutoSize = true;
            this.Toggle_encender_camara.Location = new System.Drawing.Point(339, 73);
            this.Toggle_encender_camara.MinimumSize = new System.Drawing.Size(45, 22);
            this.Toggle_encender_camara.Name = "Toggle_encender_camara";
            this.Toggle_encender_camara.OffBackColor = System.Drawing.Color.Gray;
            this.Toggle_encender_camara.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.Toggle_encender_camara.OnBackColor = System.Drawing.Color.Lime;
            this.Toggle_encender_camara.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.Toggle_encender_camara.Size = new System.Drawing.Size(45, 22);
            this.Toggle_encender_camara.TabIndex = 94;
            this.Toggle_encender_camara.UseVisualStyleBackColor = true;
            this.Toggle_encender_camara.CheckedChanged += new System.EventHandler(this.Toggle_encender_camara_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(42, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 1);
            this.panel7.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 33);
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
            this.combo_dispositivos.Location = new System.Drawing.Point(42, 67);
            this.combo_dispositivos.Name = "combo_dispositivos";
            this.combo_dispositivos.Size = new System.Drawing.Size(278, 28);
            this.combo_dispositivos.TabIndex = 0;
            this.combo_dispositivos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_rol_KeyPress);
            this.combo_dispositivos.MouseHover += new System.EventHandler(this.combo_dispositivos_MouseHover);
            // 
            // picture_captura
            // 
            this.picture_captura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_captura.Location = new System.Drawing.Point(339, 113);
            this.picture_captura.Name = "picture_captura";
            this.picture_captura.Size = new System.Drawing.Size(278, 270);
            this.picture_captura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_captura.TabIndex = 1;
            this.picture_captura.TabStop = false;
            // 
            // picture_tiempo_real
            // 
            this.picture_tiempo_real.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_tiempo_real.Location = new System.Drawing.Point(42, 113);
            this.picture_tiempo_real.Name = "picture_tiempo_real";
            this.picture_tiempo_real.Size = new System.Drawing.Size(278, 270);
            this.picture_tiempo_real.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_tiempo_real.TabIndex = 0;
            this.picture_tiempo_real.TabStop = false;
            // 
            // gb_datos
            // 
            this.gb_datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_datos.Controls.Add(this.tableLayoutPanel1);
            this.gb_datos.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_datos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gb_datos.Location = new System.Drawing.Point(0, 0);
            this.gb_datos.Name = "gb_datos";
            this.gb_datos.Size = new System.Drawing.Size(277, 657);
            this.gb_datos.TabIndex = 84;
            this.gb_datos.TabStop = false;
            this.gb_datos.Text = "Datos del empleado";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rjdatetime1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_telefono, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.txt_Correo, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.txt_direccion, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_apellidos, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.combo_rol, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.txt_nombres, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_matricula, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_empleado, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.lbl_apellidos, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_fecha_nacimiento, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_direccion, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Correo, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Telefono, 0, 12);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 632);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rjdatetime1
            // 
            this.rjdatetime1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rjdatetime1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.rjdatetime1.BorderSize = 2;
            this.rjdatetime1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjdatetime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjdatetime1.Location = new System.Drawing.Point(3, 276);
            this.rjdatetime1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjdatetime1.Name = "rjdatetime1";
            this.rjdatetime1.Size = new System.Drawing.Size(265, 35);
            this.rjdatetime1.SkinColor = System.Drawing.Color.Transparent;
            this.rjdatetime1.TabIndex = 3;
            this.rjdatetime1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_telefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_telefono.BorderColor = System.Drawing.Color.DimGray;
            this.txt_telefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_telefono.BorderRadius = 8;
            this.txt_telefono.BorderSize = 2;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_telefono.ForeColor = System.Drawing.Color.Black;
            this.txt_telefono.Location = new System.Drawing.Point(4, 511);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefono.Multiline = false;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Padding = new System.Windows.Forms.Padding(7);
            this.txt_telefono.PasswordChar = false;
            this.txt_telefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_telefono.PlaceholderText = "Telefono";
            this.txt_telefono.Size = new System.Drawing.Size(263, 36);
            this.txt_telefono.TabIndex = 6;
            this.txt_telefono.Texts = "";
            this.txt_telefono.UnderlinedStyle = false;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Correo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Correo.BorderColor = System.Drawing.Color.DimGray;
            this.txt_Correo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_Correo.BorderRadius = 8;
            this.txt_Correo.BorderSize = 2;
            this.txt_Correo.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_Correo.ForeColor = System.Drawing.Color.Black;
            this.txt_Correo.Location = new System.Drawing.Point(4, 433);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Correo.Multiline = false;
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Correo.PasswordChar = false;
            this.txt_Correo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Correo.PlaceholderText = "Correo";
            this.txt_Correo.Size = new System.Drawing.Size(263, 36);
            this.txt_Correo.TabIndex = 5;
            this.txt_Correo.Texts = "";
            this.txt_Correo.UnderlinedStyle = false;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_direccion.BorderColor = System.Drawing.Color.DimGray;
            this.txt_direccion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_direccion.BorderRadius = 8;
            this.txt_direccion.BorderSize = 2;
            this.txt_direccion.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_direccion.ForeColor = System.Drawing.Color.Black;
            this.txt_direccion.Location = new System.Drawing.Point(4, 355);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Multiline = false;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Padding = new System.Windows.Forms.Padding(7);
            this.txt_direccion.PasswordChar = false;
            this.txt_direccion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_direccion.PlaceholderText = "Direccion";
            this.txt_direccion.Size = new System.Drawing.Size(263, 36);
            this.txt_direccion.TabIndex = 4;
            this.txt_direccion.Texts = "";
            this.txt_direccion.UnderlinedStyle = false;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellidos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_apellidos.BorderColor = System.Drawing.Color.DimGray;
            this.txt_apellidos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_apellidos.BorderRadius = 8;
            this.txt_apellidos.BorderSize = 2;
            this.txt_apellidos.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_apellidos.ForeColor = System.Drawing.Color.Black;
            this.txt_apellidos.Location = new System.Drawing.Point(4, 199);
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
            // combo_rol
            // 
            this.combo_rol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_rol.BackColor = System.Drawing.Color.White;
            this.combo_rol.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.combo_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.combo_rol.FormattingEnabled = true;
            this.combo_rol.Items.AddRange(new object[] {
            "Administrador",
            "Basico"});
            this.combo_rol.Location = new System.Drawing.Point(3, 593);
            this.combo_rol.Name = "combo_rol";
            this.combo_rol.Size = new System.Drawing.Size(265, 31);
            this.combo_rol.TabIndex = 7;
            this.combo_rol.Text = "Administrador";
            this.combo_rol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_rol_KeyPress);
            // 
            // txt_nombres
            // 
            this.txt_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombres.BorderColor = System.Drawing.Color.DimGray;
            this.txt_nombres.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_nombres.BorderRadius = 8;
            this.txt_nombres.BorderSize = 2;
            this.txt_nombres.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_nombres.ForeColor = System.Drawing.Color.Black;
            this.txt_nombres.Location = new System.Drawing.Point(4, 121);
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
            // txt_matricula
            // 
            this.txt_matricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_matricula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_matricula.BorderColor = System.Drawing.Color.DimGray;
            this.txt_matricula.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_matricula.BorderRadius = 8;
            this.txt_matricula.BorderSize = 2;
            this.txt_matricula.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_matricula.ForeColor = System.Drawing.Color.Black;
            this.txt_matricula.Location = new System.Drawing.Point(4, 43);
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 23);
            this.label2.TabIndex = 134;
            this.label2.Text = "Matricula del empleado";
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.Location = new System.Drawing.Point(3, 94);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(265, 23);
            this.lbl_empleado.TabIndex = 122;
            this.lbl_empleado.Text = "Nombres del empleado";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 23);
            this.label3.TabIndex = 135;
            this.label3.Text = "Rol del empleado";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(3, 172);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(265, 23);
            this.lbl_apellidos.TabIndex = 124;
            this.lbl_apellidos.Text = "Apellidos del empleado";
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(3, 250);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(265, 23);
            this.lbl_fecha_nacimiento.TabIndex = 128;
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(3, 328);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(265, 23);
            this.lbl_direccion.TabIndex = 126;
            this.lbl_direccion.Text = "Direccion";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correo.Location = new System.Drawing.Point(3, 406);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(265, 23);
            this.lbl_Correo.TabIndex = 130;
            this.lbl_Correo.Text = "Correo";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(3, 484);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(265, 23);
            this.lbl_Telefono.TabIndex = 131;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // Frm_registrar_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 657);
            this.Controls.Add(this.gb_foto_perfil);
            this.Controls.Add(this.gb_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_registrar_empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar empleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_registrar_empleado_FormClosed);
            this.Load += new System.EventHandler(this.Frm_registrar_empleado_Load);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox combo_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_Telefono;
        private Textbox.Rjtextbox txt_telefono;
        private Textbox.Rjtextbox txt_Correo;
        private Textbox.Rjtextbox txt_direccion;
        private Textbox.Rjtextbox txt_apellidos;
        private Textbox.Rjtextbox txt_nombres;
        private Textbox.Rjtextbox txt_matricula;
        private Datetime.Rjdatetime rjdatetime1;
        private System.Windows.Forms.Label lbltoggle;
        private RJToggleButton.RJToggleButton Toggle_encender_camara;
        private Boton.RJButton btn_cancelar;
        private Boton.RJButton btn_registrar;
        private Boton.RJButton btn_capturar_foto;
    }
}