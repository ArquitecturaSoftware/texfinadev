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
   public class DSalida
   {
       public static void AL_Salida_mnt01(ESalida obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);
           db.AddParameter("@pidSalida", obj.IdSalida);
           db.AddParameter("@pidreqsalida", obj.Idreqsalida);
           db.AddParameter("@pidPersonal1", obj.IdPersonal1);
           db.AddParameter("@pid_local", obj.IdLocal);
           db.AddParameter("@pfe_salida", obj.Fe_salida);
           db.AddParameter("@pid_clipro", obj.Id_clipro);
           db.AddParameter("@pds_direntrega", obj.Ds_direntrega);
           db.AddParameter("@pid_condpago", obj.Id_condpago);
           db.AddParameter("@pds_placa", obj.Ds_placa);
           db.AddParameter("@pidPersonal2", obj.IdPersonal2);
           db.AddParameter("@pid_docucom", obj.Id_docucom);
           db.AddParameter("@pid_vendedor", obj.Id_vendedor);
           db.AddParameter("@pid_vmoneda", obj.Id_vmoneda);
           db.AddParameter("@pds_observ", obj.Ds_observ);
           db.AddParameter("@pmt_total", obj.Mt_total);

           db.AddParameter("@pid_ucreatrec", obj.Id_ucreatrec);



           db.ExecuteNonQuery("AL_Salida_mnt01");

       }


       public static List<Texfina.Entity.Co.Dato> Al_Salida_GenCod(string idPeriodo, string idEmpresa)
       {
           List<Texfina.Entity.Co.Dato> _lista = new List<Texfina.Entity.Co.Dato>();

           DBAccess db = new DBAccess();
           db.AddParameter("@idPeriodo", idPeriodo);
           db.AddParameter("@idEmpresa", idEmpresa);  

           IDataReader reader = db.ExecuteReader("Al_Salida_GenCod");

           while (reader.Read())
           {
               Texfina.Entity.Co.Dato _dato = new Texfina.Entity.Co.Dato();

               _dato.id = reader["idSalida"].ToString();

               _lista.Add(_dato);
           }
           return _lista;
       }



       private static ESalida mCargarExistenciaSalida(IDataReader rdr)
       {
           ESalida obj = new ESalida();
           obj.Existe = rdr.IsDBNull(rdr.GetOrdinal("existe")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("existe"));
           return obj;
       }


       public static List<ESalida> Al_Salida_qry05(ESalida obj)
       {
           DBAccess db = new DBAccess();
           db.AddParameter("@pidsalida", obj.IdSalida);
           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);


           List<ESalida> result = new List<ESalida>();

           using (IDataReader rdr = db.ExecuteReader("Al_Salida_qry05"))
           {
               while (rdr.Read())
               {
                   result.Add(mCargarExistenciaSalida(rdr));
               }
           }
           return result;
       }


       public static ESalida AL_Salida_qry01(ESalida obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);
           db.AddParameter("@pidSalida", obj.IdSalida);


           using (IDataReader rd = db.ExecuteReader("AL_Salida_qry01"))
           {
               while (rd.Read())
               {
                   return mCargarSalida(rd);
               }
           }

           return obj;
       }


       private static ESalida mCargarSalida(IDataReader rdr)
       {

           ESalida obj = new ESalida();
           obj.IdSalida = rdr.IsDBNull(rdr.GetOrdinal("idSalida")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idSalida"));
           obj.Idreqsalida = rdr.IsDBNull(rdr.GetOrdinal("idreqsalida")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idreqsalida"));
           obj.IdPersonal1 = rdr.IsDBNull(rdr.GetOrdinal("idPersonal1")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idPersonal1"));
           obj.dsPersonal1 = rdr.IsDBNull(rdr.GetOrdinal("EmitidoPor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("EmitidoPor"));
           obj.IdLocal = rdr.IsDBNull(rdr.GetOrdinal("id_local")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_local"));
           obj.Fe_salida = rdr.IsDBNull(rdr.GetOrdinal("fe_salida")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_salida"));
           obj.Hr_salida = rdr.IsDBNull(rdr.GetOrdinal("hr_salida")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("hr_salida"));

           obj.Id_clipro = rdr.IsDBNull(rdr.GetOrdinal("Id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("Id_clipro"));
           obj.ds_clipro = rdr.IsDBNull(rdr.GetOrdinal("dsCliente")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsCliente"));
           obj.Ds_direntrega = rdr.IsDBNull(rdr.GetOrdinal("ds_direntrega")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_direntrega"));
           obj.Id_condpago = rdr.IsDBNull(rdr.GetOrdinal("id_condpago")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_condpago"));
           obj.ds_condpago = rdr.IsDBNull(rdr.GetOrdinal("dsCondpago")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsCondpago"));
           obj.Ds_placa = rdr.IsDBNull(rdr.GetOrdinal("ds_placa")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_placa"));
           obj.IdPersonal2 = rdr.IsDBNull(rdr.GetOrdinal("idPersonal2")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idPersonal2"));

           obj.dsPersonal2 = rdr.IsDBNull(rdr.GetOrdinal("conductor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("conductor"));
           obj.Id_docucom = rdr.IsDBNull(rdr.GetOrdinal("id_docucom")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_docucom"));
           obj.Id_vendedor = rdr.IsDBNull(rdr.GetOrdinal("id_vendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vendedor"));
           obj.ds_vendedor = rdr.IsDBNull(rdr.GetOrdinal("dsVendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsVendedor"));
           obj.Ds_observ = rdr.IsDBNull(rdr.GetOrdinal("ds_observ")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_observ"));
           obj.Id_vmoneda = rdr.IsDBNull(rdr.GetOrdinal("id_vmoneda")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vmoneda"));

           obj.fe_autorizado = rdr.IsDBNull(rdr.GetOrdinal("fe_autorizado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_autorizado"));
           obj.fe_aprobado = rdr.IsDBNull(rdr.GetOrdinal("fe_aprobado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_aprobado"));
           obj.id_prioridad = rdr.IsDBNull(rdr.GetOrdinal("id_prioridad")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_prioridad"));

           return obj;
       }

       public DataTable AL_Salida_rpt01(ESalida obj)
       {
           DBAccess db = new DBAccess();
           ArrayList arrPrm = new ArrayList();

           arrPrm.Add(DBAccess.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, obj.IdEmpresa));
           arrPrm.Add(DBAccess.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, obj.IdPeriodo));
           arrPrm.Add(DBAccess.CreateParameter("@pidSalida", SqlDbType.Char, 7, obj.IdSalida));

           DataTable dt = db.ExecuteDatatable("AL_Salida_rpt01", arrPrm);
           return dt;
       }



    }
}
