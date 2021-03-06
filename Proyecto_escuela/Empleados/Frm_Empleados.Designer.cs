
namespace Proyecto_escuela.Empleados
{
    partial class Frm_Empleados
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
            this.panel_busqueda = new System.Windows.Forms.Panel();
            this.btn_registar_empleado = new Proyecto_escuela.Boton.RJButton();
            this.txt_empleado = new Proyecto_escuela.Textbox.Rjtextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_matricula_empleado = new System.Windows.Forms.Label();
            this.dgv_empleado = new System.Windows.Forms.DataGridView();
            this.id_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_busqueda
            // 
            this.panel_busqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_busqueda.Controls.Add(this.btn_registar_empleado);
            this.panel_busqueda.Controls.Add(this.txt_empleado);
            this.panel_busqueda.Controls.Add(this.pictureBox1);
            this.panel_busqueda.Controls.Add(this.lbl_matricula_empleado);
            this.panel_busqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_busqueda.Location = new System.Drawing.Point(0, 0);
            this.panel_busqueda.Name = "panel_busqueda";
            this.panel_busqueda.Size = new System.Drawing.Size(1178, 50);
            this.panel_busqueda.TabIndex = 10;
            // 
            // btn_registar_empleado
            // 
            this.btn_registar_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_registar_empleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_registar_empleado.BorderColor = System.Drawing.Color.HotPink;
            this.btn_registar_empleado.BorderRadius = 15;
            this.btn_registar_empleado.BorderSize = 0;
            this.btn_registar_empleado.FlatAppearance.BorderSize = 0;
            this.btn_registar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registar_empleado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registar_empleado.ForeColor = System.Drawing.Color.Black;
            this.btn_registar_empleado.Image = global::Proyecto_escuela.Properties.Resources.usuario__2_;
            this.btn_registar_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registar_empleado.Location = new System.Drawing.Point(12, 7);
            this.btn_registar_empleado.Name = "btn_registar_empleado";
            this.btn_registar_empleado.Size = new System.Drawing.Size(248, 40);
            this.btn_registar_empleado.TabIndex = 26;
            this.btn_registar_empleado.Text = "Registrar empleado";
            this.btn_registar_empleado.TextColor = System.Drawing.Color.Black;
            this.btn_registar_empleado.UseVisualStyleBackColor = false;
            this.btn_registar_empleado.Click += new System.EventHandler(this.btn_registar_empleado_Click);
            // 
            // txt_empleado
            // 
            this.txt_empleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_empleado.BackColor = System.Drawing.SystemColors.Window;
            this.txt_empleado.BorderColor = System.Drawing.Color.DimGray;
            this.txt_empleado.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_empleado.BorderRadius = 10;
            this.txt_empleado.BorderSize = 2;
            this.txt_empleado.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_empleado.ForeColor = System.Drawing.Color.Black;
            this.txt_empleado.Location = new System.Drawing.Point(514, 7);
            this.txt_empleado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_empleado.Multiline = false;
            this.txt_empleado.Name = "txt_empleado";
            this.txt_empleado.Padding = new System.Windows.Forms.Padding(7);
            this.txt_empleado.PasswordChar = false;
            this.txt_empleado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_empleado.PlaceholderText = "Ej. 17340347";
            this.txt_empleado.Size = new System.Drawing.Size(326, 36);
            this.txt_empleado.TabIndex = 25;
            this.txt_empleado.Texts = "";
            this.txt_empleado.UnderlinedStyle = false;
            this.txt_empleado._TextChanged += new System.EventHandler(this.txt_empleado_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Proyecto_escuela.Properties.Resources._1486505375_files_folder_search_magnifying_glass_file_search_magnifier_storage_81440;
            this.pictureBox1.Location = new System.Drawing.Point(843, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_matricula_empleado
            // 
            this.lbl_matricula_empleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_matricula_empleado.AutoSize = true;
            this.lbl_matricula_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula_empleado.Location = new System.Drawing.Point(249, 16);
            this.lbl_matricula_empleado.Name = "lbl_matricula_empleado";
            this.lbl_matricula_empleado.Size = new System.Drawing.Size(255, 23);
            this.lbl_matricula_empleado.TabIndex = 15;
            this.lbl_matricula_empleado.Text = "Matricula del empleado:";
            // 
            // dgv_empleado
            // 
            this.dgv_empleado.AllowUserToAddRows = false;
            this.dgv_empleado.AllowUserToDeleteRows = false;
            this.dgv_empleado.AllowUserToResizeColumns = false;
            this.dgv_empleado.AllowUserToResizeRows = false;
            this.dgv_empleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_empleado.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_empleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_empleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_alumno,
            this.Matricula,
            this.Nombres,
            this.Apellidos,
            this.Fecha_nacimiento,
            this.Direccion,
            this.Correo,
            this.Telefono,
            this.Rol,
            this.Estatus,
            this.Imagen,
            this.codigo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_empleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_empleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_empleado.EnableHeadersVisualStyles = false;
            this.dgv_empleado.GridColor = System.Drawing.Color.LightGray;
            this.dgv_empleado.Location = new System.Drawing.Point(0, 50);
            this.dgv_empleado.Name = "dgv_empleado";
            this.dgv_empleado.RowHeadersVisible = false;
            this.dgv_empleado.RowHeadersWidth = 51;
            this.dgv_empleado.RowTemplate.Height = 24;
            this.dgv_empleado.Size = new System.Drawing.Size(1178, 503);
            this.dgv_empleado.TabIndex = 11;
            this.dgv_empleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleado_CellClick);
            // 
            // id_alumno
            // 
            this.id_alumno.HeaderText = "Id_Empleado";
            this.id_alumno.MinimumWidth = 6;
            this.id_alumno.Name = "id_alumno";
            this.id_alumno.Visible = false;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.MinimumWidth = 6;
            this.Matricula.Name = "Matricula";
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
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.MinimumWidth = 6;
            this.Estatus.Name = "Estatus";
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.MinimumWidth = 6;
            this.Imagen.Name = "Imagen";
            this.Imagen.Visible = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.Visible = false;
            // 
            // Frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 553);
            this.Controls.Add(this.dgv_empleado);
            this.Controls.Add(this.panel_busqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Frm_Empleados_Load);
            this.panel_busqueda.ResumeLayout(false);
            this.panel_busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_busqueda;
        private System.Windows.Forms.Label lbl_matricula_empleado;
        public System.Windows.Forms.DataGridView dgv_empleado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private Textbox.Rjtextbox txt_empleado;
        private Boton.RJButton btn_registar_empleado;
    }
}