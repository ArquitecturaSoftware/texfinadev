using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.Core.Data;
using Texfina.Entity.Co;
using Texfina.Entity.TJ;

namespace Texfina.DOQry.TJ
{
   public class DMuestrasEtiqueta
    {
       public static DataSet MS_MuestraEtiquetaTela_qry02(ETejeduria tj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", tj.IdEmpresa);
           //db.AddParameter("@pidPeriodo", tj.IdPeriodo);
           db.AddParameter("@pid_producto", tj.Id_producto);
           db.AddParameter("@pds_producto", tj.Ds_Producto);
           db.AddParameter("@pnu_correficha", tj.Nu_correficha);
           db.AddParameter("@pnu_Tf", tj.Nu_tf);
           db.AddParameter("@pnu_TfRef", tj.Nu_tfref);
           db.AddParameter("@psintypesel", tj.psintypesel);


           return db.ExecuteDataSet("MS_MuestraEtiquetaTela_qry02");
       }

       private static ETejeduria mCargarTJ(IDataReader rdr)
       {
           ETejeduria oTJ = new ETejeduria();
           oTJ.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
           oTJ.ds_producto = rdr.IsDBNull(rdr.GetOrdinal("ds_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_producto"));
           oTJ.Nu_correficha = rdr.IsDBNull(rdr.GetOrdinal("nu_correficha")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_correficha"));
           oTJ.Id_clipro = rdr.IsDBNull(rdr.GetOrdinal("id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clipro"));
           oTJ.ds_razonSoc = rdr.IsDBNull(rdr.GetOrdinal("ds_raznombre")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_raznombre"));

           oTJ.Fe_registro = rdr.IsDBNull(rdr.GetOrdinal("fe_registro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_registro"));

         
           oTJ.Nu_tf = rdr.IsDBNull(rdr.GetOrdinal("nu_tf")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_tf"));
           oTJ.idCodBar = rdr.IsDBNull(rdr.GetOrdinal("idCodBar")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idCodBar"));
           return oTJ;
       }

       public static ETejeduria TJ_MuestrasEtiqueta_qry01(ETejeduria oTJ)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pchr_idEmpresa", oTJ.IdEmpresa);
           db.AddParameter("@pchr_idproducto", oTJ.Id_producto);
           db.AddParameter("@pchr_nucorreficha", oTJ.Nu_correficha);


           List<ETejeduria> result = new List<ETejeduria>();
           using (IDataReader rd = db.ExecuteReader("MS_MuestrasEtiqueta_qry01"))
           {
               while (rd.Read())
               {
                   return mCargarTJ(rd);
               }
           }

           return oTJ;
       }




       private static ETejeduria_DetProces mCargarTJD(System.Data.IDataReader rdr)
       {
           ETejeduria_DetProces oTJ = new ETejeduria_DetProces();
           //oTJ.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
           //oTJ.Nu_correficha = rdr.IsDBNull(rdr.GetOrdinal("nu_correficha")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_correficha"));
           //oTJ.Nu_secuen = rdr.IsDBNull(rdr.GetOrdinal("nu_secuen")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_secuen"));
           oTJ.IdItem = rdr.IsDBNull(rdr.GetOrdinal("Item")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("Item"));
           oTJ.IdRutaProces = rdr.IsDBNull(rdr.GetOrdinal("idRutaProces")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idRutaProces"));

           return oTJ;
       }






       public static List<ETejeduria_DetProces> MS_MuestrasEtiquetaDet_qry03(ETejeduria_DetProces oTJ)
       {
           DBAccess db = new DBAccess();

           //db.AddParameter("@pidPeriodo", oTJ.IdPeriodo);
           db.AddParameter("@pidEmpresa", oTJ.IdEmpresa);
           db.AddParameter("@pid_producto", oTJ.Id_producto);
           db.AddParameter("@pnu_correficha", oTJ.Nu_correficha);


           List<ETejeduria_DetProces> result = new List<ETejeduria_DetProces>();
           using (IDataReader rd = db.ExecuteReader("MS_MuestraEtiquetaTelaDet_qry01"))
           {
               while (rd.Read())
               {
                   result.Add(mCargarTJD(rd));
               }
           }

           return result;
       }


       public DataTable GetMuestraEtiqueta_rpt01(ETejeduria tj)
       {
           DBAccess db = new DBAccess();
           ArrayList arrPrm = new ArrayList();

           arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, tj.IdEmpresa));
           arrPrm.Add(DBAccess.CreateParameter("@id_producto", SqlDbType.Char,12, tj.Id_producto));
           arrPrm.Add(DBAccess.CreateParameter("@nu_correficha", SqlDbType.Char, 6, tj.Nu_correficha));

           DataTable dt = db.ExecuteDatatable("TJ_TejeduriaCodBarr_qry01", arrPrm);
           return dt;
       }


       public DataTable GetMuestraEtiqueta_rpt02(ETejeduria tj)
       {
           DBAccess db = new DBAccess();
           ArrayList arrPrm = new ArrayList();

           arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, tj.IdEmpresa));
           arrPrm.Add(DBAccess.CreateParameter("@id_producto", SqlDbType.Char, 12, tj.Id_producto));
           arrPrm.Add(DBAccess.CreateParameter("@nu_correficha", SqlDbType.Char, 6, tj.Nu_correficha));

           DataTable dt = db.ExecuteDatatable("TJ_TejeduriaCodBarr_qry02", arrPrm);
           return dt;
       }

       public static void MS_MuestraEtiqueta_mnt01(EEtiqueta_tela ms)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", ms.IdEmpresa);
           db.AddParameter("@pidPeriodo", ms.IdPeriodo);
           db.AddParameter("@pid_producto", ms.Id_producto);
           db.AddParameter("@pnu_correficha", ms.Nu_correficha);
           db.AddParameter("@pidCodBar", ms.IdCodBar);
           db.AddParameter("@pItem", ms.Item);
           db.AddParameter("@pidRutaProces", ms.IdRutaProces);
           db.AddParameter("@pidCodBar2", ms.IdCodBar2);
           db.AddParameter("@pid_ucrearec", ms.Id_ucrearec);
           db.AddParameter("@pstAnulado", ms.StAnulado);

           db.ExecuteNonQuery("MS_Etiqueta_Tela_mnt01");

       }


       public static List<Dato> MuestraEtiquetaCodBar_qry01(string idEmpresa,string idperiodo,string nuTF)
       {
           List<Dato> _lista = new List<Dato>();

           DBAccess db = new DBAccess();
        
           db.AddParameter("@idEmpresa", idEmpresa);
           db.AddParameter("@IdPeriodo", idperiodo);
           db.AddParameter("@nuTF", nuTF);

           IDataReader reader = db.ExecuteReader("MS_EtiquetaGenCodBar");

           while (reader.Read())
           {
               Dato _dato = new Dato();

               _dato.id = reader["IdCodBar"].ToString();

               _lista.Add(_dato);
           }
           return _lista;
       }


    }
}
