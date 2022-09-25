
namespace ProyectoFinal
{
    partial class FormQuicksort
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
            this.lblCantDatosQui = new System.Windows.Forms.Label();
            this.cmbCantiDatosQui = new System.Windows.Forms.ComboBox();
            this.lblIteracionesQui = new System.Windows.Forms.Label();
            this.lblComparacionesQui = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblmostIterQui = new System.Windows.Forms.Label();
            this.btnOrdenarQui = new System.Windows.Forms.Button();
            this.lblQuicksort = new System.Windows.Forms.Label();
            this.lstBoxDatosOrdenadosQui = new System.Windows.Forms.ListBox();
            this.lblmostComparacionesQui = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCantDatosQui
            // 
            this.lblCantDatosQui.AutoSize = true;
            this.lblCantDatosQui.Location = new System.Drawing.Point(60, 74);
            this.lblCantDatosQui.Name = "lblCantDatosQui";
            this.lblCantDatosQui.Size = new System.Drawing.Size(84, 15);
            this.lblCantDatosQui.TabIndex = 0;
            this.lblCantDatosQui.Text = "Cant. de Datos";
            // 
            // cmbCantiDatosQui
            // 
            this.cmbCantiDatosQui.FormattingEnabled = true;
            this.cmbCantiDatosQui.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000",
            "100000"});
            this.cmbCantiDatosQui.Location = new System.Drawing.Point(60, 121);
            this.cmbCantiDatosQui.Name = "cmbCantiDatosQui";
            this.cmbCantiDatosQui.Size = new System.Drawing.Size(121, 23);
            this.cmbCantiDatosQui.TabIndex = 1;
            this.cmbCantiDatosQui.Text = "Seleccione";
            this.cmbCantiDatosQui.SelectedIndexChanged += new System.EventHandler(this.cmbCantiDatosQui_SelectedIndexChanged);
            // 
            // lblIteracionesQui
            // 
            this.lblIteracionesQui.AutoSize = true;
            this.lblIteracionesQui.Location = new System.Drawing.Point(49, 282);
            this.lblIteracionesQui.Name = "lblIteracionesQui";
            this.lblIteracionesQui.Size = new System.Drawing.Size(64, 15);
            this.lblIteracionesQui.TabIndex = 2;
            this.lblIteracionesQui.Text = "Iteraciones";
            // 
            // lblComparacionesQui
            // 
            this.lblComparacionesQui.AutoSize = true;
            this.lblComparacionesQui.Location = new System.Drawing.Point(49, 357);
            this.lblComparacionesQui.Name = "lblComparacionesQui";
            this.lblComparacionesQui.Size = new System.Drawing.Size(90, 15);
            this.lblComparacionesQui.TabIndex = 3;
            this.lblComparacionesQui.Text = "Comparaciones";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(265, 282);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 4;
            // 
            // lblmostIterQui
            // 
            this.lblmostIterQui.AutoSize = true;
            this.lblmostIterQui.BackColor = System.Drawing.SystemColors.Control;
            this.lblmostIterQui.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostIterQui.Location = new System.Drawing.Point(208, 281);
            this.lblmostIterQui.Name = "lblmostIterQui";
            this.lblmostIterQui.Size = new System.Drawing.Size(29, 17);
            this.lblmostIterQui.TabIndex = 5;
            this.lblmostIterQui.Text = "null";
            // 
            // btnOrdenarQui
            // 
            this.btnOrdenarQui.Location = new System.Drawing.Point(280, 120);
            this.btnOrdenarQui.Name = "btnOrdenarQui";
            this.btnOrdenarQui.Size = new System.Drawing.Size(99, 53);
            this.btnOrdenarQui.TabIndex = 7;
            this.btnOrdenarQui.Text = "Ordenar";
            this.btnOrdenarQui.UseVisualStyleBackColor = true;
            this.btnOrdenarQui.Click += new System.EventHandler(this.btnOrdenarQui_Click);
            // 
            // lblQuicksort
            // 
            this.lblQuicksort.AutoSize = true;
            this.lblQuicksort.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuicksort.Location = new System.Drawing.Point(265, 27);
            this.lblQuicksort.Name = "lblQuicksort";
            this.lblQuicksort.Size = new System.Drawing.Size(179, 50);
            this.lblQuicksort.TabIndex = 10;
            this.lblQuicksort.Text = "Quicksort";
            // 
            // lstBoxDatosOrdenadosQui
            // 
            this.lstBoxDatosOrdenadosQui.FormattingEnabled = true;
            this.lstBoxDatosOrdenadosQui.ItemHeight = 15;
            this.lstBoxDatosOrdenadosQui.Items.AddRange(new object[] {
            " "});
            this.lstBoxDatosOrdenadosQui.Location = new System.Drawing.Point(544, 74);
            this.lstBoxDatosOrdenadosQui.Name = "lstBoxDatosOrdenadosQui";
            this.lstBoxDatosOrdenadosQui.Size = new System.Drawing.Size(120, 334);
            this.lstBoxDatosOrdenadosQui.TabIndex = 11;
            // 
            // lblmostComparacionesQui
            // 
            this.lblmostComparacionesQui.AutoSize = true;
            this.lblmostComparacionesQui.BackColor = System.Drawing.SystemColors.Control;
            this.lblmostComparacionesQui.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostComparacionesQui.Location = new System.Drawing.Point(208, 357);
            this.lblmostComparacionesQui.Name = "lblmostComparacionesQui";
            this.lblmostComparacionesQui.Size = new System.Drawing.Size(29, 17);
            this.lblmostComparacionesQui.TabIndex = 12;
            this.lblmostComparacionesQui.Text = "null";
            // 
            // FormQuicksort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmostComparacionesQui);
            this.Controls.Add(this.lstBoxDatosOrdenadosQui);
            this.Controls.Add(this.lblQuicksort);
            this.Controls.Add(this.btnOrdenarQui);
            this.Controls.Add(this.lblmostIterQui);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblComparacionesQui);
            this.Controls.Add(this.lblIteracionesQui);
            this.Controls.Add(this.cmbCantiDatosQui);
            this.Controls.Add(this.lblCantDatosQui);
            this.Name = "FormQuicksort";
            this.Text = "Algoritmo de Ordenación Quicksort";
            this.Load += new System.EventHandler(this.FormQuicksort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantDatosQui;
        private System.Windows.Forms.ComboBox cmbCantiDatosQui;
        private System.Windows.Forms.Label lblIteracionesQui;
        private System.Windows.Forms.Label lblComparacionesQui;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblmostIterQui;
        private System.Windows.Forms.Button btnOrdenarQui;
        private System.Windows.Forms.Label lblQuicksort;
        private System.Windows.Forms.ListBox lstBoxDatosOrdenadosQui;
        private System.Windows.Forms.Label lblmostComparacionesQui;
    }
}