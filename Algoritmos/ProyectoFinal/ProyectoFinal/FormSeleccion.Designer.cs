
namespace ProyectoFinal
{
    partial class FormSeleccion
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
            this.lstBoxDatosOrdenadosSelec = new System.Windows.Forms.ListBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.btnOrdenarSelec = new System.Windows.Forms.Button();
            this.lblmostComparacionesSelec = new System.Windows.Forms.Label();
            this.lblmostInterSelec = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblComparacionesSelec = new System.Windows.Forms.Label();
            this.lblIntercambiosSelec = new System.Windows.Forms.Label();
            this.cmbCantiDatosSelec = new System.Windows.Forms.ComboBox();
            this.lblCantDatosSelec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxDatosOrdenadosSelec
            // 
            this.lstBoxDatosOrdenadosSelec.FormattingEnabled = true;
            this.lstBoxDatosOrdenadosSelec.ItemHeight = 15;
            this.lstBoxDatosOrdenadosSelec.Items.AddRange(new object[] {
            " "});
            this.lstBoxDatosOrdenadosSelec.Location = new System.Drawing.Point(588, 82);
            this.lstBoxDatosOrdenadosSelec.Name = "lstBoxDatosOrdenadosSelec";
            this.lstBoxDatosOrdenadosSelec.Size = new System.Drawing.Size(120, 334);
            this.lstBoxDatosOrdenadosSelec.TabIndex = 51;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccion.Location = new System.Drawing.Point(309, 35);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(175, 50);
            this.lblSeleccion.TabIndex = 50;
            this.lblSeleccion.Text = "Selección";
            // 
            // btnOrdenarSelec
            // 
            this.btnOrdenarSelec.Location = new System.Drawing.Point(324, 128);
            this.btnOrdenarSelec.Name = "btnOrdenarSelec";
            this.btnOrdenarSelec.Size = new System.Drawing.Size(99, 53);
            this.btnOrdenarSelec.TabIndex = 49;
            this.btnOrdenarSelec.Text = "Ordenar";
            this.btnOrdenarSelec.UseVisualStyleBackColor = true;
            this.btnOrdenarSelec.Click += new System.EventHandler(this.btnOrdenarSelec_Click);
            // 
            // lblmostComparacionesSelec
            // 
            this.lblmostComparacionesSelec.AutoSize = true;
            this.lblmostComparacionesSelec.BackColor = System.Drawing.SystemColors.Control;
            this.lblmostComparacionesSelec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostComparacionesSelec.Location = new System.Drawing.Point(252, 365);
            this.lblmostComparacionesSelec.Name = "lblmostComparacionesSelec";
            this.lblmostComparacionesSelec.Size = new System.Drawing.Size(29, 17);
            this.lblmostComparacionesSelec.TabIndex = 48;
            this.lblmostComparacionesSelec.Text = "null";
            // 
            // lblmostInterSelec
            // 
            this.lblmostInterSelec.AutoSize = true;
            this.lblmostInterSelec.BackColor = System.Drawing.SystemColors.Control;
            this.lblmostInterSelec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostInterSelec.Location = new System.Drawing.Point(252, 289);
            this.lblmostInterSelec.Name = "lblmostInterSelec";
            this.lblmostInterSelec.Size = new System.Drawing.Size(29, 17);
            this.lblmostInterSelec.TabIndex = 47;
            this.lblmostInterSelec.Text = "null";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(309, 290);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 46;
            // 
            // lblComparacionesSelec
            // 
            this.lblComparacionesSelec.AutoSize = true;
            this.lblComparacionesSelec.Location = new System.Drawing.Point(93, 365);
            this.lblComparacionesSelec.Name = "lblComparacionesSelec";
            this.lblComparacionesSelec.Size = new System.Drawing.Size(90, 15);
            this.lblComparacionesSelec.TabIndex = 45;
            this.lblComparacionesSelec.Text = "Comparaciones";
            // 
            // lblIntercambiosSelec
            // 
            this.lblIntercambiosSelec.AutoSize = true;
            this.lblIntercambiosSelec.Location = new System.Drawing.Point(93, 290);
            this.lblIntercambiosSelec.Name = "lblIntercambiosSelec";
            this.lblIntercambiosSelec.Size = new System.Drawing.Size(76, 15);
            this.lblIntercambiosSelec.TabIndex = 44;
            this.lblIntercambiosSelec.Text = "Intercambios";
            // 
            // cmbCantiDatosSelec
            // 
            this.cmbCantiDatosSelec.FormattingEnabled = true;
            this.cmbCantiDatosSelec.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000"});
            this.cmbCantiDatosSelec.Location = new System.Drawing.Point(104, 129);
            this.cmbCantiDatosSelec.Name = "cmbCantiDatosSelec";
            this.cmbCantiDatosSelec.Size = new System.Drawing.Size(121, 23);
            this.cmbCantiDatosSelec.TabIndex = 43;
            this.cmbCantiDatosSelec.Text = "Seleccione";
            this.cmbCantiDatosSelec.SelectedIndexChanged += new System.EventHandler(this.cmbCantiDatosSelec_SelectedIndexChanged);
            // 
            // lblCantDatosSelec
            // 
            this.lblCantDatosSelec.AutoSize = true;
            this.lblCantDatosSelec.Location = new System.Drawing.Point(104, 82);
            this.lblCantDatosSelec.Name = "lblCantDatosSelec";
            this.lblCantDatosSelec.Size = new System.Drawing.Size(84, 15);
            this.lblCantDatosSelec.TabIndex = 42;
            this.lblCantDatosSelec.Text = "Cant. de Datos";
            // 
            // FormSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxDatosOrdenadosSelec);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.btnOrdenarSelec);
            this.Controls.Add(this.lblmostComparacionesSelec);
            this.Controls.Add(this.lblmostInterSelec);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblComparacionesSelec);
            this.Controls.Add(this.lblIntercambiosSelec);
            this.Controls.Add(this.cmbCantiDatosSelec);
            this.Controls.Add(this.lblCantDatosSelec);
            this.Name = "FormSeleccion";
            this.Text = "Algoritmo de Ordenación por Selección";
            this.Load += new System.EventHandler(this.FormSeleccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxDatosOrdenadosSelec;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button btnOrdenarSelec;
        private System.Windows.Forms.Label lblmostComparacionesSelec;
        private System.Windows.Forms.Label lblmostInterSelec;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblComparacionesSelec;
        private System.Windows.Forms.Label lblIntercambiosSelec;
        private System.Windows.Forms.ComboBox cmbCantiDatosSelec;
        private System.Windows.Forms.Label lblCantDatosSelec;
    }
}