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
    public class BOrdPedido
    {
        public static List<Texfina.Entity.Co.Dato> OrdenPedidoGenCod_qry01_(string idperiodo, string idEmpresa)
        {
            return DOrdPedido.OrdenPedidoGenCod_qry01_(idEmpresa, idperiodo);

        }

        public static void OrdenPedido_mnt01(EOrdPedido obj)
        {
            DOrdPedido.VE_OrdPedido_mnt01(obj);
        }

        public static void OrdenPedido_mnt03(EOrdPedido obj)
        {
            DOrdPedido.VE_OrdPedido_mnt03(obj);
        }

        public static void OrdenPedido_mnt04(EOrdPedido obj)
        {
            DOrdPedido.VE_OrdPedido_mnt04(obj);
        }

        public static void OrdenPedido_mnt05(EOrdPedido obj)
        {
            DOrdPedido.VE_OrdPedido_mnt05(obj);
        }

        public static List<EOrdPedido> VE_OrdPedido_qry05(EOrdPedido obj)
        {
            return DOrdPedido.VE_OrdPedido_qry05(obj);
        }


        public static EOrdPedido VE_OrdPedido_qry01(EOrdPedido obj)
        {

            return DOrdPedido.VE_OrdPedido_qry01(obj);
        }


        public DataTable OrdenPedido_rpt01(EOrdPedido op)
        {

            DOrdPedido objop = new DOrdPedido();

            DataTable dt = objop.GetOrdenPedido_rpt01(op);
            return dt;
        }


        public static DataSet VE_OrdenPedido_qry06(EParametros obj)
        {
            return DOrdPedido.VE_OrdenPedido_qry06(obj);
        }

        public static DataSet VE_OrdenPedido_qry08(EParametros obj)
        {
            return DOrdPedido.VE_OrdenPedido_qry08(obj);
        }


        public static DataSet VE_OrdenPedido_qry07(EParametros obj)
        {
            return DOrdPedido.VE_OrdenPedido_qry07(obj);
        }


        public static DataSet VE_OrdenPedido_qry09(EParametros obj)
        {
            return DOrdPedido.VE_OrdenPedido_qry09(obj);
        }

        public static DataSet VE_OrdPedido_mnt02(EParametros obj)
        {
            return DOrdPedido.VE_OrdPedido_mnt02(obj);
        }

        public static DataSet VE_OrdenPedido_Habilitar(EParametros OP)
        {
            return DOrdPedido.VE_OrdenPedido_Habilitar(OP);
        }

        /// <summary>
        /// /////Creado por JVillavicencio
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public  DataTable VE_OrdenPedido_qry07_rpt(EParametros obj)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DOrdPedido _obj = new DOrdPedido();

            DataTable dt = _obj.VE_OrdenPedido_qry07_rpt(obj);
            
            return dt;
         
        }

    }
}
