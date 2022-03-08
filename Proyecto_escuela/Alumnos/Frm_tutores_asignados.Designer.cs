namespace Proyecto_escuela
{
    partial class Frm_tutores_asignados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_foto_perfil = new System.Windows.Forms.GroupBox();
            this.picture_imagen_perfil = new System.Windows.Forms.PictureBox();
            this.gb_datos_tutor = new System.Windows.Forms.GroupBox();
            this.lbl_estatus_tutor = new System.Windows.Forms.Label();
            this.lbl_parentesco_tutor = new System.Windows.Forms.Label();
            this.lbl_fecha_tutor = new System.Windows.Forms.Label();
            this.lbl_correo_tutor = new System.Windows.Forms.Label();
            this.lbl_telefono_tutor = new System.Windows.Forms.Label();
            this.lbl_direccion_tutor = new System.Windows.Forms.Label();
            this.lbl_apellidos_tutor = new System.Windows.Forms.Label();
            this.lbl_nombres_tutor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_tutor = new System.Windows.Forms.DataGridView();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_foto_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagen_perfil)).BeginInit();
            this.gb_datos_tutor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutor)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.gb_foto_perfil, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1172, 457);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // gb_foto_perfil
            // 
            this.gb_foto_perfil.Controls.Add(this.picture_imagen_perfil);
            this.gb_foto_perfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_foto_perfil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_foto_perfil.Location = new System.Drawing.Point(393, 3);
            this.gb_foto_perfil.Name = "gb_foto_perfil";
            this.gb_foto_perfil.Size = new System.Drawing.Size(384, 451);
            this.gb_foto_perfil.TabIndex = 2;
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
            // gb_datos_tutor
            // 
            this.gb_datos_tutor.Controls.Add(this.tableLayoutPanel2);
            this.gb_datos_tutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_datos_tutor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datos_tutor.Location = new System.Drawing.Point(783, 3);
            this.gb_datos_tutor.Name = "gb_datos_tutor";
            this.gb_datos_tutor.Size = new System.Drawing.Size(386, 451);
            this.gb_datos_tutor.TabIndex = 3;
            this.gb_datos_tutor.TabStop = false;
            this.gb_datos_tutor.Text = "Datos del tutor";
            // 
            // lbl_estatus_tutor
            // 
            this.lbl_estatus_tutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estatus_tutor.AutoSize = true;
            this.lbl_estatus_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus_tutor.Location = new System.Drawing.Point(3, 388);
            this.lbl_estatus_tutor.Name = "lbl_estatus_tutor";
            this.lbl_estatus_tutor.Size = new System.Drawing.Size(374, 23);
            this.lbl_estatus_tutor.TabIndex = 114;
            this.lbl_estatus_tutor.Text = "Activo:";
            // 
            // lbl_parentesco_tutor
            // 
            this.lbl_parentesco_tutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_parentesco_tutor.AutoSize = true;
            this.lbl_parentesco_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parentesco_tutor.Location = new System.Drawing.Point(3, 333);
            this.lbl_parentesco_tutor.Name = "lbl_parentesco_tutor";
            this.lbl_parentesco_tutor.Size = new System.Drawing.Size(374, 23);
            this.lbl_parentesco_tutor.TabIndex = 112;
            this.lbl_parentesco_tutor.Text = "Parentesco:";
            // 
            // lbl_fecha_tutor
            // 
            this.lbl_fecha_tutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha_tutor.AutoSize = true;
            this.lbl_fecha_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_tutor.Location = new System.Drawing.Point(3, 280);
            this.lbl_fecha_tutor.Name = "lbl_fecha_tutor";
            this.lbl_fecha_tutor.Size = new System.Drawing.Size(374, 23);
            this.lbl_fecha_tutor.TabIndex = 111;
            this.lbl_fecha_tutor.Text = "Fecha:";
            // 
            // lbl_correo_tutor
            // 
            this.lbl_correo_tutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_correo_tutor.AutoSize = true;
            this.lbl_correo_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo_tutor.Location = new System.Drawing.Point(3, 227);
            this.lbl_correo_tutor.Name = "lbl_correo_tutor";
            this.lbl_correo_tutor.Size = new System.Drawing.Size(374, 23);
            this.lbl_correo_tutor.TabIndex = 110;
            this.lbl_correo_tutor.Text = "Correo:";
            // 
            // lbl_telefono_tutor
            // 
            this.lbl_telefono_tutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_telefono_tutor.AutoSize = true;
            this.lbl_telefono_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono_tutor.Location = new System.Drawing.Point(3, 174);
            this.lbl_telefono_tutor.Name = "lbl_telefono_tutor";
            this.lbl_telefono_tutor.Size = new System.Drawing.Size(374, 23);
            this.lbl_telefono_tutor.TabIndex = 109;
            this.lbl_telefono_tutor.Text = "Telefono:";
            // 
            // lbl_direccion_tutor
            // 
            this.lbl_direccion_tutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_direccion_tutor.AutoSize = true;
            this.lbl_direccion_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion_tutor.Location = new System.Drawing.Point(3, 121);
            this.lbl_direccion_tutor.Name = "lbl_direccion_tutor";
            this.lbl_direccion_tutor.Size = new System.Drawing.Size(374, 23);
            this.lbl_direccion_tutor.TabIndex = 108;
            this.lbl_direccion_tutor.Text = "Direccion:";
            // 
            // lbl_apellidos_tutor
            // 
            this.lbl_apellidos_tutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellidos_tutor.AutoSize = true;
            this.lbl_apellidos_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos_tutor.Location = new System.Drawing.Point(3, 68);
            this.lbl_apellidos_tutor.Name = "lbl_apellidos_tutor";
            this.lbl_apellidos_tutor.Size = new System.Drawing.Size(374, 23);
            this.lbl_apellidos_tutor.TabIndex = 107;
            this.lbl_apellidos_tutor.Text = "Apellidos:";
            // 
            // lbl_nombres_tutor
            // 
            this.lbl_nombres_tutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombres_tutor.AutoSize = true;
            this.lbl_nombres_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres_tutor.Location = new System.Drawing.Point(3, 15);
            this.lbl_nombres_tutor.Name = "lbl_nombres_tutor";
            this.lbl_nombres_tutor.Size = new System.Drawing.Size(374, 23);
            this.lbl_nombres_tutor.TabIndex = 106;
            this.lbl_nombres_tutor.Text = "Nombres:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_tutor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 451);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tutores asignados";
            // 
            // dgv_tutor
            // 
            this.dgv_tutor.AllowUserToAddRows = false;
            this.dgv_tutor.AllowUserToDeleteRows = false;
            this.dgv_tutor.AllowUserToResizeColumns = false;
            this.dgv_tutor.AllowUserToResizeRows = false;
            this.dgv_tutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tutor.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_tutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tutor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombres,
            this.Apellidos,
            this.Direccion,
            this.Telefono,
            this.Correo,
            this.Fecha_nacimiento,
            this.Parentesco,
            this.Estatus,
            this.id_tutor,
            this.imagen});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tutor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tutor.EnableHeadersVisualStyles = false;
            this.dgv_tutor.GridColor = System.Drawing.Color.LightGray;
            this.dgv_tutor.Location = new System.Drawing.Point(3, 18);
            this.dgv_tutor.Name = "dgv_tutor";
            this.dgv_tutor.RowHeadersVisible = false;
            this.dgv_tutor.RowHeadersWidth = 51;
            this.dgv_tutor.RowTemplate.Height = 24;
            this.dgv_tutor.Size = new System.Drawing.Size(378, 430);
            this.dgv_tutor.TabIndex = 8;
            this.dgv_tutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tutor_CellClick);
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
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Visible = false;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Visible = false;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Visible = false;
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.HeaderText = "Fecha de nacimiento";
            this.Fecha_nacimiento.MinimumWidth = 6;
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.Visible = false;
            // 
            // Parentesco
            // 
            this.Parentesco.HeaderText = "Parentesco";
            this.Parentesco.MinimumWidth = 6;
            this.Parentesco.Name = "Parentesco";
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.MinimumWidth = 6;
            this.Estatus.Name = "Estatus";
            this.Estatus.Visible = false;
            // 
            // id_tutor
            // 
            this.id_tutor.HeaderText = "id_tutor";
            this.id_tutor.MinimumWidth = 6;
            this.id_tutor.Name = "id_tutor";
            this.id_tutor.Visible = false;
            // 
            // imagen
            // 
            this.imagen.HeaderText = "imagen";
            this.imagen.MinimumWidth = 6;
            this.imagen.Name = "imagen";
            this.imagen.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_nombres_tutor, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_estatus_tutor, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lbl_apellidos_tutor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_parentesco_tutor, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lbl_direccion_tutor, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_fecha_tutor, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbl_telefono_tutor, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_correo_tutor, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(380, 429);
            this.tableLayoutPanel2.TabIndex = 115;
            // 
            // Frm_tutores_asignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1172, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_tutores_asignados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutores";
            this.Load += new System.EventHandler(this.Frm_tutores_asignados_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gb_foto_perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagen_perfil)).EndInit();
            this.gb_datos_tutor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutor)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parentesco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagen;
        private System.Windows.Forms.GroupBox gb_datos_tutor;
        public System.Windows.Forms.Label lbl_estatus_tutor;
        public System.Windows.Forms.Label lbl_parentesco_tutor;
        public System.Windows.Forms.Label lbl_fecha_tutor;
        public System.Windows.Forms.Label lbl_correo_tutor;
        public System.Windows.Forms.Label lbl_telefono_tutor;
        public System.Windows.Forms.Label lbl_direccion_tutor;
        public System.Windows.Forms.Label lbl_apellidos_tutor;
        public System.Windows.Forms.Label lbl_nombres_tutor;
        private System.Windows.Forms.GroupBox gb_foto_perfil;
        public System.Windows.Forms.PictureBox picture_imagen_perfil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}