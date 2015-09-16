using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Co;
using System.Data;
using Texfina.Core.Data;

namespace Texfina.DOQry.Co
{
   public class DOrdenCompraFactura
    {
       private static EOrdenCompraFactura mCargarOrdenCompraFact(IDataReader rdr)
       {
           EOrdenCompraFactura oCompra = new EOrdenCompraFactura();
           //oCompra.Id_periodo = rdr.IsDBNull(rdr.GetOrdinal("id_periodo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_periodo"));
           //oCompra.Id_ordenco = rdr.IsDBNull(rdr.GetOrdinal("id_ordenco")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_ordenco"));
           oCompra.Nu_secuen = rdr.IsDBNull(rdr.GetOrdinal("nu_secuen")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_secuen"));
           oCompra.Id_docucom = rdr.IsDBNull(rdr.GetOrdinal("id_docucom")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_docucom"));
           oCompra.Nu_docum = rdr.IsDBNull(rdr.GetOrdinal("nu_docum")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_docum"));

           oCompra.Fe_docum = Convert.ToDateTime(rdr.IsDBNull(rdr.GetOrdinal("fe_docum")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_docum")));

           oCompra.Mt_docum = rdr.IsDBNull(rdr.GetOrdinal("mt_docum")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_docum"));

           oCompra.ds_observa = rdr.IsDBNull(rdr.GetOrdinal("ds_observa")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_observa"));
           
           //oCompra.Id_empresa = rdr.IsDBNull(rdr.GetOrdinal("id_empresa")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_empresa"));
           return oCompra;
       }

        public static List<EOrdenCompraFactura> mListarOrdenCompraFact(EOrdenCompraFactura oc)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pchr_idperiodo", oc.Id_periodo);
            db.AddParameter("@pchr_idordenco", oc.Id_ordenco);
            db.AddParameter("@pchr_idEmpresa", oc.Id_empresa);

            List<EOrdenCompraFactura> result = new List<EOrdenCompraFactura>();

            using (IDataReader rdr = db.ExecuteReader("CO_ocFactura_qry02"))
            {
                while (rdr.Read())
                {
                    result.Add(mCargarOrdenCompraFact(rdr));
                }
            }
            return result;
        }

        public static List<EOrdenCompraFactura> mListarOrdenCompraFact2(EOrdenCompraFactura oc)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pchr_idperiodo", oc.Id_periodo);
            db.AddParameter("@pchr_idordenco", oc.Id_ordenco);
            db.AddParameter("@pchr_idEmpresa", oc.Id_empresa);

            List<EOrdenCompraFactura> result = new List<EOrdenCompraFactura>();

            using (IDataReader rdr = db.ExecuteReader("CO_ocFactura_qry02"))
            {
                while (rdr.Read())
                {
                    result.Add(mCargarOrdenCompraFact(rdr));
                }
            }
            return result;
        }

        public static void CO_DetOrdenCompraFact_mnt01(EOrdenCompraFactura doc)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pid_periodo", doc.Id_periodo);
            db.AddParameter("@pid_ordenco", doc.Id_ordenco);
            db.AddParameter("@pnu_secuen", doc.Nu_secuen);
            db.AddParameter("@pid_docucom", doc.Id_docucom);
            db.AddParameter("@pnu_docum", doc.Nu_docum);
            db.AddParameter("@pmt_docum", doc.Mt_docum);
            db.AddParameter("@pfe_docum", doc.Fe_docum);
            db.AddParameter("@pid_ucrearec", doc.Id_ucrearec);
            db.AddParameter("@pid_uupdarec", doc.Id_uupdarec);
            db.AddParameter("@pid_empresa", doc.Id_empresa);


            db.ExecuteNonQuery("CO_OrdenCompraFactura_mnt01");
        }

       //ANULAR LA FACTURA
        public static void CO_DetOrdenCompraFact_mnt02(EOrdenCompraFactura doc)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pid_empresa", doc.Id_empresa);
            db.AddParameter("@pid_periodo", doc.Id_periodo);
            db.AddParameter("@pid_ordenco", doc.Id_ordenco);
            db.AddParameter("@pnu_secuen", doc.Nu_secuen);
            db.AddParameter("@pid_uupdarec", doc.Id_uupdarec);
            db.ExecuteNonQuery("CO_OrdenCompraFactura_mnt02");
        }


        public static IDataReader GEN_OC_FAC(string idPeriodo, string idEmpresa, string oc)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@idPeriodo", idPeriodo);
            db.AddParameter("@idEmpresa", idEmpresa);
            db.AddParameter("@idOc", oc);
            return db.ExecuteReader("MG_GenSecFact");
        }

    }
}
