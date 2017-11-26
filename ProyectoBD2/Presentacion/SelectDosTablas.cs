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
    public partial class SelectDosTablas : Form
    {
        public SelectDosTablas()
        {
            InitializeComponent();
        }
        private int counter;


        public void llenarcombotablas()
        {
            try
            {
                Logica.Creartabla datos = new Logica.Creartabla();
                DataTable dttablas = new DataTable();

                dttablas = datos.llenarcombotabla();
                cbotabla1.DisplayMember = "Nombre";
                cbotabla1.ValueMember = "id";
                cbotabla1.DataSource = dttablas;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void llenarcombotablas1()
        {
            try
            {
                Logica.Creartabla datos = new Logica.Creartabla();
                DataTable dttablas = new DataTable();

                dttablas = datos.llenarcombotabla();
                cbotabla2.DisplayMember = "Nombre";
                cbotabla2.ValueMember = "id";
                cbotabla2.DataSource = dttablas;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void llenarcombocolumnas1()
        {
            try
            {
                Logica.Creartabla datos = new Logica.Creartabla();
                DataTable dttablas = new DataTable();

                dttablas = datos.llenarcombocolumna(cbotabla1.Text);
                cbocolumna1.DisplayMember = "NombreColumna";
                cbocolumna1.ValueMember = "id";
                cbocolumna1.DataSource = dttablas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void llenarcombocolumnas2()
        {
            try
            {
                Logica.Creartabla datos = new Logica.Creartabla();
                DataTable dttablas = new DataTable();

                dttablas = datos.llenarcombocolumna(cbotabla2.Text);
                cbocolumna2.DisplayMember = "NombreColumna";
                cbocolumna2.ValueMember = "id";
                cbocolumna2.DataSource = dttablas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ConsultarTablas()
        {
            Logica.Creartabla consulta = new Logica.Creartabla();
            DataTable dttablas = new DataTable();

            dttablas = consulta.ConsultarTablas();
            dtselecttablas.DataSource = dttablas;
        }


        private void consultarcolumnas1()
        {
            try
            {
                Logica.Creartabla consulta = new Logica.Creartabla();
                DataTable dtcolumnas = new DataTable();
                dtcolumnas = consulta.consultarcolumnas(cbotabla1.Text);
                dtselecttablas.DataSource = dtcolumnas;
            }
            catch
            {
                MessageBox.Show("La tabla no existe");
            }
        }

        private void consultarcolumnas2()
        {
            try
            {
                Logica.Creartabla consulta = new Logica.Creartabla();
                DataTable dtcolumnas = new DataTable();
                dtcolumnas = consulta.consultarcolumnas(cbotabla2.Text);
                dtselecttablas.DataSource = dtcolumnas;
            }
            catch
            {
                MessageBox.Show("La tabla no existe");
            }
        }

        private void cbotabla1_Click(object sender, EventArgs e)
        {
            llenarcombotablas();
        }

        private void cbocolumna1_Click(object sender, EventArgs e)
        {
            llenarcombocolumnas1();
        }

        private void cbotabla2_Click(object sender, EventArgs e)
        {
            llenarcombotablas1();
        }

        private void cbocolumna2_Click(object sender, EventArgs e)
        {
            llenarcombocolumnas2();
        }
    }
}
