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
            
            ConsultarTablas();
            llenarcombo();
        }

        public void llenarcombo()
        {
            Logica.Creartabla datos = new Logica.Creartabla();
            DataTable dtDatos = new DataTable();


            dtDatos = datos.llenarcombo();
            cmbdato01.DataSource = dtDatos;
            cmbdato01.DisplayMember = "Dato";
            cmbdato01.ValueMember = "Dato";

            //Logica.Creartabla lista = new Logica.Creartabla();
            //this.cmbdato01.DataSource = lista.llenarcombo();
            //this.cmbdato01.DisplayMember = lista.llenarcombo().ToList().ToString();
            ////this.cmbdato01.ValueMember = lista.llenarcombo().ToList().ToString();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
