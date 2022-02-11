
namespace Proyecto_escuela
{
    partial class Frm_Alumnos
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
            this.panel_grid = new System.Windows.Forms.Panel();
            this.dgv_alumno = new System.Windows.Forms.DataGridView();
            this.panel_busqueda = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_alumno = new System.Windows.Forms.TextBox();
            this.lbl_alumno = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_registrar_alumno = new System.Windows.Forms.Button();
            this.id_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumno)).BeginInit();
            this.panel_busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_grid
            // 
            this.panel_grid.Controls.Add(this.dgv_alumno);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid.Location = new System.Drawing.Point(0, 50);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(1178, 503);
            this.panel_grid.TabIndex = 10;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alumno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_alumno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_alumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_alumno.EnableHeadersVisualStyles = false;
            this.dgv_alumno.GridColor = System.Drawing.Color.LightGray;
            this.dgv_alumno.Location = new System.Drawing.Point(0, 0);
            this.dgv_alumno.Name = "dgv_alumno";
            this.dgv_alumno.RowHeadersVisible = false;
            this.dgv_alumno.RowHeadersWidth = 51;
            this.dgv_alumno.RowTemplate.Height = 24;
            this.dgv_alumno.Size = new System.Drawing.Size(1178, 503);
            this.dgv_alumno.TabIndex = 5;
            this.dgv_alumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_alumno_CellClick);
            // 
            // panel_busqueda
            // 
            this.panel_busqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_busqueda.Controls.Add(this.btn_registrar_alumno);
            this.panel_busqueda.Controls.Add(this.panel3);
            this.panel_busqueda.Controls.Add(this.txt_alumno);
            this.panel_busqueda.Controls.Add(this.lbl_alumno);
            this.panel_busqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_busqueda.Location = new System.Drawing.Point(0, 0);
            this.panel_busqueda.Name = "panel_busqueda";
            this.panel_busqueda.Size = new System.Drawing.Size(1178, 50);
            this.panel_busqueda.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(516, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 1);
            this.panel3.TabIndex = 17;
            // 
            // txt_alumno
            // 
            this.txt_alumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_alumno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_alumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_alumno.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alumno.Location = new System.Drawing.Point(519, 18);
            this.txt_alumno.Name = "txt_alumno";
            this.txt_alumno.Size = new System.Drawing.Size(318, 21);
            this.txt_alumno.TabIndex = 0;
            this.txt_alumno.TextChanged += new System.EventHandler(this.txt_alumno_TextChanged);
            // 
            // lbl_alumno
            // 
            this.lbl_alumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alumno.AutoSize = true;
            this.lbl_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alumno.Location = new System.Drawing.Point(279, 16);
            this.lbl_alumno.Name = "lbl_alumno";
            this.lbl_alumno.Size = new System.Drawing.Size(220, 23);
            this.lbl_alumno.TabIndex = 15;
            this.lbl_alumno.Text = "Matricula del alumno";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Modificar";
            this.dataGridViewImageColumn1.Image = global::Proyecto_escuela.Properties.Resources.usuario__4_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 117;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Proyecto_escuela.Properties.Resources.usuario__3_;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 118;
            // 
            // btn_registrar_alumno
            // 
            this.btn_registrar_alumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_alumno.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_registrar_alumno.FlatAppearance.BorderSize = 0;
            this.btn_registrar_alumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_registrar_alumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_registrar_alumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_alumno.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_alumno.Image = global::Proyecto_escuela.Properties.Resources.usuario__2_;
            this.btn_registrar_alumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registrar_alumno.Location = new System.Drawing.Point(3, 3);
            this.btn_registrar_alumno.Name = "btn_registrar_alumno";
            this.btn_registrar_alumno.Size = new System.Drawing.Size(246, 41);
            this.btn_registrar_alumno.TabIndex = 18;
            this.btn_registrar_alumno.Text = "Registrar alumno";
            this.btn_registrar_alumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar_alumno.UseVisualStyleBackColor = true;
            this.btn_registrar_alumno.Click += new System.EventHandler(this.btn_registrar_alumno_Click);
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
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.MinimumWidth = 6;
            this.Imagen.Name = "Imagen";
            this.Imagen.Visible = false;
            // 
            // Frm_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 553);
            this.Controls.Add(this.panel_grid);
            this.Controls.Add(this.panel_busqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Alumnos";
            this.Text = "Frm_Alumnos";
            this.Load += new System.EventHandler(this.Frm_Alumnos_Load);
            this.panel_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumno)).EndInit();
            this.panel_busqueda.ResumeLayout(false);
            this.panel_busqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.Panel panel_busqueda;
        private System.Windows.Forms.Button btn_registrar_alumno;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_alumno;
        private System.Windows.Forms.Label lbl_alumno;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        public System.Windows.Forms.DataGridView dgv_alumno;
    }
}