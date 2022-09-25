
namespace ProyectoFinal
{
    partial class frmAlgoritmos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAlgoritmos = new System.Windows.Forms.Label();
            this.btnOrdenacion = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnOptimizacion = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlgoritmos
            // 
            this.lblAlgoritmos.AutoSize = true;
            this.lblAlgoritmos.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlgoritmos.Location = new System.Drawing.Point(297, 31);
            this.lblAlgoritmos.Name = "lblAlgoritmos";
            this.lblAlgoritmos.Size = new System.Drawing.Size(204, 50);
            this.lblAlgoritmos.TabIndex = 0;
            this.lblAlgoritmos.Text = "Algoritmos";
            // 
            // btnOrdenacion
            // 
            this.btnOrdenacion.Location = new System.Drawing.Point(137, 134);
            this.btnOrdenacion.Name = "btnOrdenacion";
            this.btnOrdenacion.Size = new System.Drawing.Size(183, 63);
            this.btnOrdenacion.TabIndex = 1;
            this.btnOrdenacion.Text = "Algoritmo de Ordenación";
            this.btnOrdenacion.UseVisualStyleBackColor = true;
            this.btnOrdenacion.Click += new System.EventHandler(this.btnOrdenacion_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(515, 134);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(183, 63);
            this.btnBusqueda.TabIndex = 2;
            this.btnBusqueda.Text = "Algoritmo de Busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnOptimizacion
            // 
            this.btnOptimizacion.Location = new System.Drawing.Point(137, 284);
            this.btnOptimizacion.Name = "btnOptimizacion";
            this.btnOptimizacion.Size = new System.Drawing.Size(183, 63);
            this.btnOptimizacion.TabIndex = 3;
            this.btnOptimizacion.Text = "Algoritmo de Optimización";
            this.btnOptimizacion.UseVisualStyleBackColor = true;
            this.btnOptimizacion.Click += new System.EventHandler(this.btnOptimizacion_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(515, 274);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(183, 63);
            this.btnX.TabIndex = 4;
            this.btnX.Text = "Algoritmo de Seguridad";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // frmAlgoritmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnOptimizacion);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnOrdenacion);
            this.Controls.Add(this.lblAlgoritmos);
            this.Name = "frmAlgoritmos";
            this.Text = "Algoritmos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlgoritmos;
        private System.Windows.Forms.Button btnOrdenacion;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnOptimizacion;
        private System.Windows.Forms.Button btnX;
    }
}

