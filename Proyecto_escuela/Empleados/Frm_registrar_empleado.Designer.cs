
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_enceder = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_dispositivos = new System.Windows.Forms.ComboBox();
            this.btn_capturar_foto = new System.Windows.Forms.Button();
            this.picture_captura = new System.Windows.Forms.PictureBox();
            this.picture_tiempo_real = new System.Windows.Forms.PictureBox();
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.combo_rol = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Panel();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
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
            this.gb_foto_perfil.Controls.Add(this.btn_enceder);
            this.gb_foto_perfil.Controls.Add(this.panel7);
            this.gb_foto_perfil.Controls.Add(this.label1);
            this.gb_foto_perfil.Controls.Add(this.combo_dispositivos);
            this.gb_foto_perfil.Controls.Add(this.btn_capturar_foto);
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
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelar.Location = new System.Drawing.Point(42, 562);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(575, 42);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar registro";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.Enabled = false;
            this.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_registrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_registrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_registrar.Location = new System.Drawing.Point(42, 513);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(575, 42);
            this.btn_registrar.TabIndex = 11;
            this.btn_registrar.Text = "Registrar empleado";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_enceder
            // 
            this.btn_enceder.BackColor = System.Drawing.Color.Orange;
            this.btn_enceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enceder.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_enceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enceder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_enceder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_enceder.Location = new System.Drawing.Point(339, 63);
            this.btn_enceder.Name = "btn_enceder";
            this.btn_enceder.Size = new System.Drawing.Size(278, 34);
            this.btn_enceder.TabIndex = 9;
            this.btn_enceder.Text = "Encender webcam";
            this.btn_enceder.UseVisualStyleBackColor = false;
            this.btn_enceder.Click += new System.EventHandler(this.btn_enceder_Click);
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
            this.combo_dispositivos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_dispositivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_dispositivos.FormattingEnabled = true;
            this.combo_dispositivos.Location = new System.Drawing.Point(42, 67);
            this.combo_dispositivos.Name = "combo_dispositivos";
            this.combo_dispositivos.Size = new System.Drawing.Size(278, 28);
            this.combo_dispositivos.TabIndex = 8;
            this.combo_dispositivos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_rol_KeyPress);
            this.combo_dispositivos.MouseHover += new System.EventHandler(this.combo_dispositivos_MouseHover);
            // 
            // btn_capturar_foto
            // 
            this.btn_capturar_foto.BackColor = System.Drawing.Color.Green;
            this.btn_capturar_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_capturar_foto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_capturar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_capturar_foto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_capturar_foto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_capturar_foto.Location = new System.Drawing.Point(42, 433);
            this.btn_capturar_foto.Name = "btn_capturar_foto";
            this.btn_capturar_foto.Size = new System.Drawing.Size(575, 42);
            this.btn_capturar_foto.TabIndex = 10;
            this.btn_capturar_foto.Text = "Capturar foto de perfil";
            this.btn_capturar_foto.UseVisualStyleBackColor = false;
            this.btn_capturar_foto.Click += new System.EventHandler(this.btn_capturar_foto_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 23);
            this.tableLayoutPanel1.Controls.Add(this.combo_rol, 0, 22);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 20);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.lbl_empleado, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.txt_telefono, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 21);
            this.tableLayoutPanel1.Controls.Add(this.line1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_apellidos, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_matricula, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_fecha_nacimiento, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_Correo, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.lbl_direccion, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.dtp_fecha_nacimiento, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Correo, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.txt_direccion, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Telefono, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.txt_nombres, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_apellidos, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 24;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 632);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(3, 628);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(265, 1);
            this.panel9.TabIndex = 136;
            // 
            // combo_rol
            // 
            this.combo_rol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_rol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_rol.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.combo_rol.FormattingEnabled = true;
            this.combo_rol.Items.AddRange(new object[] {
            "Administrador",
            "Basico"});
            this.combo_rol.Location = new System.Drawing.Point(3, 592);
            this.combo_rol.Name = "combo_rol";
            this.combo_rol.Size = new System.Drawing.Size(265, 31);
            this.combo_rol.TabIndex = 120;
            this.combo_rol.Text = "Administrador";
            this.combo_rol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_rol_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(3, 549);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 1);
            this.panel3.TabIndex = 132;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(3, 75);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(265, 1);
            this.panel8.TabIndex = 133;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(3, 470);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 1);
            this.panel4.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 23);
            this.label2.TabIndex = 134;
            this.label2.Text = "Matricula del empleado";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 1);
            this.panel2.TabIndex = 125;
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.Location = new System.Drawing.Point(3, 92);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(265, 23);
            this.lbl_empleado.TabIndex = 122;
            this.lbl_empleado.Text = "Nombres del empleado";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(3, 312);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 1);
            this.panel5.TabIndex = 127;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_telefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.Gray;
            this.txt_telefono.Location = new System.Drawing.Point(3, 518);
            this.txt_telefono.MaxLength = 10;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(265, 25);
            this.txt_telefono.TabIndex = 119;
            this.txt_telefono.Text = "Telefono";
            this.txt_telefono.Enter += new System.EventHandler(this.txt_telefono_Enter);
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 1);
            this.panel1.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 23);
            this.label3.TabIndex = 135;
            this.label3.Text = "Rol del empleado";
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.BackColor = System.Drawing.Color.Gray;
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line1.Location = new System.Drawing.Point(3, 154);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(265, 1);
            this.line1.TabIndex = 121;
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(3, 171);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(265, 23);
            this.lbl_apellidos.TabIndex = 124;
            this.lbl_apellidos.Text = "Apellidos del empleado";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_matricula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_matricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricula.ForeColor = System.Drawing.Color.Gray;
            this.txt_matricula.Location = new System.Drawing.Point(3, 44);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(265, 25);
            this.txt_matricula.TabIndex = 113;
            this.txt_matricula.Text = "Matricula";
            this.txt_matricula.Enter += new System.EventHandler(this.txt_matricula_Enter);
            this.txt_matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_matricula_KeyPress);
            this.txt_matricula.Leave += new System.EventHandler(this.txt_matricula_Leave);
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
            // txt_Correo
            // 
            this.txt_Correo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Correo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo.ForeColor = System.Drawing.Color.Gray;
            this.txt_Correo.Location = new System.Drawing.Point(3, 439);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(265, 25);
            this.txt_Correo.TabIndex = 118;
            this.txt_Correo.Text = "Correo";
            this.txt_Correo.Enter += new System.EventHandler(this.txt_Correo_Enter);
            this.txt_Correo.Leave += new System.EventHandler(this.txt_Correo_Leave);
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(3, 329);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(265, 23);
            this.lbl_direccion.TabIndex = 126;
            this.lbl_direccion.Text = "Direccion";
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(3, 276);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(265, 32);
            this.dtp_fecha_nacimiento.TabIndex = 116;
            this.dtp_fecha_nacimiento.Value = new System.DateTime(2021, 12, 28, 0, 0, 0, 0);
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correo.Location = new System.Drawing.Point(3, 408);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(265, 23);
            this.lbl_Correo.TabIndex = 130;
            this.lbl_Correo.Text = "Correo";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.Gray;
            this.txt_direccion.Location = new System.Drawing.Point(3, 360);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(265, 25);
            this.txt_direccion.TabIndex = 117;
            this.txt_direccion.Text = "Direccion";
            this.txt_direccion.Enter += new System.EventHandler(this.txt_direccion_Enter);
            this.txt_direccion.Leave += new System.EventHandler(this.txt_direccion_Leave);
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(3, 487);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(265, 23);
            this.lbl_Telefono.TabIndex = 131;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombres.ForeColor = System.Drawing.Color.Gray;
            this.txt_nombres.Location = new System.Drawing.Point(3, 123);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(265, 25);
            this.txt_nombres.TabIndex = 114;
            this.txt_nombres.Text = "Nombres";
            this.txt_nombres.Enter += new System.EventHandler(this.txt_nombres_Enter);
            this.txt_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombres_KeyPress);
            this.txt_nombres.Leave += new System.EventHandler(this.txt_nombres_Leave);
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellidos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos.ForeColor = System.Drawing.Color.Gray;
            this.txt_apellidos.Location = new System.Drawing.Point(3, 202);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(265, 25);
            this.txt_apellidos.TabIndex = 115;
            this.txt_apellidos.Text = "Apellidos";
            this.txt_apellidos.Enter += new System.EventHandler(this.txt_apellidos_Enter);
            this.txt_apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombres_KeyPress);
            this.txt_apellidos.Leave += new System.EventHandler(this.txt_apellidos_Leave);
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
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_enceder;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_dispositivos;
        private System.Windows.Forms.Button btn_capturar_foto;
        private System.Windows.Forms.PictureBox picture_captura;
        private System.Windows.Forms.PictureBox picture_tiempo_real;
        private System.Windows.Forms.GroupBox gb_datos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox combo_rol;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apellidos;
    }
}