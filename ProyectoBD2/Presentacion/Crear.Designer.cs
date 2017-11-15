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
            this.btncreartabla = new System.Windows.Forms.Button();
            this.labelnombre = new System.Windows.Forms.Label();
            this.txtnombretabla = new System.Windows.Forms.TextBox();
            this.labelcolumnas = new System.Windows.Forms.Label();
            this.txtnombrecolumna = new System.Windows.Forms.TextBox();
            this.cmbdato01 = new System.Windows.Forms.ComboBox();
            this.txttama01 = new System.Windows.Forms.TextBox();
            this.dtgtablas = new System.Windows.Forms.DataGridView();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbtipodato = new System.Windows.Forms.Label();
            this.lbtamaño = new System.Windows.Forms.Label();
            this.btnagregarcolum = new System.Windows.Forms.Button();
            this.chkidentity = new System.Windows.Forms.CheckBox();
            this.txtideini = new System.Windows.Forms.TextBox();
            this.txtidefin = new System.Windows.Forms.TextBox();
            this.brnlimpiar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.chkdefault = new System.Windows.Forms.CheckBox();
            this.txtdefault = new System.Windows.Forms.TextBox();
            this.cmbnombretabla = new System.Windows.Forms.ComboBox();
            this.dtgtablasdedic = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbnombrecolum = new System.Windows.Forms.ComboBox();
            this.btneliminarcolumn = new System.Windows.Forms.Button();
            this.btneliminartabla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtablasdedic)).BeginInit();
            this.SuspendLayout();
            // 
            // btncreartabla
            // 
            this.btncreartabla.Location = new System.Drawing.Point(199, 10);
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
            this.labelnombre.Location = new System.Drawing.Point(13, 15);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(44, 13);
            this.labelnombre.TabIndex = 1;
            this.labelnombre.Text = "Nombre";
            // 
            // txtnombretabla
            // 
            this.txtnombretabla.Location = new System.Drawing.Point(74, 12);
            this.txtnombretabla.Name = "txtnombretabla";
            this.txtnombretabla.Size = new System.Drawing.Size(100, 20);
            this.txtnombretabla.TabIndex = 2;
            // 
            // labelcolumnas
            // 
            this.labelcolumnas.AutoSize = true;
            this.labelcolumnas.Location = new System.Drawing.Point(13, 40);
            this.labelcolumnas.Name = "labelcolumnas";
            this.labelcolumnas.Size = new System.Drawing.Size(53, 13);
            this.labelcolumnas.TabIndex = 3;
            this.labelcolumnas.Text = "Columnas";
            // 
            // txtnombrecolumna
            // 
            this.txtnombrecolumna.Location = new System.Drawing.Point(16, 83);
            this.txtnombrecolumna.Name = "txtnombrecolumna";
            this.txtnombrecolumna.Size = new System.Drawing.Size(100, 20);
            this.txtnombrecolumna.TabIndex = 4;
            // 
            // cmbdato01
            // 
            this.cmbdato01.DisplayMember = "ID";
            this.cmbdato01.FormattingEnabled = true;
            this.cmbdato01.Location = new System.Drawing.Point(122, 83);
            this.cmbdato01.Name = "cmbdato01";
            this.cmbdato01.Size = new System.Drawing.Size(121, 21);
            this.cmbdato01.TabIndex = 5;
            this.cmbdato01.ValueMember = "Nombre";
            this.cmbdato01.SelectedIndexChanged += new System.EventHandler(this.cmbdato01_SelectedIndexChanged);
            // 
            // txttama01
            // 
            this.txttama01.Location = new System.Drawing.Point(249, 84);
            this.txttama01.Name = "txttama01";
            this.txttama01.Size = new System.Drawing.Size(100, 20);
            this.txttama01.TabIndex = 6;
            // 
            // dtgtablas
            // 
            this.dtgtablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgtablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtablas.Location = new System.Drawing.Point(381, 15);
            this.dtgtablas.Name = "dtgtablas";
            this.dtgtablas.Size = new System.Drawing.Size(406, 234);
            this.dtgtablas.TabIndex = 20;
            this.dtgtablas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgtablas_CellContentClick_1);
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(13, 65);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(44, 13);
            this.lbnombre.TabIndex = 21;
            this.lbnombre.Text = "Nombre";
            // 
            // lbtipodato
            // 
            this.lbtipodato.AutoSize = true;
            this.lbtipodato.Location = new System.Drawing.Point(119, 65);
            this.lbtipodato.Name = "lbtipodato";
            this.lbtipodato.Size = new System.Drawing.Size(69, 13);
            this.lbtipodato.TabIndex = 22;
            this.lbtipodato.Text = "Tipo de Dato";
            // 
            // lbtamaño
            // 
            this.lbtamaño.AutoSize = true;
            this.lbtamaño.Location = new System.Drawing.Point(246, 65);
            this.lbtamaño.Name = "lbtamaño";
            this.lbtamaño.Size = new System.Drawing.Size(46, 13);
            this.lbtamaño.TabIndex = 23;
            this.lbtamaño.Text = "Tamaño";
            // 
            // btnagregarcolum
            // 
            this.btnagregarcolum.Location = new System.Drawing.Point(249, 123);
            this.btnagregarcolum.Name = "btnagregarcolum";
            this.btnagregarcolum.Size = new System.Drawing.Size(100, 23);
            this.btnagregarcolum.TabIndex = 24;
            this.btnagregarcolum.Text = "Agregar Columna";
            this.btnagregarcolum.UseVisualStyleBackColor = true;
            this.btnagregarcolum.Click += new System.EventHandler(this.btnagregarcolum_Click);
            // 
            // chkidentity
            // 
            this.chkidentity.AutoSize = true;
            this.chkidentity.Location = new System.Drawing.Point(16, 114);
            this.chkidentity.Name = "chkidentity";
            this.chkidentity.Size = new System.Drawing.Size(60, 17);
            this.chkidentity.TabIndex = 25;
            this.chkidentity.Text = "Identity";
            this.chkidentity.UseVisualStyleBackColor = true;
            // 
            // txtideini
            // 
            this.txtideini.Location = new System.Drawing.Point(82, 112);
            this.txtideini.Name = "txtideini";
            this.txtideini.Size = new System.Drawing.Size(28, 20);
            this.txtideini.TabIndex = 26;
            // 
            // txtidefin
            // 
            this.txtidefin.Location = new System.Drawing.Point(116, 112);
            this.txtidefin.Name = "txtidefin";
            this.txtidefin.Size = new System.Drawing.Size(28, 20);
            this.txtidefin.TabIndex = 27;
            // 
            // brnlimpiar
            // 
            this.brnlimpiar.Location = new System.Drawing.Point(381, 255);
            this.brnlimpiar.Name = "brnlimpiar";
            this.brnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.brnlimpiar.TabIndex = 28;
            this.brnlimpiar.Text = "Limpiar";
            this.brnlimpiar.UseVisualStyleBackColor = true;
            this.brnlimpiar.Click += new System.EventHandler(this.brnlimpiar_Click);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Location = new System.Drawing.Point(712, 255);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnrefrescar.TabIndex = 29;
            this.btnrefrescar.Text = "Refrescar";
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // chkdefault
            // 
            this.chkdefault.AutoSize = true;
            this.chkdefault.Location = new System.Drawing.Point(16, 140);
            this.chkdefault.Name = "chkdefault";
            this.chkdefault.Size = new System.Drawing.Size(60, 17);
            this.chkdefault.TabIndex = 30;
            this.chkdefault.Text = "Default";
            this.chkdefault.UseVisualStyleBackColor = true;
            // 
            // txtdefault
            // 
            this.txtdefault.Location = new System.Drawing.Point(82, 138);
            this.txtdefault.Name = "txtdefault";
            this.txtdefault.Size = new System.Drawing.Size(62, 20);
            this.txtdefault.TabIndex = 31;
            // 
            // cmbnombretabla
            // 
            this.cmbnombretabla.FormattingEnabled = true;
            this.cmbnombretabla.Location = new System.Drawing.Point(116, 286);
            this.cmbnombretabla.Name = "cmbnombretabla";
            this.cmbnombretabla.Size = new System.Drawing.Size(121, 21);
            this.cmbnombretabla.TabIndex = 32;
            this.cmbnombretabla.SelectedIndexChanged += new System.EventHandler(this.cmbnombretabla_SelectedIndexChanged);
            this.cmbnombretabla.Click += new System.EventHandler(this.cmbnombretabla_Click);
            // 
            // dtgtablasdedic
            // 
            this.dtgtablasdedic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgtablasdedic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtablasdedic.Location = new System.Drawing.Point(381, 284);
            this.dtgtablasdedic.Name = "dtgtablasdedic";
            this.dtgtablasdedic.Size = new System.Drawing.Size(406, 150);
            this.dtgtablasdedic.TabIndex = 33;
            this.dtgtablasdedic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre Tabla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nombre Columna";
            // 
            // cmbnombrecolum
            // 
            this.cmbnombrecolum.FormattingEnabled = true;
            this.cmbnombrecolum.Location = new System.Drawing.Point(116, 315);
            this.cmbnombrecolum.Name = "cmbnombrecolum";
            this.cmbnombrecolum.Size = new System.Drawing.Size(121, 21);
            this.cmbnombrecolum.TabIndex = 37;
            this.cmbnombrecolum.SelectedIndexChanged += new System.EventHandler(this.cmbnombrecolum_SelectedIndexChanged);
            this.cmbnombrecolum.Click += new System.EventHandler(this.cmbnombrecolum_Click);
            // 
            // btneliminarcolumn
            // 
            this.btneliminarcolumn.Location = new System.Drawing.Point(249, 313);
            this.btneliminarcolumn.Name = "btneliminarcolumn";
            this.btneliminarcolumn.Size = new System.Drawing.Size(100, 23);
            this.btneliminarcolumn.TabIndex = 38;
            this.btneliminarcolumn.Text = "Eliminar Columna";
            this.btneliminarcolumn.UseVisualStyleBackColor = true;
            this.btneliminarcolumn.Click += new System.EventHandler(this.btneliminarcolumn_Click);
            // 
            // btneliminartabla
            // 
            this.btneliminartabla.Location = new System.Drawing.Point(249, 284);
            this.btneliminartabla.Name = "btneliminartabla";
            this.btneliminartabla.Size = new System.Drawing.Size(100, 23);
            this.btneliminartabla.TabIndex = 39;
            this.btneliminartabla.Text = "Eliminar Tabla";
            this.btneliminartabla.UseVisualStyleBackColor = true;
            this.btneliminartabla.Click += new System.EventHandler(this.btneliminartabla_Click);
            // 
            // Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 447);
            this.Controls.Add(this.btneliminartabla);
            this.Controls.Add(this.btneliminarcolumn);
            this.Controls.Add(this.cmbnombrecolum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgtablasdedic);
            this.Controls.Add(this.cmbnombretabla);
            this.Controls.Add(this.txtdefault);
            this.Controls.Add(this.chkdefault);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.brnlimpiar);
            this.Controls.Add(this.txtidefin);
            this.Controls.Add(this.txtideini);
            this.Controls.Add(this.chkidentity);
            this.Controls.Add(this.btnagregarcolum);
            this.Controls.Add(this.lbtamaño);
            this.Controls.Add(this.lbtipodato);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.dtgtablas);
            this.Controls.Add(this.txttama01);
            this.Controls.Add(this.cmbdato01);
            this.Controls.Add(this.txtnombrecolumna);
            this.Controls.Add(this.labelcolumnas);
            this.Controls.Add(this.txtnombretabla);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.btncreartabla);
            this.Name = "Crear";
            this.Text = "Crear Tablas y Columnas";
            this.Load += new System.EventHandler(this.Crear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgtablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtablasdedic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreartabla;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.TextBox txtnombretabla;
        private System.Windows.Forms.Label labelcolumnas;
        private System.Windows.Forms.TextBox txtnombrecolumna;
        private System.Windows.Forms.ComboBox cmbdato01;
        private System.Windows.Forms.TextBox txttama01;
        private System.Windows.Forms.DataGridView dtgtablas;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbtipodato;
        private System.Windows.Forms.Label lbtamaño;
        private System.Windows.Forms.Button btnagregarcolum;
        private System.Windows.Forms.CheckBox chkidentity;
        private System.Windows.Forms.TextBox txtideini;
        private System.Windows.Forms.TextBox txtidefin;
        private System.Windows.Forms.Button brnlimpiar;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.CheckBox chkdefault;
        private System.Windows.Forms.TextBox txtdefault;
        private System.Windows.Forms.ComboBox cmbnombretabla;
        private System.Windows.Forms.DataGridView dtgtablasdedic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbnombrecolum;
        private System.Windows.Forms.Button btneliminarcolumn;
        private System.Windows.Forms.Button btneliminartabla;
    }
}