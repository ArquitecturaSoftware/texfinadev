using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Co;
using Texfina.Core.Data;
using System.Data;
using System.Collections;

namespace Texfina.DOQry.Co
{
    public class DFactura
    {
        public static void Factura_mnt01(EFactura fac)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pid_periodo", fac.Id_periodo);
            db.AddParameter("@pid_serie", fac.Id_serie);
            db.AddParameter("@pid_factura", fac.Id_factura);
            db.AddParameter("@pid_ordenco", fac.Id_ordenco);
            db.AddParameter("@pfe_factura", fac.Fe_factura);
            db.AddParameter("@pid_docucom", fac.Id_docucom);
            db.AddParameter("@pnu_docu", fac.Nu_docu);
            db.AddParameter("@pid_clipro", fac.Id_clipro);
            db.AddParameter("@pid_personal", fac.Id_personal);
            db.AddParameter("@pds_observa", fac.Ds_observa);
            db.AddParameter("@pid_vmoneda", fac.Id_vmoneda);
            db.AddParameter("@pmt_total", fac.Mt_total);
            db.AddParameter("@pmt_tc", fac.Mt_tc);
            db.AddParameter("@pid_modcomp", fac.Id_modcomp);
            db.AddParameter("@pst_factura", fac.St_factura);
            db.AddParameter("@pid_ucrearec", fac.Id_ucrearec);
            db.AddParameter("@pid_uupdarec", fac.Id_uupdarec);
            db.AddParameter("@pst_anulado", fac.St_anulado);
            db.AddParameter("@pid_empresa", fac.Id_empresa);
            db.ExecuteNonQuery("CO_Factura_mnt01");
        }


        public static void Factura_mnt02(EDetOrdenCompra fac)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@id_periodo", fac.Id_periodo);
            db.AddParameter("@id_empresa", fac.idEmpresa);
            db.AddParameter("@id_ordenco", fac.Id_ordenco);
            db.AddParameter("@nu_correla", fac.Nu_correla);
            db.AddParameter("@id_producto", fac.Id_producto);
            db.AddParameter("@qt_difcierre", fac.Qt_difcierre);


            db.ExecuteNonQuery("CO_Factura_mnt02");
        }


        public static void FacturaCierre_qry01(EOrdenCompra fac)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@id_periodo", fac.Id_periodo);
            db.AddParameter("@id_ordenco", fac.Id_ordenco);
            db.AddParameter("@id_uupdarec", fac.Id_uupdarec);
            db.AddParameter("@id_empresa", fac.Id_Empresa);
            db.ExecuteNonQuery("SP_OrdenCompra_Cierre");
        }

        public static DataSet factura_rpt(String periodo, String idEmpresa, String fechaini, String fechafin, String exportacion, String importacion, String nufac, String NuOC)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@idPeriodo", periodo);
            db.AddParameter("@idEmpresa", idEmpresa);
            db.AddParameter("@fechaini", fechaini);
            db.AddParameter("@fechafin", fechafin);
            db.AddParameter("@exportacion", exportacion);
            db.AddParameter("@importacion", importacion);
            db.AddParameter("@nuFactura", nufac);
            db.AddParameter("@idOrden", NuOC);
            //db.AddParameter("@pdte_Estado", estado);
            return db.ExecuteDataSet("CO_Factura_rpt");
        }


        public DataTable GetFctura_rpt02(EParOCFillrpt fac)
        {
            DBAccess db = new DBAccess();
            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DBAccess.CreateParameter("@idPeriodo", SqlDbType.Char, 5, fac.IdAnio));
            arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, fac.IdEmpresa));
            arrPrm.Add(DBAccess.CreateParameter("@fechaini", SqlDbType.Char, 10, fac.fechaini ));
            arrPrm.Add(DBAccess.CreateParameter("@fechafin", SqlDbType.Char, 10, fac.fechaFin));
            arrPrm.Add(DBAccess.CreateParameter("@exportacion", SqlDbType.Char, 7, fac.nuExportacion));
            arrPrm.Add(DBAccess.CreateParameter("@importacion", SqlDbType.Char, 7, fac.nuImportacion));
            arrPrm.Add(DBAccess.CreateParameter("@nuFactura", SqlDbType.Char, 12, fac.nuFactura));
            arrPrm.Add(DBAccess.CreateParameter("@idOrden", SqlDbType.Char, 10,fac.IdOrdenCompra));

            DataTable dt = db.ExecuteDatatable("CO_Factura_rpt", arrPrm);
            return dt;
        }

        public DataTable GetFactura_rpt01(EParOCFillrpt oc)
        {
            DBAccess db = new DBAccess();
            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DBAccess.CreateParameter("@fechaini", SqlDbType.Char, oc.fechaini));
            arrPrm.Add(DBAccess.CreateParameter("@fechafin", SqlDbType.VarChar, oc.fechaFin));
            arrPrm.Add(DBAccess.CreateParameter("@idcliprov", SqlDbType.VarChar, oc.idProv));
            arrPrm.Add(DBAccess.CreateParameter("@local", SqlDbType.VarChar, oc.local));
            arrPrm.Add(DBAccess.CreateParameter("@idempresa", SqlDbType.VarChar, oc.IdEmpresa));


            DataTable dt = db.ExecuteDatatable("sp_ocfactura_rpt", arrPrm);
            return dt;
        }


        public static IDataReader Factura_qry01( string idPeriodo, string idEmpresa)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@idPeriodo", idPeriodo);
            db.AddParameter("@idEmpresa", idEmpresa);

            return db.ExecuteReader("MG_GencodigoFact");

        }

        public static DataSet Factura_qry01(String idPeriodo, String idEmpresa, String nufac,String dsRs,  String feini, String fefin, String dsproducto, String idOC)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@idPeriodo", idPeriodo);
            db.AddParameter("@idEmpresa", idEmpresa);
            db.AddParameter("@nuFactura", nufac);
            db.AddParameter("@dsRazonSoc", dsRs);
            db.AddParameter("@fechaIni", feini);
            db.AddParameter("@fechaFin", fefin);
            db.AddParameter("@dsproducto", dsproducto);
            db.AddParameter("@idOC", idOC);
            return db.ExecuteDataSet("CO_Factura_qry01");
        }

        private static EFactura mCargarFactura(IDataReader rdr)
        {
            EFactura oFactura = new EFactura();
            oFactura.Id_periodo = rdr.IsDBNull(rdr.GetOrdinal("id_periodo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_periodo"));
            oFactura.Fe_factura = rdr.IsDBNull(rdr.GetOrdinal("fe_factura")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_factura"));
            oFactura.Fe_OrdenCompra = rdr.IsDBNull(rdr.GetOrdinal("fe_ordenco")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_ordenco"));

            oFactura.Id_factura = rdr.IsDBNull(rdr.GetOrdinal("id_factura")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_factura"));
            oFactura.Id_ordenco = rdr.IsDBNull(rdr.GetOrdinal("id_ordenco")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_ordenco"));
            oFactura.Id_docucom = rdr.IsDBNull(rdr.GetOrdinal("id_docucom")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_docucom"));
            oFactura.Id_serie = rdr.IsDBNull(rdr.GetOrdinal("id_serie")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_serie"));
            oFactura.Nu_docu = rdr.IsDBNull(rdr.GetOrdinal("nu_docu")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_docu"));
            oFactura.Id_clipro = rdr.IsDBNull(rdr.GetOrdinal("id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clipro"));

            oFactura.ds_clipro = rdr.IsDBNull(rdr.GetOrdinal("clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("clipro"));

            oFactura.Id_personal = rdr.IsDBNull(rdr.GetOrdinal("id_personal")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_personal"));
            oFactura.ds_personal = rdr.IsDBNull(rdr.GetOrdinal("ds_personal")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_personal"));
            oFactura.Ds_observa = rdr.IsDBNull(rdr.GetOrdinal("ds_observa")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_observa"));
            oFactura.Id_modcomp = rdr.IsDBNull(rdr.GetOrdinal("id_modcomp")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_modcomp"));
            oFactura.Id_vmoneda = rdr.IsDBNull(rdr.GetOrdinal("id_vmoneda")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vmoneda"));
            oFactura.Mt_tc = rdr.IsDBNull(rdr.GetOrdinal("mt_tc")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_tc"));
            oFactura.Mt_total = rdr.IsDBNull(rdr.GetOrdinal("mt_total")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_total"));
            return oFactura;
        }

        public static EFactura mObtenerFactura(EFactura ocfac)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pchr_idperiodo", ocfac.Id_periodo);
            db.AddParameter("@pchr_idfactura", ocfac.Id_factura);
            db.AddParameter("@pdte_empresa", ocfac.Id_empresa);

            List<EOrdenCompra> result = new List<EOrdenCompra>();
            using (IDataReader rd = db.ExecuteReader("CO_facturaGetQrt01"))
            {
                while (rd.Read())
                {
                    return mCargarFactura(rd);
                }
            }

            return ocfac;
        }
    }
}
