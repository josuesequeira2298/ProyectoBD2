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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void llenarcombotablas()
        {
            try
            {
                Logica.Creartabla datos = new Logica.Creartabla();
                DataTable dttablas = new DataTable();

                dttablas = datos.llenarcombotabla();
                cmbnombretabla.DisplayMember = "Nombre";
                cmbnombretabla.ValueMember = "id";
                cmbnombretabla.DataSource = dttablas;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void llenarcombocolumnas()
        {
            try
            {
                Logica.Creartabla datos = new Logica.Creartabla();
                DataTable dttablas = new DataTable();

                dttablas = datos.llenarcombocolumna(cmbnombretabla.Text);
                cmbnombrecolum.DisplayMember = "NombreColumna";
                cmbnombrecolum.ValueMember = "id";
                cmbnombrecolum.DataSource = dttablas;
            }catch(Exception ex)
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
            agregartabla();
            ConsultarTablas();
            limpiar();
        }



        private void cmbdato01_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void agregartabla()
        {
            Logica.Creartabla agregar = new Logica.Creartabla();
            try
            {
                if (txtnombretabla.Text != " ")
                {
                    if (txtnombrecolumna.Text != " ")
                    {
                        if (chkidentity.Checked)
                        {
                            if (cmbdato01.Text == "INT" || cmbdato01.Text == "DECIMAL")
                            {
                                agregar.agregartablaidentity(txtnombretabla.Text, txtnombrecolumna.Text, cmbdato01.Text, txtideini.Text, txtidefin.Text);
                                MessageBox.Show("Tabla " + txtnombretabla.Text + " y columna " + txtnombrecolumna.Text + " agregadas correctamente");
                            }
                            else
                            {
                                MessageBox.Show("La función Identity solo funciona con datos numericos (INT o DOUBLE)");
                            }
                        }
                        else
                        {
                            if (chkdefault.Checked)
                            {
                                if(cmbdato01.Text == "INT" || cmbdato01.Text == "DECIMAL" || cmbdato01.Text == "BIT" || cmbdato01.Text == "DATETIME" || cmbdato01.Text == "DATE")
                                {
                                    agregar.agregartabkaenteradef(txtnombretabla.Text, txtnombrecolumna.Text, cmbdato01.Text, txtdefault.Text);
                                    MessageBox.Show("Tabla " + txtnombretabla.Text + " y columna " + txtnombrecolumna.Text + " agregadas correctamente");
                                }
                                else
                                {
                                    agregar.agregartabladef(txtnombretabla.Text,txtnombrecolumna.Text,cmbdato01.Text,txttama01.Text,txtdefault.Text);
                                    MessageBox.Show("Tabla " + txtnombretabla.Text + " y columna " + txtnombrecolumna.Text + " agregadas correctamente");
                                }
                            }
                            else
                            {
                                if (cmbdato01.Text == "INT" || cmbdato01.Text == "DECIMAL" || cmbdato01.Text == "BIT" || cmbdato01.Text == "DATETIME" || cmbdato01.Text == "DATE")
                                {
                                    agregar.agregartablaentera(txtnombretabla.Text, txtnombrecolumna.Text, cmbdato01.Text);
                                    MessageBox.Show("Tabla " + txtnombretabla.Text + " y columna " + txtnombrecolumna.Text + " agregadas correctamente");
                                }
                                else
                                {
                                    agregar.agregartabla(txtnombretabla.Text, txtnombrecolumna.Text, cmbdato01.Text, txttama01.Text);
                                    MessageBox.Show("Tabla " + txtnombretabla.Text + " y columna " + txtnombrecolumna.Text + " agregadas correctamente");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sin Nombre de Columna");
                    }
                }
                else
                {
                    MessageBox.Show("Sin Nombre de Tabla");
                }
            }
            catch
            {
                MessageBox.Show("Error de sintaxis, favor revisar");
            }
        }

        public void limpiarTodo()
        {
            txttama01.Text = " ";
            txtnombretabla.Text = " ";
            txtnombrecolumna.Text = " ";
            txtideini.Text = " ";
            txtidefin.Text = " ";
            llenarcombo();
            chkidentity.Checked = false;
            cmbnombretabla.Text = " ";
            cmbnombrecolum.Text = " ";
        }

        private void btnagregarcolum_Click(object sender, EventArgs e)
        {
            agregarcolumna();
            ConsultarTablas();
            limpiar();
        }

        private void brnlimpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }
        private void limpiar()
        {
            txttama01.Text = " ";
            txtnombrecolumna.Text = " ";
            txtideini.Text = " ";
            txtidefin.Text = " ";
            llenarcombo();
            chkidentity.Checked = false;
            chkdefault.Checked = false;
            txtdefault.Text = " ";
            cmbnombretabla.Text = " ";
            cmbnombrecolum.Text = " ";
        }
        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            ConsultarTablas();
            llenarcombo();
        }
        private void agregarcolumna()
        {
            Logica.Creartabla agregar = new Logica.Creartabla();
            try
            {
                if (txtnombretabla.Text != " ")
                {
                    if (txtnombrecolumna.Text != " ")
                    {
                        if (chkidentity.Checked)
                        {
                            MessageBox.Show("Función Identity solo disponible al crear la primera columna para este IDE");
                        }
                        else
                        {
                            if (chkdefault.Checked)
                            {
                                if(cmbdato01.Text == "INT" || cmbdato01.Text == "DECIMAL" || cmbdato01.Text == "BIT" || cmbdato01.Text == "DATETIME" || cmbdato01.Text == "DATE")
                                {
                                    agregar.agregarcolumnaenteradefa(txtnombretabla.Text,txtnombrecolumna.Text,cmbdato01.Text,txtdefault.Text);
                                    MessageBox.Show("Columna " + txtnombrecolumna.Text + " agregada correctamente");
                                }
                                else
                                {
                                    agregar.agregarcolumnadefa(txtnombretabla.Text,txtnombrecolumna.Text,cmbdato01.Text,txttama01.Text,txtdefault.Text);
                                    MessageBox.Show("Columna " + txtnombrecolumna.Text + " agregada correctamente");
                                }
                            }else
                            {
                                if (cmbdato01.Text == "INT" || cmbdato01.Text == "DECIMAL" || cmbdato01.Text == "BIT" || cmbdato01.Text == "DATETIME" || cmbdato01.Text == "DATE")
                                {
                                    agregar.agregarcolumnaentera(txtnombretabla.Text, txtnombrecolumna.Text, cmbdato01.Text);
                                    MessageBox.Show("Columna " + txtnombrecolumna.Text + " agregada correctamente");
                                }
                                else
                                {
                                    agregar.agregarcolumna(txtnombretabla.Text, txtnombrecolumna.Text, cmbdato01.Text, txttama01.Text);
                                    MessageBox.Show("Columna " + txtnombrecolumna.Text + " agregada correctamente");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sin Nombre de Columna");
                    }
                }
                else
                {
                    MessageBox.Show("Sin Nombre de Tabla");
                }
            }
            catch
            {
                MessageBox.Show("Error de sintaxis, favor revisar");
            }
        }

        private void dtgtablas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            seleccionardtgtablas();
        }
        public void seleccionardtgtablas()
        {
            cmbnombretabla.Text = dtgtablas.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnllenardtg_Click(object sender, EventArgs e)
        {

        }

        private void cmbnombrecolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbnombrecolum_Click(object sender, EventArgs e)
        {
            llenarcombocolumnas();
        }

        private void cmbnombretabla_Click(object sender, EventArgs e)
        {
            llenarcombotablas();
        }
    }
}
