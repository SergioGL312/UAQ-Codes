
namespace ProyectoFinal
{
    partial class FormBurbujaBandera
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
            this.lstBoxDatosOrdenadosBurbBand = new System.Windows.Forms.ListBox();
            this.lblBurbujaBandera = new System.Windows.Forms.Label();
            this.btnOrdenarBurbBand = new System.Windows.Forms.Button();
            this.lblmostComparacionesBurbBand = new System.Windows.Forms.Label();
            this.lblmostInterBurbBand = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblComparacionesBurbBand = new System.Windows.Forms.Label();
            this.lblIntercambiosBurbBand = new System.Windows.Forms.Label();
            this.cmbCantiDatosBurbBand = new System.Windows.Forms.ComboBox();
            this.lblCantDatosBurbBand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxDatosOrdenadosBurbBand
            // 
            this.lstBoxDatosOrdenadosBurbBand.FormattingEnabled = true;
            this.lstBoxDatosOrdenadosBurbBand.ItemHeight = 15;
            this.lstBoxDatosOrdenadosBurbBand.Items.AddRange(new object[] {
            " "});
            this.lstBoxDatosOrdenadosBurbBand.Location = new System.Drawing.Point(588, 82);
            this.lstBoxDatosOrdenadosBurbBand.Name = "lstBoxDatosOrdenadosBurbBand";
            this.lstBoxDatosOrdenadosBurbBand.Size = new System.Drawing.Size(120, 334);
            this.lstBoxDatosOrdenadosBurbBand.TabIndex = 31;
            // 
            // lblBurbujaBandera
            // 
            this.lblBurbujaBandera.AutoSize = true;
            this.lblBurbujaBandera.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBurbujaBandera.Location = new System.Drawing.Point(252, 33);
            this.lblBurbujaBandera.Name = "lblBurbujaBandera";
            this.lblBurbujaBandera.Size = new System.Drawing.Size(292, 50);
            this.lblBurbujaBandera.TabIndex = 30;
            this.lblBurbujaBandera.Text = "Burbuja Bandera";
            // 
            // btnOrdenarBurbBand
            // 
            this.btnOrdenarBurbBand.Location = new System.Drawing.Point(324, 128);
            this.btnOrdenarBurbBand.Name = "btnOrdenarBurbBand";
            this.btnOrdenarBurbBand.Size = new System.Drawing.Size(99, 53);
            this.btnOrdenarBurbBand.TabIndex = 29;
            this.btnOrdenarBurbBand.Text = "Ordenar";
            this.btnOrdenarBurbBand.UseVisualStyleBackColor = true;
            this.btnOrdenarBurbBand.Click += new System.EventHandler(this.btnOrdenarBurbBand_Click);
            // 
            // lblmostComparacionesBurbBand
            // 
            this.lblmostComparacionesBurbBand.AutoSize = true;
            this.lblmostComparacionesBurbBand.BackColor = System.Drawing.SystemColors.Control;
            this.lblmostComparacionesBurbBand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostComparacionesBurbBand.Location = new System.Drawing.Point(252, 365);
            this.lblmostComparacionesBurbBand.Name = "lblmostComparacionesBurbBand";
            this.lblmostComparacionesBurbBand.Size = new System.Drawing.Size(29, 17);
            this.lblmostComparacionesBurbBand.TabIndex = 28;
            this.lblmostComparacionesBurbBand.Text = "null";
            // 
            // lblmostInterBurbBand
            // 
            this.lblmostInterBurbBand.AutoSize = true;
            this.lblmostInterBurbBand.BackColor = System.Drawing.SystemColors.Control;
            this.lblmostInterBurbBand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostInterBurbBand.Location = new System.Drawing.Point(252, 289);
            this.lblmostInterBurbBand.Name = "lblmostInterBurbBand";
            this.lblmostInterBurbBand.Size = new System.Drawing.Size(29, 17);
            this.lblmostInterBurbBand.TabIndex = 27;
            this.lblmostInterBurbBand.Text = "null";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(309, 290);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 26;
            // 
            // lblComparacionesBurbBand
            // 
            this.lblComparacionesBurbBand.AutoSize = true;
            this.lblComparacionesBurbBand.Location = new System.Drawing.Point(93, 365);
            this.lblComparacionesBurbBand.Name = "lblComparacionesBurbBand";
            this.lblComparacionesBurbBand.Size = new System.Drawing.Size(90, 15);
            this.lblComparacionesBurbBand.TabIndex = 25;
            this.lblComparacionesBurbBand.Text = "Comparaciones";
            // 
            // lblIntercambiosBurbBand
            // 
            this.lblIntercambiosBurbBand.AutoSize = true;
            this.lblIntercambiosBurbBand.Location = new System.Drawing.Point(93, 290);
            this.lblIntercambiosBurbBand.Name = "lblIntercambiosBurbBand";
            this.lblIntercambiosBurbBand.Size = new System.Drawing.Size(76, 15);
            this.lblIntercambiosBurbBand.TabIndex = 24;
            this.lblIntercambiosBurbBand.Text = "Intercambios";
            // 
            // cmbCantiDatosBurbBand
            // 
            this.cmbCantiDatosBurbBand.FormattingEnabled = true;
            this.cmbCantiDatosBurbBand.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000"});
            this.cmbCantiDatosBurbBand.Location = new System.Drawing.Point(104, 129);
            this.cmbCantiDatosBurbBand.Name = "cmbCantiDatosBurbBand";
            this.cmbCantiDatosBurbBand.Size = new System.Drawing.Size(121, 23);
            this.cmbCantiDatosBurbBand.TabIndex = 23;
            this.cmbCantiDatosBurbBand.Text = "Seleccione";
            this.cmbCantiDatosBurbBand.SelectedIndexChanged += new System.EventHandler(this.cmbCantiDatosBurbBand_SelectedIndexChanged);
            // 
            // lblCantDatosBurbBand
            // 
            this.lblCantDatosBurbBand.AutoSize = true;
            this.lblCantDatosBurbBand.Location = new System.Drawing.Point(104, 82);
            this.lblCantDatosBurbBand.Name = "lblCantDatosBurbBand";
            this.lblCantDatosBurbBand.Size = new System.Drawing.Size(84, 15);
            this.lblCantDatosBurbBand.TabIndex = 22;
            this.lblCantDatosBurbBand.Text = "Cant. de Datos";
            // 
            // FormBurbujaBandera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxDatosOrdenadosBurbBand);
            this.Controls.Add(this.lblBurbujaBandera);
            this.Controls.Add(this.btnOrdenarBurbBand);
            this.Controls.Add(this.lblmostComparacionesBurbBand);
            this.Controls.Add(this.lblmostInterBurbBand);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblComparacionesBurbBand);
            this.Controls.Add(this.lblIntercambiosBurbBand);
            this.Controls.Add(this.cmbCantiDatosBurbBand);
            this.Controls.Add(this.lblCantDatosBurbBand);
            this.Name = "FormBurbujaBandera";
            this.Text = "Algoritmo de Ordenación por Burbuja con Bandera";
            this.Load += new System.EventHandler(this.FormBurbujaBandera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxDatosOrdenadosBurbBand;
        private System.Windows.Forms.Label lblBurbujaBandera;
        private System.Windows.Forms.Button btnOrdenarBurbBand;
        private System.Windows.Forms.Label lblmostComparacionesBurbBand;
        private System.Windows.Forms.Label lblmostInterBurbBand;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblComparacionesBurbBand;
        private System.Windows.Forms.Label lblIntercambiosBurbBand;
        private System.Windows.Forms.ComboBox cmbCantiDatosBurbBand;
        private System.Windows.Forms.Label lblCantDatosBurbBand;
    }
}