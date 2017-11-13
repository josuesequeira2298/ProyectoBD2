﻿using System;
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
        SqlConnection objConnection = new SqlConnection("Server=tcp:proyectodb02.database.windows.net,1433;Initial Catalog=ProyectoBD02;Persist Security Info=False;User ID=administrador;Password=Admin12.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private bool OpenConnection()
        {
            try
            {
                objConnection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                if (objConnection.State == ConnectionState.Closed)
                {
                    return true;
                }
                objConnection.Close();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                objConnection.Close();
            }
        }

        public DataTable ExecuteQuery(SqlCommand oSQLC)
        {
            try
            {
                DataTable oDT = new DataTable();
                SqlDataAdapter oSQLDA = new SqlDataAdapter(oSQLC);
                oSQLC.Connection = objConnection;
                if (OpenConnection())
                {
                    oSQLDA.Fill(oDT);
                }
                CloseConnection();
                return oDT;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
