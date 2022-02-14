
namespace Proyecto_escuela
{
    partial class Frm_main
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
            this.components = new System.ComponentModel.Container();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_barra_titulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pic_fecha = new System.Windows.Forms.PictureBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.pic_hora = new System.Windows.Forms.PictureBox();
            this.panel_barra_izquierda = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_tutores = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_jane = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_menu = new System.Windows.Forms.PictureBox();
            this.btn_cerrar_sesion = new System.Windows.Forms.Button();
            this.btn_salidas = new System.Windows.Forms.Button();
            this.btn_Empleados = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_alumnos = new System.Windows.Forms.Button();
            this.timer_fecha_hora = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_barra_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hora)).BeginInit();
            this.panel_barra_izquierda.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(179, 50);
            this.panel_contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1178, 553);
            this.panel_contenedor.TabIndex = 4;
            // 
            // panel_barra_titulo
            // 
            this.panel_barra_titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_barra_titulo.Controls.Add(this.lbltitulo);
            this.panel_barra_titulo.Controls.Add(this.pic_fecha);
            this.panel_barra_titulo.Controls.Add(this.lbl_fecha);
            this.panel_barra_titulo.Controls.Add(this.lbl_hora);
            this.panel_barra_titulo.Controls.Add(this.pic_hora);
            this.panel_barra_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra_titulo.Location = new System.Drawing.Point(179, 0);
            this.panel_barra_titulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_barra_titulo.Name = "panel_barra_titulo";
            this.panel_barra_titulo.Size = new System.Drawing.Size(1178, 50);
            this.panel_barra_titulo.TabIndex = 2;
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Black;
            this.lbltitulo.Location = new System.Drawing.Point(555, 14);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(59, 23);
            this.lbltitulo.TabIndex = 18;
            this.lbltitulo.Text = "Inicio";
            // 
            // pic_fecha
            // 
            this.pic_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_fecha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_fecha.Image = global::Proyecto_escuela.Properties.Resources.calendario;
            this.pic_fecha.Location = new System.Drawing.Point(992, 5);
            this.pic_fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_fecha.Name = "pic_fecha";
            this.pic_fecha.Size = new System.Drawing.Size(40, 39);
            this.pic_fecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_fecha.TabIndex = 17;
            this.pic_fecha.TabStop = false;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.Black;
            this.lbl_fecha.Location = new System.Drawing.Point(1036, 15);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(62, 21);
            this.lbl_fecha.TabIndex = 16;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.Black;
            this.lbl_hora.Location = new System.Drawing.Point(57, 15);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(50, 21);
            this.lbl_hora.TabIndex = 15;
            this.lbl_hora.Text = "Hora";
            // 
            // pic_hora
            // 
            this.pic_hora.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_hora.Image = global::Proyecto_escuela.Properties.Resources.reloj;
            this.pic_hora.Location = new System.Drawing.Point(13, 6);
            this.pic_hora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_hora.Name = "pic_hora";
            this.pic_hora.Size = new System.Drawing.Size(40, 39);
            this.pic_hora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_hora.TabIndex = 14;
            this.pic_hora.TabStop = false;
            // 
            // panel_barra_izquierda
            // 
            this.panel_barra_izquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_barra_izquierda.Controls.Add(this.tableLayoutPanel1);
            this.panel_barra_izquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_barra_izquierda.Location = new System.Drawing.Point(0, 0);
            this.panel_barra_izquierda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_barra_izquierda.Name = "panel_barra_izquierda";
            this.panel_barra_izquierda.Size = new System.Drawing.Size(179, 603);
            this.panel_barra_izquierda.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_tutores, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cerrar_sesion, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btn_salidas, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_Empleados, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_usuarios, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_alumnos, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.8322F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.83219F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.05577F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.05597F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.05597F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.05597F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.05597F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.05597F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(179, 603);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_tutores
            // 
            this.btn_tutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_tutores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tutores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_tutores.FlatAppearance.BorderSize = 0;
            this.btn_tutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutores.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tutores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_tutores.Image = global::Proyecto_escuela.Properties.Resources.usuario;
            this.btn_tutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutores.Location = new System.Drawing.Point(3, 204);
            this.btn_tutores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tutores.Name = "btn_tutores";
            this.btn_tutores.Size = new System.Drawing.Size(173, 62);
            this.btn_tutores.TabIndex = 2;
            this.btn_tutores.Text = "Tutores";
            this.btn_tutores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tutores.UseVisualStyleBackColor = false;
            this.btn_tutores.Click += new System.EventHandler(this.btn_tutores_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_jane);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 97);
            this.panel2.TabIndex = 0;
            // 
            // lbl_jane
            // 
            this.lbl_jane.AutoSize = true;
            this.lbl_jane.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_jane.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jane.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_jane.Location = new System.Drawing.Point(0, 0);
            this.lbl_jane.Name = "lbl_jane";
            this.lbl_jane.Size = new System.Drawing.Size(167, 25);
            this.lbl_jane.TabIndex = 1;
            this.lbl_jane.Text = "Jane Software";
            this.lbl_jane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 97);
            this.panel1.TabIndex = 0;
            // 
            // pic_menu
            // 
            this.pic_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_menu.Image = global::Proyecto_escuela.Properties.Resources.menu;
            this.pic_menu.Location = new System.Drawing.Point(4, 2);
            this.pic_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_menu.Name = "pic_menu";
            this.pic_menu.Size = new System.Drawing.Size(51, 50);
            this.pic_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_menu.TabIndex = 2;
            this.pic_menu.TabStop = false;
            this.pic_menu.Click += new System.EventHandler(this.pic_menu_Click_1);
            // 
            // btn_cerrar_sesion
            // 
            this.btn_cerrar_sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_cerrar_sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_sesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cerrar_sesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_sesion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_sesion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cerrar_sesion.Image = global::Proyecto_escuela.Properties.Resources.entrar;
            this.btn_cerrar_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar_sesion.Location = new System.Drawing.Point(3, 534);
            this.btn_cerrar_sesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(173, 67);
            this.btn_cerrar_sesion.TabIndex = 8;
            this.btn_cerrar_sesion.Text = "Cerrar sesion";
            this.btn_cerrar_sesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar_sesion.UseVisualStyleBackColor = false;
            this.btn_cerrar_sesion.Click += new System.EventHandler(this.btn_cerrar_sesion_Click);
            // 
            // btn_salidas
            // 
            this.btn_salidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_salidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_salidas.FlatAppearance.BorderSize = 0;
            this.btn_salidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salidas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salidas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_salidas.Image = global::Proyecto_escuela.Properties.Resources.salida;
            this.btn_salidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salidas.Location = new System.Drawing.Point(3, 468);
            this.btn_salidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salidas.Name = "btn_salidas";
            this.btn_salidas.Size = new System.Drawing.Size(173, 62);
            this.btn_salidas.TabIndex = 5;
            this.btn_salidas.Text = "Salidas";
            this.btn_salidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salidas.UseVisualStyleBackColor = false;
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Empleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Empleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Empleados.FlatAppearance.BorderSize = 0;
            this.btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empleados.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Empleados.Image = global::Proyecto_escuela.Properties.Resources.usuario;
            this.btn_Empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empleados.Location = new System.Drawing.Point(3, 402);
            this.btn_Empleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Size = new System.Drawing.Size(173, 62);
            this.btn_Empleados.TabIndex = 4;
            this.btn_Empleados.Text = "Empleados";
            this.btn_Empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Empleados.UseVisualStyleBackColor = false;
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_usuarios.Image = global::Proyecto_escuela.Properties.Resources.usuario;
            this.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.Location = new System.Drawing.Point(3, 336);
            this.btn_usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(173, 62);
            this.btn_usuarios.TabIndex = 3;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_usuarios.UseVisualStyleBackColor = false;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_alumnos
            // 
            this.btn_alumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_alumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_alumnos.FlatAppearance.BorderSize = 0;
            this.btn_alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alumnos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alumnos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_alumnos.Image = global::Proyecto_escuela.Properties.Resources.usuario;
            this.btn_alumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alumnos.Location = new System.Drawing.Point(3, 270);
            this.btn_alumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_alumnos.Name = "btn_alumnos";
            this.btn_alumnos.Size = new System.Drawing.Size(173, 62);
            this.btn_alumnos.TabIndex = 1;
            this.btn_alumnos.Text = "Alumnos";
            this.btn_alumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alumnos.UseVisualStyleBackColor = false;
            this.btn_alumnos.Click += new System.EventHandler(this.btn_alumnos_Click);
            // 
            // timer_fecha_hora
            // 
            this.timer_fecha_hora.Enabled = true;
            this.timer_fecha_hora.Interval = 10;
            this.timer_fecha_hora.Tick += new System.EventHandler(this.timer_fecha_hora_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutoresToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.salidasToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1357, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // tutoresToolStripMenuItem
            // 
            this.tutoresToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutoresToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tutoresToolStripMenuItem.Name = "tutoresToolStripMenuItem";
            this.tutoresToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.tutoresToolStripMenuItem.Text = "Tutores";
            this.tutoresToolStripMenuItem.Click += new System.EventHandler(this.tutoresToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alumnosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidasToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.salidasToolStripMenuItem.Text = "Salidas";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(130, 25);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1357, 603);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_barra_titulo);
            this.Controls.Add(this.panel_barra_izquierda);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_main_FormClosed);
            this.panel_barra_titulo.ResumeLayout(false);
            this.panel_barra_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hora)).EndInit();
            this.panel_barra_izquierda.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Panel panel_barra_titulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox pic_fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.PictureBox pic_hora;
        private System.Windows.Forms.Panel panel_barra_izquierda;
        private System.Windows.Forms.Button btn_cerrar_sesion;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_alumnos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_salidas;
        private System.Windows.Forms.Button btn_Empleados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_jane;
        private System.Windows.Forms.Button btn_tutores;
        private System.Windows.Forms.Timer timer_fecha_hora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}