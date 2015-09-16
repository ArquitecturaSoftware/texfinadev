using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.DOMnt.Al;
using Texfina.Entity.Al;
using Texfina.Entity.Co;

namespace Texfina.BOMnt.Al
{
    public class BCliente
    {
        public static DataSet ClienteFill(ECliente prov)
        {
            return DCliente.ClienteFill(prov);
        }


        public static List<Dato> Cliente_qry06(String codigo)
        {
            return DCliente.Cliente_qry06(codigo);
        }

        public static void BCliente_mnt01(ECliente prov)
        {
            DCliente.Cliente_mnt01(prov);            
        }

        public static List<ECliente> MG_Cliente_qry05(ECliente oCliProv)
        {
            return DCliente.MG_Cliente_qry05(oCliProv);
                
        }


        public static ECliente MG_Cliente_qry02(ECliente oCliProv)
        {
            return DCliente.MG_Cliente_qry02(oCliProv);
        }

        public static DataSet DeleteCliente(ECliente oCliProv)
        {
            return DCliente.Cliente_mnt02(oCliProv);
        }

        public static List<Dato> ObtenerDatoCliente(ECliente c)
        {
            return DCliente.ObtenerDatoCliente(c);
        }


        public DataTable MG_Cliente_rpt01(ECliente c)
        {

            DCliente objop = new DCliente();

            DataTable dt = objop.MG_Cliente_rpt01(c);
            return dt;
        }

    }
}
