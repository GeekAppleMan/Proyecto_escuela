﻿namespace Proyecto_escuela
{
    partial class Frm_Ajustes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_verde = new System.Windows.Forms.Button();
            this.btn_azul = new System.Windows.Forms.Button();
            this.btn_rojo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_black = new System.Windows.Forms.Button();
            this.btn_white = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdb_arriba = new System.Windows.Forms.RadioButton();
            this.rdb_izquierda = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barra de menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Colores de la barra de menu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btn_verde);
            this.groupBox1.Controls.Add(this.btn_azul);
            this.groupBox1.Controls.Add(this.btn_rojo);
            this.groupBox1.Location = new System.Drawing.Point(16, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 78);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btn_verde
            // 
            this.btn_verde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_verde.FlatAppearance.BorderSize = 0;
            this.btn_verde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verde.Location = new System.Drawing.Point(236, 21);
            this.btn_verde.Name = "btn_verde";
            this.btn_verde.Size = new System.Drawing.Size(75, 41);
            this.btn_verde.TabIndex = 2;
            this.btn_verde.UseVisualStyleBackColor = false;
            this.btn_verde.Click += new System.EventHandler(this.btn_verde_Click);
            // 
            // btn_azul
            // 
            this.btn_azul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_azul.FlatAppearance.BorderSize = 0;
            this.btn_azul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_azul.Location = new System.Drawing.Point(126, 21);
            this.btn_azul.Name = "btn_azul";
            this.btn_azul.Size = new System.Drawing.Size(75, 41);
            this.btn_azul.TabIndex = 1;
            this.btn_azul.UseVisualStyleBackColor = false;
            this.btn_azul.Click += new System.EventHandler(this.btn_azul_Click);
            // 
            // btn_rojo
            // 
            this.btn_rojo.BackColor = System.Drawing.Color.Red;
            this.btn_rojo.FlatAppearance.BorderSize = 0;
            this.btn_rojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rojo.Location = new System.Drawing.Point(16, 21);
            this.btn_rojo.Name = "btn_rojo";
            this.btn_rojo.Size = new System.Drawing.Size(75, 41);
            this.btn_rojo.TabIndex = 0;
            this.btn_rojo.UseVisualStyleBackColor = false;
            this.btn_rojo.Click += new System.EventHandler(this.btn_rojo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btn_red);
            this.groupBox2.Controls.Add(this.btn_black);
            this.groupBox2.Controls.Add(this.btn_white);
            this.groupBox2.Location = new System.Drawing.Point(16, 570);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 78);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.Red;
            this.btn_red.FlatAppearance.BorderSize = 0;
            this.btn_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_red.Location = new System.Drawing.Point(236, 21);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(75, 41);
            this.btn_red.TabIndex = 2;
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_black
            // 
            this.btn_black.BackColor = System.Drawing.Color.Black;
            this.btn_black.FlatAppearance.BorderSize = 0;
            this.btn_black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_black.Location = new System.Drawing.Point(126, 21);
            this.btn_black.Name = "btn_black";
            this.btn_black.Size = new System.Drawing.Size(75, 41);
            this.btn_black.TabIndex = 1;
            this.btn_black.UseVisualStyleBackColor = false;
            this.btn_black.Click += new System.EventHandler(this.btn_black_Click);
            // 
            // btn_white
            // 
            this.btn_white.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_white.FlatAppearance.BorderSize = 0;
            this.btn_white.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_white.Location = new System.Drawing.Point(16, 21);
            this.btn_white.Name = "btn_white";
            this.btn_white.Size = new System.Drawing.Size(75, 41);
            this.btn_white.TabIndex = 0;
            this.btn_white.UseVisualStyleBackColor = false;
            this.btn_white.Click += new System.EventHandler(this.btn_white_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Colores de la fuente del menu";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.rdb_arriba);
            this.groupBox3.Controls.Add(this.rdb_izquierda);
            this.groupBox3.Location = new System.Drawing.Point(16, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(720, 361);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_escuela.Properties.Resources.menu_arriba;
            this.pictureBox2.Location = new System.Drawing.Point(368, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 286);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_escuela.Properties.Resources.menu_izquierda;
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rdb_arriba
            // 
            this.rdb_arriba.AutoSize = true;
            this.rdb_arriba.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_arriba.Location = new System.Drawing.Point(502, 11);
            this.rdb_arriba.Name = "rdb_arriba";
            this.rdb_arriba.Size = new System.Drawing.Size(89, 27);
            this.rdb_arriba.TabIndex = 7;
            this.rdb_arriba.TabStop = true;
            this.rdb_arriba.Text = "Arriba";
            this.rdb_arriba.UseVisualStyleBackColor = true;
            this.rdb_arriba.CheckedChanged += new System.EventHandler(this.rdb_arriba_CheckedChanged);
            // 
            // rdb_izquierda
            // 
            this.rdb_izquierda.AutoSize = true;
            this.rdb_izquierda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_izquierda.Location = new System.Drawing.Point(126, 11);
            this.rdb_izquierda.Name = "rdb_izquierda";
            this.rdb_izquierda.Size = new System.Drawing.Size(121, 27);
            this.rdb_izquierda.TabIndex = 6;
            this.rdb_izquierda.TabStop = true;
            this.rdb_izquierda.Text = "Izquierda";
            this.rdb_izquierda.UseVisualStyleBackColor = true;
            this.rdb_izquierda.CheckedChanged += new System.EventHandler(this.rdb_izquierda_CheckedChanged);
            // 
            // Frm_Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(753, 656);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Ajustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_azul;
        private System.Windows.Forms.Button btn_rojo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_verde;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_black;
        private System.Windows.Forms.Button btn_white;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdb_arriba;
        private System.Windows.Forms.RadioButton rdb_izquierda;
    }
}