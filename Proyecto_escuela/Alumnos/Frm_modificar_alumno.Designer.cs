﻿
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
            this.rdb_conservar = new System.Windows.Forms.RadioButton();
            this.rdb_cambiar = new System.Windows.Forms.RadioButton();
            this.btn_enceder = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_dispositivos = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_capturar_foto = new System.Windows.Forms.Button();
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.combo_estatus = new System.Windows.Forms.ComboBox();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.combo_grupo = new System.Windows.Forms.ComboBox();
            this.lbl_grupo = new System.Windows.Forms.Label();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.lbl_alumno = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Panel();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.picture_captura = new System.Windows.Forms.PictureBox();
            this.picture_tiempo_real = new System.Windows.Forms.PictureBox();
            this.gb_foto_perfil.SuspendLayout();
            this.gb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_captura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tiempo_real)).BeginInit();
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
            this.gb_foto_perfil.Location = new System.Drawing.Point(277, 0);
            this.gb_foto_perfil.Name = "gb_foto_perfil";
            this.gb_foto_perfil.Size = new System.Drawing.Size(668, 678);
            this.gb_foto_perfil.TabIndex = 85;
            this.gb_foto_perfil.TabStop = false;
            this.gb_foto_perfil.Text = "Capturar foto de perfil";
            // 
            // rdb_conservar
            // 
            this.rdb_conservar.AutoSize = true;
            this.rdb_conservar.Location = new System.Drawing.Point(231, 23);
            this.rdb_conservar.Name = "rdb_conservar";
            this.rdb_conservar.Size = new System.Drawing.Size(166, 24);
            this.rdb_conservar.TabIndex = 88;
            this.rdb_conservar.Text = "Conservar imagen";
            this.rdb_conservar.UseVisualStyleBackColor = true;
            // 
            // rdb_cambiar
            // 
            this.rdb_cambiar.AutoSize = true;
            this.rdb_cambiar.Location = new System.Drawing.Point(40, 23);
            this.rdb_cambiar.Name = "rdb_cambiar";
            this.rdb_cambiar.Size = new System.Drawing.Size(152, 24);
            this.rdb_cambiar.TabIndex = 87;
            this.rdb_cambiar.Text = "Cambiar imagen";
            this.rdb_cambiar.UseVisualStyleBackColor = true;
            // 
            // btn_enceder
            // 
            this.btn_enceder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_enceder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_enceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enceder.Enabled = false;
            this.btn_enceder.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_enceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enceder.ForeColor = System.Drawing.Color.Black;
            this.btn_enceder.Location = new System.Drawing.Point(339, 106);
            this.btn_enceder.Name = "btn_enceder";
            this.btn_enceder.Size = new System.Drawing.Size(278, 34);
            this.btn_enceder.TabIndex = 1;
            this.btn_enceder.Text = "Encender webcam";
            this.btn_enceder.UseVisualStyleBackColor = false;
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
            this.combo_dispositivos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_dispositivos.Enabled = false;
            this.combo_dispositivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_dispositivos.FormattingEnabled = true;
            this.combo_dispositivos.Location = new System.Drawing.Point(42, 106);
            this.combo_dispositivos.Name = "combo_dispositivos";
            this.combo_dispositivos.Size = new System.Drawing.Size(278, 28);
            this.combo_dispositivos.TabIndex = 0;
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
            this.btn_cancelar.Location = new System.Drawing.Point(42, 626);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(575, 42);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar registro";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_modificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificar.Enabled = false;
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.Black;
            this.btn_modificar.Location = new System.Drawing.Point(42, 577);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(575, 42);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar alumno";
            this.btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_capturar_foto
            // 
            this.btn_capturar_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_capturar_foto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_capturar_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_capturar_foto.Enabled = false;
            this.btn_capturar_foto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_capturar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capturar_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capturar_foto.ForeColor = System.Drawing.Color.Black;
            this.btn_capturar_foto.Location = new System.Drawing.Point(42, 441);
            this.btn_capturar_foto.Name = "btn_capturar_foto";
            this.btn_capturar_foto.Size = new System.Drawing.Size(575, 42);
            this.btn_capturar_foto.TabIndex = 2;
            this.btn_capturar_foto.Text = "Capturar foto de perfil";
            this.btn_capturar_foto.UseVisualStyleBackColor = false;
            // 
            // gb_datos
            // 
            this.gb_datos.Controls.Add(this.panel9);
            this.gb_datos.Controls.Add(this.combo_estatus);
            this.gb_datos.Controls.Add(this.lbl_estatus);
            this.gb_datos.Controls.Add(this.panel8);
            this.gb_datos.Controls.Add(this.lbl_matricula);
            this.gb_datos.Controls.Add(this.txt_matricula);
            this.gb_datos.Controls.Add(this.panel6);
            this.gb_datos.Controls.Add(this.combo_grupo);
            this.gb_datos.Controls.Add(this.lbl_grupo);
            this.gb_datos.Controls.Add(this.dtp_fecha_nacimiento);
            this.gb_datos.Controls.Add(this.lbl_fecha_nacimiento);
            this.gb_datos.Controls.Add(this.panel5);
            this.gb_datos.Controls.Add(this.lbl_direccion);
            this.gb_datos.Controls.Add(this.panel2);
            this.gb_datos.Controls.Add(this.txt_direccion);
            this.gb_datos.Controls.Add(this.lbl_apellidos);
            this.gb_datos.Controls.Add(this.panel1);
            this.gb_datos.Controls.Add(this.txt_apellidos);
            this.gb_datos.Controls.Add(this.lbl_alumno);
            this.gb_datos.Controls.Add(this.line1);
            this.gb_datos.Controls.Add(this.txt_nombres);
            this.gb_datos.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_datos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gb_datos.Location = new System.Drawing.Point(0, 0);
            this.gb_datos.Name = "gb_datos";
            this.gb_datos.Size = new System.Drawing.Size(277, 678);
            this.gb_datos.TabIndex = 84;
            this.gb_datos.TabStop = false;
            this.gb_datos.Text = "Datos del alumno";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(16, 634);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(238, 1);
            this.panel9.TabIndex = 115;
            // 
            // combo_estatus
            // 
            this.combo_estatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_estatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_estatus.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.combo_estatus.FormattingEnabled = true;
            this.combo_estatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.combo_estatus.Location = new System.Drawing.Point(16, 597);
            this.combo_estatus.Name = "combo_estatus";
            this.combo_estatus.Size = new System.Drawing.Size(234, 31);
            this.combo_estatus.TabIndex = 113;
            this.combo_estatus.Text = "Activo";
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus.Location = new System.Drawing.Point(12, 558);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(77, 23);
            this.lbl_estatus.TabIndex = 114;
            this.lbl_estatus.Text = "Estatus";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(12, 94);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(238, 1);
            this.panel8.TabIndex = 103;
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.Location = new System.Drawing.Point(8, 28);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(220, 23);
            this.lbl_matricula.TabIndex = 102;
            this.lbl_matricula.Text = "Matricula del alumno";
            // 
            // txt_matricula
            // 
            this.txt_matricula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_matricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricula.ForeColor = System.Drawing.Color.Gray;
            this.txt_matricula.Location = new System.Drawing.Point(12, 63);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(238, 25);
            this.txt_matricula.TabIndex = 2;
            this.txt_matricula.Text = "Matricula";
            this.txt_matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_matricula_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(16, 546);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(238, 1);
            this.panel6.TabIndex = 100;
            // 
            // combo_grupo
            // 
            this.combo_grupo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_grupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_grupo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.combo_grupo.FormattingEnabled = true;
            this.combo_grupo.Items.AddRange(new object[] {
            "1:A",
            "2:A",
            "3:A",
            "4:A",
            "5:A",
            "6:A"});
            this.combo_grupo.Location = new System.Drawing.Point(16, 509);
            this.combo_grupo.Name = "combo_grupo";
            this.combo_grupo.Size = new System.Drawing.Size(234, 31);
            this.combo_grupo.TabIndex = 7;
            this.combo_grupo.Text = "1:A";
            // 
            // lbl_grupo
            // 
            this.lbl_grupo.AutoSize = true;
            this.lbl_grupo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupo.Location = new System.Drawing.Point(12, 473);
            this.lbl_grupo.Name = "lbl_grupo";
            this.lbl_grupo.Size = new System.Drawing.Size(68, 23);
            this.lbl_grupo.TabIndex = 98;
            this.lbl_grupo.Text = "grupo";
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(16, 421);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(234, 32);
            this.dtp_fecha_nacimiento.TabIndex = 6;
            this.dtp_fecha_nacimiento.Value = new System.DateTime(2021, 12, 28, 0, 0, 0, 0);
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(12, 385);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(220, 23);
            this.lbl_fecha_nacimiento.TabIndex = 96;
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(16, 457);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 1);
            this.panel5.TabIndex = 95;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(12, 290);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(101, 23);
            this.lbl_direccion.TabIndex = 88;
            this.lbl_direccion.Text = "Direccion";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(16, 362);
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
            this.txt_direccion.Location = new System.Drawing.Point(16, 329);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(238, 25);
            this.txt_direccion.TabIndex = 5;
            this.txt_direccion.Text = "Direccion";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(12, 197);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(219, 23);
            this.lbl_apellidos.TabIndex = 85;
            this.lbl_apellidos.Text = "Apellidos del alumno";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(16, 270);
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
            this.txt_apellidos.Location = new System.Drawing.Point(16, 237);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(238, 25);
            this.txt_apellidos.TabIndex = 4;
            this.txt_apellidos.Text = "Apellidos";
            this.txt_apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellidos_KeyPress);
            // 
            // lbl_alumno
            // 
            this.lbl_alumno.AutoSize = true;
            this.lbl_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alumno.Location = new System.Drawing.Point(8, 108);
            this.lbl_alumno.Name = "lbl_alumno";
            this.lbl_alumno.Size = new System.Drawing.Size(217, 23);
            this.lbl_alumno.TabIndex = 82;
            this.lbl_alumno.Text = "Nombres del alumno";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Gray;
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line1.Location = new System.Drawing.Point(12, 180);
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
            this.txt_nombres.Location = new System.Drawing.Point(12, 147);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(238, 25);
            this.txt_nombres.TabIndex = 3;
            this.txt_nombres.Text = "Nombres";
            this.txt_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombres_KeyPress);
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
            // Frm_modificar_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(945, 678);
            this.Controls.Add(this.gb_foto_perfil);
            this.Controls.Add(this.gb_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_modificar_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Alumno";
            this.gb_foto_perfil.ResumeLayout(false);
            this.gb_foto_perfil.PerformLayout();
            this.gb_datos.ResumeLayout(false);
            this.gb_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_captura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tiempo_real)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_foto_perfil;
        private System.Windows.Forms.Button btn_enceder;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_dispositivos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_capturar_foto;
        private System.Windows.Forms.PictureBox picture_captura;
        private System.Windows.Forms.PictureBox picture_tiempo_real;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_grupo;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_alumno;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.ComboBox combo_estatus;
        private System.Windows.Forms.Label lbl_estatus;
        private System.Windows.Forms.RadioButton rdb_conservar;
        private System.Windows.Forms.RadioButton rdb_cambiar;
        public System.Windows.Forms.GroupBox gb_datos;
        public System.Windows.Forms.TextBox txt_matricula;
        public System.Windows.Forms.ComboBox combo_grupo;
        public System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        public System.Windows.Forms.TextBox txt_direccion;
        public System.Windows.Forms.TextBox txt_apellidos;
        public System.Windows.Forms.TextBox txt_nombres;
    }
}