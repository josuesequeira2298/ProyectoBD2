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
            try
            {
                Logica.Creartabla datos = new Logica.Creartabla();
                DataTable dtDatos = new DataTable();
                

                dtDatos = datos.llenarcombo();
                cmbdato01.DisplayMember = "Nombre";
                cmbdato01.ValueMember = "ID";
                cmbdato01.DataSource = dtDatos;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


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
            llenarcombo();
        }

       
    }
}
