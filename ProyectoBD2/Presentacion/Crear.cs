using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
        }

        private void Crear_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cmbdato.tipodato' Puede moverla o quitarla según sea necesario.
            this.tipodatoTableAdapter2.Fill(this.cmbdato.tipodato);
            // TODO: esta línea de código carga datos en la tabla 'proyectoBD02DataSet2.tipodato' Puede moverla o quitarla según sea necesario.
            this.tipodatoTableAdapter1.Fill(this.proyectoBD02DataSet2.tipodato);
            // TODO: esta línea de código carga datos en la tabla 'proyectoBD02DataSet1.tipodato' Puede moverla o quitarla según sea necesario.
            this.tipodatoTableAdapter.Fill(this.proyectoBD02DataSet1.tipodato);
            // TODO: esta línea de código carga datos en la tabla 'proyectoBD02DataSet.Tablas' Puede moverla o quitarla según sea necesario.
            this.tablasTableAdapter.Fill(this.proyectoBD02DataSet.Tablas);
            ConsultarTablas();
        }

        public void ConsultarTablas()
        {
            Logica.Creartabla consulta = new Logica.Creartabla();
            DataTable dttablas = new DataTable();

            dttablas = consulta.ConsultarTablas();
            dtgtablas.DataSource = dttablas;
 


        }

        private void dtgtablas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncreartabla_Click(object sender, EventArgs e)
        {
            ConsultarTablas();
        }

        private void cmbdato01_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
