
namespace Proyecto_escuela.Inicio
{
    partial class Form1
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
            this.panel2 = new Proyecto_escuela.panel.panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.Label();
            this.picturebox1 = new Proyecto_escuela.picturebox.picturebox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Nombre);
            this.panel2.Controls.Add(this.matricula);
            this.panel2.Controls.Add(this.picturebox1);
            this.panel2.Location = new System.Drawing.Point(-88, 65);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 20;
            this.panel2.Size = new System.Drawing.Size(976, 321);
            this.panel2.TabIndex = 22;
            this.panel2.Thickness = 5F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "SALIENDO AHORA";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(315, 145);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(527, 40);
            this.Nombre.TabIndex = 25;
            this.Nombre.Text = "Jaime Alberto Sanchez Martinez";
            // 
            // matricula
            // 
            this.matricula.AutoSize = true;
            this.matricula.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricula.Location = new System.Drawing.Point(315, 94);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(161, 40);
            this.matricula.TabIndex = 24;
            this.matricula.Text = "17340346";
            // 
            // picturebox1
            // 
            this.picturebox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picturebox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.picturebox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.picturebox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picturebox1.BorderSize = 5;
            this.picturebox1.GradientAngle = 50F;
            this.picturebox1.Location = new System.Drawing.Point(3, 4);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(312, 312);
            this.picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox1.TabIndex = 23;
            this.picturebox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private panel.panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label matricula;
        private picturebox.picturebox picturebox1;
    }
}