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
        private SqlConnection oCN = new SqlConnection(@"Data Source=proyectodb02.database.windows.net;Initial Catalog=ProyectoBD02;Persist Security Info=True;User ID=administrador; Password=Admin12.");
        //private SqlConnection oCN = new SqlConnection(@"Data Source=DESKTOP-IVNC8A5\SQL2014;Initial Catalog=ProyectoBD02;Integrated Security=True");
        //private SqlConnection oCN = new SqlConnection(@"Data Source=JOSU;Initial Catalog=ProyectoBD02;Integrated Security=True");

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
