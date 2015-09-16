using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.DOMnt.Al;

namespace Texfina.BOMnt.Al
{
    public class BAlmacen
    {
        public static List<Texfina.Entity.Co.Dato> ObtenerDatoAlmacen()
        {
            return DAlmacen.ObtenerAlmacen();
        }
    }
}
