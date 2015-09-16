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
    public class BIngreso_Detalle
    {
        public static void IngresoDetalle_mnt01(EIngresoDetalle obj)
        {
            DIngreso_Detalle.IngresoDetalle_mnt01(obj);
        }

         public static DataSet AL_IngresoDetalle_qry02(EIngresoDetalle obj)
        {
            return DIngreso_Detalle.AL_IngresoDetalle_qry02(obj);
        }

        public static List<EIngresoDetalle> AL_IngresoDetalle_qry01(EIngresoDetalle objID)
        {
            return DIngreso_Detalle.AL_IngresoDetalle_qry01(objID);
        }


        public static List<EIngresoDetalle> AL_IngresoDetalle_qry03(EIngresoDetalle objID)
        {
            return DIngreso_Detalle.AL_IngresoDetalle_qry03(objID);
        }

        public static void AL_Ingreso_Detalle_mnt03(EIngresoDetalle obj)
        {
            DIngreso_Detalle.AL_Ingreso_Detalle_mnt03(obj);
            
        }

        public static EParametros AL_Ingreso_Detalle_qry7(EParametros obj)
        {

            return DIngreso_Detalle.AL_Ingreso_Detalle_qry7(obj);
        }

        public static void AL_Ingreso_Detalle_mnt02(EIngresoDetalle obj)
        {
            DIngreso_Detalle.AL_Ingreso_Detalle_mnt02(obj);
        }

        public static DataSet AL_Producto_Stock(EIngresoDetalle obj)
        {
            return DIngreso_Detalle.AL_Producto_Stock(obj);
        }

        public static DataSet AL_Producto_Stock_TF(EIngresoDetalle obj)
        {
            return DIngreso_Detalle.AL_Ingreso_Detalle_Stock_TF(obj);
        }


        public static List<EIngresoDetalle> AL_IngresoDetalle_qry04(EIngresoDetalle objID)
        {
            return DIngreso_Detalle.AL_IngresoDetalle_qry04(objID);
        }


        public static void AL_Ingreso_Detalle_mnt04(EIngresoDetalle obj)
        {
            DIngreso_Detalle.AL_Ingreso_Detalle_mnt04(obj);

        }

        public static void AL_Ingreso_Detalle_mnt05(EIngresoDetalle obj)
        {
            DIngreso_Detalle.AL_Ingreso_Detalle_mnt05(obj);
        }

        public static void AL_Ingreso_Detalle_mnt06(EIngresoDetalle obj)
        {
            DIngreso_Detalle.AL_Ingreso_Detalle_mnt06(obj);

        }


        public DataTable AL_Ingreso_etiqueta02_rpt(EIngresoDetalle obj)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DIngreso_Detalle _obj = new DIngreso_Detalle();

            DataTable dt = _obj.AL_Ingreso_etiqueta02_rpt(obj);
            return dt;
        }



        public DataTable AL_Ingreso_etiqueta03_rpt(EIngresoDetalle obj)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DIngreso_Detalle _obj = new DIngreso_Detalle();

            DataTable dt = _obj.AL_Ingreso_etiqueta03_rpt(obj);
            return dt;
        }




        public static void AL_Ingreso_Detalle_mnt07(EIngresoDetalle obj)
        {
            DIngreso_Detalle.AL_Ingreso_Detalle_mnt07(obj);

        }

        public static List<EIngresoDetalle> AL_Ingreso_Detalle_Stock02(EIngresoDetalle obj)
        {
            return DIngreso_Detalle.AL_Ingreso_Detalle_Stock02(obj);

        }




        public static DataSet AL_Ingreso_Detalle_Stock_TF(EIngresoDetalle obj)
        {
            return DIngreso_Detalle.AL_Ingreso_Detalle_Stock_TF(obj);
        }


        public DataTable AL_Ingreso_Detalle_rpt01(EIngresoDetalle obj)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DIngreso_Detalle _obj = new DIngreso_Detalle();

            DataTable dt = _obj.AL_Ingreso_Detalle_rpt01(obj);
            return dt;
        }


        public DataTable _AL_Producto_Stock(EIngresoDetalle obj)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DIngreso_Detalle _obj = new DIngreso_Detalle();

            DataTable dt = _obj._AL_Producto_Stock(obj);

            return dt;
        }

        public DataTable _AL_Ingreso_Detalle_Stock_TF(EIngresoDetalle obj)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DIngreso_Detalle _obj = new DIngreso_Detalle();

            DataTable dt = _obj._AL_Ingreso_Detalle_Stock_TF(obj);

            return dt;
        }

   }
}
