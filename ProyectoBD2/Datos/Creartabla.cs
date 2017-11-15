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
        Conexion conect = new Conexion();
        Conexion consultar = new Conexion();

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
            DtDatos = conectar.ejecutar("select * from tipodato");
            return DtDatos;

        }

        public bool agregartablaidentity(string nombretabla, string nombrecolumna, string tipodato, string inicioide, string finide)
        {
            bool agregandotablas;
            bool agregandotabla02;

            agregandotabla02 = conect.ejecutarInsert("insert into Tablas (Nombre) values ('"+nombretabla+"')");
            agregandotablas = conect.ejecutarInsert("create table "+nombretabla+"("+nombrecolumna+" "+tipodato+" identity ("+inicioide+","+finide+"))");
            if (agregandotablas)
            {
                return true;
            }
            return false;
        }



    }

}


