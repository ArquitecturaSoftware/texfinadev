using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.DOMnt.Al;
using Texfina.Entity.Al;

namespace Texfina.BOMnt.Al
{
   public class BlistPrecio_Detalle
    {
       public static DataSet AL_ListaPrecio_qry(ElistPrecio_Detalle obj)
       {
           return DlistPrecio_Detalle.AL_ListaPrecio_qry(obj);
       }
    }
}
