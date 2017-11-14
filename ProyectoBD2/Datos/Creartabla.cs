using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Creartabla
    {
        string Cadena = @"Data Source=DESKTOP-IVNC8A5\SQL2014;Initial Catalog=ProyectoBD02;Integrated Security=True";
        SqlConnection objConexion;
        SqlCommand objComando;
        List<listas> listadolistas;

        public DataTable ConsultarTablas()
        {
            Datos.Conexion conectar = new Datos.Conexion();
            DataTable dttablas;
            dttablas = conectar.ejecutar("select * from Tablas");
            return dttablas;


        }

        public DataTable llenarcombo()
        {
            Datos.Conexion conectar = new Datos.Conexion();
            DataTable DtDatos;
            DtDatos = conectar.ejecutar("SELECT Id_Persona as Identificación, Activo as Activo from dbo.Cliente");
            return DtDatos;

            //    try
            //    {

            //        SqlDataReader dr;
            //        Conectar(true);
            //        objComando = new SqlCommand();
            //        objComando.Connection = objConexion;
            //        objComando.CommandTimeout = 0;
            //        objComando.CommandType = CommandType.Text;
            //        objComando.CommandText = "select Nombre from tipodato";

            //        listadolistas = new List<listas>();

            //        dr = objComando.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            listas objlistas = new listas();
            //            objlistas.Datos = dr.GetString(1);
            //            listadolistas.Add(objlistas);
            //        }

            //    }
            //    catch(Exception ex)
            //    {
            //        ex.ToString();
            //    }
            //    datos = listadolistas;
            //    return datos;

        }

            private void Conectar(bool pConectar)
            {
                objConexion = new SqlConnection();
                objConexion.ConnectionString = Cadena;
                if (pConectar)
                {
                    objConexion.Open();
                }
                else
                {
                    objConexion.Close();

                }
            }

        }
    }

