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

        public DataTable llenarcombotabla()
        {
            Datos.Conexion conectar = new Datos.Conexion();
            DataTable dttablas;
            dttablas = conectar.ejecutar("select * from Tablas");
            return dttablas;
        }
        public DataTable llenarcombocolumna(string nombretabla)
        {
            Datos.Conexion conectar = new Datos.Conexion();
            DataTable dttablas;
            dttablas = conectar.ejecutar("select * from Columnas where NombreTabla = '" + nombretabla + "'");
            return dttablas;
        }

        public bool agregartablaidentity(string nombretabla, string nombrecolumna, string tipodato, string inicioide, string finide)
        {
            bool agregandotablas;
            bool agregandotabla02;
            bool agregandotabla03;


            agregandotablas = conect.ejecutarInsert("create table " + nombretabla + "(" + nombrecolumna + " " + tipodato + " identity (" + inicioide + "," + finide + "))");
            if (agregandotablas)
            {
                agregandotabla02 = conect.ejecutarInsert("insert into Tablas (Nombre) values ('" + nombretabla + "')");
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','" + nombrecolumna + "')");
                return true;
            }
            return false;
        }
        public bool agregartabla(string nombretabla, string nombrecolumna, string tipodato, string tama)
        {
            bool agregandotablas;
            bool agregandotabla02;
            bool agregandotabla03;


            agregandotablas = conect.ejecutarInsert("create table " + nombretabla + "(" + nombrecolumna + " " + tipodato + "(" + tama + "));");
            if (agregandotablas)
            {
                agregandotabla02 = conect.ejecutarInsert("insert into Tablas (Nombre) values ('" + nombretabla + "')");
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','" + nombrecolumna + "')");
                return true;
            }
            return false;
        }
        public bool agregartablaentera(string nombretabla, string nombrecolumna, string tipodato)
        {
            bool agregandotablas;
            bool agregandotabla02;
            bool agregandotabla03;

            agregandotablas = conect.ejecutarInsert("create table " + nombretabla + "(" + nombrecolumna + " " + tipodato + ")");
            if (agregandotablas)
            {
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','" + nombrecolumna + "')");
                agregandotabla02 = conect.ejecutarInsert("insert into Tablas (Nombre) values ('" + nombretabla + "')");
                return true;
            }
            return false;
        }
        public bool agregartabkaenteradef(string nombretabla, string nombrecolumna, string tipodato, string defal)
        {
            bool agregandotablas;
            bool agregandotabla02;
            bool agregandotabla03;


            agregandotablas = conect.ejecutarInsert("create table " + nombretabla + " (" + nombrecolumna + " " + tipodato + " default " + defal + ")");
            if (agregandotablas)
            {
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','" + nombrecolumna + "')");
                agregandotabla02 = conect.ejecutarInsert("insert into Tablas (Nombre) values ('" + nombretabla + "')");
                return true;
            }
            return false;
        }
        public bool agregartabladef(string nombretabla, string nombrecolumna, string tipodato, string tama, string def)
        {
            bool agregandotablas;
            bool agregandotabla02;
            bool agregandotabla03;

            agregandotablas = conect.ejecutarInsert("create table " + nombretabla + " (" + nombrecolumna + " " + tipodato + "(" + tama + ") default '" + def + "')");
            if (agregandotablas)
            {
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','" + nombrecolumna + "')");
                agregandotabla02 = conect.ejecutarInsert("insert into Tablas (Nombre) values ('" + nombretabla + "')");
                return true;
            }
            return false;
        }
        public bool agregarcolumnaidentity(string nombretabla, string nombrecolumna, string tipodato, string inicioide, string finide)
        {
            bool agregandotablas;
            bool agregandotabla02;
            bool agregandotabla03;

            agregandotablas = conect.ejecutarInsert("alter table " + nombretabla + " add " + nombrecolumna + " " + tipodato + " identity(" + inicioide + "," + finide + ");");
            if (agregandotablas)
            {
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','" + nombrecolumna + "')");
                agregandotabla02 = conect.ejecutarInsert("UPDATE Tablas SET Numero_Columnas = (Numero_Columnas+1)where Nombre = '" + nombretabla + "'");
                return true;
            }
            return false;
        }
        public bool agregarcolumna(string nombretabla, string nombrecolumna, string tipodato, string tama)
        {
            bool agregandotablas;
            bool agregandotabla02;
            bool agregandotabla03;

            agregandotablas = conect.ejecutarInsert("alter table " + nombretabla + " add " + nombrecolumna + " " + tipodato + "(" + tama + ");");
            if (agregandotablas)
            {
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','" + nombrecolumna + "')");
                agregandotabla02 = conect.ejecutarInsert("UPDATE Tablas SET Numero_Columnas = (Numero_Columnas+1)where Nombre = '" + nombretabla + "'");
                return true;
            }
            return false;
        }
        public bool agregarcolumnaentera(string nombretabla, string nombrecolumna, string tipodato)
        {
            bool agregandotablas;
            bool agregandotabla02;
            bool agregandotabla03;

            agregandotablas = conect.ejecutarInsert("alter table " + nombretabla + " add " + nombrecolumna + " " + tipodato + "");
            if (agregandotablas)
            {
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','" + nombrecolumna + "')");
                agregandotabla02 = conect.ejecutarInsert("UPDATE Tablas SET Numero_Columnas = (Numero_Columnas+1)where Nombre = '" + nombretabla + "'");
                return true;
            }
            return false;
        }
        public bool agregarcolumnadefa(string nombretabla, string nombrecolumna, string tipodato, string tama, string defa)
        {
            bool agregandotablas;
            bool agregandotabla02;
            bool agregandotabla03;

            agregandotablas = conect.ejecutarInsert("alter table " + nombretabla + " add " + nombrecolumna + " " + tipodato + "(" + tama + ") default '" + defa + "'");
            if (agregandotablas)
            {
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','" + nombrecolumna + "')");
                agregandotabla02 = conect.ejecutarInsert("UPDATE Tablas SET Numero_Columnas = (Numero_Columnas+1)where Nombre = '" + nombretabla + "'");
                return true;
            }
            return false;
        }
        public bool agregarcolumnaenteradefa(string nombretabla, string nombrecolumna, string tipodato, string defa)
        {
            bool agregandotablas;
            bool agregandotabla02;
            bool agregandotabla03;

            agregandotablas = conect.ejecutarInsert("alter table " + nombretabla + " add " + nombrecolumna + " " + tipodato + " default " + defa + "");
            if (agregandotablas)
            {
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','" + nombrecolumna + "')");
                agregandotabla02 = conect.ejecutarInsert("UPDATE Tablas SET Numero_Columnas = (Numero_Columnas+1)where Nombre = '" + nombretabla + "'");
                return true;
            }
            return false;
        }

    }

}


