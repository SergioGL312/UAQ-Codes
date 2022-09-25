
namespace ProyectoFinal
{
    partial class FormShell
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
            this.lstBoxDatosOrdenadosShell = new System.Windows.Forms.ListBox();
            this.lblShell = new System.Windows.Forms.Label();
            this.btnOrdenarShell = new System.Windows.Forms.Button();
            this.lblmostComparacionesShell = new System.Windows.Forms.Label();
            this.lblmostInterShell = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblComparacionesShell = new System.Windows.Forms.Label();
            this.lblIntercambiosShell = new System.Windows.Forms.Label();
            this.cmbCantiDatosShell = new System.Windows.Forms.ComboBox();
            this.lblCantDatosShell = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxDatosOrdenadosShell
            // 
            this.lstBoxDatosOrdenadosShell.FormattingEnabled = true;
            this.lstBoxDatosOrdenadosShell.ItemHeight = 15;
            this.lstBoxDatosOrdenadosShell.Items.AddRange(new object[] {
            " "});
            this.lstBoxDatosOrdenadosShell.Location = new System.Drawing.Point(588, 82);
            this.lstBoxDatosOrdenadosShell.Name = "lstBoxDatosOrdenadosShell";
            this.lstBoxDatosOrdenadosShell.Size = new System.Drawing.Size(120, 334);
            this.lstBoxDatosOrdenadosShell.TabIndex = 61;
            // 
            // lblShell
            // 
            this.lblShell.AutoSize = true;
            this.lblShell.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShell.Location = new System.Drawing.Point(309, 35);
            this.lblShell.Name = "lblShell";
            this.lblShell.Size = new System.Drawing.Size(100, 50);
            this.lblShell.TabIndex = 60;
            this.lblShell.Text = "Shell";
            // 
            // btnOrdenarShell
            // 
            this.btnOrdenarShell.Location = new System.Drawing.Point(324, 128);
            this.btnOrdenarShell.Name = "btnOrdenarShell";
            this.btnOrdenarShell.Size = new System.Drawing.Size(99, 53);
            this.btnOrdenarShell.TabIndex = 59;
            this.btnOrdenarShell.Text = "Ordenar";
            this.btnOrdenarShell.UseVisualStyleBackColor = true;
            this.btnOrdenarShell.Click += new System.EventHandler(this.btnOrdenarShell_Click);
            // 
            // lblmostComparacionesShell
            // 
            this.lblmostComparacionesShell.AutoSize = true;
            this.lblmostComparacionesShell.BackColor = System.Drawing.SystemColors.Control;
            this.lblmostComparacionesShell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostComparacionesShell.Location = new System.Drawing.Point(252, 365);
            this.lblmostComparacionesShell.Name = "lblmostComparacionesShell";
            this.lblmostComparacionesShell.Size = new System.Drawing.Size(29, 17);
            this.lblmostComparacionesShell.TabIndex = 58;
            this.lblmostComparacionesShell.Text = "null";
            // 
            // lblmostInterShell
            // 
            this.lblmostInterShell.AutoSize = true;
            this.lblmostInterShell.BackColor = System.Drawing.SystemColors.Control;
            this.lblmostInterShell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostInterShell.Location = new System.Drawing.Point(252, 289);
            this.lblmostInterShell.Name = "lblmostInterShell";
            this.lblmostInterShell.Size = new System.Drawing.Size(29, 17);
            this.lblmostInterShell.TabIndex = 57;
            this.lblmostInterShell.Text = "null";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(309, 290);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 56;
            // 
            // lblComparacionesShell
            // 
            this.lblComparacionesShell.AutoSize = true;
            this.lblComparacionesShell.Location = new System.Drawing.Point(93, 365);
            this.lblComparacionesShell.Name = "lblComparacionesShell";
            this.lblComparacionesShell.Size = new System.Drawing.Size(90, 15);
            this.lblComparacionesShell.TabIndex = 55;
            this.lblComparacionesShell.Text = "Comparaciones";
            // 
            // lblIntercambiosShell
            // 
            this.lblIntercambiosShell.AutoSize = true;
            this.lblIntercambiosShell.Location = new System.Drawing.Point(93, 290);
            this.lblIntercambiosShell.Name = "lblIntercambiosShell";
            this.lblIntercambiosShell.Size = new System.Drawing.Size(76, 15);
            this.lblIntercambiosShell.TabIndex = 54;
            this.lblIntercambiosShell.Text = "Intercambios";
            // 
            // cmbCantiDatosShell
            // 
            this.cmbCantiDatosShell.FormattingEnabled = true;
            this.cmbCantiDatosShell.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000"});
            this.cmbCantiDatosShell.Location = new System.Drawing.Point(104, 129);
            this.cmbCantiDatosShell.Name = "cmbCantiDatosShell";
            this.cmbCantiDatosShell.Size = new System.Drawing.Size(121, 23);
            this.cmbCantiDatosShell.TabIndex = 53;
            this.cmbCantiDatosShell.Text = "Seleccione";
            this.cmbCantiDatosShell.SelectedIndexChanged += new System.EventHandler(this.cmbCantiDatosShell_SelectedIndexChanged);
            // 
            // lblCantDatosShell
            // 
            this.lblCantDatosShell.AutoSize = true;
            this.lblCantDatosShell.Location = new System.Drawing.Point(104, 82);
            this.lblCantDatosShell.Name = "lblCantDatosShell";
            this.lblCantDatosShell.Size = new System.Drawing.Size(84, 15);
            this.lblCantDatosShell.TabIndex = 52;
            this.lblCantDatosShell.Text = "Cant. de Datos";
            // 
            // FormShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxDatosOrdenadosShell);
            this.Controls.Add(this.lblShell);
            this.Controls.Add(this.btnOrdenarShell);
            this.Controls.Add(this.lblmostComparacionesShell);
            this.Controls.Add(this.lblmostInterShell);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblComparacionesShell);
            this.Controls.Add(this.lblIntercambiosShell);
            this.Controls.Add(this.cmbCantiDatosShell);
            this.Controls.Add(this.lblCantDatosShell);
            this.Name = "FormShell";
            this.Text = "Algoritmo de Ordenación Shell";
            this.Load += new System.EventHandler(this.FormShell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxDatosOrdenadosShell;
        private System.Windows.Forms.Label lblShell;
        private System.Windows.Forms.Button btnOrdenarShell;
        private System.Windows.Forms.Label lblmostComparacionesShell;
        private System.Windows.Forms.Label lblmostInterShell;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblComparacionesShell;
        private System.Windows.Forms.Label lblIntercambiosShell;
        private System.Windows.Forms.ComboBox cmbCantiDatosShell;
        private System.Windows.Forms.Label lblCantDatosShell;
    }
}