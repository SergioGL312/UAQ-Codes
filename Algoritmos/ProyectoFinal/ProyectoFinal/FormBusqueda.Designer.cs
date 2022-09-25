
namespace ProyectoFinal
{
    partial class FormBusqueda
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
            this.btnLineal = new System.Windows.Forms.Button();
            this.btnBinaria = new System.Windows.Forms.Button();
            this.lblAlgoritmosBusq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLineal
            // 
            this.btnLineal.Location = new System.Drawing.Point(172, 145);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(99, 52);
            this.btnLineal.TabIndex = 0;
            this.btnLineal.Text = "Busqueda Lineal";
            this.btnLineal.UseVisualStyleBackColor = true;
            this.btnLineal.Click += new System.EventHandler(this.btnLineal_Click);
            // 
            // btnBinaria
            // 
            this.btnBinaria.Location = new System.Drawing.Point(569, 145);
            this.btnBinaria.Name = "btnBinaria";
            this.btnBinaria.Size = new System.Drawing.Size(99, 52);
            this.btnBinaria.TabIndex = 1;
            this.btnBinaria.Text = "Busqueda Binaria";
            this.btnBinaria.UseVisualStyleBackColor = true;
            this.btnBinaria.Click += new System.EventHandler(this.btnBinaria_Click);
            // 
            // lblAlgoritmosBusq
            // 
            this.lblAlgoritmosBusq.AutoSize = true;
            this.lblAlgoritmosBusq.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlgoritmosBusq.Location = new System.Drawing.Point(329, 34);
            this.lblAlgoritmosBusq.Name = "lblAlgoritmosBusq";
            this.lblAlgoritmosBusq.Size = new System.Drawing.Size(191, 47);
            this.lblAlgoritmosBusq.TabIndex = 2;
            this.lblAlgoritmosBusq.Text = "Algoritmos";
            // 
            // FormBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAlgoritmosBusq);
            this.Controls.Add(this.btnBinaria);
            this.Controls.Add(this.btnLineal);
            this.Name = "FormBusqueda";
            this.Text = "Algoritmos de Busqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLineal;
        private System.Windows.Forms.Button btnBinaria;
        private System.Windows.Forms.Label lblAlgoritmosBusq;
    }
}