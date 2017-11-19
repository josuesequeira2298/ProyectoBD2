namespace Presentacion
{
    partial class Inserciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcolumna01 = new System.Windows.Forms.ComboBox();
            this.txtdato01 = new System.Windows.Forms.TextBox();
            this.cmbfila01 = new System.Windows.Forms.ComboBox();
            this.btninsert01 = new System.Windows.Forms.Button();
            this.dtgtabla = new System.Windows.Forms.DataGridView();
            this.cmbtablas = new System.Windows.Forms.ComboBox();
            this.btnllamar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Columna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contenido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fila";
            // 
            // cmbcolumna01
            // 
            this.cmbcolumna01.FormattingEnabled = true;
            this.cmbcolumna01.Location = new System.Drawing.Point(41, 29);
            this.cmbcolumna01.Name = "cmbcolumna01";
            this.cmbcolumna01.Size = new System.Drawing.Size(121, 21);
            this.cmbcolumna01.TabIndex = 5;
            // 
            // txtdato01
            // 
            this.txtdato01.Location = new System.Drawing.Point(168, 29);
            this.txtdato01.Name = "txtdato01";
            this.txtdato01.Size = new System.Drawing.Size(100, 20);
            this.txtdato01.TabIndex = 6;
            // 
            // cmbfila01
            // 
            this.cmbfila01.FormattingEnabled = true;
            this.cmbfila01.Location = new System.Drawing.Point(12, 29);
            this.cmbfila01.Name = "cmbfila01";
            this.cmbfila01.Size = new System.Drawing.Size(23, 21);
            this.cmbfila01.TabIndex = 4;
            // 
            // btninsert01
            // 
            this.btninsert01.Location = new System.Drawing.Point(274, 27);
            this.btninsert01.Name = "btninsert01";
            this.btninsert01.Size = new System.Drawing.Size(75, 23);
            this.btninsert01.TabIndex = 7;
            this.btninsert01.Text = "Insertar";
            this.btninsert01.UseVisualStyleBackColor = true;
            this.btninsert01.Click += new System.EventHandler(this.btninsert01_Click);
            // 
            // dtgtabla
            // 
            this.dtgtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtabla.Location = new System.Drawing.Point(355, 29);
            this.dtgtabla.Name = "dtgtabla";
            this.dtgtabla.Size = new System.Drawing.Size(252, 150);
            this.dtgtabla.TabIndex = 8;
            // 
            // cmbtablas
            // 
            this.cmbtablas.FormattingEnabled = true;
            this.cmbtablas.Location = new System.Drawing.Point(355, 185);
            this.cmbtablas.Name = "cmbtablas";
            this.cmbtablas.Size = new System.Drawing.Size(121, 21);
            this.cmbtablas.TabIndex = 9;
            // 
            // btnllamar
            // 
            this.btnllamar.Location = new System.Drawing.Point(522, 185);
            this.btnllamar.Name = "btnllamar";
            this.btnllamar.Size = new System.Drawing.Size(85, 23);
            this.btnllamar.TabIndex = 10;
            this.btnllamar.Text = "Llamar Tabla";
            this.btnllamar.UseVisualStyleBackColor = true;
            this.btnllamar.Click += new System.EventHandler(this.btnllamar_Click);
            // 
            // Inserciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 226);
            this.Controls.Add(this.btnllamar);
            this.Controls.Add(this.cmbtablas);
            this.Controls.Add(this.dtgtabla);
            this.Controls.Add(this.btninsert01);
            this.Controls.Add(this.txtdato01);
            this.Controls.Add(this.cmbcolumna01);
            this.Controls.Add(this.cmbfila01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inserciones";
            this.Text = "Inserciones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgtabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcolumna01;
        private System.Windows.Forms.TextBox txtdato01;
        private System.Windows.Forms.ComboBox cmbfila01;
        private System.Windows.Forms.Button btninsert01;
        private System.Windows.Forms.DataGridView dtgtabla;
        private System.Windows.Forms.ComboBox cmbtablas;
        private System.Windows.Forms.Button btnllamar;
    }
}