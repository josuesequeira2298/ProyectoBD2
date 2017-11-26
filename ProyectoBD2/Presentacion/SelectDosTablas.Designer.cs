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
            ((System.ComponentModel.ISupportInitialize)(this.dtselecttablas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbotabla1
            // 
            this.cbotabla1.FormattingEnabled = true;
            this.cbotabla1.Location = new System.Drawing.Point(37, 36);
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
            this.dtselecttablas.Location = new System.Drawing.Point(200, 36);
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
            this.cbotabla2.Location = new System.Drawing.Point(700, 36);
            this.cbotabla2.Name = "cbotabla2";
            this.cbotabla2.Size = new System.Drawing.Size(121, 21);
            this.cbotabla2.TabIndex = 4;
            this.cbotabla2.Click += new System.EventHandler(this.cbotabla2_Click);
            // 
            // SelectDosTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 299);
            this.Controls.Add(this.cbotabla2);
            this.Controls.Add(this.cbocolumna1);
            this.Controls.Add(this.dtselecttablas);
            this.Controls.Add(this.cbocolumna2);
            this.Controls.Add(this.cbotabla1);
            this.Name = "SelectDosTablas";
            this.Text = "SelectDosTablas";
            ((System.ComponentModel.ISupportInitialize)(this.dtselecttablas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbotabla1;
        private System.Windows.Forms.ComboBox cbocolumna2;
        private System.Windows.Forms.DataGridView dtselecttablas;
        private System.Windows.Forms.ComboBox cbocolumna1;
        private System.Windows.Forms.ComboBox cbotabla2;
    }
}