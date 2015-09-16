using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.Entity.Co;
using Texfina.DOQry.TJ;
using System.Data;


namespace Texfina.BOQry.TJ
{
    public class BTejido
    {

        public static void Tejido_mnt(EProducto prod)
        {
            DTejido.Tejido_mnt(prod);
        }


        public static void TejidoDet_mmt(EProdXUnd prod)
        {
           
            DTejido.TejidoDet_mnt(prod);
        }


        public static List<Dato> getCodigo(EProducto prod)
        {
            return DTejido.GenCodTejido_qry01(prod);
        }

        public static DataSet GetListFill(EProducto prod)
        {
            return DTejido.TejidoFill(prod);
        }

        public static List<EProdXUnd> mListarTejido(EProdXUnd oprod)
        {
            return DTejido.GetListTejido_qry01(oprod);
        }


        public static EProducto mListarTejido(EProducto eprod)
        {
            return DTejido.mObtenerTejido(eprod);
        }
        public static EProducto mListarTejido2(EProducto eprod)
        {
            return DTejido.mObtenerTejido2(eprod);
        }

        public static List<EProducto> MG_Tejido_qry06(EProducto oprod)
        {
            return DTejido.MG_Tejido_qry06(oprod);
        }


    }
}
