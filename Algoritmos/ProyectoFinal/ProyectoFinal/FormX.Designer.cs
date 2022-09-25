
namespace ProyectoFinal
{
    partial class FormSeguridad
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
            this.lblGeneradordeContrasenas = new System.Windows.Forms.Label();
            this.lblTamContrasena = new System.Windows.Forms.Label();
            this.lblMostTamContrasena = new System.Windows.Forms.Label();
            this.trkBTam = new System.Windows.Forms.TrackBar();
            this.btnGenerarContra = new System.Windows.Forms.Button();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtBmostContra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkBTam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGeneradordeContrasenas
            // 
            this.lblGeneradordeContrasenas.AutoSize = true;
            this.lblGeneradordeContrasenas.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGeneradordeContrasenas.Location = new System.Drawing.Point(201, 34);
            this.lblGeneradordeContrasenas.Name = "lblGeneradordeContrasenas";
            this.lblGeneradordeContrasenas.Size = new System.Drawing.Size(434, 47);
            this.lblGeneradordeContrasenas.TabIndex = 0;
            this.lblGeneradordeContrasenas.Text = "Generador de Contraseñas";
            // 
            // lblTamContrasena
            // 
            this.lblTamContrasena.AutoSize = true;
            this.lblTamContrasena.Location = new System.Drawing.Point(40, 147);
            this.lblTamContrasena.Name = "lblTamContrasena";
            this.lblTamContrasena.Size = new System.Drawing.Size(49, 15);
            this.lblTamContrasena.TabIndex = 2;
            this.lblTamContrasena.Text = "Tamaño";
            // 
            // lblMostTamContrasena
            // 
            this.lblMostTamContrasena.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostTamContrasena.Location = new System.Drawing.Point(109, 146);
            this.lblMostTamContrasena.Name = "lblMostTamContrasena";
            this.lblMostTamContrasena.Size = new System.Drawing.Size(58, 23);
            this.lblMostTamContrasena.TabIndex = 3;
            // 
            // trkBTam
            // 
            this.trkBTam.Location = new System.Drawing.Point(40, 202);
            this.trkBTam.Maximum = 128;
            this.trkBTam.Minimum = 5;
            this.trkBTam.Name = "trkBTam";
            this.trkBTam.Size = new System.Drawing.Size(580, 45);
            this.trkBTam.TabIndex = 4;
            this.trkBTam.Value = 5;
            this.trkBTam.Scroll += new System.EventHandler(this.trkBTam_Scroll);
            // 
            // btnGenerarContra
            // 
            this.btnGenerarContra.Location = new System.Drawing.Point(320, 283);
            this.btnGenerarContra.Name = "btnGenerarContra";
            this.btnGenerarContra.Size = new System.Drawing.Size(95, 39);
            this.btnGenerarContra.TabIndex = 5;
            this.btnGenerarContra.Text = "Generar Contraseña";
            this.btnGenerarContra.UseVisualStyleBackColor = true;
            this.btnGenerarContra.Click += new System.EventHandler(this.btnGenerarContra_Click);
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(79, 363);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(70, 15);
            this.lblContra.TabIndex = 6;
            this.lblContra.Text = "Contraseña:";
            // 
            // txtBmostContra
            // 
            this.txtBmostContra.Location = new System.Drawing.Point(175, 360);
            this.txtBmostContra.Name = "txtBmostContra";
            this.txtBmostContra.Size = new System.Drawing.Size(468, 23);
            this.txtBmostContra.TabIndex = 7;
            // 
            // FormSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBmostContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.btnGenerarContra);
            this.Controls.Add(this.trkBTam);
            this.Controls.Add(this.lblMostTamContrasena);
            this.Controls.Add(this.lblTamContrasena);
            this.Controls.Add(this.lblGeneradordeContrasenas);
            this.Name = "FormSeguridad";
            this.Text = "Algoritmo de Seguridad";
            this.Load += new System.EventHandler(this.FormSeguridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkBTam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeneradordeContrasenas;
        private System.Windows.Forms.Label lblTamContrasena;
        private System.Windows.Forms.Label lblMostTamContrasena;
        private System.Windows.Forms.TrackBar trkBTam;
        private System.Windows.Forms.Button btnGenerarContra;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtBmostContra;
    }
}