namespace Proyecto_escuela
{
    partial class Frm_credencial_empleado
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
            this.gb_datos_tutor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_matricula_empleado = new System.Windows.Forms.Label();
            this.lbl_estatus_empleado = new System.Windows.Forms.Label();
            this.lbl_nombres_empleado = new System.Windows.Forms.Label();
            this.lbl_rol_empleado = new System.Windows.Forms.Label();
            this.lbl_apellidos_empleado = new System.Windows.Forms.Label();
            this.lbl_telefono_empleado = new System.Windows.Forms.Label();
            this.lbl_fecha_empleado = new System.Windows.Forms.Label();
            this.lbl_correo_empleado = new System.Windows.Forms.Label();
            this.lbl_direccion_empleado = new System.Windows.Forms.Label();
            this.gb_foto_perfil = new System.Windows.Forms.GroupBox();
            this.picture_imagen_perfil = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_baja = new Proyecto_escuela.Boton.RJButton();
            this.btn_modificar = new Proyecto_escuela.Boton.RJButton();
            this.grbopciones = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_datos_tutor.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gb_foto_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagen_perfil)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbopciones.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_datos_tutor
            // 
            this.gb_datos_tutor.Controls.Add(this.tableLayoutPanel3);
            this.gb_datos_tutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_datos_tutor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datos_tutor.Location = new System.Drawing.Point(589, 3);
            this.gb_datos_tutor.Name = "gb_datos_tutor";
            this.gb_datos_tutor.Size = new System.Drawing.Size(580, 507);
            this.gb_datos_tutor.TabIndex = 7;
            this.gb_datos_tutor.TabStop = false;
            this.gb_datos_tutor.Text = "Datos del empleado";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_matricula_empleado, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_estatus_empleado, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.lbl_nombres_empleado, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_rol_empleado, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.lbl_apellidos_empleado, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_telefono_empleado, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lbl_fecha_empleado, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_correo_empleado, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lbl_direccion_empleado, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(574, 485);
            this.tableLayoutPanel3.TabIndex = 123;
            // 
            // lbl_matricula_empleado
            // 
            this.lbl_matricula_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_matricula_empleado.AutoSize = true;
            this.lbl_matricula_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula_empleado.Location = new System.Drawing.Point(3, 15);
            this.lbl_matricula_empleado.Name = "lbl_matricula_empleado";
            this.lbl_matricula_empleado.Size = new System.Drawing.Size(568, 23);
            this.lbl_matricula_empleado.TabIndex = 118;
            this.lbl_matricula_empleado.Text = "Matricula:";
            // 
            // lbl_estatus_empleado
            // 
            this.lbl_estatus_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estatus_empleado.AutoSize = true;
            this.lbl_estatus_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus_empleado.Location = new System.Drawing.Point(3, 443);
            this.lbl_estatus_empleado.Name = "lbl_estatus_empleado";
            this.lbl_estatus_empleado.Size = new System.Drawing.Size(568, 23);
            this.lbl_estatus_empleado.TabIndex = 122;
            this.lbl_estatus_empleado.Text = "Estatus:";
            // 
            // lbl_nombres_empleado
            // 
            this.lbl_nombres_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombres_empleado.AutoSize = true;
            this.lbl_nombres_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres_empleado.Location = new System.Drawing.Point(3, 68);
            this.lbl_nombres_empleado.Name = "lbl_nombres_empleado";
            this.lbl_nombres_empleado.Size = new System.Drawing.Size(568, 23);
            this.lbl_nombres_empleado.TabIndex = 106;
            this.lbl_nombres_empleado.Text = "Nombres:";
            // 
            // lbl_rol_empleado
            // 
            this.lbl_rol_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_rol_empleado.AutoSize = true;
            this.lbl_rol_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol_empleado.Location = new System.Drawing.Point(3, 386);
            this.lbl_rol_empleado.Name = "lbl_rol_empleado";
            this.lbl_rol_empleado.Size = new System.Drawing.Size(568, 23);
            this.lbl_rol_empleado.TabIndex = 120;
            this.lbl_rol_empleado.Text = "Rol:";
            // 
            // lbl_apellidos_empleado
            // 
            this.lbl_apellidos_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidos_empleado.AutoSize = true;
            this.lbl_apellidos_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos_empleado.Location = new System.Drawing.Point(3, 121);
            this.lbl_apellidos_empleado.Name = "lbl_apellidos_empleado";
            this.lbl_apellidos_empleado.Size = new System.Drawing.Size(568, 23);
            this.lbl_apellidos_empleado.TabIndex = 107;
            this.lbl_apellidos_empleado.Text = "Apellidos:";
            // 
            // lbl_telefono_empleado
            // 
            this.lbl_telefono_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_telefono_empleado.AutoSize = true;
            this.lbl_telefono_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono_empleado.Location = new System.Drawing.Point(3, 333);
            this.lbl_telefono_empleado.Name = "lbl_telefono_empleado";
            this.lbl_telefono_empleado.Size = new System.Drawing.Size(568, 23);
            this.lbl_telefono_empleado.TabIndex = 116;
            this.lbl_telefono_empleado.Text = "Telefono:";
            // 
            // lbl_fecha_empleado
            // 
            this.lbl_fecha_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha_empleado.AutoSize = true;
            this.lbl_fecha_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_empleado.Location = new System.Drawing.Point(3, 174);
            this.lbl_fecha_empleado.Name = "lbl_fecha_empleado";
            this.lbl_fecha_empleado.Size = new System.Drawing.Size(568, 23);
            this.lbl_fecha_empleado.TabIndex = 108;
            this.lbl_fecha_empleado.Text = "Fecha:";
            // 
            // lbl_correo_empleado
            // 
            this.lbl_correo_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_correo_empleado.AutoSize = true;
            this.lbl_correo_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo_empleado.Location = new System.Drawing.Point(3, 280);
            this.lbl_correo_empleado.Name = "lbl_correo_empleado";
            this.lbl_correo_empleado.Size = new System.Drawing.Size(568, 23);
            this.lbl_correo_empleado.TabIndex = 110;
            this.lbl_correo_empleado.Text = "Correo:";
            // 
            // lbl_direccion_empleado
            // 
            this.lbl_direccion_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_direccion_empleado.AutoSize = true;
            this.lbl_direccion_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion_empleado.Location = new System.Drawing.Point(3, 227);
            this.lbl_direccion_empleado.Name = "lbl_direccion_empleado";
            this.lbl_direccion_empleado.Size = new System.Drawing.Size(568, 23);
            this.lbl_direccion_empleado.TabIndex = 109;
            this.lbl_direccion_empleado.Text = "Direccion:";
            // 
            // gb_foto_perfil
            // 
            this.gb_foto_perfil.Controls.Add(this.picture_imagen_perfil);
            this.gb_foto_perfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_foto_perfil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_foto_perfil.Location = new System.Drawing.Point(3, 3);
            this.gb_foto_perfil.Name = "gb_foto_perfil";
            this.gb_foto_perfil.Size = new System.Drawing.Size(580, 507);
            this.gb_foto_perfil.TabIndex = 6;
            this.gb_foto_perfil.TabStop = false;
            this.gb_foto_perfil.Text = "Foto de perfil";
            // 
            // picture_imagen_perfil
            // 
            this.picture_imagen_perfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_imagen_perfil.Location = new System.Drawing.Point(3, 19);
            this.picture_imagen_perfil.Name = "picture_imagen_perfil";
            this.picture_imagen_perfil.Size = new System.Drawing.Size(574, 485);
            this.picture_imagen_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_imagen_perfil.TabIndex = 0;
            this.picture_imagen_perfil.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_baja, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_modificar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1166, 69);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_baja
            // 
            this.btn_baja.BackColor = System.Drawing.Color.Red;
            this.btn_baja.BackgroundColor = System.Drawing.Color.Red;
            this.btn_baja.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_baja.BorderRadius = 15;
            this.btn_baja.BorderSize = 0;
            this.btn_baja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_baja.FlatAppearance.BorderSize = 0;
            this.btn_baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_baja.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baja.ForeColor = System.Drawing.Color.White;
            this.btn_baja.Location = new System.Drawing.Point(586, 3);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(577, 63);
            this.btn_baja.TabIndex = 102;
            this.btn_baja.Text = "Baja";
            this.btn_baja.TextColor = System.Drawing.Color.White;
            this.btn_baja.UseVisualStyleBackColor = false;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_modificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_modificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_modificar.BorderRadius = 15;
            this.btn_modificar.BorderSize = 0;
            this.btn_modificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(3, 3);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(577, 63);
            this.btn_modificar.TabIndex = 101;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextColor = System.Drawing.Color.White;
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // grbopciones
            // 
            this.grbopciones.Controls.Add(this.tableLayoutPanel1);
            this.grbopciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbopciones.Location = new System.Drawing.Point(0, 513);
            this.grbopciones.Name = "grbopciones";
            this.grbopciones.Size = new System.Drawing.Size(1172, 90);
            this.grbopciones.TabIndex = 8;
            this.grbopciones.TabStop = false;
            this.grbopciones.Text = "Opciones";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gb_datos_tutor, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gb_foto_perfil, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1172, 513);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // Frm_credencial_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 603);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.grbopciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_credencial_empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credencial del empleado";
            this.Load += new System.EventHandler(this.Frm_credencial_empleado_Load);
            this.gb_datos_tutor.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gb_foto_perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagen_perfil)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grbopciones.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_datos_tutor;
        public System.Windows.Forms.Label lbl_matricula_empleado;
        public System.Windows.Forms.Label lbl_telefono_empleado;
        public System.Windows.Forms.Label lbl_correo_empleado;
        public System.Windows.Forms.Label lbl_direccion_empleado;
        public System.Windows.Forms.Label lbl_fecha_empleado;
        public System.Windows.Forms.Label lbl_apellidos_empleado;
        public System.Windows.Forms.Label lbl_nombres_empleado;
        private System.Windows.Forms.GroupBox gb_foto_perfil;
        public System.Windows.Forms.PictureBox picture_imagen_perfil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lbl_estatus_empleado;
        public System.Windows.Forms.Label lbl_rol_empleado;
        public System.Windows.Forms.GroupBox grbopciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Boton.RJButton btn_modificar;
        private Boton.RJButton btn_baja;
    }
}