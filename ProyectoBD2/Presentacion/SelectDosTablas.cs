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
                cbocolumna1.ValueMember = "ID";
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
                cbocolumna2.ValueMember = "ID";
                cbocolumna2.DataSource = dttablas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ConsultarTablas()
        {
            try
            {
                Logica.Creartabla consulta = new Logica.Creartabla();
                DataTable dttablas = new DataTable();

                dttablas = consulta.ConsultarTablas();
                dtselecttablas.DataSource = dttablas;
            }
            catch 
            {

                MessageBox.Show("Errorde sintaxis");
            }
        }
        public void ConsultarSelect()
        {
            try
            {
                Logica.Creartabla consulta = new Logica.Creartabla();
                DataTable dttablaselect = new DataTable();

                dtselecttablas.DataSource = cbotabla1.Text + cbotabla2.Text;
            }
            catch 
            {

                MessageBox.Show("Error de sintaxis");
            }
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

        private void select()
        {
            lbtimestar.Text = DateTime.Now.ToLongTimeString();
            try
            {
                if (cbocolumna1.Text == cbocolumna2.Text)
                {
                    Logica.Creartabla select = new Logica.Creartabla();
                    select.select(cbotabla1.Text, cbotabla2.Text, cbocolumna1.Text, cbocolumna2.Text);
                    MessageBox.Show("Se realizó el select exitosamente");
                    lbtimestop.Text = DateTime.Now.ToLongTimeString();
                }
                else
                {
                    MessageBox.Show("Las columnas de conexión no son iguales");
                }
            }
            catch 
            {

                MessageBox.Show("Error de sintaxis");
            }
            calculoTiempo();
        }
        private void calculoTiempo()
        {
            try
            {
                DateTime var1 = (DateTime.Parse(lbtimestar.Text));
                string[] fecha = new string[3];
                string temp = lbtimestop.Text;
                fecha = temp.Split(':');
                DateTime var2 = (DateTime.Parse(lbtimestop.Text));
                var2 = new DateTime(var1.Year, var1.Month, var1.Day, Convert.ToInt32(fecha[0]), Convert.ToInt32(fecha[1]), Convert.ToInt32(fecha[2]));
                TimeSpan dif = new TimeSpan();
                dif = var2 - var1;
                lbdiferencia.Text = dif.ToString();
                MessageBox.Show("Tiempo demorado: " + lbdiferencia.Text);
            }
            catch
            {
                MessageBox.Show("Error al calcular tiempo");
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

        private void button1_Click(object sender, EventArgs e)
        {
            select();
            ConsultarSelect();
        }
    }
}
