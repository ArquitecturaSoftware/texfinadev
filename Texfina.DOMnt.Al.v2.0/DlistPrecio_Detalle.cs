using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.Core.Data;
using Texfina.Entity.Al;

namespace Texfina.DOMnt.Al
{
   public class DlistPrecio_Detalle
    {
       public static DataSet AL_ListaPrecio_qry(ElistPrecio_Detalle obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@psintypesel", obj.psintypesel);
           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@ds_producto", obj.ds_producto);
           db.AddParameter("@nu_tf", obj.NuTF);




           return db.ExecuteDataSet("Al_ListadoPrecio_qry");
       }
    }
}
