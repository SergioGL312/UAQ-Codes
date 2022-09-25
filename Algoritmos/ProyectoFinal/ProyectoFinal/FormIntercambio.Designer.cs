
namespace ProyectoFinal
{
    partial class FormIntercambio
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
            this.lstBoxDatosOrdenadosInter = new System.Windows.Forms.ListBox();
            this.lblIntercambio = new System.Windows.Forms.Label();
            this.btnOrdenarInter = new System.Windows.Forms.Button();
            this.lblmostComparacionesInter = new System.Windows.Forms.Label();
            this.lblmostInterInter = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblComparacionesInter = new System.Windows.Forms.Label();
            this.lblIntercambiosInter = new System.Windows.Forms.Label();
            this.cmbCantiDatosInter = new System.Windows.Forms.ComboBox();
            this.lblCantDatosInter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxDatosOrdenadosInter
            // 
            this.lstBoxDatosOrdenadosInter.FormattingEnabled = true;
            this.lstBoxDatosOrdenadosInter.ItemHeight = 15;
            this.lstBoxDatosOrdenadosInter.Items.AddRange(new object[] {
            " "});
            this.lstBoxDatosOrdenadosInter.Location = new System.Drawing.Point(588, 82);
            this.lstBoxDatosOrdenadosInter.Name = "lstBoxDatosOrdenadosInter";
            this.lstBoxDatosOrdenadosInter.Size = new System.Drawing.Size(120, 334);
            this.lstBoxDatosOrdenadosInter.TabIndex = 31;
            // 
            // lblIntercambio
            // 
            this.lblIntercambio.AutoSize = true;
            this.lblIntercambio.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIntercambio.Location = new System.Drawing.Point(309, 35);
            this.lblIntercambio.Name = "lblIntercambio";
            this.lblIntercambio.Size = new System.Drawing.Size(219, 50);
            this.lblIntercambio.TabIndex = 30;
            this.lblIntercambio.Text = "Intercambio";
            // 
            // btnOrdenarInter
            // 
            this.btnOrdenarInter.Location = new System.Drawing.Point(324, 128);
            this.btnOrdenarInter.Name = "btnOrdenarInter";
            this.btnOrdenarInter.Size = new System.Drawing.Size(99, 53);
            this.btnOrdenarInter.TabIndex = 29;
            this.btnOrdenarInter.Text = "Ordenar";
            this.btnOrdenarInter.UseVisualStyleBackColor = true;
            this.btnOrdenarInter.Click += new System.EventHandler(this.btnOrdenarInter_Click);
            // 
            // lblmostComparacionesInter
            // 
            this.lblmostComparacionesInter.AutoSize = true;
            this.lblmostComparacionesInter.BackColor = System.Drawing.SystemColors.Control;
            this.lblmostComparacionesInter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostComparacionesInter.Location = new System.Drawing.Point(252, 365);
            this.lblmostComparacionesInter.Name = "lblmostComparacionesInter";
            this.lblmostComparacionesInter.Size = new System.Drawing.Size(29, 17);
            this.lblmostComparacionesInter.TabIndex = 28;
            this.lblmostComparacionesInter.Text = "null";
            // 
            // lblmostInterInter
            // 
            this.lblmostInterInter.AutoSize = true;
            this.lblmostInterInter.BackColor = System.Drawing.SystemColors.Control;
            this.lblmostInterInter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostInterInter.Location = new System.Drawing.Point(252, 289);
            this.lblmostInterInter.Name = "lblmostInterInter";
            this.lblmostInterInter.Size = new System.Drawing.Size(29, 17);
            this.lblmostInterInter.TabIndex = 27;
            this.lblmostInterInter.Text = "null";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(309, 290);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 26;
            // 
            // lblComparacionesInter
            // 
            this.lblComparacionesInter.AutoSize = true;
            this.lblComparacionesInter.Location = new System.Drawing.Point(93, 365);
            this.lblComparacionesInter.Name = "lblComparacionesInter";
            this.lblComparacionesInter.Size = new System.Drawing.Size(90, 15);
            this.lblComparacionesInter.TabIndex = 25;
            this.lblComparacionesInter.Text = "Comparaciones";
            // 
            // lblIntercambiosInter
            // 
            this.lblIntercambiosInter.AutoSize = true;
            this.lblIntercambiosInter.Location = new System.Drawing.Point(93, 290);
            this.lblIntercambiosInter.Name = "lblIntercambiosInter";
            this.lblIntercambiosInter.Size = new System.Drawing.Size(76, 15);
            this.lblIntercambiosInter.TabIndex = 24;
            this.lblIntercambiosInter.Text = "Intercambios";
            // 
            // cmbCantiDatosInter
            // 
            this.cmbCantiDatosInter.FormattingEnabled = true;
            this.cmbCantiDatosInter.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000"});
            this.cmbCantiDatosInter.Location = new System.Drawing.Point(104, 129);
            this.cmbCantiDatosInter.Name = "cmbCantiDatosInter";
            this.cmbCantiDatosInter.Size = new System.Drawing.Size(121, 23);
            this.cmbCantiDatosInter.TabIndex = 23;
            this.cmbCantiDatosInter.Text = "Seleccione";
            this.cmbCantiDatosInter.SelectedIndexChanged += new System.EventHandler(this.cmbCantiDatosInter_SelectedIndexChanged);
            // 
            // lblCantDatosInter
            // 
            this.lblCantDatosInter.AutoSize = true;
            this.lblCantDatosInter.Location = new System.Drawing.Point(104, 82);
            this.lblCantDatosInter.Name = "lblCantDatosInter";
            this.lblCantDatosInter.Size = new System.Drawing.Size(84, 15);
            this.lblCantDatosInter.TabIndex = 22;
            this.lblCantDatosInter.Text = "Cant. de Datos";
            // 
            // FormIntercambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxDatosOrdenadosInter);
            this.Controls.Add(this.lblIntercambio);
            this.Controls.Add(this.btnOrdenarInter);
            this.Controls.Add(this.lblmostComparacionesInter);
            this.Controls.Add(this.lblmostInterInter);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblComparacionesInter);
            this.Controls.Add(this.lblIntercambiosInter);
            this.Controls.Add(this.cmbCantiDatosInter);
            this.Controls.Add(this.lblCantDatosInter);
            this.Name = "FormIntercambio";
            this.Text = "Algoritmo de Ordenación por Intercambio";
            this.Load += new System.EventHandler(this.FormIntercambio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxDatosOrdenadosInter;
        private System.Windows.Forms.Label lblIntercambio;
        private System.Windows.Forms.Button btnOrdenarInter;
        private System.Windows.Forms.Label lblmostComparacionesInter;
        private System.Windows.Forms.Label lblmostInterInter;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblComparacionesInter;
        private System.Windows.Forms.Label lblIntercambiosInter;
        private System.Windows.Forms.ComboBox cmbCantiDatosInter;
        private System.Windows.Forms.Label lblCantDatosInter;
    }
}