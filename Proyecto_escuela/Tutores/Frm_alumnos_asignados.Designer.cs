namespace Proyecto_escuela
{
    partial class Frm_alumnos_asignados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_alumno = new System.Windows.Forms.DataGridView();
            this.id_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_datos_tutor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_matricula_alumno = new System.Windows.Forms.Label();
            this.lbl_estatus_alumno = new System.Windows.Forms.Label();
            this.lbl_grupo_alumno = new System.Windows.Forms.Label();
            this.lbl_direccion_alumno = new System.Windows.Forms.Label();
            this.lbl_fecha_alumno = new System.Windows.Forms.Label();
            this.lbl_apellidos_alumno = new System.Windows.Forms.Label();
            this.lbl_nombres_alumno = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gb_foto_perfil = new System.Windows.Forms.GroupBox();
            this.picture_imagen_perfil = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumno)).BeginInit();
            this.gb_datos_tutor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gb_foto_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagen_perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gb_datos_tutor, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1172, 457);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.dgv_alumno);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos asignados";
            // 
            // dgv_alumno
            // 
            this.dgv_alumno.AllowUserToAddRows = false;
            this.dgv_alumno.AllowUserToDeleteRows = false;
            this.dgv_alumno.AllowUserToResizeColumns = false;
            this.dgv_alumno.AllowUserToResizeRows = false;
            this.dgv_alumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_alumno.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_alumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_alumno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alumno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_alumno,
            this.Matricula,
            this.Nombres,
            this.Apellidos,
            this.Fecha_nacimiento,
            this.Direccion,
            this.Grupo,
            this.Estatus,
            this.Imagen});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_alumno.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_alumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_alumno.EnableHeadersVisualStyles = false;
            this.dgv_alumno.GridColor = System.Drawing.Color.LightGray;
            this.dgv_alumno.Location = new System.Drawing.Point(3, 18);
            this.dgv_alumno.Name = "dgv_alumno";
            this.dgv_alumno.RowHeadersVisible = false;
            this.dgv_alumno.RowHeadersWidth = 51;
            this.dgv_alumno.RowTemplate.Height = 24;
            this.dgv_alumno.Size = new System.Drawing.Size(378, 430);
            this.dgv_alumno.TabIndex = 6;
            this.dgv_alumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_alumno_CellClick);
            // 
            // id_alumno
            // 
            this.id_alumno.HeaderText = "Id_alumno";
            this.id_alumno.MinimumWidth = 6;
            this.id_alumno.Name = "id_alumno";
            this.id_alumno.Visible = false;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.MinimumWidth = 6;
            this.Matricula.Name = "Matricula";
            this.Matricula.Visible = false;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.MinimumWidth = 6;
            this.Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.HeaderText = "Fecha de nacimiento";
            this.Fecha_nacimiento.MinimumWidth = 6;
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.Visible = false;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Visible = false;
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.MinimumWidth = 6;
            this.Grupo.Name = "Grupo";
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.MinimumWidth = 6;
            this.Estatus.Name = "Estatus";
            this.Estatus.Visible = false;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.MinimumWidth = 6;
            this.Imagen.Name = "Imagen";
            this.Imagen.Visible = false;
            // 
            // gb_datos_tutor
            // 
            this.gb_datos_tutor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_datos_tutor.Controls.Add(this.tableLayoutPanel2);
            this.gb_datos_tutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_datos_tutor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datos_tutor.Location = new System.Drawing.Point(783, 3);
            this.gb_datos_tutor.Name = "gb_datos_tutor";
            this.gb_datos_tutor.Size = new System.Drawing.Size(386, 451);
            this.gb_datos_tutor.TabIndex = 3;
            this.gb_datos_tutor.TabStop = false;
            this.gb_datos_tutor.Text = "Datos del alumno";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_matricula_alumno, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_estatus_alumno, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lbl_grupo_alumno, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbl_direccion_alumno, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_fecha_alumno, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_apellidos_alumno, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_nombres_alumno, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(380, 429);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl_matricula_alumno
            // 
            this.lbl_matricula_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_matricula_alumno.AutoSize = true;
            this.lbl_matricula_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula_alumno.Location = new System.Drawing.Point(3, 19);
            this.lbl_matricula_alumno.Name = "lbl_matricula_alumno";
            this.lbl_matricula_alumno.Size = new System.Drawing.Size(374, 23);
            this.lbl_matricula_alumno.TabIndex = 132;
            this.lbl_matricula_alumno.Text = "Matricula:";
            // 
            // lbl_estatus_alumno
            // 
            this.lbl_estatus_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estatus_alumno.AutoSize = true;
            this.lbl_estatus_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus_alumno.Location = new System.Drawing.Point(3, 386);
            this.lbl_estatus_alumno.Name = "lbl_estatus_alumno";
            this.lbl_estatus_alumno.Size = new System.Drawing.Size(374, 23);
            this.lbl_estatus_alumno.TabIndex = 130;
            this.lbl_estatus_alumno.Text = "Activo:";
            // 
            // lbl_grupo_alumno
            // 
            this.lbl_grupo_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_grupo_alumno.AutoSize = true;
            this.lbl_grupo_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupo_alumno.Location = new System.Drawing.Point(3, 324);
            this.lbl_grupo_alumno.Name = "lbl_grupo_alumno";
            this.lbl_grupo_alumno.Size = new System.Drawing.Size(374, 23);
            this.lbl_grupo_alumno.TabIndex = 128;
            this.lbl_grupo_alumno.Text = "Grupo:";
            // 
            // lbl_direccion_alumno
            // 
            this.lbl_direccion_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_direccion_alumno.AutoSize = true;
            this.lbl_direccion_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion_alumno.Location = new System.Drawing.Point(3, 263);
            this.lbl_direccion_alumno.Name = "lbl_direccion_alumno";
            this.lbl_direccion_alumno.Size = new System.Drawing.Size(374, 23);
            this.lbl_direccion_alumno.TabIndex = 127;
            this.lbl_direccion_alumno.Text = "Direccion:";
            // 
            // lbl_fecha_alumno
            // 
            this.lbl_fecha_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha_alumno.AutoSize = true;
            this.lbl_fecha_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_alumno.Location = new System.Drawing.Point(3, 202);
            this.lbl_fecha_alumno.Name = "lbl_fecha_alumno";
            this.lbl_fecha_alumno.Size = new System.Drawing.Size(374, 23);
            this.lbl_fecha_alumno.TabIndex = 126;
            this.lbl_fecha_alumno.Text = "Fecha:";
            // 
            // lbl_apellidos_alumno
            // 
            this.lbl_apellidos_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidos_alumno.AutoSize = true;
            this.lbl_apellidos_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos_alumno.Location = new System.Drawing.Point(3, 141);
            this.lbl_apellidos_alumno.Name = "lbl_apellidos_alumno";
            this.lbl_apellidos_alumno.Size = new System.Drawing.Size(374, 23);
            this.lbl_apellidos_alumno.TabIndex = 125;
            this.lbl_apellidos_alumno.Text = "Apellidos:";
            // 
            // lbl_nombres_alumno
            // 
            this.lbl_nombres_alumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombres_alumno.AutoSize = true;
            this.lbl_nombres_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres_alumno.Location = new System.Drawing.Point(3, 80);
            this.lbl_nombres_alumno.Name = "lbl_nombres_alumno";
            this.lbl_nombres_alumno.Size = new System.Drawing.Size(374, 23);
            this.lbl_nombres_alumno.TabIndex = 124;
            this.lbl_nombres_alumno.Text = "Nombres:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gb_foto_perfil);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(393, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 451);
            this.panel3.TabIndex = 1;
            // 
            // gb_foto_perfil
            // 
            this.gb_foto_perfil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_foto_perfil.Controls.Add(this.picture_imagen_perfil);
            this.gb_foto_perfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_foto_perfil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_foto_perfil.Location = new System.Drawing.Point(0, 0);
            this.gb_foto_perfil.Name = "gb_foto_perfil";
            this.gb_foto_perfil.Size = new System.Drawing.Size(384, 451);
            this.gb_foto_perfil.TabIndex = 1;
            this.gb_foto_perfil.TabStop = false;
            this.gb_foto_perfil.Text = "Foto de perfil";
            // 
            // picture_imagen_perfil
            // 
            this.picture_imagen_perfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_imagen_perfil.Location = new System.Drawing.Point(3, 19);
            this.picture_imagen_perfil.Name = "picture_imagen_perfil";
            this.picture_imagen_perfil.Size = new System.Drawing.Size(378, 429);
            this.picture_imagen_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_imagen_perfil.TabIndex = 0;
            this.picture_imagen_perfil.TabStop = false;
            // 
            // Frm_alumnos_asignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_alumnos_asignados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos Asignados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_alumnos_asignados_FormClosed);
            this.Load += new System.EventHandler(this.Frm_alumnos_asignados_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumno)).EndInit();
            this.gb_datos_tutor.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gb_foto_perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagen_perfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgv_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.GroupBox gb_datos_tutor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label lbl_matricula_alumno;
        public System.Windows.Forms.Label lbl_estatus_alumno;
        public System.Windows.Forms.Label lbl_grupo_alumno;
        public System.Windows.Forms.Label lbl_direccion_alumno;
        public System.Windows.Forms.Label lbl_fecha_alumno;
        public System.Windows.Forms.Label lbl_apellidos_alumno;
        public System.Windows.Forms.Label lbl_nombres_alumno;
        private System.Windows.Forms.GroupBox gb_foto_perfil;
        public System.Windows.Forms.PictureBox picture_imagen_perfil;
    }
}