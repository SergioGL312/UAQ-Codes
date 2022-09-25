
namespace ProyectoFinal
{
    partial class FormInsercion
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
            this.lstBoxDatosOrdenadosInser = new System.Windows.Forms.ListBox();
            this.lblInsercion = new System.Windows.Forms.Label();
            this.btnOrdenarInser = new System.Windows.Forms.Button();
            this.lblmostComparacionesInser = new System.Windows.Forms.Label();
            this.lblmostInterInser = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblComparacionesInser = new System.Windows.Forms.Label();
            this.lblIntercambiosInser = new System.Windows.Forms.Label();
            this.cmbCantiDatosInser = new System.Windows.Forms.ComboBox();
            this.lblCantDatosInser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxDatosOrdenadosInser
            // 
            this.lstBoxDatosOrdenadosInser.FormattingEnabled = true;
            this.lstBoxDatosOrdenadosInser.ItemHeight = 15;
            this.lstBoxDatosOrdenadosInser.Items.AddRange(new object[] {
            " "});
            this.lstBoxDatosOrdenadosInser.Location = new System.Drawing.Point(588, 82);
            this.lstBoxDatosOrdenadosInser.Name = "lstBoxDatosOrdenadosInser";
            this.lstBoxDatosOrdenadosInser.Size = new System.Drawing.Size(120, 334);
            this.lstBoxDatosOrdenadosInser.TabIndex = 41;
            // 
            // lblInsercion
            // 
            this.lblInsercion.AutoSize = true;
            this.lblInsercion.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInsercion.Location = new System.Drawing.Point(309, 35);
            this.lblInsercion.Name = "lblInsercion";
            this.lblInsercion.Size = new System.Drawing.Size(170, 50);
            this.lblInsercion.TabIndex = 40;
            this.lblInsercion.Text = "Inserción";
            // 
            // btnOrdenarInser
            // 
            this.btnOrdenarInser.Location = new System.Drawing.Point(324, 128);
            this.btnOrdenarInser.Name = "btnOrdenarInser";
            this.btnOrdenarInser.Size = new System.Drawing.Size(99, 53);
            this.btnOrdenarInser.TabIndex = 39;
            this.btnOrdenarInser.Text = "Ordenar";
            this.btnOrdenarInser.UseVisualStyleBackColor = true;
            this.btnOrdenarInser.Click += new System.EventHandler(this.btnOrdenarInser_Click);
            // 
            // lblmostComparacionesInser
            // 
            this.lblmostComparacionesInser.AutoSize = true;
            this.lblmostComparacionesInser.BackColor = System.Drawing.SystemColors.Control;
            this.lblmostComparacionesInser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostComparacionesInser.Location = new System.Drawing.Point(252, 365);
            this.lblmostComparacionesInser.Name = "lblmostComparacionesInser";
            this.lblmostComparacionesInser.Size = new System.Drawing.Size(29, 17);
            this.lblmostComparacionesInser.TabIndex = 38;
            this.lblmostComparacionesInser.Text = "null";
            // 
            // lblmostInterInser
            // 
            this.lblmostInterInser.AutoSize = true;
            this.lblmostInterInser.BackColor = System.Drawing.SystemColors.Control;
            this.lblmostInterInser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostInterInser.Location = new System.Drawing.Point(252, 289);
            this.lblmostInterInser.Name = "lblmostInterInser";
            this.lblmostInterInser.Size = new System.Drawing.Size(29, 17);
            this.lblmostInterInser.TabIndex = 37;
            this.lblmostInterInser.Text = "null";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(309, 290);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 36;
            // 
            // lblComparacionesInser
            // 
            this.lblComparacionesInser.AutoSize = true;
            this.lblComparacionesInser.Location = new System.Drawing.Point(93, 365);
            this.lblComparacionesInser.Name = "lblComparacionesInser";
            this.lblComparacionesInser.Size = new System.Drawing.Size(90, 15);
            this.lblComparacionesInser.TabIndex = 35;
            this.lblComparacionesInser.Text = "Comparaciones";
            // 
            // lblIntercambiosInser
            // 
            this.lblIntercambiosInser.AutoSize = true;
            this.lblIntercambiosInser.Location = new System.Drawing.Point(93, 290);
            this.lblIntercambiosInser.Name = "lblIntercambiosInser";
            this.lblIntercambiosInser.Size = new System.Drawing.Size(76, 15);
            this.lblIntercambiosInser.TabIndex = 34;
            this.lblIntercambiosInser.Text = "Intercambios";
            // 
            // cmbCantiDatosInser
            // 
            this.cmbCantiDatosInser.FormattingEnabled = true;
            this.cmbCantiDatosInser.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000"});
            this.cmbCantiDatosInser.Location = new System.Drawing.Point(104, 129);
            this.cmbCantiDatosInser.Name = "cmbCantiDatosInser";
            this.cmbCantiDatosInser.Size = new System.Drawing.Size(121, 23);
            this.cmbCantiDatosInser.TabIndex = 33;
            this.cmbCantiDatosInser.Text = "Seleccione";
            this.cmbCantiDatosInser.SelectedIndexChanged += new System.EventHandler(this.cmbCantiDatosInser_SelectedIndexChanged);
            // 
            // lblCantDatosInser
            // 
            this.lblCantDatosInser.AutoSize = true;
            this.lblCantDatosInser.Location = new System.Drawing.Point(104, 82);
            this.lblCantDatosInser.Name = "lblCantDatosInser";
            this.lblCantDatosInser.Size = new System.Drawing.Size(84, 15);
            this.lblCantDatosInser.TabIndex = 32;
            this.lblCantDatosInser.Text = "Cant. de Datos";
            // 
            // FormInsercion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxDatosOrdenadosInser);
            this.Controls.Add(this.lblInsercion);
            this.Controls.Add(this.btnOrdenarInser);
            this.Controls.Add(this.lblmostComparacionesInser);
            this.Controls.Add(this.lblmostInterInser);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblComparacionesInser);
            this.Controls.Add(this.lblIntercambiosInser);
            this.Controls.Add(this.cmbCantiDatosInser);
            this.Controls.Add(this.lblCantDatosInser);
            this.Name = "FormInsercion";
            this.Text = "Algoritmo de Ordenación por Inserción";
            this.Load += new System.EventHandler(this.FormInsercion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxDatosOrdenadosInser;
        private System.Windows.Forms.Label lblInsercion;
        private System.Windows.Forms.Button btnOrdenarInser;
        private System.Windows.Forms.Label lblmostComparacionesInser;
        private System.Windows.Forms.Label lblmostInterInser;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblComparacionesInser;
        private System.Windows.Forms.Label lblIntercambiosInser;
        private System.Windows.Forms.ComboBox cmbCantiDatosInser;
        private System.Windows.Forms.Label lblCantDatosInser;
    }
}