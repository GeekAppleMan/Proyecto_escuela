namespace Proyecto_escuela
{
    partial class Frm_Asignacion_de_alumno
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
            this.panel_barra = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.lbl_tutor = new System.Windows.Forms.Label();
            this.panel_grid = new System.Windows.Forms.Panel();
            this.dgv_tutor = new System.Windows.Forms.DataGridView();
            this.id_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_aceptar = new Proyecto_escuela.Boton.RJButton();
            this.btn_cancelar = new Proyecto_escuela.Boton.RJButton();
            this.btn_asignar_alumno = new Proyecto_escuela.Boton.RJButton();
            this.panel_barra.SuspendLayout();
            this.panel_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutor)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_barra
            // 
            this.panel_barra.Controls.Add(this.btn_asignar_alumno);
            this.panel_barra.Controls.Add(this.panel3);
            this.panel_barra.Controls.Add(this.txt_matricula);
            this.panel_barra.Controls.Add(this.lbl_tutor);
            this.panel_barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra.Location = new System.Drawing.Point(0, 0);
            this.panel_barra.Name = "panel_barra";
            this.panel_barra.Size = new System.Drawing.Size(1172, 57);
            this.panel_barra.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(589, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 1);
            this.panel3.TabIndex = 21;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_matricula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_matricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matricula.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_matricula.Location = new System.Drawing.Point(592, 20);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(318, 25);
            this.txt_matricula.TabIndex = 19;
            // 
            // lbl_tutor
            // 
            this.lbl_tutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tutor.AutoSize = true;
            this.lbl_tutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tutor.Location = new System.Drawing.Point(346, 23);
            this.lbl_tutor.Name = "lbl_tutor";
            this.lbl_tutor.Size = new System.Drawing.Size(220, 23);
            this.lbl_tutor.TabIndex = 20;
            this.lbl_tutor.Text = "Matricula del alumno";
            // 
            // panel_grid
            // 
            this.panel_grid.Controls.Add(this.dgv_tutor);
            this.panel_grid.Controls.Add(this.tableLayoutPanel1);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid.Location = new System.Drawing.Point(0, 57);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(1172, 546);
            this.panel_grid.TabIndex = 1;
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
            this.id_alumno,
            this.id_tutor,
            this.Nombres,
            this.Apellidos,
            this.Eliminar});
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
            this.dgv_tutor.Location = new System.Drawing.Point(0, 0);
            this.dgv_tutor.Name = "dgv_tutor";
            this.dgv_tutor.RowHeadersVisible = false;
            this.dgv_tutor.RowHeadersWidth = 51;
            this.dgv_tutor.RowTemplate.Height = 24;
            this.dgv_tutor.Size = new System.Drawing.Size(1172, 495);
            this.dgv_tutor.TabIndex = 6;
            this.dgv_tutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tutor_CellClick);
            // 
            // id_alumno
            // 
            this.id_alumno.HeaderText = "id_alumno";
            this.id_alumno.MinimumWidth = 6;
            this.id_alumno.Name = "id_alumno";
            this.id_alumno.Visible = false;
            // 
            // id_tutor
            // 
            this.id_tutor.HeaderText = "id_tutor";
            this.id_tutor.MinimumWidth = 6;
            this.id_tutor.Name = "id_tutor";
            this.id_tutor.Visible = false;
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
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Proyecto_escuela.Properties.Resources.eliminar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_aceptar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancelar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 495);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1172, 51);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Proyecto_escuela.Properties.Resources.eliminar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 192;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_aceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_aceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_aceptar.BorderRadius = 15;
            this.btn_aceptar.BorderSize = 0;
            this.btn_aceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.Location = new System.Drawing.Point(3, 3);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(580, 45);
            this.btn_aceptar.TabIndex = 91;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextColor = System.Drawing.Color.White;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.BackgroundColor = System.Drawing.Color.Red;
            this.btn_cancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cancelar.BorderRadius = 15;
            this.btn_cancelar.BorderSize = 0;
            this.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(589, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(580, 45);
            this.btn_cancelar.TabIndex = 92;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextColor = System.Drawing.Color.White;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_asignar_alumno
            // 
            this.btn_asignar_alumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_asignar_alumno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_asignar_alumno.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_asignar_alumno.BorderRadius = 15;
            this.btn_asignar_alumno.BorderSize = 0;
            this.btn_asignar_alumno.FlatAppearance.BorderSize = 0;
            this.btn_asignar_alumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asignar_alumno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asignar_alumno.ForeColor = System.Drawing.Color.White;
            this.btn_asignar_alumno.Image = global::Proyecto_escuela.Properties.Resources.usuario__2_;
            this.btn_asignar_alumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_asignar_alumno.Location = new System.Drawing.Point(3, 6);
            this.btn_asignar_alumno.Name = "btn_asignar_alumno";
            this.btn_asignar_alumno.Size = new System.Drawing.Size(242, 45);
            this.btn_asignar_alumno.TabIndex = 92;
            this.btn_asignar_alumno.Text = "Asignar alumno";
            this.btn_asignar_alumno.TextColor = System.Drawing.Color.White;
            this.btn_asignar_alumno.UseVisualStyleBackColor = false;
            this.btn_asignar_alumno.Click += new System.EventHandler(this.btn_asignar_alumno_Click);
            // 
            // Frm_Asignacion_de_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1172, 603);
            this.Controls.Add(this.panel_grid);
            this.Controls.Add(this.panel_barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Asignacion_de_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar alumno";
            this.Load += new System.EventHandler(this.Frm_Asignacion_de_alumno_Load);
            this.panel_barra.ResumeLayout(false);
            this.panel_barra.PerformLayout();
            this.panel_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutor)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_barra;
        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Label lbl_tutor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_tutor;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private Boton.RJButton btn_aceptar;
        private Boton.RJButton btn_asignar_alumno;
        private Boton.RJButton btn_cancelar;
    }
}