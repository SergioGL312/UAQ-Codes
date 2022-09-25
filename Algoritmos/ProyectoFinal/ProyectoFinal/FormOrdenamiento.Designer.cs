
namespace ProyectoFinal
{
    partial class FormOrdenamiento
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
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.btnInsercion = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.btnQuicksort = new System.Windows.Forms.Button();
            this.btnBurbujaBandera = new System.Windows.Forms.Button();
            this.btnIntercambio = new System.Windows.Forms.Button();
            this.lblAlgoritmosOrd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(360, 214);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(118, 56);
            this.btnSeleccion.TabIndex = 0;
            this.btnSeleccion.Text = "Ordenación por Selección";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // btnInsercion
            // 
            this.btnInsercion.Location = new System.Drawing.Point(146, 214);
            this.btnInsercion.Name = "btnInsercion";
            this.btnInsercion.Size = new System.Drawing.Size(118, 56);
            this.btnInsercion.TabIndex = 1;
            this.btnInsercion.Text = "Ordenamiento por Inserción";
            this.btnInsercion.UseVisualStyleBackColor = true;
            this.btnInsercion.Click += new System.EventHandler(this.btnInsercion_Click);
            // 
            // btnShell
            // 
            this.btnShell.Location = new System.Drawing.Point(560, 214);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(118, 56);
            this.btnShell.TabIndex = 2;
            this.btnShell.Text = "Ordenamiento Shell";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.Location = new System.Drawing.Point(146, 102);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(118, 56);
            this.btnBurbuja.TabIndex = 3;
            this.btnBurbuja.Text = "Ordenamiento por Burbuja";
            this.btnBurbuja.UseVisualStyleBackColor = true;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
            // 
            // btnQuicksort
            // 
            this.btnQuicksort.Location = new System.Drawing.Point(360, 337);
            this.btnQuicksort.Name = "btnQuicksort";
            this.btnQuicksort.Size = new System.Drawing.Size(118, 57);
            this.btnQuicksort.TabIndex = 4;
            this.btnQuicksort.Text = "Ordenamiento Quicksort";
            this.btnQuicksort.UseVisualStyleBackColor = true;
            this.btnQuicksort.Click += new System.EventHandler(this.btnQuicksort_Click);
            // 
            // btnBurbujaBandera
            // 
            this.btnBurbujaBandera.Location = new System.Drawing.Point(360, 102);
            this.btnBurbujaBandera.Name = "btnBurbujaBandera";
            this.btnBurbujaBandera.Size = new System.Drawing.Size(118, 56);
            this.btnBurbujaBandera.TabIndex = 5;
            this.btnBurbujaBandera.Text = "Ordenamiento por Burbuja con Bandera";
            this.btnBurbujaBandera.UseVisualStyleBackColor = true;
            this.btnBurbujaBandera.Click += new System.EventHandler(this.btnBurbujaBandera_Click);
            // 
            // btnIntercambio
            // 
            this.btnIntercambio.Location = new System.Drawing.Point(560, 102);
            this.btnIntercambio.Name = "btnIntercambio";
            this.btnIntercambio.Size = new System.Drawing.Size(118, 56);
            this.btnIntercambio.TabIndex = 6;
            this.btnIntercambio.Text = "Ordenamiento por Intercambio";
            this.btnIntercambio.UseVisualStyleBackColor = true;
            this.btnIntercambio.Click += new System.EventHandler(this.btnIntercambio_Click);
            // 
            // lblAlgoritmosOrd
            // 
            this.lblAlgoritmosOrd.AutoSize = true;
            this.lblAlgoritmosOrd.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlgoritmosOrd.Location = new System.Drawing.Point(315, 9);
            this.lblAlgoritmosOrd.Name = "lblAlgoritmosOrd";
            this.lblAlgoritmosOrd.Size = new System.Drawing.Size(195, 48);
            this.lblAlgoritmosOrd.TabIndex = 7;
            this.lblAlgoritmosOrd.Text = "Algoritmos";
            // 
            // FormOrdenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAlgoritmosOrd);
            this.Controls.Add(this.btnIntercambio);
            this.Controls.Add(this.btnBurbujaBandera);
            this.Controls.Add(this.btnQuicksort);
            this.Controls.Add(this.btnBurbuja);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.btnInsercion);
            this.Controls.Add(this.btnSeleccion);
            this.Name = "FormOrdenamiento";
            this.Text = "Algoritmos de Ordenamiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Button btnInsercion;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button btnQuicksort;
        private System.Windows.Forms.Button btnBurbujaBandera;
        private System.Windows.Forms.Button btnIntercambio;
        private System.Windows.Forms.Label lblAlgoritmosOrd;
    }
}