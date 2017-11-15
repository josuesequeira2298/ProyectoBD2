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
                            if (cmbdato01.Text == "INT")
                            {
                                agregar.agregartablaidentity(txtnombretabla.Text, txtnombrecolumna.Text, cmbdato01.Text, txtideini.Text, txtidefin.Text);
                            }
                            else
                            {
                                MessageBox.Show("La función Identity solo funciona con datos enteros (INT)");
                            }
                        }
                        else
                        {
                            if (cmbdato01.Text == "INT")
                            {
                                agregar.agregartablaentera(txtnombretabla.Text, txtnombrecolumna.Text, cmbdato01.Text);
                            }
                            else
                            {
                                agregar.agregartabla(txtnombretabla.Text, txtnombrecolumna.Text, cmbdato01.Text, txttama01.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error Desconocido (" + ex.ToString() + ")");
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
                            if (cmbdato01.Text == "INT")
                            {
                                agregar.agregarcolumnaentera(txtnombretabla.Text, txtnombrecolumna.Text, cmbdato01.Text);
                            }
                            else
                            {
                                agregar.agregarcolumna(txtnombretabla.Text, txtnombrecolumna.Text, cmbdato01.Text, txttama01.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error Desconocido (" + ex.ToString() + ")");
            }
        }
    }
}
