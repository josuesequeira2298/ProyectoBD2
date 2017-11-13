using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private SqlConnection oCN = new SqlConnection("Data Source=proyectodb02.database.windows.net;Persist Security Info=True;User ID=administrador");

        public bool abrirConexion()
        {
            try
            {
                oCN.Open();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool cerrarConexion()
        {
            try
            {
                if (oCN.State == ConnectionState.Closed)
                {
                    return true;
                }
                oCN.Close();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                oCN.Close();
            }

        }

        public DataTable ejecutar(String txtSelect)
        {
            SqlCommand cSelect = new SqlCommand();
            DataTable oDT = new DataTable();
            SqlDataAdapter oSQLDA = new SqlDataAdapter(cSelect);

            try
            {
                cSelect.CommandText = txtSelect;
                cSelect.Connection = oCN;
            }
            catch (Exception)
            {

                throw;
            }
            if (abrirConexion())
            {
                oSQLDA.Fill(oDT);
            }
            cerrarConexion();

            return oDT;
        }

        public bool ejecutarInsert(String txtInsert)
        {
            SqlCommand cInsert = new SqlCommand(txtInsert);
            try
            {
                cInsert.Connection = oCN;
                cInsert.CommandType = CommandType.Text;
                if (abrirConexion())
                {
                    cInsert.ExecuteNonQuery();
                }
                cerrarConexion();
                return true;
            }
            catch (Exception e)
            {
                throw e;

            }
        }
        public DataTable consultar(String consulta)
        {
            abrirConexion();
            SqlCommand comando = new SqlCommand(consulta, oCN);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            cerrarConexion();
            return dt;
        }
    }
}
