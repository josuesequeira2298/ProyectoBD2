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

        public DataTable consultarcolumnas(string nombretabla)
        {
            Datos.Conexion conectar = new Datos.Conexion();
            DataTable dtcolumnas;
            dtcolumnas = conectar.ejecutar("select * from "+nombretabla+"");
            return dtcolumnas;
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
        public DataTable llenarcomboid(string nombretabla)
        {
            Datos.Conexion conectar = new Datos.Conexion();
            DataTable dttablas;
            dttablas = conectar.ejecutar("select ID from "+nombretabla+"");
            return dttablas;
        }
        public DataTable llenarcombocolumna(string nombretabla)
        {
            Datos.Conexion conectar = new Datos.Conexion();
            DataTable dttablas;
            dttablas = conectar.ejecutar("select * from Columnas where NombreTabla = '" + nombretabla + "'");
            return dttablas;
        }

        public bool eliminarcolumna(string nombretabla, string nombrecolumna)
        {
            bool eliminandocolumna;
            bool eliminandocolumna02;
            bool eliminandocolumna03;

            eliminandocolumna = conect.ejecutarInsert("alter table "+nombretabla+" drop column "+nombrecolumna+"");
            if (eliminandocolumna)
            {
                eliminandocolumna02 = conect.ejecutarInsert("UPDATE Tablas SET Numero_Columnas = (Numero_Columnas-1)where Nombre = '" + nombretabla + "'");
                eliminandocolumna03 = conect.ejecutarInsert("delete from Columnas where NombreTabla = '"+nombretabla+"' and NombreColumna = '"+nombrecolumna+"'");
                return true;
            }
            return false;
        }

        public bool eliminartabla(string nombretabla)
        {
            bool eliminartabla;
            bool eliminartabla2;
            bool eliminartabla3;

            eliminartabla = conect.ejecutarInsert("drop table "+nombretabla+"");
            if (eliminartabla)
            {
                eliminartabla2 = conect.ejecutarInsert("delete from Columnas where NombreTabla = '"+nombretabla+"' ");
                eliminartabla3 = conect.ejecutarInsert("delete from Tablas where Nombre = '"+nombretabla+"';");
                return true;
            }
            return false;
        }
        public bool agregartabla02(string nombretabla)
        {
            bool agregandotablas;
            bool agregandotabla02;
            bool agregandotabla03;

            agregandotablas = conect.ejecutarInsert("create table " + nombretabla + "(ID int identity (1,1))");
            if (agregandotablas)
            {
                agregandotabla02 = conect.ejecutarInsert("insert into Tablas (Nombre) values ('" + nombretabla + "')");
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','ID')");
                return true;
            }
            return false;
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

            agregandotablas = conect.ejecutarInsert("alter table " + nombretabla + " add " + nombrecolumna + " " + tipodato + "(" + tama + ") default '';");
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

            agregandotablas = conect.ejecutarInsert("alter table "+nombretabla+" add "+nombrecolumna+" "+tipodato+" default '0'");
            if (agregandotablas)
            {
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','" + nombrecolumna + "')");
                agregandotabla02 = conect.ejecutarInsert("UPDATE Tablas SET Numero_Columnas = (Numero_Columnas+1) where Nombre = '" + nombretabla + "'");
                return true;
            }
            return false;
        }

        public bool agregarcolumnaFECHA(string nombretabla, string nombrecolumna, string tipodato)
        {
            bool agregandotablas;
            bool agregandotabla02;
            bool agregandotabla03;

            agregandotablas = conect.ejecutarInsert("alter table "+nombretabla+" add "+nombrecolumna+" "+tipodato+" default '20170101'");
            if (agregandotablas)
            {
                agregandotabla03 = conect.ejecutarInsert("insert into Columnas (NombreTabla, NombreColumna) values ('" + nombretabla + "','" + nombrecolumna + "')");
                agregandotabla02 = conect.ejecutarInsert("UPDATE Tablas SET Numero_Columnas = (Numero_Columnas+1) where Nombre = '" + nombretabla + "'");
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

        public bool eliminarfilas(string nombretabla, string id)
        {
            bool eliminarfila;

            eliminarfila = conect.ejecutarInsert("delete from " + nombretabla + " where ID = '" + id + "'");
            if (eliminarfila)
            {
                return true;
            }
            return false;
        }

        public bool update(string nombretabla, string nombreclumna, string dato, string id)
        {
            bool updatetabla;

            updatetabla = conect.ejecutarInsert("update " + nombretabla + " set  " + nombreclumna + " = '" + dato + "' where ID = '" + id + "'");
            if (updatetabla)
            {
                return true;
            }
            return false;
        }

        public bool insert(string nombretabla, string nombreclumna, string dato)
        {
            bool insertar;

            insertar = conect.ejecutarInsert("insert into " + nombretabla + " (" + nombreclumna + ") values ('" + dato + "')");
            if (insertar)
            {
                return true;
            }
            return false;
        }

        public DataTable selecttablas(string nombretabla1, string nombretabla2, string dato1, string dato2)
        {
          
            Datos.Conexion conectar = new Datos.Conexion();
            DataTable dttablas;
            dttablas = conectar.ejecutar("select J." + dato1 + ", p." + dato2 + " from " + nombretabla1 + " J, " + nombretabla2 + " P where J.ID = P.ID;");
            return dttablas;
        }

    }

}


