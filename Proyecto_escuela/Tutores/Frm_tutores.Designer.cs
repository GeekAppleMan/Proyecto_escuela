
namespace Proyecto_escuela
{
    partial class Frm_tutores
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
            this.panel_busqueda = new System.Windows.Forms.Panel();
            this.btn_registrar_tutor = new Proyecto_escuela.Boton.RJButton();
            this.txttutor = new Proyecto_escuela.Textbox.Rjtextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_tutor = new System.Windows.Forms.Label();
            this.panel_grid = new System.Windows.Forms.Panel();
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
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_busqueda
            // 
            this.panel_busqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_busqueda.Controls.Add(this.btn_registrar_tutor);
            this.panel_busqueda.Controls.Add(this.txttutor);
            this.panel_busqueda.Controls.Add(this.pictureBox1);
            this.panel_busqueda.Controls.Add(this.lbl_tutor);
            this.panel_busqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_busqueda.Location = new System.Drawing.Point(0, 0);
            this.panel_busqueda.Name = "panel_busqueda";
            this.panel_busqueda.Size = new System.Drawing.Size(1178, 50);
            this.panel_busqueda.TabIndex = 5;
            // 
            // btn_registrar_tutor
            // 
            this.btn_registrar_tutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_registrar_tutor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_registrar_tutor.BorderColor = System.Drawing.Color.HotPink;
            this.btn_registrar_tutor.BorderRadius = 15;
            this.btn_registrar_tutor.BorderSize = 0;
            this.btn_registrar_tutor.FlatAppearance.BorderSize = 0;
            this.btn_registrar_tutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_tutor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_tutor.ForeColor = System.Drawing.Color.Black;
            this.btn_registrar_tutor.Image = global::Proyecto_escuela.Properties.Resources.usuario__2_;
            this.btn_registrar_tutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registrar_tutor.Location = new System.Drawing.Point(12, 4);
            this.btn_registrar_tutor.Name = "btn_registrar_tutor";
            this.btn_registrar_tutor.Size = new System.Drawing.Size(234, 40);
            this.btn_registrar_tutor.TabIndex = 22;
            this.btn_registrar_tutor.Text = "Registrar tutor";
            this.btn_registrar_tutor.TextColor = System.Drawing.Color.Black;
            this.btn_registrar_tutor.UseVisualStyleBackColor = false;
            this.btn_registrar_tutor.Click += new System.EventHandler(this.btn_registrar_tutor_Click);
            // 
            // txttutor
            // 
            this.txttutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttutor.BackColor = System.Drawing.SystemColors.Window;
            this.txttutor.BorderColor = System.Drawing.Color.DimGray;
            this.txttutor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txttutor.BorderRadius = 10;
            this.txttutor.BorderSize = 2;
            this.txttutor.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txttutor.ForeColor = System.Drawing.Color.Black;
            this.txttutor.Location = new System.Drawing.Point(464, 8);
            this.txttutor.Margin = new System.Windows.Forms.Padding(4);
            this.txttutor.Multiline = false;
            this.txttutor.Name = "txttutor";
            this.txttutor.Padding = new System.Windows.Forms.Padding(7);
            this.txttutor.PasswordChar = false;
            this.txttutor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txttutor.PlaceholderText = "Ej. Jaime Sanchez";
            this.txttutor.Size = new System.Drawing.Size(326, 36);
            this.txttutor.TabIndex = 20;
            this.txttutor.Texts = "";
            this.txttutor.UnderlinedStyle = false;
            this.txttutor._TextChanged += new System.EventHandler(this.txttutor__TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Proyecto_escuela.Properties.Resources._1486505375_files_folder_search_magnifying_glass_file_search_magnifier_storage_81440;
            this.pictureBox1.Location = new System.Drawing.Point(797, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_tutor
            // 
            this.lbl_tutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tutor.AutoSize = true;
            this.lbl_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tutor.Location = new System.Drawing.Point(268, 11);
            this.lbl_tutor.Name = "lbl_tutor";
            this.lbl_tutor.Size = new System.Drawing.Size(184, 23);
            this.lbl_tutor.TabIndex = 15;
            this.lbl_tutor.Text = "Nombre del tutor:";
            // 
            // panel_grid
            // 
            this.panel_grid.Controls.Add(this.dgv_tutor);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid.Location = new System.Drawing.Point(0, 50);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(1178, 503);
            this.panel_grid.TabIndex = 8;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.imagen,
            this.codigo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tutor.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_tutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tutor.EnableHeadersVisualStyles = false;
            this.dgv_tutor.GridColor = System.Drawing.Color.LightGray;
            this.dgv_tutor.Location = new System.Drawing.Point(0, 0);
            this.dgv_tutor.Name = "dgv_tutor";
            this.dgv_tutor.RowHeadersVisible = false;
            this.dgv_tutor.RowHeadersWidth = 51;
            this.dgv_tutor.RowTemplate.Height = 24;
            this.dgv_tutor.Size = new System.Drawing.Size(1178, 503);
            this.dgv_tutor.TabIndex = 5;
            this.dgv_tutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tutor_CellClick);
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.MinimumWidth = 6;
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.HeaderText = "Fecha de nacimiento";
            this.Fecha_nacimiento.MinimumWidth = 6;
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.ReadOnly = true;
            // 
            // Parentesco
            // 
            this.Parentesco.HeaderText = "Parentesco";
            this.Parentesco.MinimumWidth = 6;
            this.Parentesco.Name = "Parentesco";
            this.Parentesco.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.MinimumWidth = 6;
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
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
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Modificar";
            this.dataGridViewImageColumn1.Image = global::Proyecto_escuela.Properties.Resources.usuario__4_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 131;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Proyecto_escuela.Properties.Resources.usuario__3_;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 131;
            // 
            // Frm_tutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 553);
            this.Controls.Add(this.panel_grid);
            this.Controls.Add(this.panel_busqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_tutores";
            this.Text = "Tutores";
            this.Load += new System.EventHandler(this.Frm_tutores_Load);
            this.panel_busqueda.ResumeLayout(false);
            this.panel_busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_busqueda;
        private System.Windows.Forms.Label lbl_tutor;
        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.DataGridView dgv_tutor;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private Textbox.Rjtextbox txttutor;
        private Boton.RJButton btn_registrar_tutor;
    }
}