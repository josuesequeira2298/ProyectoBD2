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
            this.cmbcolumna01 = new System.Windows.Forms.ComboBox();
            this.txtdato01 = new System.Windows.Forms.TextBox();
            this.cmbfila01 = new System.Windows.Forms.ComboBox();
            this.btninsert01 = new System.Windows.Forms.Button();
            this.dtgtabla = new System.Windows.Forms.DataGridView();
            this.cmbtablas = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cmbupdate = new System.Windows.Forms.ComboBox();
            this.cmbideliminar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbidupdate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.txtdato = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Columna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contenido";
            // 
            // cmbcolumna01
            // 
            this.cmbcolumna01.FormattingEnabled = true;
            this.cmbcolumna01.Location = new System.Drawing.Point(60, 28);
            this.cmbcolumna01.Name = "cmbcolumna01";
            this.cmbcolumna01.Size = new System.Drawing.Size(121, 21);
            this.cmbcolumna01.TabIndex = 5;
            this.cmbcolumna01.Click += new System.EventHandler(this.cmbcolumna01_Click);
            // 
            // txtdato01
            // 
            this.txtdato01.Location = new System.Drawing.Point(196, 29);
            this.txtdato01.Name = "txtdato01";
            this.txtdato01.Size = new System.Drawing.Size(100, 20);
            this.txtdato01.TabIndex = 6;
            // 
            // cmbfila01
            // 
            this.cmbfila01.FormattingEnabled = true;
            this.cmbfila01.Location = new System.Drawing.Point(12, 32);
            this.cmbfila01.Name = "cmbfila01";
            this.cmbfila01.Size = new System.Drawing.Size(30, 21);
            this.cmbfila01.TabIndex = 4;
            this.cmbfila01.Visible = false;
            this.cmbfila01.Click += new System.EventHandler(this.cmbfila01_Click);
            // 
            // btninsert01
            // 
            this.btninsert01.Location = new System.Drawing.Point(302, 29);
            this.btninsert01.Name = "btninsert01";
            this.btninsert01.Size = new System.Drawing.Size(75, 23);
            this.btninsert01.TabIndex = 7;
            this.btninsert01.Text = "Insertar";
            this.btninsert01.UseVisualStyleBackColor = true;
            this.btninsert01.Click += new System.EventHandler(this.btninsert01_Click);
            // 
            // dtgtabla
            // 
            this.dtgtabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtabla.Location = new System.Drawing.Point(383, 15);
            this.dtgtabla.Name = "dtgtabla";
            this.dtgtabla.Size = new System.Drawing.Size(335, 164);
            this.dtgtabla.TabIndex = 8;
            // 
            // cmbtablas
            // 
            this.cmbtablas.FormattingEnabled = true;
            this.cmbtablas.Location = new System.Drawing.Point(439, 205);
            this.cmbtablas.Name = "cmbtablas";
            this.cmbtablas.Size = new System.Drawing.Size(121, 21);
            this.cmbtablas.TabIndex = 25;
            this.cmbtablas.SelectedIndexChanged += new System.EventHandler(this.cmbtablas_SelectedIndexChanged);
            this.cmbtablas.Click += new System.EventHandler(this.cmbtablas_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(60, 93);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(302, 157);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cmbupdate
            // 
            this.cmbupdate.FormattingEnabled = true;
            this.cmbupdate.Location = new System.Drawing.Point(60, 156);
            this.cmbupdate.Name = "cmbupdate";
            this.cmbupdate.Size = new System.Drawing.Size(121, 21);
            this.cmbupdate.TabIndex = 16;
            this.cmbupdate.SelectedIndexChanged += new System.EventHandler(this.cmbupdate_SelectedIndexChanged);
            this.cmbupdate.TextChanged += new System.EventHandler(this.cmbupdate_TextChanged);
            this.cmbupdate.Click += new System.EventHandler(this.cmbupdate_Click);
            // 
            // cmbideliminar
            // 
            this.cmbideliminar.FormattingEnabled = true;
            this.cmbideliminar.Location = new System.Drawing.Point(12, 93);
            this.cmbideliminar.Name = "cmbideliminar";
            this.cmbideliminar.Size = new System.Drawing.Size(41, 21);
            this.cmbideliminar.TabIndex = 17;
            this.cmbideliminar.Click += new System.EventHandler(this.cmbideliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID";
            // 
            // cmbidupdate
            // 
            this.cmbidupdate.FormattingEnabled = true;
            this.cmbidupdate.Location = new System.Drawing.Point(12, 156);
            this.cmbidupdate.Name = "cmbidupdate";
            this.cmbidupdate.Size = new System.Drawing.Size(41, 21);
            this.cmbidupdate.TabIndex = 22;
            this.cmbidupdate.Click += new System.EventHandler(this.cmbidupdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tablas";
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(566, 205);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(114, 23);
            this.btnconsultar.TabIndex = 24;
            this.btnconsultar.Text = "Consultar Tablas";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // txtdato
            // 
            this.txtdato.Location = new System.Drawing.Point(196, 157);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(100, 20);
            this.txtdato.TabIndex = 26;
            // 
            // Inserciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 238);
            this.Controls.Add(this.txtdato);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbidupdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbideliminar);
            this.Controls.Add(this.cmbupdate);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cmbtablas);
            this.Controls.Add(this.dtgtabla);
            this.Controls.Add(this.btninsert01);
            this.Controls.Add(this.txtdato01);
            this.Controls.Add(this.cmbcolumna01);
            this.Controls.Add(this.cmbfila01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inserciones";
            this.Text = "Inserciones";
            this.Load += new System.EventHandler(this.Inserciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgtabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcolumna01;
        private System.Windows.Forms.TextBox txtdato01;
        private System.Windows.Forms.ComboBox cmbfila01;
        private System.Windows.Forms.Button btninsert01;
        private System.Windows.Forms.DataGridView dtgtabla;
        private System.Windows.Forms.ComboBox cmbtablas;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox cmbupdate;
        private System.Windows.Forms.ComboBox cmbideliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbidupdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.TextBox txtdato;
    }
}