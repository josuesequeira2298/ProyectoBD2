using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Creartabla
    {
        public DataTable ConsultarTablas()
        {
            return new Datos.Creartabla().ConsultarTablas();
        }
        public DataTable consultarcolumnas(string nombretabla)
        {
            return new Datos.Creartabla().consultarcolumnas(nombretabla);
        }
        
        public DataTable llenarcombo()
        {
            Datos.Creartabla Datos = new Datos.Creartabla();
            return Datos.llenarcombo();
        }
        public DataTable llenarcombotabla()
        {
            Datos.Creartabla datos = new Datos.Creartabla();
            return datos.llenarcombotabla();
        }

        public DataTable llenarcomboid(string nombretabla)
        {
            Datos.Creartabla Datos = new Datos.Creartabla();
            return Datos.llenarcomboid(nombretabla);
        }

        public DataTable llenarcombocolumna(string nombretabla)
        {
            Datos.Creartabla datos = new Datos.Creartabla();
            return datos.llenarcombocolumna(nombretabla);
        }
        public bool eliminarcolumna(string nombretabla, string nombrecolumna)
        {
            return new Datos.Creartabla().eliminarcolumna(nombretabla, nombrecolumna);
        }
        public bool eliminartabla(string nombretabla)
        {
            return new Datos.Creartabla().eliminartabla(nombretabla);
        }
        public bool agregartablaidentity(string nombretabla, string nombrecolumna, string tipodato, string inicioide, string finide)
        {
            return new Datos.Creartabla().agregartablaidentity(nombretabla, nombrecolumna, tipodato, inicioide, finide);
        }

        public bool agregartabla02(string nombretabla)
        {
            return new Datos.Creartabla().agregartabla02(nombretabla);
        }
        public bool agregartabla(string nombretabla, string nombrecolumna, string tipodato, string tama)
        {
            return new Datos.Creartabla().agregartabla(nombretabla, nombrecolumna, tipodato, tama);
        }
        public bool agregartablaentera(string nombretabla, string nombrecolumna, string tipodato)
        {
            return new Datos.Creartabla().agregartablaentera(nombretabla, nombrecolumna, tipodato);
        }
        public bool agregartabkaenteradef(string nombretabla, string nombrecolumna, string tipodato, string defal)
        {
            return new Datos.Creartabla().agregartabkaenteradef(nombretabla,nombrecolumna,tipodato,defal);
        }
        public bool agregartabladef(string nombretabla, string nombrecolumna, string tipodato, string tama, string def)
        {
            return new Datos.Creartabla().agregartabladef(nombretabla,nombrecolumna,tipodato,tama,def);
        }
        public bool agregarcolumnaidentity(string nombretabla, string nombrecolumna, string tipodato, string inicioide, string finide)
        {
            return new Datos.Creartabla().agregarcolumnaidentity(nombretabla, nombrecolumna, tipodato, inicioide, finide);
        }
        public bool agregarcolumna(string nombretabla, string nombrecolumna, string tipodato, string tama)
        {
            return new Datos.Creartabla().agregarcolumna(nombretabla, nombrecolumna, tipodato, tama);
        }
        public bool agregarcolumnaentera(string nombretabla, string nombrecolumna, string tipodato)
        {
            return new Datos.Creartabla().agregarcolumnaentera(nombretabla, nombrecolumna, tipodato);
        }
        public bool agregarcolumnaFECHA(string nombretabla, string nombrecolumna, string tipodato)
        {
            return new Datos.Creartabla().agregarcolumnaFECHA(nombretabla, nombrecolumna, tipodato);
        }
        public bool agregarcolumnadefa(string nombretabla, string nombrecolumna, string tipodato, string tama, string defa)
        {
            return new Datos.Creartabla().agregarcolumnadefa(nombretabla, nombrecolumna, tipodato, tama, defa);
        }
        public bool agregarcolumnaenteradefa(string nombretabla, string nombrecolumna, string tipodato, string defa)
        {
            return new Datos.Creartabla().agregarcolumnaenteradefa(nombretabla, nombrecolumna, tipodato, defa);
        }

        public bool eliminarfilas(string nombretabla, string id)
        {
            return new Datos.Creartabla().eliminarfilas(nombretabla, id);
        }

        public bool update(string nombretabla, string nombreclumna, string dato, string id)
        {
            return new Datos.Creartabla().update(nombretabla, nombreclumna, dato, id);
        }

        public bool insert(string nombretabla, string nombreclumna, string dato)
        {
            return new Datos.Creartabla().insert(nombretabla, nombreclumna, dato);
        }

        public DataTable select(string nombretabla1, string nombretabla2, string dato1, string dato2)
        {
            return new Datos.Creartabla().selecttablas(nombretabla1, nombretabla2, dato1, dato2);
        }
    }
}
