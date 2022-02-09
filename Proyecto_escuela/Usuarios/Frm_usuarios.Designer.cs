namespace Proyecto_escuela
{
    partial class Frm_usuarios
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
            this.panel_grid = new System.Windows.Forms.Panel();
            this.dgv_usuario = new System.Windows.Forms.DataGridView();
            this.id_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_busqueda = new System.Windows.Forms.Panel();
            this.btn_registrar_usuario = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.panel_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).BeginInit();
            this.panel_busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_grid
            // 
            this.panel_grid.Controls.Add(this.dgv_usuario);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid.Location = new System.Drawing.Point(0, 50);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(1193, 528);
            this.panel_grid.TabIndex = 12;
            // 
            // dgv_usuario
            // 
            this.dgv_usuario.AllowUserToAddRows = false;
            this.dgv_usuario.AllowUserToDeleteRows = false;
            this.dgv_usuario.AllowUserToResizeColumns = false;
            this.dgv_usuario.AllowUserToResizeRows = false;
            this.dgv_usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_alumno,
            this.Matricula,
            this.Nombres,
            this.Apellidos,
            this.Fecha_nacimiento,
            this.Direccion,
            this.Grupo,
            this.Estatus,
            this.Imagen,
            this.Modificar,
            this.Eliminar});
            this.dgv_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_usuario.Location = new System.Drawing.Point(0, 0);
            this.dgv_usuario.Name = "dgv_usuario";
            this.dgv_usuario.RowHeadersVisible = false;
            this.dgv_usuario.RowHeadersWidth = 51;
            this.dgv_usuario.RowTemplate.Height = 24;
            this.dgv_usuario.Size = new System.Drawing.Size(1193, 528);
            this.dgv_usuario.TabIndex = 5;
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
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Image = global::Proyecto_escuela.Properties.Resources.usuario__4_;
            this.Modificar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Modificar.MinimumWidth = 6;
            this.Modificar.Name = "Modificar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Proyecto_escuela.Properties.Resources.usuario__3_;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // panel_busqueda
            // 
            this.panel_busqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_busqueda.Controls.Add(this.btn_registrar_usuario);
            this.panel_busqueda.Controls.Add(this.panel3);
            this.panel_busqueda.Controls.Add(this.txt_usuario);
            this.panel_busqueda.Controls.Add(this.lbl_usuario);
            this.panel_busqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_busqueda.Location = new System.Drawing.Point(0, 0);
            this.panel_busqueda.Name = "panel_busqueda";
            this.panel_busqueda.Size = new System.Drawing.Size(1193, 50);
            this.panel_busqueda.TabIndex = 11;
            // 
            // btn_registrar_usuario
            // 
            this.btn_registrar_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_usuario.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_registrar_usuario.FlatAppearance.BorderSize = 0;
            this.btn_registrar_usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_registrar_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_registrar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_usuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_usuario.Image = global::Proyecto_escuela.Properties.Resources.usuario__2_;
            this.btn_registrar_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registrar_usuario.Location = new System.Drawing.Point(3, 3);
            this.btn_registrar_usuario.Name = "btn_registrar_usuario";
            this.btn_registrar_usuario.Size = new System.Drawing.Size(246, 41);
            this.btn_registrar_usuario.TabIndex = 18;
            this.btn_registrar_usuario.Text = "Registrar usuario";
            this.btn_registrar_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar_usuario.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(523, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 1);
            this.panel3.TabIndex = 17;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_usuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(526, 18);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(318, 21);
            this.txt_usuario.TabIndex = 0;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(286, 16);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(202, 23);
            this.lbl_usuario.TabIndex = 15;
            this.lbl_usuario.Text = "Nombre del usuario";
            // 
            // Frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 578);
            this.Controls.Add(this.panel_grid);
            this.Controls.Add(this.panel_busqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_usuarios";
            this.panel_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).EndInit();
            this.panel_busqueda.ResumeLayout(false);
            this.panel_busqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.DataGridView dgv_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewImageColumn Modificar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panel_busqueda;
        private System.Windows.Forms.Button btn_registrar_usuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_usuario;
    }
}