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
            lbtimestar.Text = DateTime.Now.ToLongTimeString();
            try             
            {
                if (cmbtablas.Text != " ")
                {
                    if (cmbcolumna01.Text == "ID")
                    {
                        MessageBox.Show("Columna ID inhabilitada para edición");
                        limpiar();
                    }
                    else
                    {
                        Logica.Creartabla insert = new Logica.Creartabla();
                        insert.insert(cmbtablas.Text, cmbcolumna01.Text, txtdato01.Text);
                        MessageBox.Show("Se insertó la fila correctamente");
                        limpiar();
                        lbtimestop.Text = DateTime.Now.ToLongTimeString();
                        consultarcolumnas();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una tabla");
                }
            }
            catch
            {
                MessageBox.Show("Error de sintaxis, favor revisar");
            }
            calculoTiempo();

        }

        private void btnllamar_Click(object sender, EventArgs e)
        {

        }
        public void llenarcombocolumnas1()
        {
            try
            {
                Logica.Creartabla datos = new Logica.Creartabla();
                DataTable dttablas = new DataTable();

                dttablas = datos.llenarcombocolumna(cmbtablas.Text);
                cmbupdate.DisplayMember = "NombreColumna";
                cmbupdate.ValueMember = "ID";
                cmbupdate.DataSource = dttablas;
            }
            catch (Exception)
            {
                MessageBox.Show("Favor seleccione una tabla");
            }
        }
        public void llenarcombocolumnas2()
        {
            try
            {
                Logica.Creartabla datos = new Logica.Creartabla();
                DataTable dttablas = new DataTable();

                dttablas = datos.llenarcombocolumna(cmbtablas.Text);
                cmbcolumna01.DisplayMember = "NombreColumna";
                cmbcolumna01.ValueMember = "ID";
                cmbcolumna01.DataSource = dttablas;
            }
            catch (Exception)
            {
                MessageBox.Show("Favor seleccione una tabla");
            }
        }

        public void ConsultarTablas()
        {
            Logica.Creartabla consulta = new Logica.Creartabla();
            DataTable dttablas = new DataTable();

            dttablas = consulta.ConsultarTablas();
            dtgtabla.DataSource = dttablas;
        }

        public void llenarcombotablas()
        {
            try
            {
                Logica.Creartabla datos = new Logica.Creartabla();
                DataTable dttablas = new DataTable();

                dttablas = datos.llenarcombotabla();
                cmbtablas.DisplayMember = "Nombre";
                cmbtablas.ValueMember = "id";
                cmbtablas.DataSource = dttablas;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbtablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultarcolumnas();
        }
        private void consultarcolumnas()
        {
            try
            {
                Logica.Creartabla consulta = new Logica.Creartabla();
                DataTable dtcolumnas = new DataTable();
                dtcolumnas = consulta.consultarcolumnas(cmbtablas.Text);
                dtgtabla.DataSource = dtcolumnas;
            }
            catch
            {
                MessageBox.Show("La tabla no existe");
            }
        }

        private void llenarcomboid()
        {
            try
            {
                Logica.Creartabla Datos = new Logica.Creartabla();
                DataTable dtid = new DataTable();
                dtid = Datos.llenarcomboid(cmbtablas.Text);
                cmbideliminar.DisplayMember = "ID";
                cmbideliminar.DataSource = dtid;
            }
            catch (Exception)
            {
                MessageBox.Show("Favor seleccionar una tabla");
            }
        }
        private void llenarcomboid2()
        {
            try
            {
                Logica.Creartabla Datos = new Logica.Creartabla();
                DataTable dtid = new DataTable();
                dtid = Datos.llenarcomboid(cmbtablas.Text);
                cmbfila01.DisplayMember = "ID";
                cmbfila01.DataSource = dtid;
            }
            catch (Exception)
            {
                MessageBox.Show("Favor seleccionar una tabla");
            }
        }
        private void llenarcomboid3()
        {
            try
            {
                Logica.Creartabla Datos = new Logica.Creartabla();
                DataTable dtid = new DataTable();
                dtid = Datos.llenarcomboid(cmbtablas.Text);
                cmbidupdate.DisplayMember = "ID";
                cmbidupdate.DataSource = dtid;
            }
            catch (Exception)
            {
                MessageBox.Show("Favor seleccionar una tabla");
            }
        }

        private void eliminarfilas()
        {
            lbtimestar.Text = DateTime.Now.ToLongTimeString();
            try
            {
                Logica.Creartabla eliminarfila = new Logica.Creartabla();
                eliminarfila.eliminarfilas(cmbtablas.Text, cmbideliminar.Text);
                MessageBox.Show("Se eliminó la fila correctamente");
                lbtimestop.Text = DateTime.Now.ToLongTimeString();
            }
            catch 
            {
                MessageBox.Show("Error de sintaxis");
            }
            calculoTiempo();
        }
        private void update()
        {
            try
            {
                Logica.Creartabla update = new Logica.Creartabla();
                update.update(cmbtablas.Text, cmbupdate.Text, txtdato.Text, cmbidupdate.Text);
                MessageBox.Show("Se actualizó con éxito la fila");
            }
            catch
            {
                MessageBox.Show("Error de sintaxis");
            }
        }
        private void limpiar()
        {
            cmbfila01.Text = " ";
            cmbcolumna01.Text = " ";
            txtdato01.Text = "";
            cmbideliminar.Text = "";
            cmbidupdate.Text = "";
            cmbupdate.Text = "";
            txtdato.Text = "";
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

        private void cmbtablas_Click(object sender, EventArgs e)
        {
            llenarcombotablas();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            ConsultarTablas();
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            eliminarfilas();
            limpiar();
            consultarcolumnas();
        }

        private void cmbideliminar_Click(object sender, EventArgs e)
        {
            llenarcomboid();
        }

        private void cmbfila01_Click(object sender, EventArgs e)
        {
            llenarcomboid2();
        }

        private void cmbidupdate_Click(object sender, EventArgs e)
        {
            llenarcomboid3();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            lbtimestar.Text = DateTime.Now.ToLongTimeString();
            try
            {
                if (cmbupdate.Text == "ID")
                {
                    MessageBox.Show("Columna ID inhabilitada para edición");
                    limpiar();
                }
                else
                {
                    update();
                    limpiar();
                    lbtimestop.Text = DateTime.Now.ToLongTimeString();
                    consultarcolumnas();
                }
            }
            catch 
            {
                MessageBox.Show("Error de sintaxis");
            }
            calculoTiempo();

        }

        private void cmbupdate_Click(object sender, EventArgs e)
        {
            llenarcombocolumnas1();
            
        }

        private void cmbcolumna01_Click(object sender, EventArgs e)
        {
            llenarcombocolumnas2();
        }

        private void cmbupdate_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbupdate_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtgtabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbideliminar.Text = dtgtabla.CurrentRow.Cells[0].Value.ToString();
            cmbidupdate.Text = dtgtabla.CurrentRow.Cells[0].Value.ToString();
            //cmbupdate.Text = dtgtabla.CurrentRow.Cells[dtgtabla.CurrentCellAddress.Y].Value.ToString();
            /*No usar metodo de llenado en proceso*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
