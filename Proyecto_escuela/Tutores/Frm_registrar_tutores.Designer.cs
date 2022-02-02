
namespace Proyecto_escuela
{
    partial class Frm_registrar_tutores
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
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.combo_parentesco = new System.Windows.Forms.ComboBox();
            this.lbl_parentesco = new System.Windows.Forms.Label();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.lbl_tutor = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Panel();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.gb_foto_perfil = new System.Windows.Forms.GroupBox();
            this.btn_enceder = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_dispositivos = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_capturar_foto = new System.Windows.Forms.Button();
            this.picture_captura = new System.Windows.Forms.PictureBox();
            this.picture_tiempo_real = new System.Windows.Forms.PictureBox();
            this.gb_datos.SuspendLayout();
            this.gb_foto_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_captura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tiempo_real)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_datos
            // 
            this.gb_datos.Controls.Add(this.panel6);
            this.gb_datos.Controls.Add(this.combo_parentesco);
            this.gb_datos.Controls.Add(this.lbl_parentesco);
            this.gb_datos.Controls.Add(this.dtp_fecha_nacimiento);
            this.gb_datos.Controls.Add(this.lbl_fecha_nacimiento);
            this.gb_datos.Controls.Add(this.panel5);
            this.gb_datos.Controls.Add(this.lbl_correo);
            this.gb_datos.Controls.Add(this.panel4);
            this.gb_datos.Controls.Add(this.txt_correo);
            this.gb_datos.Controls.Add(this.lbl_telefono);
            this.gb_datos.Controls.Add(this.panel3);
            this.gb_datos.Controls.Add(this.txt_telefono);
            this.gb_datos.Controls.Add(this.lbl_direccion);
            this.gb_datos.Controls.Add(this.panel2);
            this.gb_datos.Controls.Add(this.txt_direccion);
            this.gb_datos.Controls.Add(this.lbl_apellidos);
            this.gb_datos.Controls.Add(this.panel1);
            this.gb_datos.Controls.Add(this.txt_apellidos);
            this.gb_datos.Controls.Add(this.lbl_tutor);
            this.gb_datos.Controls.Add(this.line1);
            this.gb_datos.Controls.Add(this.txt_nombres);
            this.gb_datos.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_datos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gb_datos.Location = new System.Drawing.Point(0, 0);
            this.gb_datos.Name = "gb_datos";
            this.gb_datos.Size = new System.Drawing.Size(287, 694);
            this.gb_datos.TabIndex = 80;
            this.gb_datos.TabStop = false;
            this.gb_datos.Text = "Datos del tutor";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(20, 642);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(238, 1);
            this.panel6.TabIndex = 100;
            // 
            // combo_parentesco
            // 
            this.combo_parentesco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_parentesco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_parentesco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.combo_parentesco.FormattingEnabled = true;
            this.combo_parentesco.Items.AddRange(new object[] {
            "Padre",
            "Madre",
            "Tutor"});
            this.combo_parentesco.Location = new System.Drawing.Point(20, 605);
            this.combo_parentesco.Name = "combo_parentesco";
            this.combo_parentesco.Size = new System.Drawing.Size(234, 31);
            this.combo_parentesco.TabIndex = 7;
            this.combo_parentesco.Text = "Padre";
            this.combo_parentesco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_parentesco_KeyPress);
            // 
            // lbl_parentesco
            // 
            this.lbl_parentesco.AutoSize = true;
            this.lbl_parentesco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parentesco.Location = new System.Drawing.Point(16, 577);
            this.lbl_parentesco.Name = "lbl_parentesco";
            this.lbl_parentesco.Size = new System.Drawing.Size(123, 23);
            this.lbl_parentesco.TabIndex = 98;
            this.lbl_parentesco.Text = "parentesco";
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(20, 523);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(234, 32);
            this.dtp_fecha_nacimiento.TabIndex = 6;
            this.dtp_fecha_nacimiento.Value = new System.DateTime(2021, 12, 28, 0, 0, 0, 0);
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(16, 487);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(220, 23);
            this.lbl_fecha_nacimiento.TabIndex = 96;
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(20, 559);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 1);
            this.panel5.TabIndex = 95;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(16, 395);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(77, 23);
            this.lbl_correo.TabIndex = 94;
            this.lbl_correo.Text = "Correo";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(20, 467);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 1);
            this.panel4.TabIndex = 93;
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.Gray;
            this.txt_correo.Location = new System.Drawing.Point(20, 434);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(238, 25);
            this.txt_correo.TabIndex = 5;
            this.txt_correo.Text = "Correo";
            this.txt_correo.Enter += new System.EventHandler(this.txt_correo_Enter);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(16, 300);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(93, 23);
            this.lbl_telefono.TabIndex = 91;
            this.lbl_telefono.Text = "Telefono";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(20, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 1);
            this.panel3.TabIndex = 90;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.Gray;
            this.txt_telefono.Location = new System.Drawing.Point(20, 339);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(238, 25);
            this.txt_telefono.TabIndex = 4;
            this.txt_telefono.Text = "Telefono";
            this.txt_telefono.Enter += new System.EventHandler(this.txt_telefono_Enter);
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(16, 208);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(101, 23);
            this.lbl_direccion.TabIndex = 88;
            this.lbl_direccion.Text = "Direccion";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(20, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 1);
            this.panel2.TabIndex = 87;
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.Gray;
            this.txt_direccion.Location = new System.Drawing.Point(20, 247);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(238, 25);
            this.txt_direccion.TabIndex = 3;
            this.txt_direccion.Text = "Direccion";
            this.txt_direccion.Enter += new System.EventHandler(this.txt_direccion_Enter);
            this.txt_direccion.Leave += new System.EventHandler(this.txt_direccion_Leave);
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(16, 117);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(189, 23);
            this.lbl_apellidos.TabIndex = 85;
            this.lbl_apellidos.Text = "Apellidos del tutor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(20, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 1);
            this.panel1.TabIndex = 84;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos.ForeColor = System.Drawing.Color.Gray;
            this.txt_apellidos.Location = new System.Drawing.Point(20, 157);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(238, 25);
            this.txt_apellidos.TabIndex = 2;
            this.txt_apellidos.Text = "Apellidos";
            this.txt_apellidos.Enter += new System.EventHandler(this.txt_apellidos_Enter);
            this.txt_apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellidos_KeyPress);
            this.txt_apellidos.Leave += new System.EventHandler(this.txt_apellidos_Leave);
            // 
            // lbl_tutor
            // 
            this.lbl_tutor.AutoSize = true;
            this.lbl_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tutor.Location = new System.Drawing.Point(12, 22);
            this.lbl_tutor.Name = "lbl_tutor";
            this.lbl_tutor.Size = new System.Drawing.Size(187, 23);
            this.lbl_tutor.TabIndex = 82;
            this.lbl_tutor.Text = "Nombres del tutor";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Gray;
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line1.Location = new System.Drawing.Point(16, 94);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(238, 1);
            this.line1.TabIndex = 81;
            // 
            // txt_nombres
            // 
            this.txt_nombres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombres.ForeColor = System.Drawing.Color.Gray;
            this.txt_nombres.Location = new System.Drawing.Point(16, 61);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(238, 25);
            this.txt_nombres.TabIndex = 1;
            this.txt_nombres.Text = "Nombres";
            this.txt_nombres.Enter += new System.EventHandler(this.txt_nombres_Enter);
            this.txt_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombres_KeyPress);
            this.txt_nombres.Leave += new System.EventHandler(this.txt_nombres_Leave);
            // 
            // gb_foto_perfil
            // 
            this.gb_foto_perfil.Controls.Add(this.btn_enceder);
            this.gb_foto_perfil.Controls.Add(this.panel7);
            this.gb_foto_perfil.Controls.Add(this.label1);
            this.gb_foto_perfil.Controls.Add(this.combo_dispositivos);
            this.gb_foto_perfil.Controls.Add(this.btn_cancelar);
            this.gb_foto_perfil.Controls.Add(this.btn_registrar);
            this.gb_foto_perfil.Controls.Add(this.btn_capturar_foto);
            this.gb_foto_perfil.Controls.Add(this.picture_captura);
            this.gb_foto_perfil.Controls.Add(this.picture_tiempo_real);
            this.gb_foto_perfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_foto_perfil.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gb_foto_perfil.Location = new System.Drawing.Point(287, 0);
            this.gb_foto_perfil.Name = "gb_foto_perfil";
            this.gb_foto_perfil.Size = new System.Drawing.Size(655, 694);
            this.gb_foto_perfil.TabIndex = 81;
            this.gb_foto_perfil.TabStop = false;
            this.gb_foto_perfil.Text = "Capturar foto de perfil";
            // 
            // btn_enceder
            // 
            this.btn_enceder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_enceder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_enceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enceder.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_enceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enceder.ForeColor = System.Drawing.Color.Black;
            this.btn_enceder.Location = new System.Drawing.Point(339, 56);
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
            this.combo_dispositivos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_dispositivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_dispositivos.FormattingEnabled = true;
            this.combo_dispositivos.Location = new System.Drawing.Point(42, 56);
            this.combo_dispositivos.Name = "combo_dispositivos";
            this.combo_dispositivos.Size = new System.Drawing.Size(278, 28);
            this.combo_dispositivos.TabIndex = 0;
            this.combo_dispositivos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_dispositivos_KeyPress);
            this.combo_dispositivos.MouseHover += new System.EventHandler(this.combo_dispositivos_MouseHover);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.Location = new System.Drawing.Point(42, 634);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(575, 42);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar registro";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_registrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.Enabled = false;
            this.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.Black;
            this.btn_registrar.Location = new System.Drawing.Point(42, 585);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(575, 42);
            this.btn_registrar.TabIndex = 3;
            this.btn_registrar.Text = "Registrar tutor";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_capturar_foto
            // 
            this.btn_capturar_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_capturar_foto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_capturar_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_capturar_foto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_capturar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capturar_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capturar_foto.ForeColor = System.Drawing.Color.Black;
            this.btn_capturar_foto.Location = new System.Drawing.Point(42, 397);
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
            this.picture_captura.Location = new System.Drawing.Point(339, 102);
            this.picture_captura.Name = "picture_captura";
            this.picture_captura.Size = new System.Drawing.Size(278, 270);
            this.picture_captura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_captura.TabIndex = 1;
            this.picture_captura.TabStop = false;
            // 
            // picture_tiempo_real
            // 
            this.picture_tiempo_real.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_tiempo_real.Location = new System.Drawing.Point(42, 102);
            this.picture_tiempo_real.Name = "picture_tiempo_real";
            this.picture_tiempo_real.Size = new System.Drawing.Size(278, 270);
            this.picture_tiempo_real.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_tiempo_real.TabIndex = 0;
            this.picture_tiempo_real.TabStop = false;
            // 
            // Frm_registrar_tutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(942, 694);
            this.Controls.Add(this.gb_foto_perfil);
            this.Controls.Add(this.gb_datos);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_registrar_tutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de tutores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_registrar_tutores_FormClosed);
            this.Load += new System.EventHandler(this.Frm_registrar_tutores_Load);
            this.gb_datos.ResumeLayout(false);
            this.gb_datos.PerformLayout();
            this.gb_foto_perfil.ResumeLayout(false);
            this.gb_foto_perfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_captura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tiempo_real)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_datos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox combo_parentesco;
        private System.Windows.Forms.Label lbl_parentesco;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label lbl_tutor;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.GroupBox gb_foto_perfil;
        private System.Windows.Forms.PictureBox picture_captura;
        private System.Windows.Forms.PictureBox picture_tiempo_real;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_capturar_foto;
        private System.Windows.Forms.ComboBox combo_dispositivos;
        private System.Windows.Forms.Button btn_enceder;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
    }
}