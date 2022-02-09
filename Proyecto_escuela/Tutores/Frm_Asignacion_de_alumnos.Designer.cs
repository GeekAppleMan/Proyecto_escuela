namespace Proyecto_escuela
{
    partial class Frm_Asignacion_de_alumnos
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
            this.panel_barra = new System.Windows.Forms.Panel();
            this.panel_grid = new System.Windows.Forms.Panel();
            this.btn_asignar_alumno = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_alumno = new System.Windows.Forms.TextBox();
            this.lbl_alumno = new System.Windows.Forms.Label();
            this.dgv_asignacion_alumno = new System.Windows.Forms.DataGridView();
            this.id_tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_barra.SuspendLayout();
            this.panel_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacion_alumno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_barra
            // 
            this.panel_barra.Controls.Add(this.btn_asignar_alumno);
            this.panel_barra.Controls.Add(this.panel3);
            this.panel_barra.Controls.Add(this.txt_alumno);
            this.panel_barra.Controls.Add(this.lbl_alumno);
            this.panel_barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra.Location = new System.Drawing.Point(0, 0);
            this.panel_barra.Name = "panel_barra";
            this.panel_barra.Size = new System.Drawing.Size(962, 57);
            this.panel_barra.TabIndex = 0;
            // 
            // panel_grid
            // 
            this.panel_grid.Controls.Add(this.dgv_asignacion_alumno);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid.Location = new System.Drawing.Point(0, 57);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(962, 494);
            this.panel_grid.TabIndex = 1;
            // 
            // btn_asignar_alumno
            // 
            this.btn_asignar_alumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_asignar_alumno.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_asignar_alumno.FlatAppearance.BorderSize = 0;
            this.btn_asignar_alumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_asignar_alumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_asignar_alumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asignar_alumno.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asignar_alumno.Image = global::Proyecto_escuela.Properties.Resources.usuario__2_;
            this.btn_asignar_alumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_asignar_alumno.Location = new System.Drawing.Point(12, 10);
            this.btn_asignar_alumno.Name = "btn_asignar_alumno";
            this.btn_asignar_alumno.Size = new System.Drawing.Size(246, 41);
            this.btn_asignar_alumno.TabIndex = 22;
            this.btn_asignar_alumno.Text = "Asignar alumno";
            this.btn_asignar_alumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_asignar_alumno.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(525, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 1);
            this.panel3.TabIndex = 21;
            // 
            // txt_alumno
            // 
            this.txt_alumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_alumno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_alumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_alumno.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_alumno.Location = new System.Drawing.Point(528, 20);
            this.txt_alumno.Name = "txt_alumno";
            this.txt_alumno.Size = new System.Drawing.Size(318, 25);
            this.txt_alumno.TabIndex = 19;
            // 
            // lbl_alumno
            // 
            this.lbl_alumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alumno.AutoSize = true;
            this.lbl_alumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alumno.Location = new System.Drawing.Point(285, 23);
            this.lbl_alumno.Name = "lbl_alumno";
            this.lbl_alumno.Size = new System.Drawing.Size(220, 23);
            this.lbl_alumno.TabIndex = 20;
            this.lbl_alumno.Text = "Matricula del alumno";
            // 
            // dgv_asignacion_alumno
            // 
            this.dgv_asignacion_alumno.AllowUserToAddRows = false;
            this.dgv_asignacion_alumno.AllowUserToDeleteRows = false;
            this.dgv_asignacion_alumno.AllowUserToResizeColumns = false;
            this.dgv_asignacion_alumno.AllowUserToResizeRows = false;
            this.dgv_asignacion_alumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_asignacion_alumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_asignacion_alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asignacion_alumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tutor,
            this.id_alumno,
            this.Nombres,
            this.Apellidos,
            this.Modificar,
            this.Eliminar});
            this.dgv_asignacion_alumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_asignacion_alumno.Location = new System.Drawing.Point(0, 0);
            this.dgv_asignacion_alumno.Name = "dgv_asignacion_alumno";
            this.dgv_asignacion_alumno.RowHeadersVisible = false;
            this.dgv_asignacion_alumno.RowHeadersWidth = 51;
            this.dgv_asignacion_alumno.RowTemplate.Height = 24;
            this.dgv_asignacion_alumno.Size = new System.Drawing.Size(962, 494);
            this.dgv_asignacion_alumno.TabIndex = 6;
            // 
            // id_tutor
            // 
            this.id_tutor.HeaderText = "id_tutor";
            this.id_tutor.MinimumWidth = 6;
            this.id_tutor.Name = "id_tutor";
            // 
            // id_alumno
            // 
            this.id_alumno.HeaderText = "id_alumno";
            this.id_alumno.MinimumWidth = 6;
            this.id_alumno.Name = "id_alumno";
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
            // Frm_Asignacion_de_alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(962, 551);
            this.Controls.Add(this.panel_grid);
            this.Controls.Add(this.panel_barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Asignacion_de_alumnos";
            this.Text = "Asignar alumnos";
            this.panel_barra.ResumeLayout(false);
            this.panel_barra.PerformLayout();
            this.panel_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacion_alumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_barra;
        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.Button btn_asignar_alumno;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_alumno;
        private System.Windows.Forms.Label lbl_alumno;
        private System.Windows.Forms.DataGridView dgv_asignacion_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewImageColumn Modificar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}