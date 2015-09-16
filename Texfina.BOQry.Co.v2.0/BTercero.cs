using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;
using System.Data;

namespace Texfina.BOQry.Co
{
    public class BTercero
    {
        public static void Btercero_mnt01(ETerceros prov)
        {
            DTerceros.Proveedor_mnt01(prov);
        }


        public static IDataReader Terceso_qry02(String id)
        {
            return DTerceros.Terceros_qry02(id);
        }
    /// <summary>
           /// codigo para desktop Terceso_qry02_
    /// </summary>
    /// <returns></returns>
        public static List<Dato> Terceso_qry02_(String codigo)
        {
            return DTerceros.Terceros_qry02_(codigo);
        }



    }
}
