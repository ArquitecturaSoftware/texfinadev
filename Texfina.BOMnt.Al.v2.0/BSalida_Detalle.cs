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
   public class BSalida_Detalle
    {
       public static void AL_Salida_Detalle_mnt01(ESalida_Detalle obj)
       {
           DSalida_Detalle.AL_Salida_Detalle_mnt01(obj);
       }

       public static void Al_Salida_Detalle_mnt03(ESalida_Detalle obj)
       {
           DSalida_Detalle.Al_Salida_Detalle_mnt03(obj);

       }
       //anular despacho (salida)
       public static void Al_Salida_Detalle_mnt04(ESalida_Detalle obj)
       {
           DSalida_Detalle.Al_Salida_Detalle_mnt04(obj);

       }


       public static DataSet AL_Salida_Detalle_qry02(ESalida_Detalle obj)
       {
           return DSalida_Detalle.AL_Salida_Detalle_qry02(obj);
       }


       public static List<ESalida_Detalle> AL_Salida_Detalle_qry01(ESalida_Detalle objDS)
       {
           return DSalida_Detalle.AL_Salida_Detalle_qry01(objDS);
       }


       public static void VE_OrdPedido_Detalle_mnt02(ESalida_Detalle obj)
       {
           DSalida_Detalle.VE_OrdPedido_Detalle_mnt02(obj);
       }

       //public static void VE_OrdPedido_Detalle_mnt04(ESalida_Detalle obj)
       //{
       //    DSalida_Detalle.VE_OrdPedido_Detalle_mnt04(obj);
       //}


       public static List<ESalida_Detalle> AL_Salida_Detalle_qry03(ESalida_Detalle objSD)
       {
           return DSalida_Detalle.AL_Salida_Detalle_qry03(objSD);
       }



       public DataTable AL_Salida_Detalle_rpt02(ESalida_Detalle obj)
       {

           //return DOrdenCompra.OrdenCompra_rpt01(oc);
           DSalida_Detalle _obj = new DSalida_Detalle();

           DataTable dt = _obj.AL_Salida_Detalle_rpt02(obj);

           return dt;
       }


    }
}
