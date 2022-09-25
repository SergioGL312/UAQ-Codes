
namespace ProyectoFinal
{
    partial class FormOptimizacion
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
            this.lblCantidaddeNodos = new System.Windows.Forms.Label();
            this.txtBCantidaddeNodos = new System.Windows.Forms.TextBox();
            this.btnGenerarLista = new System.Windows.Forms.Button();
            this.btnCalcularRuta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBxMostRutaCritica = new System.Windows.Forms.TextBox();
            this.txtBxMostDuracionTot = new System.Windows.Forms.TextBox();
            this.lblRutaCritica = new System.Windows.Forms.Label();
            this.lblDuracionTot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidaddeNodos
            // 
            this.lblCantidaddeNodos.AutoSize = true;
            this.lblCantidaddeNodos.Location = new System.Drawing.Point(41, 31);
            this.lblCantidaddeNodos.Name = "lblCantidaddeNodos";
            this.lblCantidaddeNodos.Size = new System.Drawing.Size(110, 15);
            this.lblCantidaddeNodos.TabIndex = 0;
            this.lblCantidaddeNodos.Text = "Cantidad de nodos:";
            // 
            // txtBCantidaddeNodos
            // 
            this.txtBCantidaddeNodos.Location = new System.Drawing.Point(177, 31);
            this.txtBCantidaddeNodos.Name = "txtBCantidaddeNodos";
            this.txtBCantidaddeNodos.Size = new System.Drawing.Size(100, 23);
            this.txtBCantidaddeNodos.TabIndex = 1;
            this.txtBCantidaddeNodos.TextChanged += new System.EventHandler(this.txtBCantidaddeNodos_TextChanged);
            // 
            // btnGenerarLista
            // 
            this.btnGenerarLista.Location = new System.Drawing.Point(378, 22);
            this.btnGenerarLista.Name = "btnGenerarLista";
            this.btnGenerarLista.Size = new System.Drawing.Size(99, 42);
            this.btnGenerarLista.TabIndex = 2;
            this.btnGenerarLista.Text = "Generar Lista";
            this.btnGenerarLista.UseVisualStyleBackColor = true;
            this.btnGenerarLista.Click += new System.EventHandler(this.btnGenerarLista_Click);
            // 
            // btnCalcularRuta
            // 
            this.btnCalcularRuta.Location = new System.Drawing.Point(505, 22);
            this.btnCalcularRuta.Name = "btnCalcularRuta";
            this.btnCalcularRuta.Size = new System.Drawing.Size(99, 42);
            this.btnCalcularRuta.TabIndex = 3;
            this.btnCalcularRuta.Text = "Calcular Ruta Critica";
            this.btnCalcularRuta.UseVisualStyleBackColor = true;
            this.btnCalcularRuta.Click += new System.EventHandler(this.btnCalcularRuta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 324);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtBxMostRutaCritica
            // 
            this.txtBxMostRutaCritica.Location = new System.Drawing.Point(560, 133);
            this.txtBxMostRutaCritica.Multiline = true;
            this.txtBxMostRutaCritica.Name = "txtBxMostRutaCritica";
            this.txtBxMostRutaCritica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxMostRutaCritica.Size = new System.Drawing.Size(207, 139);
            this.txtBxMostRutaCritica.TabIndex = 7;
            // 
            // txtBxMostDuracionTot
            // 
            this.txtBxMostDuracionTot.Location = new System.Drawing.Point(607, 315);
            this.txtBxMostDuracionTot.Name = "txtBxMostDuracionTot";
            this.txtBxMostDuracionTot.Size = new System.Drawing.Size(100, 23);
            this.txtBxMostDuracionTot.TabIndex = 6;
            // 
            // lblRutaCritica
            // 
            this.lblRutaCritica.AutoSize = true;
            this.lblRutaCritica.Location = new System.Drawing.Point(560, 97);
            this.lblRutaCritica.Name = "lblRutaCritica";
            this.lblRutaCritica.Size = new System.Drawing.Size(69, 15);
            this.lblRutaCritica.TabIndex = 8;
            this.lblRutaCritica.Text = "Ruta critica:";
            // 
            // lblDuracionTot
            // 
            this.lblDuracionTot.AutoSize = true;
            this.lblDuracionTot.Location = new System.Drawing.Point(607, 294);
            this.lblDuracionTot.Name = "lblDuracionTot";
            this.lblDuracionTot.Size = new System.Drawing.Size(85, 15);
            this.lblDuracionTot.TabIndex = 9;
            this.lblDuracionTot.Text = "Duración total:";
            // 
            // FormOptimizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDuracionTot);
            this.Controls.Add(this.lblRutaCritica);
            this.Controls.Add(this.txtBxMostDuracionTot);
            this.Controls.Add(this.txtBxMostRutaCritica);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCalcularRuta);
            this.Controls.Add(this.btnGenerarLista);
            this.Controls.Add(this.txtBCantidaddeNodos);
            this.Controls.Add(this.lblCantidaddeNodos);
            this.Name = "FormOptimizacion";
            this.Text = "frmOptimizacion";
            this.Load += new System.EventHandler(this.FormOptimizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidaddeNodos;
        private System.Windows.Forms.TextBox txtBCantidaddeNodos;
        private System.Windows.Forms.Button btnGenerarLista;
        private System.Windows.Forms.Button btnCalcularRuta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBxMostRutaCritica;
        private System.Windows.Forms.TextBox txtBxMostDuracionTot;
        private System.Windows.Forms.Label lblRutaCritica;
        private System.Windows.Forms.Label lblDuracionTot;
    }
}