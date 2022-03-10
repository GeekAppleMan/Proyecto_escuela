namespace Proyecto_escuela
{
    partial class Frm_Modificar_empleado
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
            this.rdb_conservar = new System.Windows.Forms.RadioButton();
            this.rdb_cambiar = new System.Windows.Forms.RadioButton();
            this.btn_enceder = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_dispositivos = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_capturar_foto = new System.Windows.Forms.Button();
            this.picture_captura = new System.Windows.Forms.PictureBox();
            this.picture_tiempo_real = new System.Windows.Forms.PictureBox();
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_tutor = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.combo_estatus = new System.Windows.Forms.ComboBox();
            this.line1 = new System.Windows.Forms.Panel();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.combo_parentesco = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_parentesco = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.gb_foto_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_captura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tiempo_real)).BeginInit();
            this.gb_datos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_foto_perfil
            // 
            this.gb_foto_perfil.Controls.Add(this.rdb_conservar);
            this.gb_foto_perfil.Controls.Add(this.rdb_cambiar);
            this.gb_foto_perfil.Controls.Add(this.btn_enceder);
            this.gb_foto_perfil.Controls.Add(this.panel7);
            this.gb_foto_perfil.Controls.Add(this.label1);
            this.gb_foto_perfil.Controls.Add(this.combo_dispositivos);
            this.gb_foto_perfil.Controls.Add(this.btn_cancelar);
            this.gb_foto_perfil.Controls.Add(this.btn_modificar);
            this.gb_foto_perfil.Controls.Add(this.btn_capturar_foto);
            this.gb_foto_perfil.Controls.Add(this.picture_captura);
            this.gb_foto_perfil.Controls.Add(this.picture_tiempo_real);
            this.gb_foto_perfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_foto_perfil.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gb_foto_perfil.Location = new System.Drawing.Point(287, 0);
            this.gb_foto_perfil.Name = "gb_foto_perfil";
            this.gb_foto_perfil.Size = new System.Drawing.Size(651, 657);
            this.gb_foto_perfil.TabIndex = 85;
            this.gb_foto_perfil.TabStop = false;
            this.gb_foto_perfil.Text = "Capturar foto de perfil";
            // 
            // rdb_conservar
            // 
            this.rdb_conservar.AutoSize = true;
            this.rdb_conservar.Checked = true;
            this.rdb_conservar.Location = new System.Drawing.Point(233, 29);
            this.rdb_conservar.Name = "rdb_conservar";
            this.rdb_conservar.Size = new System.Drawing.Size(166, 24);
            this.rdb_conservar.TabIndex = 86;
            this.rdb_conservar.TabStop = true;
            this.rdb_conservar.Text = "Conservar imagen";
            this.rdb_conservar.UseVisualStyleBackColor = true;
            this.rdb_conservar.Click += new System.EventHandler(this.rdb_conservar_Click);
            // 
            // rdb_cambiar
            // 
            this.rdb_cambiar.AutoSize = true;
            this.rdb_cambiar.Location = new System.Drawing.Point(42, 29);
            this.rdb_cambiar.Name = "rdb_cambiar";
            this.rdb_cambiar.Size = new System.Drawing.Size(152, 24);
            this.rdb_cambiar.TabIndex = 85;
            this.rdb_cambiar.Text = "Cambiar imagen";
            this.rdb_cambiar.UseVisualStyleBackColor = true;
            this.rdb_cambiar.Click += new System.EventHandler(this.rdb_cambiar_Click);
            // 
            // btn_enceder
            // 
            this.btn_enceder.BackColor = System.Drawing.Color.Orange;
            this.btn_enceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enceder.Enabled = false;
            this.btn_enceder.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_enceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enceder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_enceder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_enceder.Location = new System.Drawing.Point(339, 95);
            this.btn_enceder.Name = "btn_enceder";
            this.btn_enceder.Size = new System.Drawing.Size(278, 34);
            this.btn_enceder.TabIndex = 1;
            this.btn_enceder.Text = "Encender webcam";
            this.btn_enceder.UseVisualStyleBackColor = false;
            this.btn_enceder.Click += new System.EventHandler(this.btn_enceder_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(42, 128);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 1);
            this.panel7.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 83;
            this.label1.Text = "Seleccionar webcam";
            // 
            // combo_dispositivos
            // 
            this.combo_dispositivos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_dispositivos.Enabled = false;
            this.combo_dispositivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_dispositivos.FormattingEnabled = true;
            this.combo_dispositivos.Location = new System.Drawing.Point(42, 94);
            this.combo_dispositivos.Name = "combo_dispositivos";
            this.combo_dispositivos.Size = new System.Drawing.Size(278, 28);
            this.combo_dispositivos.TabIndex = 0;
            this.combo_dispositivos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_dispositivos_KeyPress);
            this.combo_dispositivos.MouseHover += new System.EventHandler(this.combo_dispositivos_MouseHover);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelar.Location = new System.Drawing.Point(42, 605);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(575, 42);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar modificacion";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modificar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_modificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_modificar.Location = new System.Drawing.Point(42, 548);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(575, 42);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar empleado";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_capturar_foto
            // 
            this.btn_capturar_foto.BackColor = System.Drawing.Color.Green;
            this.btn_capturar_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_capturar_foto.Enabled = false;
            this.btn_capturar_foto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_capturar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_capturar_foto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_capturar_foto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_capturar_foto.Location = new System.Drawing.Point(42, 463);
            this.btn_capturar_foto.Name = "btn_capturar_foto";
            this.btn_capturar_foto.Size = new System.Drawing.Size(575, 42);
            this.btn_capturar_foto.TabIndex = 2;
            this.btn_capturar_foto.Text = "Capturar foto de perfil";
            this.btn_capturar_foto.UseVisualStyleBackColor = false;
            this.btn_capturar_foto.Click += new System.EventHandler(this.btn_capturar_foto_Click);
            // 
            // picture_captura
            // 
            this.picture_captura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_captura.Enabled = false;
            this.picture_captura.Location = new System.Drawing.Point(339, 140);
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
            this.picture_tiempo_real.Location = new System.Drawing.Point(42, 140);
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
            this.gb_datos.Size = new System.Drawing.Size(287, 657);
            this.gb_datos.TabIndex = 84;
            this.gb_datos.TabStop = false;
            this.gb_datos.Text = "Datos del empleado";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 23);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tutor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_nombres, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.combo_estatus, 0, 22);
            this.tableLayoutPanel1.Controls.Add(this.line1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_apellidos, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_estatus, 0, 21);
            this.tableLayoutPanel1.Controls.Add(this.txt_apellidos, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 20);
            this.tableLayoutPanel1.Controls.Add(this.lbl_direccion, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_direccion, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.combo_parentesco, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_telefono, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbl_parentesco, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.txt_telefono, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.dtp_fecha_nacimiento, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.lbl_correo, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.txt_correo, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.lbl_fecha_nacimiento, 0, 15);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 632);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(3, 628);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(275, 1);
            this.panel8.TabIndex = 103;
            // 
            // lbl_tutor
            // 
            this.lbl_tutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tutor.AutoSize = true;
            this.lbl_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tutor.Location = new System.Drawing.Point(3, 13);
            this.lbl_tutor.Name = "lbl_tutor";
            this.lbl_tutor.Size = new System.Drawing.Size(275, 23);
            this.lbl_tutor.TabIndex = 82;
            this.lbl_tutor.Text = "Nombres del empleado";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombres.ForeColor = System.Drawing.Color.Black;
            this.txt_nombres.Location = new System.Drawing.Point(3, 44);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(275, 25);
            this.txt_nombres.TabIndex = 1;
            this.txt_nombres.Text = "Nombres";
            this.txt_nombres.Enter += new System.EventHandler(this.txt_nombres_Enter);
            this.txt_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombres_KeyPress);
            this.txt_nombres.Leave += new System.EventHandler(this.txt_nombres_Leave);
            // 
            // combo_estatus
            // 
            this.combo_estatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_estatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_estatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_estatus.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.combo_estatus.FormattingEnabled = true;
            this.combo_estatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.combo_estatus.Location = new System.Drawing.Point(3, 592);
            this.combo_estatus.Name = "combo_estatus";
            this.combo_estatus.Size = new System.Drawing.Size(275, 31);
            this.combo_estatus.TabIndex = 101;
            this.combo_estatus.Text = "Activo";
            this.combo_estatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_estatus_KeyPress);
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.BackColor = System.Drawing.Color.Gray;
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line1.Location = new System.Drawing.Point(3, 75);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(275, 1);
            this.line1.TabIndex = 81;
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(3, 92);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(275, 23);
            this.lbl_apellidos.TabIndex = 85;
            this.lbl_apellidos.Text = "Apellidos del empleado";
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus.Location = new System.Drawing.Point(3, 566);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(275, 23);
            this.lbl_estatus.TabIndex = 102;
            this.lbl_estatus.Text = "Estatus";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellidos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos.ForeColor = System.Drawing.Color.Black;
            this.txt_apellidos.Location = new System.Drawing.Point(3, 123);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(275, 25);
            this.txt_apellidos.TabIndex = 2;
            this.txt_apellidos.Text = "Apellidos";
            this.txt_apellidos.Enter += new System.EventHandler(this.txt_apellidos_Enter);
            this.txt_apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellidos_KeyPress);
            this.txt_apellidos.Leave += new System.EventHandler(this.txt_apellidos_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 1);
            this.panel1.TabIndex = 84;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(3, 549);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(275, 1);
            this.panel6.TabIndex = 100;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(3, 171);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(275, 23);
            this.lbl_direccion.TabIndex = 88;
            this.lbl_direccion.Text = "Direccion";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.Black;
            this.txt_direccion.Location = new System.Drawing.Point(3, 202);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(275, 25);
            this.txt_direccion.TabIndex = 3;
            this.txt_direccion.Text = "Direccion";
            this.txt_direccion.Enter += new System.EventHandler(this.txt_direccion_Enter);
            this.txt_direccion.Leave += new System.EventHandler(this.txt_direccion_Leave);
            // 
            // combo_parentesco
            // 
            this.combo_parentesco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_parentesco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_parentesco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_parentesco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.combo_parentesco.FormattingEnabled = true;
            this.combo_parentesco.Items.AddRange(new object[] {
            "Administrador",
            "Basico"});
            this.combo_parentesco.Location = new System.Drawing.Point(3, 513);
            this.combo_parentesco.Name = "combo_parentesco";
            this.combo_parentesco.Size = new System.Drawing.Size(275, 31);
            this.combo_parentesco.TabIndex = 7;
            this.combo_parentesco.Text = "Basico";
            this.combo_parentesco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_dispositivos_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 1);
            this.panel2.TabIndex = 87;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(3, 250);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(275, 23);
            this.lbl_telefono.TabIndex = 91;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_parentesco
            // 
            this.lbl_parentesco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_parentesco.AutoSize = true;
            this.lbl_parentesco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parentesco.Location = new System.Drawing.Point(3, 487);
            this.lbl_parentesco.Name = "lbl_parentesco";
            this.lbl_parentesco.Size = new System.Drawing.Size(275, 23);
            this.lbl_parentesco.TabIndex = 98;
            this.lbl_parentesco.Text = "Rol";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_telefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.Black;
            this.txt_telefono.Location = new System.Drawing.Point(3, 281);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(275, 25);
            this.txt_telefono.TabIndex = 4;
            this.txt_telefono.Text = "Telefono";
            this.txt_telefono.Enter += new System.EventHandler(this.txt_telefono_Enter);
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(3, 312);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 1);
            this.panel3.TabIndex = 90;
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(3, 434);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(275, 32);
            this.dtp_fecha_nacimiento.TabIndex = 6;
            this.dtp_fecha_nacimiento.Value = new System.DateTime(2021, 12, 28, 0, 0, 0, 0);
            // 
            // lbl_correo
            // 
            this.lbl_correo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(3, 329);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(275, 23);
            this.lbl_correo.TabIndex = 94;
            this.lbl_correo.Text = "Correo";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(3, 470);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 1);
            this.panel5.TabIndex = 95;
            // 
            // txt_correo
            // 
            this.txt_correo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_correo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.Black;
            this.txt_correo.Location = new System.Drawing.Point(3, 360);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(275, 25);
            this.txt_correo.TabIndex = 5;
            this.txt_correo.Text = "Correo";
            this.txt_correo.Enter += new System.EventHandler(this.txt_correo_Enter);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(3, 391);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 1);
            this.panel4.TabIndex = 93;
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(3, 408);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(275, 23);
            this.lbl_fecha_nacimiento.TabIndex = 96;
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento";
            // 
            // Frm_Modificar_empleado
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
            this.Name = "Frm_Modificar_empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar empleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Modificar_empleado_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Modificar_empleado_Load);
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
        private System.Windows.Forms.RadioButton rdb_conservar;
        private System.Windows.Forms.RadioButton rdb_cambiar;
        private System.Windows.Forms.Button btn_enceder;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_dispositivos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_capturar_foto;
        public System.Windows.Forms.PictureBox picture_captura;
        private System.Windows.Forms.PictureBox picture_tiempo_real;
        private System.Windows.Forms.GroupBox gb_datos;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.ComboBox combo_estatus;
        private System.Windows.Forms.Label lbl_estatus;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.ComboBox combo_parentesco;
        private System.Windows.Forms.Label lbl_parentesco;
        public System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label lbl_tutor;
        private System.Windows.Forms.Panel line1;
        public System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}