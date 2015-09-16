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
   public class DSalida_Detalle
    {
       public static void AL_Salida_Detalle_mnt01(ESalida_Detalle obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);
           db.AddParameter("@pidSalida", obj.IdSalida);
           db.AddParameter("@pid_producto", obj.Id_producto);
           db.AddParameter("@pnu_item", obj.Nu_item);
           db.AddParameter("@pCodBar", obj.CodBar);
           db.AddParameter("@pnu_op", obj.Nu_op);
           db.AddParameter("@pnu_tf", obj.Nu_tf);
           db.AddParameter("@pid_color", obj.Id_color);
           db.AddParameter("@pid_tipo", obj.Id_tipo);
           db.AddParameter("@pid_mercado", obj.Id_mercado);
           db.AddParameter("@pid_tiptela", obj.Id_tiptela);
           db.AddParameter("@pqt_rollo", obj.Qt_rollo);
           db.AddParameter("@pqt_peso", obj.Qt_peso);
           db.AddParameter("@pmt_precio", obj.Mt_precio);
           db.AddParameter("@pmt_igv", obj.Mt_igv);
           db.AddParameter("@pmt_total", obj.Mt_total);

           db.AddParameter("@pid_ucreatrec", obj.Id_ucreatrec);




           db.ExecuteNonQuery("AL_Salida_Detalle_mnt01");

       }


       public static void Al_Salida_Detalle_mnt03(ESalida_Detalle obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);
           db.AddParameter("@pidsalida", obj.IdSalida);
           db.AddParameter("@pnuItem", obj.Nu_item);
           db.AddParameter("@pCodBar", obj.CodBar);
           db.AddParameter("@peso", obj.Qt_peso);
           db.AddParameter("@pidreqsalida", obj._pidreqsalida);
           db.AddParameter("@pid_clipro", obj._id_cliente);
           db.AddParameter("@pid_producto", obj.Id_producto);
           db.AddParameter("@pid_color", obj.Id_color);
           db.AddParameter("@pnurollo", obj.Qt_rollo);


           db.AddParameter("@pid_uupdarec", obj.Id_uupdarec);
           db.ExecuteNonQuery("Al_Salida_Detalle_mnt03");

       }
       // anular despacho (salida)

       public static void Al_Salida_Detalle_mnt04(ESalida_Detalle obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);
           db.AddParameter("@pidsalida", obj.IdSalida);
           db.AddParameter("@pnuItem", obj.Nu_item);
           db.AddParameter("@pCodBar", obj.CodBar);
           db.AddParameter("@peso", obj.Qt_peso);
           db.AddParameter("@pidreqsalida", obj._pidreqsalida);
           db.AddParameter("@pid_clipro", obj._id_cliente);
           db.AddParameter("@pid_producto", obj.Id_producto);
           db.AddParameter("@pid_color", obj.Id_color);
           db.AddParameter("@pnurollo", obj.Qt_rollo);


           db.AddParameter("@pid_uupdarec", obj.Id_uupdarec);
           db.ExecuteNonQuery("Al_Salida_Detalle_mnt04");

       }



       public static DataSet AL_Salida_Detalle_qry02(ESalida_Detalle obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@psintypesel", obj.psintypesel);
           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);
           db.AddParameter("@pidSalida", obj.IdSalida);
           db.AddParameter("@pnuTF", obj.Nu_tf);
           db.AddParameter("@dsproducto", obj.Ds_producto);

           return db.ExecuteDataSet("AL_Salida_Detalle_qry02");
       }


       public static List<ESalida_Detalle> AL_Salida_Detalle_qry01(ESalida_Detalle obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);
           db.AddParameter("@pidSalida", obj.IdSalida);


           List<ESalida_Detalle> result = new List<ESalida_Detalle>();
           using (IDataReader rd = db.ExecuteReader("AL_Salida_Detalle_qry01"))
           {
               while (rd.Read())
               {
                   result.Add(mCargarSalDet(rd));
               }
           }

           return result;
       }




       private static ESalida_Detalle mCargarSalDet(IDataReader rdr)
       {
           ESalida_Detalle objID = new ESalida_Detalle();

           objID.Nu_item = rdr.IsDBNull(rdr.GetOrdinal("nu_item")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_item"));
           objID.CodBar = rdr.IsDBNull(rdr.GetOrdinal("CodBar")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("CodBar"));
           objID.Nu_tf = rdr.IsDBNull(rdr.GetOrdinal("nu_tf")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_tf"));
           objID.Nu_op = rdr.IsDBNull(rdr.GetOrdinal("nu_op")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_op"));

           objID.Id_mercado = rdr.IsDBNull(rdr.GetOrdinal("id_mercado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_mercado"));
           objID.Id_tipo = rdr.IsDBNull(rdr.GetOrdinal("id_tipo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tipo"));
           objID.Id_tiptela = rdr.IsDBNull(rdr.GetOrdinal("id_tiptela")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tiptela"));

           objID.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
           objID.Ds_producto = rdr.IsDBNull(rdr.GetOrdinal("ds_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_producto"));
           objID.Id_color = rdr.IsDBNull(rdr.GetOrdinal("id_color")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_color"));
           objID.Ds_color = rdr.IsDBNull(rdr.GetOrdinal("ds_color")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_color"));
           objID.Qt_rollo = rdr.IsDBNull(rdr.GetOrdinal("qt_rollo")) ? 0 : rdr.GetInt32(rdr.GetOrdinal("qt_rollo"));
           objID.Qt_peso_Actual = rdr.IsDBNull(rdr.GetOrdinal("qt_peso_actual")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso_actual"));
           objID.Qt_peso = rdr.IsDBNull(rdr.GetOrdinal("qt_peso")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso"));
           objID.Mt_precio = rdr.IsDBNull(rdr.GetOrdinal("mt_precio")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_precio"));

           objID.Mt_igv = rdr.IsDBNull(rdr.GetOrdinal("mt_igv")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_igv"));
           objID.Mt_total = rdr.IsDBNull(rdr.GetOrdinal("mt_total")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_total"));

           objID._id_cliente = rdr.IsDBNull(rdr.GetOrdinal("id_cliente")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_cliente"));
           objID.Qt_peso_Disp= rdr.IsDBNull(rdr.GetOrdinal("qt_peso_actual")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso_actual"));
           //objID._id_cliente = rdr.IsDBNull(rdr.GetOrdinal("id_cliente")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_cliente"));


           return objID;
       }

       public static void VE_OrdPedido_Detalle_mnt02(ESalida_Detalle obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);
           db.AddParameter("@pidreqsalida", obj._pidreqsalida);
           db.AddParameter("@pid_clipro", obj._id_cliente);
           db.AddParameter("@pid_producto", obj.Id_producto);
           db.AddParameter("@pid_color", obj.Id_color);
           db.AddParameter("@pnurollo", obj.Qt_rollo);
           db.ExecuteNonQuery("VE_OrdPedido_Detalle_mnt02");

       }



       //public static void VE_OrdPedido_Detalle_mnt04(ESalida_Detalle obj)
       //{
       //    DBAccess db = new DBAccess();

       //    db.AddParameter("@pidEmpresa", obj.IdEmpresa);
       //    db.AddParameter("@pidPeriodo", obj.IdPeriodo);
       //    db.AddParameter("@pidreqsalida", obj._pidreqsalida);
       //    db.AddParameter("@pid_clipro", obj._id_cliente);
       //    db.AddParameter("@pid_producto", obj.Id_producto);
       //    db.AddParameter("@pid_color", obj.Id_color);
       //    db.AddParameter("@pnurollo", obj.Qt_rollo);
       //    db.ExecuteNonQuery("VE_OrdPedido_Detalle_mnt04");
       //}

       private static ESalida_Detalle mCargarSalida_Detalle_qry03(IDataReader rdr)
       {
           ESalida_Detalle objSD = new ESalida_Detalle();
           objSD.Nu_item = rdr.IsDBNull(rdr.GetOrdinal("nu_item")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_item"));
           objSD.CodBar = rdr.IsDBNull(rdr.GetOrdinal("CodBar")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("CodBar"));
           objSD.Nu_tf = rdr.IsDBNull(rdr.GetOrdinal("nu_tf")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_tf"));
           objSD.Nu_op = rdr.IsDBNull(rdr.GetOrdinal("nu_op")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_op"));
           objSD.Id_tipo = rdr.IsDBNull(rdr.GetOrdinal("id_tipo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tipo"));
           objSD.Id_tiptela = rdr.IsDBNull(rdr.GetOrdinal("id_tiptela")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tiptela"));
           objSD.Id_mercado = rdr.IsDBNull(rdr.GetOrdinal("id_mercado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_mercado"));
           objSD.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
           objSD.Ds_producto = rdr.IsDBNull(rdr.GetOrdinal("ds_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_producto"));
           objSD.Id_color = rdr.IsDBNull(rdr.GetOrdinal("id_color")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_color"));
           objSD.Ds_color = rdr.IsDBNull(rdr.GetOrdinal("ds_Color")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_Color"));
           objSD.Qt_rollo = rdr.IsDBNull(rdr.GetOrdinal("qt_rollo")) ? 0 : rdr.GetInt32(rdr.GetOrdinal("qt_rollo"));
           objSD.Qt_peso = rdr.IsDBNull(rdr.GetOrdinal("qt_peso")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso"));
           objSD.Mt_precio = rdr.IsDBNull(rdr.GetOrdinal("mt_precio")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_precio"));

           return objSD;
       }





       public static List<ESalida_Detalle> AL_Salida_Detalle_qry03(ESalida_Detalle obj)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pidEmpresa", obj.IdEmpresa);
           db.AddParameter("@pidPeriodo", obj.IdPeriodo);
           db.AddParameter("@pidSalida", obj.IdSalida);
           db.AddParameter("@pidreqsalida", obj._pidreqsalida);
           db.AddParameter("@pid_producto", obj.Id_producto);
           db.AddParameter("@pid_color", obj.Id_color);




           List<ESalida_Detalle> result = new List<ESalida_Detalle>();
           using (IDataReader rd = db.ExecuteReader("AL_Salida_Detalle_qry03"))
           {
               while (rd.Read())
               {
                   result.Add(mCargarSalida_Detalle_qry03(rd));
               }
           }

           return result;
       }

       public DataTable AL_Salida_Detalle_rpt02(ESalida_Detalle obj)
       {
           DBAccess db = new DBAccess();
           ArrayList arrPrm = new ArrayList();

           arrPrm.Add(DBAccess.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, obj.IdEmpresa));
           arrPrm.Add(DBAccess.CreateParameter("@fecha_ini", SqlDbType.DateTime,  obj.Fe_creatrec));
           arrPrm.Add(DBAccess.CreateParameter("@fecha_fin", SqlDbType.DateTime, obj.Fe_uupdarec));
           arrPrm.Add(DBAccess.CreateParameter("@vendedor", SqlDbType.VarChar, 15, obj.Id_vendedor));
           arrPrm.Add(DBAccess.CreateParameter("@producto", SqlDbType.VarChar, 20, obj.Id_producto));
           arrPrm.Add(DBAccess.CreateParameter("@color", SqlDbType.VarChar, 40, obj.Id_color));
           arrPrm.Add(DBAccess.CreateParameter("@cliente", SqlDbType.VarChar, 50, obj._id_cliente));
           arrPrm.Add(DBAccess.CreateParameter("@tipo", SqlDbType.VarChar, 20, obj.Id_tipo));
           arrPrm.Add(DBAccess.CreateParameter("@dsMercado", SqlDbType.VarChar, 15, obj.Id_mercado));
           arrPrm.Add(DBAccess.CreateParameter("@dstipTela", SqlDbType.VarChar, 15, obj.Id_tiptela));

           DataTable dt = db.ExecuteDatatable("AL_Salida_Detalle_rpt02", arrPrm);
           return dt;
       }






    }
}
