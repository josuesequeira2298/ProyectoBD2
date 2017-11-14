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
        
        public List<Datos.listas> llenarcombo()
        {
            Datos.Creartabla lista = new Datos.Creartabla();
            return lista.llenarcombo();
        }
    }
}
