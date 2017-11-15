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
        
        public DataTable llenarcombo()
        {
            Datos.Creartabla Datos = new Datos.Creartabla();
            return Datos.llenarcombo();
        }
        public bool agregartablaidentity(string nombretabla, string nombrecolumna, string tipodato, string inicioide, string finide)
        {
            return new Datos.Creartabla().agregartablaidentity(nombretabla, nombrecolumna, tipodato, inicioide, finide);
        }
        public bool agregartabla(string nombretabla, string nombrecolumna, string tipodato, string tama)
        {
            return new Datos.Creartabla().agregartabla(nombretabla, nombrecolumna, tipodato, tama);
        }
        public bool agregartablaentera(string nombretabla, string nombrecolumna, string tipodato)
        {
            return new Datos.Creartabla().agregartablaentera(nombretabla, nombrecolumna, tipodato);
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
    }
}
