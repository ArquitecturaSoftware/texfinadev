using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.Core.Data;
using Texfina.Entity.Al;

namespace Texfina.DOMnt.Al
{
   public class DOrdPedido
    {

       public static List<Texfina.Entity.Co.Dato> OrdenPedidoGenCod_qry01_(string idPeriodo, string idEmpresa)
       {
           List<Texfina.Entity.Co.Dato> _lista = new List<Texfina.Entity.Co.Dato>();

           DBAccess db = new DBAccess();
           db.AddParameter("@idEmpresa", idEmpresa);
           db.AddParameter("@idPeriodo", idPeriodo);

           IDataReader reader = db.ExecuteReader("VE_OrdenPedido_GenCod");

           while (reader.Read())
           {
               Texfina.Entity.Co.Dato _dato = new Texfina.Entity.Co.Dato();

               _dato.id = reader["idreqsalida"].ToString();

               _lista.Add(_dato);
           }
           return _lista;
       }


       public static void VE_OrdPedido_mnt01(EOrdPedido obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidreqsalida", obj.Idreqsalida);
           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);
           db.AddParameter("@pid_condpago", obj.Id_condpago);
           db.AddParameter("@pid_clipro", obj.Id_clipro);
           db.AddParameter("@pfe_requer", obj.Fe_requer);
           db.AddParameter("@pidpersonal1", obj.Idpersonal1);
           db.AddParameter("@pid_local", obj.IdLocal);
           db.AddParameter("@pfe_venc", obj.Fe_venc);
           db.AddParameter("@pds_direntrega", obj.Ds_direntrega);
           db.AddParameter("@pid_vendedor", obj.Id_vendedor);
           db.AddParameter("@pid_tipsalida", obj.Id_tipsalida);
           db.AddParameter("@pid_prioridad", obj.Id_prioridad);
           db.AddParameter("@pid_vmoneda", obj.id_vmoneda);
           db.AddParameter("@pid_autorizado", obj.Id_autorizado);
           db.AddParameter("@pid_autorizado2", obj.Id_autorizado2);
           db.AddParameter("@pid_aprobado", obj.Id_aprobado);
           db.AddParameter("@pst_autorizado", obj.St_autorizado);
           db.AddParameter("@pst_autorizado2", obj.St_autorizado2);
           db.AddParameter("@pst_aprobado", obj.St_aprobado);
           db.AddParameter("@pds_observ", obj.Ds_observ);
           db.AddParameter("@pid_ucreatrec", obj.Id_ucreatrec);

           db.AddParameter("@pds_prontoPago", obj.Ds_prontoPago);
           db.AddParameter("@pds_promocion", obj.Ds_promocion);

           db.ExecuteNonQuery("VE_OrdPedido_mnt01");

       }

       public static void VE_OrdPedido_mnt03(EOrdPedido obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@idreqsalida", obj.Idreqsalida);
           db.AddParameter("@idEmpresa", obj.IdEmpresa);
           db.AddParameter("@idPeriodo", obj.IdPeriodo);
           db.AddParameter("@ds_observ", obj.Ds_observ);
           db.AddParameter("@id_uupdatrec", obj.Id_ucreatrec);


           db.ExecuteNonQuery("VE_OrdenPedido_mnt03");

       }

       public static void VE_OrdPedido_mnt04(EOrdPedido obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@idreqsalida", obj.Idreqsalida);
           db.AddParameter("@idEmpresa", obj.IdEmpresa);
           db.AddParameter("@idPeriodo", obj.IdPeriodo);
           db.AddParameter("@ds_observ", obj.Ds_observ);
           db.AddParameter("@id_uupdatrec", obj.Id_ucreatrec);


           db.ExecuteNonQuery("VE_OrdenPedido_mnt04");

       }

       public static void VE_OrdPedido_mnt05(EOrdPedido obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@idreqsalida", obj.Idreqsalida);
           db.AddParameter("@idEmpresa", obj.IdEmpresa);
           db.AddParameter("@idPeriodo", obj.IdPeriodo);
           db.AddParameter("@ds_observ", obj.Ds_observ);
           db.AddParameter("@id_uupdatrec", obj.Id_ucreatrec);


           db.ExecuteNonQuery("VE_OrdenPedido_mnt05");

       }

       private static EOrdPedido mCargarExistenciaOp(IDataReader rdr)
       {
           EOrdPedido obj = new EOrdPedido();
           obj.Existe = rdr.IsDBNull(rdr.GetOrdinal("existe")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("existe"));
           return obj;
       }


       public static List<EOrdPedido> VE_OrdPedido_qry05(EOrdPedido obj)
       {
           DBAccess db = new DBAccess();
           db.AddParameter("@pidreqsalida", obj.Idreqsalida);
           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);


           List<EOrdPedido> result = new List<EOrdPedido>();

           using (IDataReader rdr = db.ExecuteReader("VE_OrdPedido_qry05"))
           {
               while (rdr.Read())
               {
                   result.Add(mCargarExistenciaOp(rdr));
               }
           }
           return result;
       }



       private static EOrdPedido mCargarIngreso(IDataReader rdr)
       {

           EOrdPedido obj = new EOrdPedido();
           obj.Idreqsalida = rdr.IsDBNull(rdr.GetOrdinal("idreqsalida")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idreqsalida"));
           obj.IdEmpresa = rdr.IsDBNull(rdr.GetOrdinal("idEmpresa")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idEmpresa"));
           obj.IdPeriodo = rdr.IsDBNull(rdr.GetOrdinal("idPeriodo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idPeriodo"));
           obj.Id_condpago = rdr.IsDBNull(rdr.GetOrdinal("id_condpago")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_condpago"));
           obj.ds_condpago = rdr.IsDBNull(rdr.GetOrdinal("ds_condpago")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_condpago"));
           obj.Id_clipro = rdr.IsDBNull(rdr.GetOrdinal("id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clipro"));
           obj.ds_raznombre = rdr.IsDBNull(rdr.GetOrdinal("ds_raznombre")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_raznombre"));
           obj.Fe_requer = rdr.IsDBNull(rdr.GetOrdinal("fe_requer")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_requer"));
           obj.Idpersonal1 = rdr.IsDBNull(rdr.GetOrdinal("idpersonal1")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idpersonal1"));
           obj.emitidap = rdr.IsDBNull(rdr.GetOrdinal("emitidap")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("emitidap"));
           obj.IdLocal = rdr.IsDBNull(rdr.GetOrdinal("id_local")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_local"));
           obj.Fe_venc = rdr.IsDBNull(rdr.GetOrdinal("fe_venc")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_venc"));
           obj.Ds_direntrega = rdr.IsDBNull(rdr.GetOrdinal("ds_direntrega")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_direntrega"));
           obj.Id_vendedor = rdr.IsDBNull(rdr.GetOrdinal("id_vendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vendedor"));
           obj.dsVendedor = rdr.IsDBNull(rdr.GetOrdinal("dsVendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsVendedor"));
           obj.dsVendedor = rdr.IsDBNull(rdr.GetOrdinal("dsVendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsVendedor"));
           obj.id_vmoneda = rdr.IsDBNull(rdr.GetOrdinal("id_vmoneda")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vmoneda"));
           obj.Id_tipsalida = rdr.IsDBNull(rdr.GetOrdinal("id_tipsalida")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tipsalida"));
           obj.ds_tipsalida = rdr.IsDBNull(rdr.GetOrdinal("ds_tipsalida")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_tipsalida"));
           obj.Id_prioridad = rdr.IsDBNull(rdr.GetOrdinal("id_prioridad")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_prioridad"));           
           obj.Ds_observ = rdr.IsDBNull(rdr.GetOrdinal("ds_observ")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_observ"));
           obj.fe_autorizado = rdr.IsDBNull(rdr.GetOrdinal("fe_autorizado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_autorizado"));
           obj.fe_aprobado = rdr.IsDBNull(rdr.GetOrdinal("fe_aprobado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_aprobado"));

           obj.Ds_prontoPago = rdr.IsDBNull(rdr.GetOrdinal("ds_prontoPago")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_prontoPago"));
           obj.Ds_promocion = rdr.IsDBNull(rdr.GetOrdinal("ds_promocion")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_promocion"));                                     

           return obj;
       }


       public static EOrdPedido VE_OrdPedido_qry01(EOrdPedido obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);
           db.AddParameter("@pidreqsalida", obj.Idreqsalida);


           using (IDataReader rd = db.ExecuteReader("VE_OrdPedido_qry01"))
           {
               while (rd.Read())
               {
                   return mCargarIngreso(rd);
               }
           }

           return obj;
       }

       public DataTable GetOrdenPedido_rpt01(EOrdPedido op)
       {
           DBAccess db = new DBAccess();
           ArrayList arrPrm = new ArrayList();

           arrPrm.Add(DBAccess.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, op.IdEmpresa));
           arrPrm.Add(DBAccess.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, op.IdPeriodo));
           arrPrm.Add(DBAccess.CreateParameter("@pidreqsalida", SqlDbType.Char, 7, op.Idreqsalida));

           DataTable dt = db.ExecuteDatatable("VE_OrdenPedido_rpt01", arrPrm);
           return dt;
       }


       public static DataSet VE_OrdenPedido_qry06(EParametros obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.idEmpresa);
           db.AddParameter("@pidPeriodo", obj.idperiodo);
           db.AddParameter("@pidreqsalida", obj.Idreqsalida);
           db.AddParameter("@pdte_feordenpeini", obj.fechaIni);
           db.AddParameter("@pdte_feordenpefin", obj.fechaFin);
           db.AddParameter("@pestado", obj.estado);
           
           return db.ExecuteDataSet("VE_OrdenPedido_qry06");
       }


       public static DataSet VE_OrdenPedido_qry07(EParametros obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.idEmpresa);
           db.AddParameter("@pidPeriodo", obj.idperiodo);
           db.AddParameter("@pidreqsalida", obj.Idreqsalida);
           db.AddParameter("@pdte_feordenpeini", obj.fechaIni);
           db.AddParameter("@pdte_feordenpefin", obj.fechaFin);
           db.AddParameter("@pestado", obj.estado);
          
           return db.ExecuteDataSet("VE_OrdenPedido_qry07");
       }

       public static DataSet VE_OrdenPedido_qry08(EParametros obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.idEmpresa);
           db.AddParameter("@pidPeriodo", obj.idperiodo);
           db.AddParameter("@pidreqsalida", obj.Idreqsalida);
           db.AddParameter("@pdte_feordenpeini", obj.fechaIni);
           db.AddParameter("@pdte_feordenpefin", obj.fechaFin);
           db.AddParameter("@pestado", obj.estado);

           return db.ExecuteDataSet("VE_OrdenPedido_qry08");
       }


       public  DataTable VE_OrdenPedido_qry07_rpt(EParametros obj)
       {
           DBAccess db = new DBAccess();
           ArrayList arrPrm = new ArrayList();

           arrPrm.Add(DBAccess.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, obj.idEmpresa));
           arrPrm.Add(DBAccess.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, obj.idperiodo));
          // arrPrm.Add(DBAccess.CreateParameter("@pidreqsalida", SqlDbType.Char, 7, obj.pidreqsalida));

           arrPrm.Add(DBAccess.CreateParameter("@pdte_feordenpeini", SqlDbType.DateTime, obj.fechaIni));
           arrPrm.Add(DBAccess.CreateParameter("@pdte_feordenpefin", SqlDbType.DateTime, obj.fechaFin));
           arrPrm.Add(DBAccess.CreateParameter("@pestado", SqlDbType.Char, 1, obj.estado));

           DataTable dt = db.ExecuteDatatable("VE_OrdenPedido_qry07_rpt", arrPrm);
           return dt;
       }

       public static DataSet VE_OrdPedido_mnt02(EParametros obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@psin_typeupd", obj.psintypesel);
           db.AddParameter("@pchr_idordenPe", obj.Idreqsalida);
           db.AddParameter("@pchr_stordenpe", obj.st_autoriza);
           db.AddParameter("@pchr_idautoriza", obj.id_autoriza);           
           db.AddParameter("@pchr_idEmpresa", obj.idEmpresa);
           db.AddParameter("@pchr_idPeriodo", obj.idperiodo);


           return db.ExecuteDataSet("VE_OrdPedido_mnt02");
       }


       public static DataSet VE_OrdenPedido_qry09(EParametros obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.idEmpresa);
           db.AddParameter("@pidPeriodo", obj.idperiodo);
           db.AddParameter("@pidreqsalida", obj.Idreqsalida);
           db.AddParameter("@pdte_feordenpeini", obj.fechaIni);
           db.AddParameter("@pdte_feordenpefin", obj.fechaFin);
        

           return db.ExecuteDataSet("VE_OrdenPedido_qry09");
       }


       public static DataSet VE_OrdenPedido_Habilitar(EParametros OP)
       {
           DBAccess db = new DBAccess();


           db.AddParameter("@idreqsalida", OP.Idreqsalida);
           db.AddParameter("@id_Empresa", OP.idEmpresa);
           db.AddParameter("@id_periodo", OP.idperiodo);


           return db.ExecuteDataSet("VE_OrdenPedido_Habilitar");
       }



    }
}
