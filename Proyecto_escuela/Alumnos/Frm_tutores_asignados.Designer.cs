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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gb_foto_perfil = new System.Windows.Forms.GroupBox();
            this.picture_imagen_perfil = new System.Windows.Forms.PictureBox();
            this.gb_datos_tutor = new System.Windows.Forms.GroupBox();
            this.lbl_estatus_tutor = new System.Windows.Forms.Label();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.lbl_parentesco_tutor = new System.Windows.Forms.Label();
            this.lbl_fecha_tutor = new System.Windows.Forms.Label();
            this.lbl_correo_tutor = new System.Windows.Forms.Label();
            this.lbl_telefono_tutor = new System.Windows.Forms.Label();
            this.lbl_direccion_tutor = new System.Windows.Forms.Label();
            this.lbl_apellidos_tutor = new System.Windows.Forms.Label();
            this.lbl_nombres_tutor = new System.Windows.Forms.Label();
            this.lbl_parentesco = new System.Windows.Forms.Label();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_tutor = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gb_foto_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagen_perfil)).BeginInit();
            this.gb_datos_tutor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 410);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(394, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 410);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gb_foto_perfil);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 404);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gb_datos_tutor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(488, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 404);
            this.panel3.TabIndex = 1;
            // 
            // gb_foto_perfil
            // 
            this.gb_foto_perfil.Controls.Add(this.picture_imagen_perfil);
            this.gb_foto_perfil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_foto_perfil.Location = new System.Drawing.Point(3, 9);
            this.gb_foto_perfil.Name = "gb_foto_perfil";
            this.gb_foto_perfil.Size = new System.Drawing.Size(473, 390);
            this.gb_foto_perfil.TabIndex = 1;
            this.gb_foto_perfil.TabStop = false;
            this.gb_foto_perfil.Text = "Foto de perfil";
            // 
            // picture_imagen_perfil
            // 
            this.picture_imagen_perfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_imagen_perfil.Location = new System.Drawing.Point(3, 19);
            this.picture_imagen_perfil.Name = "picture_imagen_perfil";
            this.picture_imagen_perfil.Size = new System.Drawing.Size(467, 368);
            this.picture_imagen_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_imagen_perfil.TabIndex = 0;
            this.picture_imagen_perfil.TabStop = false;
            // 
            // gb_datos_tutor
            // 
            this.gb_datos_tutor.Controls.Add(this.lbl_estatus_tutor);
            this.gb_datos_tutor.Controls.Add(this.lbl_estatus);
            this.gb_datos_tutor.Controls.Add(this.lbl_parentesco_tutor);
            this.gb_datos_tutor.Controls.Add(this.lbl_fecha_tutor);
            this.gb_datos_tutor.Controls.Add(this.lbl_correo_tutor);
            this.gb_datos_tutor.Controls.Add(this.lbl_telefono_tutor);
            this.gb_datos_tutor.Controls.Add(this.lbl_direccion_tutor);
            this.gb_datos_tutor.Controls.Add(this.lbl_apellidos_tutor);
            this.gb_datos_tutor.Controls.Add(this.lbl_nombres_tutor);
            this.gb_datos_tutor.Controls.Add(this.lbl_parentesco);
            this.gb_datos_tutor.Controls.Add(this.lbl_fecha_nacimiento);
            this.gb_datos_tutor.Controls.Add(this.lbl_correo);
            this.gb_datos_tutor.Controls.Add(this.lbl_telefono);
            this.gb_datos_tutor.Controls.Add(this.lbl_direccion);
            this.gb_datos_tutor.Controls.Add(this.lbl_apellidos);
            this.gb_datos_tutor.Controls.Add(this.lbl_tutor);
            this.gb_datos_tutor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datos_tutor.Location = new System.Drawing.Point(3, 9);
            this.gb_datos_tutor.Name = "gb_datos_tutor";
            this.gb_datos_tutor.Size = new System.Drawing.Size(468, 390);
            this.gb_datos_tutor.TabIndex = 2;
            this.gb_datos_tutor.TabStop = false;
            this.gb_datos_tutor.Text = "Datos del tutor";
            // 
            // lbl_estatus_tutor
            // 
            this.lbl_estatus_tutor.AutoSize = true;
            this.lbl_estatus_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus_tutor.Location = new System.Drawing.Point(100, 353);
            this.lbl_estatus_tutor.Name = "lbl_estatus_tutor";
            this.lbl_estatus_tutor.Size = new System.Drawing.Size(74, 23);
            this.lbl_estatus_tutor.TabIndex = 114;
            this.lbl_estatus_tutor.Text = "Activo";
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus.Location = new System.Drawing.Point(11, 353);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(82, 23);
            this.lbl_estatus.TabIndex = 113;
            this.lbl_estatus.Text = "Estatus:";
            // 
            // lbl_parentesco_tutor
            // 
            this.lbl_parentesco_tutor.AutoSize = true;
            this.lbl_parentesco_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parentesco_tutor.Location = new System.Drawing.Point(145, 309);
            this.lbl_parentesco_tutor.Name = "lbl_parentesco_tutor";
            this.lbl_parentesco_tutor.Size = new System.Drawing.Size(121, 23);
            this.lbl_parentesco_tutor.TabIndex = 112;
            this.lbl_parentesco_tutor.Text = "Parentesco";
            // 
            // lbl_fecha_tutor
            // 
            this.lbl_fecha_tutor.AutoSize = true;
            this.lbl_fecha_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_tutor.Location = new System.Drawing.Point(242, 265);
            this.lbl_fecha_tutor.Name = "lbl_fecha_tutor";
            this.lbl_fecha_tutor.Size = new System.Drawing.Size(72, 23);
            this.lbl_fecha_tutor.TabIndex = 111;
            this.lbl_fecha_tutor.Text = "Fecha";
            // 
            // lbl_correo_tutor
            // 
            this.lbl_correo_tutor.AutoSize = true;
            this.lbl_correo_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo_tutor.Location = new System.Drawing.Point(99, 220);
            this.lbl_correo_tutor.Name = "lbl_correo_tutor";
            this.lbl_correo_tutor.Size = new System.Drawing.Size(77, 23);
            this.lbl_correo_tutor.TabIndex = 110;
            this.lbl_correo_tutor.Text = "Correo";
            // 
            // lbl_telefono_tutor
            // 
            this.lbl_telefono_tutor.AutoSize = true;
            this.lbl_telefono_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono_tutor.Location = new System.Drawing.Point(120, 177);
            this.lbl_telefono_tutor.Name = "lbl_telefono_tutor";
            this.lbl_telefono_tutor.Size = new System.Drawing.Size(93, 23);
            this.lbl_telefono_tutor.TabIndex = 109;
            this.lbl_telefono_tutor.Text = "Telefono";
            // 
            // lbl_direccion_tutor
            // 
            this.lbl_direccion_tutor.AutoSize = true;
            this.lbl_direccion_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion_tutor.Location = new System.Drawing.Point(120, 133);
            this.lbl_direccion_tutor.Name = "lbl_direccion_tutor";
            this.lbl_direccion_tutor.Size = new System.Drawing.Size(101, 23);
            this.lbl_direccion_tutor.TabIndex = 108;
            this.lbl_direccion_tutor.Text = "Direccion";
            // 
            // lbl_apellidos_tutor
            // 
            this.lbl_apellidos_tutor.AutoSize = true;
            this.lbl_apellidos_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos_tutor.Location = new System.Drawing.Point(120, 87);
            this.lbl_apellidos_tutor.Name = "lbl_apellidos_tutor";
            this.lbl_apellidos_tutor.Size = new System.Drawing.Size(100, 23);
            this.lbl_apellidos_tutor.TabIndex = 107;
            this.lbl_apellidos_tutor.Text = "Apellidos";
            // 
            // lbl_nombres_tutor
            // 
            this.lbl_nombres_tutor.AutoSize = true;
            this.lbl_nombres_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres_tutor.Location = new System.Drawing.Point(120, 41);
            this.lbl_nombres_tutor.Name = "lbl_nombres_tutor";
            this.lbl_nombres_tutor.Size = new System.Drawing.Size(98, 23);
            this.lbl_nombres_tutor.TabIndex = 106;
            this.lbl_nombres_tutor.Text = "Nombres";
            // 
            // lbl_parentesco
            // 
            this.lbl_parentesco.AutoSize = true;
            this.lbl_parentesco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parentesco.Location = new System.Drawing.Point(11, 309);
            this.lbl_parentesco.Name = "lbl_parentesco";
            this.lbl_parentesco.Size = new System.Drawing.Size(128, 23);
            this.lbl_parentesco.TabIndex = 105;
            this.lbl_parentesco.Text = "parentesco:";
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(11, 265);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(225, 23);
            this.lbl_fecha_nacimiento.TabIndex = 104;
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento:";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(11, 220);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(82, 23);
            this.lbl_correo.TabIndex = 103;
            this.lbl_correo.Text = "Correo:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(11, 177);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(98, 23);
            this.lbl_telefono.TabIndex = 102;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(11, 133);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(106, 23);
            this.lbl_direccion.TabIndex = 101;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(11, 87);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(105, 23);
            this.lbl_apellidos.TabIndex = 100;
            this.lbl_apellidos.Text = "Apellidos:";
            // 
            // lbl_tutor
            // 
            this.lbl_tutor.AutoSize = true;
            this.lbl_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tutor.Location = new System.Drawing.Point(11, 41);
            this.lbl_tutor.Name = "lbl_tutor";
            this.lbl_tutor.Size = new System.Drawing.Size(103, 23);
            this.lbl_tutor.TabIndex = 99;
            this.lbl_tutor.Text = "Nombres:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_tutor);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 387);
            this.groupBox1.TabIndex = 0;
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
            this.dgv_tutor.Size = new System.Drawing.Size(379, 366);
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
            // Frm_tutores_asignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1365, 410);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_tutores_asignados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutores";
            this.Load += new System.EventHandler(this.Frm_tutores_asignados_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gb_foto_perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagen_perfil)).EndInit();
            this.gb_datos_tutor.ResumeLayout(false);
            this.gb_datos_tutor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gb_foto_perfil;
        public System.Windows.Forms.PictureBox picture_imagen_perfil;
        private System.Windows.Forms.GroupBox gb_datos_tutor;
        public System.Windows.Forms.Label lbl_estatus_tutor;
        private System.Windows.Forms.Label lbl_estatus;
        public System.Windows.Forms.Label lbl_parentesco_tutor;
        public System.Windows.Forms.Label lbl_fecha_tutor;
        public System.Windows.Forms.Label lbl_correo_tutor;
        public System.Windows.Forms.Label lbl_telefono_tutor;
        public System.Windows.Forms.Label lbl_direccion_tutor;
        public System.Windows.Forms.Label lbl_apellidos_tutor;
        public System.Windows.Forms.Label lbl_nombres_tutor;
        private System.Windows.Forms.Label lbl_parentesco;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_tutor;
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
    }
}