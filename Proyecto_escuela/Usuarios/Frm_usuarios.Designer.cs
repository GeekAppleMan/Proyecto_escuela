
namespace Proyecto_escuela.Usuarios
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
            this.panel_busqueda = new System.Windows.Forms.Panel();
            this.btn_registrar_usuario = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_tutor = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
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
            this.Modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_busqueda
            // 
            this.panel_busqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_busqueda.Controls.Add(this.btn_registrar_usuario);
            this.panel_busqueda.Controls.Add(this.panel3);
            this.panel_busqueda.Controls.Add(this.txt_tutor);
            this.panel_busqueda.Controls.Add(this.lbl_usuario);
            this.panel_busqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_busqueda.Location = new System.Drawing.Point(0, 0);
            this.panel_busqueda.Name = "panel_busqueda";
            this.panel_busqueda.Size = new System.Drawing.Size(1178, 50);
            this.panel_busqueda.TabIndex = 6;
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
            this.panel3.Location = new System.Drawing.Point(466, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 1);
            this.panel3.TabIndex = 17;
            // 
            // txt_tutor
            // 
            this.txt_tutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tutor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_tutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tutor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tutor.Location = new System.Drawing.Point(469, 18);
            this.txt_tutor.Name = "txt_tutor";
            this.txt_tutor.Size = new System.Drawing.Size(318, 21);
            this.txt_tutor.TabIndex = 0;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(261, 16);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(202, 23);
            this.lbl_usuario.TabIndex = 15;
            this.lbl_usuario.Text = "Nombre del usuario";
            // 
            // dgv_tutor
            // 
            this.dgv_tutor.AllowUserToAddRows = false;
            this.dgv_tutor.AllowUserToDeleteRows = false;
            this.dgv_tutor.AllowUserToResizeColumns = false;
            this.dgv_tutor.AllowUserToResizeRows = false;
            this.dgv_tutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.Modificar,
            this.Eliminar});
            this.dgv_tutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tutor.Location = new System.Drawing.Point(0, 50);
            this.dgv_tutor.Name = "dgv_tutor";
            this.dgv_tutor.RowHeadersVisible = false;
            this.dgv_tutor.RowHeadersWidth = 51;
            this.dgv_tutor.RowTemplate.Height = 24;
            this.dgv_tutor.Size = new System.Drawing.Size(1178, 503);
            this.dgv_tutor.TabIndex = 7;
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
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.HeaderText = "Fecha de nacimiento";
            this.Fecha_nacimiento.MinimumWidth = 6;
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
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
            // 
            // id_tutor
            // 
            this.id_tutor.HeaderText = "id_tutor";
            this.id_tutor.MinimumWidth = 6;
            this.id_tutor.Name = "id_tutor";
            // 
            // imagen
            // 
            this.imagen.HeaderText = "imagen";
            this.imagen.MinimumWidth = 6;
            this.imagen.Name = "imagen";
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
            // Frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 553);
            this.Controls.Add(this.dgv_tutor);
            this.Controls.Add(this.panel_busqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_usuarios";
            this.Text = "Usuarios";
            this.panel_busqueda.ResumeLayout(false);
            this.panel_busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_busqueda;
        private System.Windows.Forms.Button btn_registrar_usuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_tutor;
        private System.Windows.Forms.Label lbl_usuario;
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
        private System.Windows.Forms.DataGridViewImageColumn Modificar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}