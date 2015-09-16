using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;
using System.Data;

namespace Texfina.BOQry.Co
{
    public class BFactura
    {
        public static void Factura_mnt01(EFactura oc)
        {
            DFactura.Factura_mnt01(oc);
        }

        public static void Factura_mnt02(EDetOrdenCompra oc)
        {
            DFactura.Factura_mnt02(oc);
        }

        public static void CierreCompra_mnt02(EOrdenCompra oc)
        {
            DFactura.FacturaCierre_qry01(oc);
        }

        public DataTable Factura_rpt01(EParOCFillrpt fc)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
       
            DFactura objfac = new DFactura();
            DataTable dt = objfac.GetFactura_rpt01(fc);

            return dt;
        }



        public static IDataReader Factura_qry01(string idPeriodo, string idEmpresa )
        {
            return DFactura.Factura_qry01(idPeriodo,idEmpresa);
        }

        public static DataSet Factura_qry01(String idPeriodo, String idEmpresa, String nuFactura, String dsProv, String feini, String fefin, String dsproducto, String idoc)
        {
            return DFactura.Factura_qry01(idPeriodo, idEmpresa, nuFactura, dsProv, (feini), (fefin),  dsproducto, idoc);
        }


        public static DataSet Factura_rpt(String periodo, String idEmpresa, String fechaini, String fechafin, String exportacion, String importacion, String nufac, String NuOC)
        {
            return DFactura.factura_rpt(periodo, idEmpresa, fechaini, fechafin, (exportacion), (importacion), nufac, NuOC);
        }



        public DataTable Factura_rpt02(EParOCFillrpt oc)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DFactura objOC = new DFactura();

            DataTable dt = objOC.GetFctura_rpt02(oc);
            return dt;
        }

        public static EFactura mObtenerfac(EFactura ofactura)
        {
            return DFactura.mObtenerFactura(ofactura);
        }
    }
}
