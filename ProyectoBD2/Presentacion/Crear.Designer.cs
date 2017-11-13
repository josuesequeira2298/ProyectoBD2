namespace Presentacion
{
    partial class Crear
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
            this.components = new System.ComponentModel.Container();
            this.btncreartabla = new System.Windows.Forms.Button();
            this.labelnombre = new System.Windows.Forms.Label();
            this.txtnombretabla = new System.Windows.Forms.TextBox();
            this.labelcolumnas = new System.Windows.Forms.Label();
            this.txtdato01 = new System.Windows.Forms.TextBox();
            this.cmbdato01 = new System.Windows.Forms.ComboBox();
            this.txttama01 = new System.Windows.Forms.TextBox();
            this.txtdato02 = new System.Windows.Forms.TextBox();
            this.cmbdato02 = new System.Windows.Forms.ComboBox();
            this.txttama02 = new System.Windows.Forms.TextBox();
            this.txtdato03 = new System.Windows.Forms.TextBox();
            this.cmbdato03 = new System.Windows.Forms.ComboBox();
            this.txttama03 = new System.Windows.Forms.TextBox();
            this.dtgtablas = new System.Windows.Forms.DataGridView();
            this.proyectoBD02DataSet = new Presentacion.ProyectoBD02DataSet();
            this.tablasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablasTableAdapter = new Presentacion.ProyectoBD02DataSetTableAdapters.TablasTableAdapter();
            this.proyectoBD02DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoBD02DataSet1 = new Presentacion.ProyectoBD02DataSet1();
            this.tipodatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipodatoTableAdapter = new Presentacion.ProyectoBD02DataSet1TableAdapters.tipodatoTableAdapter();
            this.proyectoBD02DataSet2 = new Presentacion.ProyectoBD02DataSet2();
            this.tipodatoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tipodatoTableAdapter1 = new Presentacion.ProyectoBD02DataSet2TableAdapters.tipodatoTableAdapter();
            this.cmbdato = new Presentacion.cmbdato();
            this.tipodatoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tipodatoTableAdapter2 = new Presentacion.cmbdatoTableAdapters.tipodatoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBD02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBD02DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBD02DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBD02DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodatoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbdato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodatoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btncreartabla
            // 
            this.btncreartabla.Location = new System.Drawing.Point(16, 12);
            this.btncreartabla.Name = "btncreartabla";
            this.btncreartabla.Size = new System.Drawing.Size(75, 23);
            this.btncreartabla.TabIndex = 0;
            this.btncreartabla.Text = "Crear Tabla";
            this.btncreartabla.UseVisualStyleBackColor = true;
            this.btncreartabla.Click += new System.EventHandler(this.btncreartabla_Click);
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(13, 62);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(44, 13);
            this.labelnombre.TabIndex = 1;
            this.labelnombre.Text = "Nombre";
            // 
            // txtnombretabla
            // 
            this.txtnombretabla.Location = new System.Drawing.Point(74, 59);
            this.txtnombretabla.Name = "txtnombretabla";
            this.txtnombretabla.Size = new System.Drawing.Size(100, 20);
            this.txtnombretabla.TabIndex = 2;
            // 
            // labelcolumnas
            // 
            this.labelcolumnas.AutoSize = true;
            this.labelcolumnas.Location = new System.Drawing.Point(13, 93);
            this.labelcolumnas.Name = "labelcolumnas";
            this.labelcolumnas.Size = new System.Drawing.Size(53, 13);
            this.labelcolumnas.TabIndex = 3;
            this.labelcolumnas.Text = "Columnas";
            // 
            // txtdato01
            // 
            this.txtdato01.Location = new System.Drawing.Point(16, 121);
            this.txtdato01.Name = "txtdato01";
            this.txtdato01.Size = new System.Drawing.Size(100, 20);
            this.txtdato01.TabIndex = 4;
            // 
            // cmbdato01
            // 
            this.cmbdato01.FormattingEnabled = true;
            this.cmbdato01.Location = new System.Drawing.Point(137, 121);
            this.cmbdato01.Name = "cmbdato01";
            this.cmbdato01.Size = new System.Drawing.Size(121, 21);
            this.cmbdato01.TabIndex = 5;
            this.cmbdato01.SelectedIndexChanged += new System.EventHandler(this.cmbdato01_SelectedIndexChanged);
            // 
            // txttama01
            // 
            this.txttama01.Location = new System.Drawing.Point(274, 121);
            this.txttama01.Name = "txttama01";
            this.txttama01.Size = new System.Drawing.Size(100, 20);
            this.txttama01.TabIndex = 6;
            // 
            // txtdato02
            // 
            this.txtdato02.Location = new System.Drawing.Point(16, 148);
            this.txtdato02.Name = "txtdato02";
            this.txtdato02.Size = new System.Drawing.Size(100, 20);
            this.txtdato02.TabIndex = 7;
            // 
            // cmbdato02
            // 
            this.cmbdato02.FormattingEnabled = true;
            this.cmbdato02.Location = new System.Drawing.Point(137, 146);
            this.cmbdato02.Name = "cmbdato02";
            this.cmbdato02.Size = new System.Drawing.Size(121, 21);
            this.cmbdato02.TabIndex = 8;
            // 
            // txttama02
            // 
            this.txttama02.Location = new System.Drawing.Point(274, 147);
            this.txttama02.Name = "txttama02";
            this.txttama02.Size = new System.Drawing.Size(100, 20);
            this.txttama02.TabIndex = 9;
            // 
            // txtdato03
            // 
            this.txtdato03.Location = new System.Drawing.Point(16, 175);
            this.txtdato03.Name = "txtdato03";
            this.txtdato03.Size = new System.Drawing.Size(100, 20);
            this.txtdato03.TabIndex = 10;
            // 
            // cmbdato03
            // 
            this.cmbdato03.FormattingEnabled = true;
            this.cmbdato03.Location = new System.Drawing.Point(137, 173);
            this.cmbdato03.Name = "cmbdato03";
            this.cmbdato03.Size = new System.Drawing.Size(121, 21);
            this.cmbdato03.TabIndex = 11;
            // 
            // txttama03
            // 
            this.txttama03.Location = new System.Drawing.Point(274, 173);
            this.txttama03.Name = "txttama03";
            this.txttama03.Size = new System.Drawing.Size(100, 20);
            this.txttama03.TabIndex = 12;
            // 
            // dtgtablas
            // 
            this.dtgtablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtablas.Location = new System.Drawing.Point(398, 27);
            this.dtgtablas.Name = "dtgtablas";
            this.dtgtablas.Size = new System.Drawing.Size(526, 264);
            this.dtgtablas.TabIndex = 13;
            this.dtgtablas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgtablas_CellContentClick);
            // 
            // proyectoBD02DataSet
            // 
            this.proyectoBD02DataSet.DataSetName = "ProyectoBD02DataSet";
            this.proyectoBD02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablasBindingSource
            // 
            this.tablasBindingSource.DataMember = "Tablas";
            this.tablasBindingSource.DataSource = this.proyectoBD02DataSet;
            // 
            // tablasTableAdapter
            // 
            this.tablasTableAdapter.ClearBeforeFill = true;
            // 
            // proyectoBD02DataSetBindingSource
            // 
            this.proyectoBD02DataSetBindingSource.DataSource = this.proyectoBD02DataSet;
            this.proyectoBD02DataSetBindingSource.Position = 0;
            // 
            // proyectoBD02DataSet1
            // 
            this.proyectoBD02DataSet1.DataSetName = "ProyectoBD02DataSet1";
            this.proyectoBD02DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipodatoBindingSource
            // 
            this.tipodatoBindingSource.DataMember = "tipodato";
            this.tipodatoBindingSource.DataSource = this.proyectoBD02DataSet1;
            // 
            // tipodatoTableAdapter
            // 
            this.tipodatoTableAdapter.ClearBeforeFill = true;
            // 
            // proyectoBD02DataSet2
            // 
            this.proyectoBD02DataSet2.DataSetName = "ProyectoBD02DataSet2";
            this.proyectoBD02DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipodatoBindingSource1
            // 
            this.tipodatoBindingSource1.DataMember = "tipodato";
            this.tipodatoBindingSource1.DataSource = this.proyectoBD02DataSet2;
            // 
            // tipodatoTableAdapter1
            // 
            this.tipodatoTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbdato
            // 
            this.cmbdato.DataSetName = "cmbdato";
            this.cmbdato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipodatoBindingSource2
            // 
            this.tipodatoBindingSource2.DataMember = "tipodato";
            this.tipodatoBindingSource2.DataSource = this.cmbdato;
            // 
            // tipodatoTableAdapter2
            // 
            this.tipodatoTableAdapter2.ClearBeforeFill = true;
            // 
            // Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 303);
            this.Controls.Add(this.dtgtablas);
            this.Controls.Add(this.txttama03);
            this.Controls.Add(this.cmbdato03);
            this.Controls.Add(this.txtdato03);
            this.Controls.Add(this.txttama02);
            this.Controls.Add(this.cmbdato02);
            this.Controls.Add(this.txtdato02);
            this.Controls.Add(this.txttama01);
            this.Controls.Add(this.cmbdato01);
            this.Controls.Add(this.txtdato01);
            this.Controls.Add(this.labelcolumnas);
            this.Controls.Add(this.txtnombretabla);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.btncreartabla);
            this.Name = "Crear";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Crear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgtablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBD02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBD02DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBD02DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBD02DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodatoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbdato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodatoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreartabla;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.TextBox txtnombretabla;
        private System.Windows.Forms.Label labelcolumnas;
        private System.Windows.Forms.TextBox txtdato01;
        private System.Windows.Forms.ComboBox cmbdato01;
        private System.Windows.Forms.TextBox txttama01;
        private System.Windows.Forms.TextBox txtdato02;
        private System.Windows.Forms.ComboBox cmbdato02;
        private System.Windows.Forms.TextBox txttama02;
        private System.Windows.Forms.TextBox txtdato03;
        private System.Windows.Forms.ComboBox cmbdato03;
        private System.Windows.Forms.TextBox txttama03;
        private System.Windows.Forms.DataGridView dtgtablas;
        private ProyectoBD02DataSet proyectoBD02DataSet;
        private System.Windows.Forms.BindingSource tablasBindingSource;
        private ProyectoBD02DataSetTableAdapters.TablasTableAdapter tablasTableAdapter;
        private System.Windows.Forms.BindingSource proyectoBD02DataSetBindingSource;
        private ProyectoBD02DataSet1 proyectoBD02DataSet1;
        private System.Windows.Forms.BindingSource tipodatoBindingSource;
        private ProyectoBD02DataSet1TableAdapters.tipodatoTableAdapter tipodatoTableAdapter;
        private ProyectoBD02DataSet2 proyectoBD02DataSet2;
        private System.Windows.Forms.BindingSource tipodatoBindingSource1;
        private ProyectoBD02DataSet2TableAdapters.tipodatoTableAdapter tipodatoTableAdapter1;
        private cmbdato cmbdato;
        private System.Windows.Forms.BindingSource tipodatoBindingSource2;
        private cmbdatoTableAdapters.tipodatoTableAdapter tipodatoTableAdapter2;
    }
}