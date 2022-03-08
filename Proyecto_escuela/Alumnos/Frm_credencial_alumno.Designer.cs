
namespace Proyecto_escuela
{
    partial class Frm_credencial_alumno
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
            this.gb_foto_perfil = new System.Windows.Forms.GroupBox();
            this.picture_imagen_perfil = new System.Windows.Forms.PictureBox();
            this.grbopciones = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_tutor = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_nombres_alumno = new System.Windows.Forms.Label();
            this.lbl_apellidos_alumno = new System.Windows.Forms.Label();
            this.lbl_fecha_alumno = new System.Windows.Forms.Label();
            this.lbl_direccion_alumno = new System.Windows.Forms.Label();
            this.lbl_grupo_alumno = new System.Windows.Forms.Label();
            this.lbl_estatus_alumno = new System.Windows.Forms.Label();
            this.lbl_matricula_alumno = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_datos_tutor.SuspendLayout();
            this.gb_foto_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagen_perfil)).BeginInit();
            this.grbopciones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.gb_datos_tutor.TabIndex = 3;
            this.gb_datos_tutor.TabStop = false;
            this.gb_datos_tutor.Text = "Datos del alumno";
            // 
            // gb_foto_perfil
            // 
            this.gb_foto_perfil.Controls.Add(this.picture_imagen_perfil);
            this.gb_foto_perfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_foto_perfil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_foto_perfil.Location = new System.Drawing.Point(3, 3);
            this.gb_foto_perfil.Name = "gb_foto_perfil";
            this.gb_foto_perfil.Size = new System.Drawing.Size(580, 507);
            this.gb_foto_perfil.TabIndex = 2;
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
            // grbopciones
            // 
            this.grbopciones.Controls.Add(this.tableLayoutPanel1);
            this.grbopciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbopciones.Location = new System.Drawing.Point(0, 513);
            this.grbopciones.Name = "grbopciones";
            this.grbopciones.Size = new System.Drawing.Size(1172, 90);
            this.grbopciones.TabIndex = 5;
            this.grbopciones.TabStop = false;
            this.grbopciones.Text = "Opciones";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_baja, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_modificar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_tutor, 0, 0);
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
            this.btn_baja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_baja.FlatAppearance.BorderSize = 0;
            this.btn_baja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_baja.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_baja.Location = new System.Drawing.Point(779, 3);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(384, 63);
            this.btn_baja.TabIndex = 3;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = false;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_modificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modificar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_modificar.Location = new System.Drawing.Point(391, 3);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(382, 63);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_tutor
            // 
            this.btn_tutor.BackColor = System.Drawing.Color.Green;
            this.btn_tutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_tutor.FlatAppearance.BorderSize = 0;
            this.btn_tutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tutor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tutor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_tutor.Location = new System.Drawing.Point(3, 3);
            this.btn_tutor.Name = "btn_tutor";
            this.btn_tutor.Size = new System.Drawing.Size(382, 63);
            this.btn_tutor.TabIndex = 1;
            this.btn_tutor.Text = "Tutores";
            this.btn_tutor.UseVisualStyleBackColor = false;
            this.btn_tutor.Click += new System.EventHandler(this.btn_Asignar_tutor_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gb_foto_perfil, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gb_datos_tutor, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1172, 513);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lbl_nombres_alumno
            // 
            this.lbl_nombres_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombres_alumno.AutoSize = true;
            this.lbl_nombres_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres_alumno.Location = new System.Drawing.Point(3, 92);
            this.lbl_nombres_alumno.Name = "lbl_nombres_alumno";
            this.lbl_nombres_alumno.Size = new System.Drawing.Size(568, 23);
            this.lbl_nombres_alumno.TabIndex = 106;
            this.lbl_nombres_alumno.Text = "Nombres:";
            // 
            // lbl_apellidos_alumno
            // 
            this.lbl_apellidos_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidos_alumno.AutoSize = true;
            this.lbl_apellidos_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos_alumno.Location = new System.Drawing.Point(3, 161);
            this.lbl_apellidos_alumno.Name = "lbl_apellidos_alumno";
            this.lbl_apellidos_alumno.Size = new System.Drawing.Size(568, 23);
            this.lbl_apellidos_alumno.TabIndex = 107;
            this.lbl_apellidos_alumno.Text = "Apellidos:";
            // 
            // lbl_fecha_alumno
            // 
            this.lbl_fecha_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha_alumno.AutoSize = true;
            this.lbl_fecha_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_alumno.Location = new System.Drawing.Point(3, 230);
            this.lbl_fecha_alumno.Name = "lbl_fecha_alumno";
            this.lbl_fecha_alumno.Size = new System.Drawing.Size(568, 23);
            this.lbl_fecha_alumno.TabIndex = 108;
            this.lbl_fecha_alumno.Text = "Fecha:";
            // 
            // lbl_direccion_alumno
            // 
            this.lbl_direccion_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_direccion_alumno.AutoSize = true;
            this.lbl_direccion_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion_alumno.Location = new System.Drawing.Point(3, 299);
            this.lbl_direccion_alumno.Name = "lbl_direccion_alumno";
            this.lbl_direccion_alumno.Size = new System.Drawing.Size(568, 23);
            this.lbl_direccion_alumno.TabIndex = 109;
            this.lbl_direccion_alumno.Text = "Direccion:";
            // 
            // lbl_grupo_alumno
            // 
            this.lbl_grupo_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_grupo_alumno.AutoSize = true;
            this.lbl_grupo_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupo_alumno.Location = new System.Drawing.Point(3, 368);
            this.lbl_grupo_alumno.Name = "lbl_grupo_alumno";
            this.lbl_grupo_alumno.Size = new System.Drawing.Size(568, 23);
            this.lbl_grupo_alumno.TabIndex = 110;
            this.lbl_grupo_alumno.Text = "Grupo:";
            // 
            // lbl_estatus_alumno
            // 
            this.lbl_estatus_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estatus_alumno.AutoSize = true;
            this.lbl_estatus_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus_alumno.Location = new System.Drawing.Point(3, 438);
            this.lbl_estatus_alumno.Name = "lbl_estatus_alumno";
            this.lbl_estatus_alumno.Size = new System.Drawing.Size(568, 23);
            this.lbl_estatus_alumno.TabIndex = 116;
            this.lbl_estatus_alumno.Text = "Activo:";
            // 
            // lbl_matricula_alumno
            // 
            this.lbl_matricula_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_matricula_alumno.AutoSize = true;
            this.lbl_matricula_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula_alumno.Location = new System.Drawing.Point(3, 23);
            this.lbl_matricula_alumno.Name = "lbl_matricula_alumno";
            this.lbl_matricula_alumno.Size = new System.Drawing.Size(568, 23);
            this.lbl_matricula_alumno.TabIndex = 118;
            this.lbl_matricula_alumno.Text = "Matricula:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_matricula_alumno, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_estatus_alumno, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lbl_nombres_alumno, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_grupo_alumno, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lbl_apellidos_alumno, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_direccion_alumno, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_fecha_alumno, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(574, 485);
            this.tableLayoutPanel3.TabIndex = 119;
            // 
            // Frm_credencial_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 603);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.grbopciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_credencial_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credencial Alumno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_credencial_alumno_FormClosed);
            this.Load += new System.EventHandler(this.Frm_credencial_alumno_Load);
            this.gb_datos_tutor.ResumeLayout(false);
            this.gb_foto_perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagen_perfil)).EndInit();
            this.grbopciones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_datos_tutor;
        private System.Windows.Forms.GroupBox gb_foto_perfil;
        public System.Windows.Forms.PictureBox picture_imagen_perfil;
        private System.Windows.Forms.GroupBox grbopciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_tutor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Label lbl_matricula_alumno;
        public System.Windows.Forms.Label lbl_estatus_alumno;
        public System.Windows.Forms.Label lbl_nombres_alumno;
        public System.Windows.Forms.Label lbl_grupo_alumno;
        public System.Windows.Forms.Label lbl_apellidos_alumno;
        public System.Windows.Forms.Label lbl_direccion_alumno;
        public System.Windows.Forms.Label lbl_fecha_alumno;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}