using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;

namespace Texfina.BOQry.Co
{
    public class BOrdenCompra
    {
        public static DataSet OrderCompra_qry01(EOrdenCompra oc)
        {
            return DOrdenCompra.OrdenCompra_qry01(oc);
        }

        public static DataSet OrderCompra_qry001(EOrdenCompra oc)
        {
            return DOrdenCompra.OrdenCompra_qry001(oc);
        }
        /// <summary>
        /// obtener el codigo de la oc en web
        /// </summary>
        /// <param name="oc"></param>
        /// <returns></returns>
        /// 


        public static IDataReader OrderCompra_qry02(string idperiodo, string idEmpresa)
        {
            return DOrdenCompra.OrdenCompra_qry03(idperiodo, idEmpresa);
        }


     /// <summary>
        /// obtener el codigo en descktop
        /// </summary>
        /// <param name="prov"></param>
        /// <returns></returns>
        public static List<Dato> OrderCompra_qry02_(string idperiodo, string idEmpresa)
        {

            return DOrdenCompra.OrdenCompra_qry03_("MG_GencodigoComp", "idOrdenCompra", idperiodo, idEmpresa);
        }

        public static DataSet OrderCompra_qry02(EOrdenCompra oc)
        {
            return DOrdenCompra.OrdenCompra_qry02(oc);
        }
   

        public static DataSet OrderCompra_qry002(EOrdenCompra oc)
        {
            return DOrdenCompra.OrdenCompra_qry002(oc);
        }

        /// <summary>
        /// Autorizar la OC
        /// </summary>
        /// <param name="oc"></param>
        /// <returns></returns>
        public static DataSet OrderCompra_mnt01(EOrdenCompra oc)
        {
            return DOrdenCompra.OrdenCompra_mnt01(oc);
        }


        public static DataSet OrderCompra_Habilitar(EOrdenCompra oc)
        {
            return DOrdenCompra.OrdenCompra_Habilitar(oc);
        }
        /// <summary>
        /// aprobacion de la oc
        /// </summary>
        /// <param name="oc"></param>
        /// <returns></returns>
        public static DataSet OrderCompra_mnt02(EOrdenCompra oc)
        {
            return DOrdenCompra.OrdenCompra_mnt02(oc);
        }


        public static void OrderCompra_mnt03(EOrdenCompra oc)
        {
            DOrdenCompra.OrdenCompra_mnt03(oc);
        }


        public static DataSet OrderCompra_qry04(EParOCFillrpt parametro)

        {
            //String periodo, String idEmpresa,String idOrdenCompra, String idProv, String feini, String fefin, String local,String dsproducto
            return DOrdenCompra.OrdenCompra_qry04(parametro);
        }


        public static EOrdenCompra mObtenerOC(EOrdenCompra oCompra)
        {
            return DOrdenCompra.mObtenerOCompra(oCompra);
        }


        public static IDataReader OrderCompra_Usuario_qry(String dsRs)
        {
            return DOrdenCompra.OrdenCompra_Usuario_qry(dsRs);
        }

        /// <summary>
        /// codigo para desktop 
        /// </summary>
        
        /// <returns></returns>
        /// 
        public static List<Dato> OrderCompra_Usuario_qry_(String dsRs)
        {
            return DOrdenCompra.OrdenCompra_Usuario_qry_(dsRs);
        }


        public static EOrdenCompra mObtenerOC_(EOrdenCompra oCompra)
        {
            return DOrdenCompra.mObtenerOCompra_(oCompra);
        }

        public static EOrdenCompra mObtenerOCEstado(EOrdenCompra oCompra)
        {
            return DOrdenCompra.mObtenerOCompraEstado(oCompra);
        }


        public void GrabarPersona(EDetProducto oData)
        {
            //grabas los datos;
        }

        //---------------REPORTES-----------------------------------------


        public DataTable OrderCompra_rpt01(EParOCFillrpt oc)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DOrdenCompra objOC = new DOrdenCompra();

            DataTable dt = objOC.GetOrdenCompra_rpt01(oc);
            return dt;
        }


        public DataTable OrderCompra_rpt02(EParOCFillrpt oc)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DOrdenCompra objOC = new DOrdenCompra();

            DataTable dt = objOC.GetOrdenCompra_rpt02(oc);
            return dt;
        }

        public DataTable OrderCompra_rpt03(EParOCFillrpt oc)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DOrdenCompra objOC = new DOrdenCompra();

            DataTable dt = objOC.GetOrdenCompra_rpt03(oc);
            return dt;
        }

        //orden de compra por proveedor

        public DataTable OrderCompra_rpt04(EParOCFillrpt oc)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DOrdenCompra objOC = new DOrdenCompra();

            DataTable dt = objOC.GetOrdenCompra_rpt02(oc);
            return dt;
        }


        public static List<EOrdenCompra> CO_Oc_qry05(EOrdenCompra oOC)
        {
            return DOrdenCompra.CO_OrdenCompra_qry05(oOC);
        }



        //public DataTable CO_OrdenCompra_qry07_rpt(EParOCFillrpt oc)
        //{

        //    //return DOrdenCompra.OrdenCompra_rpt01(oc);
        //    DOrdenCompra objOC = new DOrdenCompra();

        //    DataTable dt = objOC.CO_OrdenCompra_qry07_rpt(oc);
        //    return dt;
        //}


        public static void CO_OrdenCompra_qry07_rpt(EParOCFillrpt oc)
        {
            DOrdenCompra.CO_OrdenCompra_qry07_rpt(oc);
        }


        

        public DataTable CO_OrdenCompra_qry06_rpt(EParOCFillrpt oc)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DOrdenCompra objOC = new DOrdenCompra();

            DataTable dt = objOC.CO_OrdenCompra_qry06_rpt(oc);
            return dt;
        }

        public DataTable CO_OrdenCompra_qry08_rpt(EParOCFillrpt oc)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DOrdenCompra objOC = new DOrdenCompra();

            DataTable dt = objOC.CO_OrdenCompra_qry08_rpt(oc);
            return dt;
        }


        ///* ADICIONAL */
        //public DataTable CO_OrdenCompra_qry10_rpt(EParOCFillrpt oc)
        //{

        //    //return DOrdenCompra.OrdenCompra_rpt01(oc);
        //    DOrdenCompra objOC = new DOrdenCompra();

        //    DataTable dt = objOC.CO_OrdenCompra_qry07_rpt(oc);
        //    return dt;
        //}
        ///* ADICIONAL */


        public DataTable CO_OrdenCompra_qry09_rpt(EParOCFillrpt oc)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DOrdenCompra objOC = new DOrdenCompra();

            DataTable dt = objOC.CO_OrdenCompra_qry09_rpt(oc);
            return dt;
        }


    }
}
