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
    }
}
