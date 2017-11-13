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
    }
}
