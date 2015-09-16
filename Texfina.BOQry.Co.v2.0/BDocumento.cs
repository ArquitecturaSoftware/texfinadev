using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.DOQry.Co;
using Texfina.Entity.Co;

namespace Texfina.BOQry.Co
{
    public class BDocumento
    {
        public static IDataReader GetDocumento_Qry01()
        {
            return DDocumento.Mg_documento_qry01();
        }

        public static List<Dato> ObtenerDatoTfactura()
        {
            return DDocumento.ObtenerDato();
        }

    }
}
