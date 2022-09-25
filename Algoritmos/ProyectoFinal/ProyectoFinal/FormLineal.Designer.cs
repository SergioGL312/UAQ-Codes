
namespace ProyectoFinal
{
    partial class FormLineal
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
            this.lblBusqLineal = new System.Windows.Forms.Label();
            this.lblNumBusqLineal = new System.Windows.Forms.Label();
            this.lblPosciLineal = new System.Windows.Forms.Label();
            this.lblMostPosiLineal = new System.Windows.Forms.Label();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lblComparacionesBusqLineal = new System.Windows.Forms.Label();
            this.lblTiempoBusqLineal = new System.Windows.Forms.Label();
            this.lblMostCompsLineal = new System.Windows.Forms.Label();
            this.lblMostTiempoBusqLineal = new System.Windows.Forms.Label();
            this.cmbCantiDatosBusqLineal = new System.Windows.Forms.ComboBox();
            this.lblCantDatosBusqLienal = new System.Windows.Forms.Label();
            this.btnBuscarLineal = new System.Windows.Forms.Button();
            this.txtBoxNumBusqLineal = new System.Windows.Forms.TextBox();
            this.lstBoxBusquedaLineal = new System.Windows.Forms.ListBox();
            this.lblMiliSeconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBusqLineal
            // 
            this.lblBusqLineal.AutoSize = true;
            this.lblBusqLineal.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBusqLineal.Location = new System.Drawing.Point(276, 18);
            this.lblBusqLineal.Name = "lblBusqLineal";
            this.lblBusqLineal.Size = new System.Drawing.Size(271, 47);
            this.lblBusqLineal.TabIndex = 0;
            this.lblBusqLineal.Text = "Búsqueda Lineal";
            // 
            // lblNumBusqLineal
            // 
            this.lblNumBusqLineal.AutoSize = true;
            this.lblNumBusqLineal.Location = new System.Drawing.Point(65, 214);
            this.lblNumBusqLineal.Name = "lblNumBusqLineal";
            this.lblNumBusqLineal.Size = new System.Drawing.Size(98, 15);
            this.lblNumBusqLineal.TabIndex = 1;
            this.lblNumBusqLineal.Text = "Numero a buscar";
            // 
            // lblPosciLineal
            // 
            this.lblPosciLineal.AutoSize = true;
            this.lblPosciLineal.Location = new System.Drawing.Point(65, 280);
            this.lblPosciLineal.Name = "lblPosciLineal";
            this.lblPosciLineal.Size = new System.Drawing.Size(52, 15);
            this.lblPosciLineal.TabIndex = 3;
            this.lblPosciLineal.Text = "Posición";
            // 
            // lblMostPosiLineal
            // 
            this.lblMostPosiLineal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostPosiLineal.Location = new System.Drawing.Point(225, 279);
            this.lblMostPosiLineal.Name = "lblMostPosiLineal";
            this.lblMostPosiLineal.Size = new System.Drawing.Size(100, 23);
            this.lblMostPosiLineal.TabIndex = 4;
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(587, 82);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(56, 15);
            this.lblNumeros.TabIndex = 5;
            this.lblNumeros.Text = "Numeros";
            // 
            // lblComparacionesBusqLineal
            // 
            this.lblComparacionesBusqLineal.AutoSize = true;
            this.lblComparacionesBusqLineal.Location = new System.Drawing.Point(65, 351);
            this.lblComparacionesBusqLineal.Name = "lblComparacionesBusqLineal";
            this.lblComparacionesBusqLineal.Size = new System.Drawing.Size(90, 15);
            this.lblComparacionesBusqLineal.TabIndex = 7;
            this.lblComparacionesBusqLineal.Text = "Comparaciones";
            // 
            // lblTiempoBusqLineal
            // 
            this.lblTiempoBusqLineal.AutoSize = true;
            this.lblTiempoBusqLineal.Location = new System.Drawing.Point(65, 420);
            this.lblTiempoBusqLineal.Name = "lblTiempoBusqLineal";
            this.lblTiempoBusqLineal.Size = new System.Drawing.Size(118, 15);
            this.lblTiempoBusqLineal.TabIndex = 8;
            this.lblTiempoBusqLineal.Text = "Tiempo de busqueda";
            // 
            // lblMostCompsLineal
            // 
            this.lblMostCompsLineal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostCompsLineal.Location = new System.Drawing.Point(225, 350);
            this.lblMostCompsLineal.Name = "lblMostCompsLineal";
            this.lblMostCompsLineal.Size = new System.Drawing.Size(100, 23);
            this.lblMostCompsLineal.TabIndex = 9;
            // 
            // lblMostTiempoBusqLineal
            // 
            this.lblMostTiempoBusqLineal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostTiempoBusqLineal.Location = new System.Drawing.Point(225, 419);
            this.lblMostTiempoBusqLineal.Name = "lblMostTiempoBusqLineal";
            this.lblMostTiempoBusqLineal.Size = new System.Drawing.Size(100, 23);
            this.lblMostTiempoBusqLineal.TabIndex = 10;
            // 
            // cmbCantiDatosBusqLineal
            // 
            this.cmbCantiDatosBusqLineal.FormattingEnabled = true;
            this.cmbCantiDatosBusqLineal.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000"});
            this.cmbCantiDatosBusqLineal.Location = new System.Drawing.Point(65, 135);
            this.cmbCantiDatosBusqLineal.Name = "cmbCantiDatosBusqLineal";
            this.cmbCantiDatosBusqLineal.Size = new System.Drawing.Size(121, 23);
            this.cmbCantiDatosBusqLineal.TabIndex = 15;
            this.cmbCantiDatosBusqLineal.Text = "Seleccione";
            this.cmbCantiDatosBusqLineal.SelectedIndexChanged += new System.EventHandler(this.cmbCantiDatosBusqLineal_SelectedIndexChanged);
            // 
            // lblCantDatosBusqLienal
            // 
            this.lblCantDatosBusqLienal.AutoSize = true;
            this.lblCantDatosBusqLienal.Location = new System.Drawing.Point(65, 88);
            this.lblCantDatosBusqLienal.Name = "lblCantDatosBusqLienal";
            this.lblCantDatosBusqLienal.Size = new System.Drawing.Size(84, 15);
            this.lblCantDatosBusqLienal.TabIndex = 14;
            this.lblCantDatosBusqLienal.Text = "Cant. de Datos";
            // 
            // btnBuscarLineal
            // 
            this.btnBuscarLineal.Location = new System.Drawing.Point(411, 201);
            this.btnBuscarLineal.Name = "btnBuscarLineal";
            this.btnBuscarLineal.Size = new System.Drawing.Size(96, 41);
            this.btnBuscarLineal.TabIndex = 16;
            this.btnBuscarLineal.Text = "Buscar Número";
            this.btnBuscarLineal.UseVisualStyleBackColor = true;
            this.btnBuscarLineal.Click += new System.EventHandler(this.btnBuscarLineal_Click);
            // 
            // txtBoxNumBusqLineal
            // 
            this.txtBoxNumBusqLineal.Location = new System.Drawing.Point(225, 211);
            this.txtBoxNumBusqLineal.Name = "txtBoxNumBusqLineal";
            this.txtBoxNumBusqLineal.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNumBusqLineal.TabIndex = 17;
            this.txtBoxNumBusqLineal.TextChanged += new System.EventHandler(this.txtBoxNumBusqLineal_TextChanged);
            // 
            // lstBoxBusquedaLineal
            // 
            this.lstBoxBusquedaLineal.FormattingEnabled = true;
            this.lstBoxBusquedaLineal.ItemHeight = 15;
            this.lstBoxBusquedaLineal.Items.AddRange(new object[] {
            " "});
            this.lstBoxBusquedaLineal.Location = new System.Drawing.Point(587, 108);
            this.lstBoxBusquedaLineal.Name = "lstBoxBusquedaLineal";
            this.lstBoxBusquedaLineal.Size = new System.Drawing.Size(120, 334);
            this.lstBoxBusquedaLineal.TabIndex = 22;
            // 
            // lblMiliSeconds
            // 
            this.lblMiliSeconds.AutoSize = true;
            this.lblMiliSeconds.Location = new System.Drawing.Point(331, 427);
            this.lblMiliSeconds.Name = "lblMiliSeconds";
            this.lblMiliSeconds.Size = new System.Drawing.Size(23, 15);
            this.lblMiliSeconds.TabIndex = 23;
            this.lblMiliSeconds.Text = "ms";
            // 
            // FormLineal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMiliSeconds);
            this.Controls.Add(this.lstBoxBusquedaLineal);
            this.Controls.Add(this.txtBoxNumBusqLineal);
            this.Controls.Add(this.btnBuscarLineal);
            this.Controls.Add(this.cmbCantiDatosBusqLineal);
            this.Controls.Add(this.lblCantDatosBusqLienal);
            this.Controls.Add(this.lblMostTiempoBusqLineal);
            this.Controls.Add(this.lblMostCompsLineal);
            this.Controls.Add(this.lblTiempoBusqLineal);
            this.Controls.Add(this.lblComparacionesBusqLineal);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.lblMostPosiLineal);
            this.Controls.Add(this.lblPosciLineal);
            this.Controls.Add(this.lblNumBusqLineal);
            this.Controls.Add(this.lblBusqLineal);
            this.Name = "FormLineal";
            this.Text = "Algorimo de Busqueda Lineal";
            this.Load += new System.EventHandler(this.FormLineal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusqLineal;
        private System.Windows.Forms.Label lblNumBusqLineal;
        private System.Windows.Forms.Label lblPosciLineal;
        private System.Windows.Forms.Label lblMostPosiLineal;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Label lblComparacionesBusqLineal;
        private System.Windows.Forms.Label lblTiempoBusqLineal;
        private System.Windows.Forms.Label lblMostCompsLineal;
        private System.Windows.Forms.Label lblMostTiempoBusqLineal;
        private System.Windows.Forms.ComboBox cmbCantiDatosBusqLineal;
        private System.Windows.Forms.Label lblCantDatosBusqLienal;
        private System.Windows.Forms.Button btnBuscarLineal;
        private System.Windows.Forms.TextBox txtBoxNumBusqLineal;
        private System.Windows.Forms.ListBox lstBoxBusquedaLineal;
        private System.Windows.Forms.Label lblMiliSeconds;
    }
}