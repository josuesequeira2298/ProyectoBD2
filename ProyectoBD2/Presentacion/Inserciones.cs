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
    public partial class Inserciones : Form
    {
        public Inserciones()
        {
            InitializeComponent();
        }

        private void Inserciones_Load(object sender, EventArgs e)
        {
            ConsultarTablas();
        }

        private void btninsert01_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbfila01.Text == "")
                {
                    //Insert
                }
                else
                {
                    //update
                }
            }
            catch
            {
                MessageBox.Show("Error de sintaxis, favor revisar");
            }
            
        }

        private void btnllamar_Click(object sender, EventArgs e)
        {

        }

        public void ConsultarTablas()
        {
            Logica.Creartabla consulta = new Logica.Creartabla();
            DataTable dttablas = new DataTable();

            dttablas = consulta.ConsultarTablas();
            dtgtabla.DataSource = dttablas;
        }

        private void cmbtablas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
