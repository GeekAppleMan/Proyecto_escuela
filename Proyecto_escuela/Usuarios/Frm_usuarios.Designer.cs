
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_busqueda = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.dgv_usuario = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_usuario = new Proyecto_escuela.Textbox.Rjtextbox();
            this.panel_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_busqueda
            // 
            this.panel_busqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_busqueda.Controls.Add(this.txt_usuario);
            this.panel_busqueda.Controls.Add(this.pictureBox1);
            this.panel_busqueda.Controls.Add(this.lbl_usuario);
            this.panel_busqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_busqueda.Location = new System.Drawing.Point(0, 0);
            this.panel_busqueda.Name = "panel_busqueda";
            this.panel_busqueda.Size = new System.Drawing.Size(1178, 50);
            this.panel_busqueda.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Proyecto_escuela.Properties.Resources._1486505375_files_folder_search_magnifying_glass_file_search_magnifier_storage_81440;
            this.pictureBox1.Location = new System.Drawing.Point(819, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(215, 11);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(255, 23);
            this.lbl_usuario.TabIndex = 15;
            this.lbl_usuario.Text = "Matricula del empleado:";
            // 
            // dgv_usuario
            // 
            this.dgv_usuario.AllowUserToAddRows = false;
            this.dgv_usuario.AllowUserToDeleteRows = false;
            this.dgv_usuario.AllowUserToResizeColumns = false;
            this.dgv_usuario.AllowUserToResizeRows = false;
            this.dgv_usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usuario.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_usuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.id_empleado,
            this.Matricula,
            this.Nombres,
            this.Apellidos,
            this.Direccion,
            this.Grupo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_usuario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_usuario.EnableHeadersVisualStyles = false;
            this.dgv_usuario.GridColor = System.Drawing.Color.LightGray;
            this.dgv_usuario.Location = new System.Drawing.Point(0, 50);
            this.dgv_usuario.Name = "dgv_usuario";
            this.dgv_usuario.RowHeadersVisible = false;
            this.dgv_usuario.RowHeadersWidth = 51;
            this.dgv_usuario.RowTemplate.Height = 24;
            this.dgv_usuario.Size = new System.Drawing.Size(1178, 503);
            this.dgv_usuario.TabIndex = 7;
            this.dgv_usuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuario_CellClick);
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "Id_Usuario";
            this.IdUsuario.MinimumWidth = 6;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Visible = false;
            // 
            // id_empleado
            // 
            this.id_empleado.HeaderText = "id_empleado";
            this.id_empleado.MinimumWidth = 6;
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.Visible = false;
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
            // Direccion
            // 
            this.Direccion.HeaderText = "Correo";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Telefono";
            this.Grupo.MinimumWidth = 6;
            this.Grupo.Name = "Grupo";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_usuario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_usuario.BorderColor = System.Drawing.Color.DimGray;
            this.txt_usuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_usuario.BorderRadius = 10;
            this.txt_usuario.BorderSize = 2;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.Location = new System.Drawing.Point(486, 4);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.Multiline = false;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Padding = new System.Windows.Forms.Padding(7);
            this.txt_usuario.PasswordChar = false;
            this.txt_usuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_usuario.PlaceholderText = "Ej. 17340347";
            this.txt_usuario.Size = new System.Drawing.Size(326, 36);
            this.txt_usuario.TabIndex = 27;
            this.txt_usuario.Texts = "";
            this.txt_usuario.UnderlinedStyle = false;
            this.txt_usuario._TextChanged += new System.EventHandler(this.txt_tutor_TextChanged);
            // 
            // Frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 553);
            this.Controls.Add(this.dgv_usuario);
            this.Controls.Add(this.panel_busqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Frm_usuarios_Load);
            this.panel_busqueda.ResumeLayout(false);
            this.panel_busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_busqueda;
        private System.Windows.Forms.Label lbl_usuario;
        public System.Windows.Forms.DataGridView dgv_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Textbox.Rjtextbox txt_usuario;
    }
}