namespace Presentacion
{
    partial class SelectDosTablas
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
            this.cbotabla1 = new System.Windows.Forms.ComboBox();
            this.cbocolumna2 = new System.Windows.Forms.ComboBox();
            this.dtselecttablas = new System.Windows.Forms.DataGridView();
            this.cbocolumna1 = new System.Windows.Forms.ComboBox();
            this.cbotabla2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbtimestar = new System.Windows.Forms.Label();
            this.lbtimestop = new System.Windows.Forms.Label();
            this.lbdiferencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtselecttablas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbotabla1
            // 
            this.cbotabla1.FormattingEnabled = true;
            this.cbotabla1.Location = new System.Drawing.Point(37, 28);
            this.cbotabla1.Name = "cbotabla1";
            this.cbotabla1.Size = new System.Drawing.Size(121, 21);
            this.cbotabla1.TabIndex = 0;
            this.cbotabla1.Click += new System.EventHandler(this.cbotabla1_Click);
            // 
            // cbocolumna2
            // 
            this.cbocolumna2.FormattingEnabled = true;
            this.cbocolumna2.Location = new System.Drawing.Point(700, 123);
            this.cbocolumna2.Name = "cbocolumna2";
            this.cbocolumna2.Size = new System.Drawing.Size(121, 21);
            this.cbocolumna2.TabIndex = 1;
            this.cbocolumna2.Click += new System.EventHandler(this.cbocolumna2_Click);
            // 
            // dtselecttablas
            // 
            this.dtselecttablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtselecttablas.Location = new System.Drawing.Point(200, 12);
            this.dtselecttablas.Name = "dtselecttablas";
            this.dtselecttablas.Size = new System.Drawing.Size(477, 237);
            this.dtselecttablas.TabIndex = 2;
            // 
            // cbocolumna1
            // 
            this.cbocolumna1.FormattingEnabled = true;
            this.cbocolumna1.Location = new System.Drawing.Point(37, 123);
            this.cbocolumna1.Name = "cbocolumna1";
            this.cbocolumna1.Size = new System.Drawing.Size(121, 21);
            this.cbocolumna1.TabIndex = 3;
            this.cbocolumna1.Click += new System.EventHandler(this.cbocolumna1_Click);
            // 
            // cbotabla2
            // 
            this.cbotabla2.FormattingEnabled = true;
            this.cbotabla2.Location = new System.Drawing.Point(700, 28);
            this.cbotabla2.Name = "cbotabla2";
            this.cbotabla2.Size = new System.Drawing.Size(121, 21);
            this.cbotabla2.TabIndex = 4;
            this.cbotabla2.Click += new System.EventHandler(this.cbotabla2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select de 2 tablas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tabla 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tabla 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Columna de conexión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Columna de conexión";
            // 
            // lbtimestar
            // 
            this.lbtimestar.AutoSize = true;
            this.lbtimestar.Location = new System.Drawing.Point(12, 265);
            this.lbtimestar.Name = "lbtimestar";
            this.lbtimestar.Size = new System.Drawing.Size(35, 13);
            this.lbtimestar.TabIndex = 10;
            this.lbtimestar.Text = "label5";
            this.lbtimestar.Visible = false;
            // 
            // lbtimestop
            // 
            this.lbtimestop.AutoSize = true;
            this.lbtimestop.Location = new System.Drawing.Point(63, 265);
            this.lbtimestop.Name = "lbtimestop";
            this.lbtimestop.Size = new System.Drawing.Size(35, 13);
            this.lbtimestop.TabIndex = 11;
            this.lbtimestop.Text = "label6";
            this.lbtimestop.Visible = false;
            // 
            // lbdiferencia
            // 
            this.lbdiferencia.AutoSize = true;
            this.lbdiferencia.Location = new System.Drawing.Point(123, 265);
            this.lbdiferencia.Name = "lbdiferencia";
            this.lbdiferencia.Size = new System.Drawing.Size(35, 13);
            this.lbdiferencia.TabIndex = 12;
            this.lbdiferencia.Text = "label7";
            this.lbdiferencia.Visible = false;
            // 
            // SelectDosTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 299);
            this.Controls.Add(this.lbdiferencia);
            this.Controls.Add(this.lbtimestop);
            this.Controls.Add(this.lbtimestar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbotabla2);
            this.Controls.Add(this.cbocolumna1);
            this.Controls.Add(this.dtselecttablas);
            this.Controls.Add(this.cbocolumna2);
            this.Controls.Add(this.cbotabla1);
            this.Name = "SelectDosTablas";
            this.Text = "SelectDosTablas";
            ((System.ComponentModel.ISupportInitialize)(this.dtselecttablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbotabla1;
        private System.Windows.Forms.ComboBox cbocolumna2;
        private System.Windows.Forms.DataGridView dtselecttablas;
        private System.Windows.Forms.ComboBox cbocolumna1;
        private System.Windows.Forms.ComboBox cbotabla2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbtimestar;
        private System.Windows.Forms.Label lbtimestop;
        private System.Windows.Forms.Label lbdiferencia;
    }
}