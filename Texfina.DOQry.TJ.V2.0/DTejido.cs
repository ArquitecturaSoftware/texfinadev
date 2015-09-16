using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.Core.Data;
using Texfina.Entity.Co;

namespace Texfina.DOQry.TJ
{
   public class DTejido
    {
       public static void Tejido_mnt(EProducto prod)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pid_producto", prod.Id_producto);
           db.AddParameter("@pds_producto", prod.Ds_producto);
           db.AddParameter("@pds_prodalias", prod.Ds_prodalias);
           db.AddParameter("@pid_grupo", prod.Id_grupo);
           db.AddParameter("@pid_familia", prod.Id_familia);
           db.AddParameter("@pid_subfami", prod.Id_subfami);
           db.AddParameter("@pid_vunimed", prod.Id_vunimed);
           db.AddParameter("@pid_vunicons", prod.Id_vunicons);
           db.AddParameter("@pnu_facequiv", prod.Nu_facequiv);
           db.AddParameter("@pid_vmoneda", prod.Id_vmoneda);
           db.AddParameter("@pmt_valrepo", prod.Mt_valrepo);
           db.AddParameter("@pst_igvisc", prod.St_igvisc);
           db.AddParameter("@pst_activo", prod.St_activo);
           db.AddParameter("@pid_tipogsto", prod.Id_tipogsto);
           db.AddParameter("@pid_ucrearec", prod.Id_ucrearec);
           db.AddParameter("@pst_anulado", prod.St_anulado);
           db.AddParameter("@pst_idEmpresa", prod.IdEmpresa);
           db.AddParameter("@pidProdFox", prod.Id_prodFOX);

           db.ExecuteNonQuery("MG_Tejido_mnt");

       }


       public static void TejidoDet_mnt(EProdXUnd prod)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pid_producto", prod.Id_producto);
           db.AddParameter("@pid_prodprese", prod.Id_prodprese);
           db.AddParameter("@pds_prodprese", prod.Ds_prodprese);
           db.AddParameter("@pnu_uniprese", prod.Nu_uniprese);
           db.AddParameter("@pnu_umprese", prod.Nu_umprese);
           db.AddParameter("@pqt_pesoneto", prod.Qt_pesoneto);
           db.AddParameter("@pqt_pesobruto", prod.Qt_pesobruto);
           db.AddParameter("@pmt_precio", prod.Mt_precio);
           db.AddParameter("@pid_ucrearec", prod.Id_ucrearec);
           db.AddParameter("@pid_uupdarec", prod.Id_ucrearec);
           db.AddParameter("@pid_empresa", prod.Id_Empresa);
           db.ExecuteNonQuery("MG_TejidoDet_mnt01");

       }

       public static List<Dato> GenCodTejido_qry01(EProducto prod)
       {
           List<Dato> _lista = new List<Dato>();

           DBAccess db = new DBAccess();
           db.AddParameter("@pchr_idgrupo", prod.Id_grupo);
           db.AddParameter("@pchr_idfamilia", prod.Id_familia);
           db.AddParameter("@pchr_idsubfami", prod.Id_subfami);         
           db.AddParameter("@idEmpresa", prod.IdEmpresa);
           IDataReader reader = db.ExecuteReader("MG_GenerarCodTejido");

           while (reader.Read())
           {
               Dato _dato = new Dato();

               _dato.id = reader["id_Producto"].ToString();
         
               _lista.Add(_dato);
           }
           return _lista;
       }

       public static DataSet TejidoFill(EProducto prod)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@psintypesel", prod.psintypesel);
           db.AddParameter("@id_producto", prod.Id_producto);
           db.AddParameter("@ds_producto", prod.Ds_producto);
           db.AddParameter("@dsPresent", prod.Ds_prese);

           db.AddParameter("@id_empresa", prod.IdEmpresa);

           return db.ExecuteDataSet("MG_Tejido_qry01");
       }


       private static EProdXUnd mCargarDetTejido(IDataReader rdr)
       {
           EProdXUnd oProd = new EProdXUnd();

           oProd.Id_prodprese = rdr.IsDBNull(rdr.GetOrdinal("id_prodprese")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_prodprese"));
           oProd.Ds_prodprese = rdr.IsDBNull(rdr.GetOrdinal("ds_prodprese")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_prodprese"));
           oProd.Nu_uniprese = rdr.IsDBNull(rdr.GetOrdinal("nu_uniprese")) ? 0 : rdr.GetInt16(rdr.GetOrdinal("nu_uniprese"));
           oProd.Nu_umprese = rdr.IsDBNull(rdr.GetOrdinal("nu_umprese")) ? 0 : rdr.GetInt16(rdr.GetOrdinal("nu_umprese"));
           oProd.Qt_pesoneto = rdr.IsDBNull(rdr.GetOrdinal("qt_pesoneto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_pesoneto"));
           oProd.Qt_pesobruto = rdr.IsDBNull(rdr.GetOrdinal("qt_pesobruto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_pesobruto"));
           oProd.Mt_precio = rdr.IsDBNull(rdr.GetOrdinal("mt_precio")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_precio"));

           return oProd;
       }

       public static List<EProdXUnd> GetListTejido_qry01(EProdXUnd prod)
       {
           DBAccess db = new DBAccess();
           db.AddParameter("@pchr_idproducto", prod.Id_producto);
           db.AddParameter("@pchr_idEmpresa", prod.Id_Empresa);

           List<EProdXUnd> result = new List<EProdXUnd>();

           using (IDataReader rdr = db.ExecuteReader("MG_Tejido_qry04"))
           {
               while (rdr.Read())
               {
                   result.Add(mCargarDetTejido(rdr));
               }
           }
           return result;
       }



       private static EProducto mCargarTejido(IDataReader rdr)
       {
           EProducto oproducto = new EProducto();
           oproducto.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
           oproducto.Ds_producto = rdr.IsDBNull(rdr.GetOrdinal("ds_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_producto"));
           oproducto.Ds_prodalias = rdr.IsDBNull(rdr.GetOrdinal("ds_prodalias")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_prodalias"));
           oproducto.Id_grupo = rdr.IsDBNull(rdr.GetOrdinal("id_grupo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_grupo"));
           oproducto.Id_familia = rdr.IsDBNull(rdr.GetOrdinal("id_familia")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_familia"));
           oproducto.Id_subfami = rdr.IsDBNull(rdr.GetOrdinal("id_subfami")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_subfami"));
           oproducto.Id_vunimed = rdr.IsDBNull(rdr.GetOrdinal("id_vunimed")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vunimed"));
           oproducto.Id_vunicons = rdr.IsDBNull(rdr.GetOrdinal("id_vunicons")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vunicons"));
           oproducto.Nu_facequiv = rdr.IsDBNull(rdr.GetOrdinal("nu_facequiv")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("nu_facequiv"));
           oproducto.Id_vmoneda = rdr.IsDBNull(rdr.GetOrdinal("id_vmoneda")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vmoneda"));
           oproducto.Mt_valrepo = rdr.IsDBNull(rdr.GetOrdinal("mt_valrepo")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_valrepo"));
           oproducto.Id_tipogsto = rdr.IsDBNull(rdr.GetOrdinal("id_tipogsto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tipogsto"));
           oproducto.ds_tipogsto = rdr.IsDBNull(rdr.GetOrdinal("ds_tipogsto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_tipogsto"));
           oproducto.St_activo = rdr.IsDBNull(rdr.GetOrdinal("st_activo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("st_activo"));
           oproducto.St_igvisc = rdr.IsDBNull(rdr.GetOrdinal("st_igvisc")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("st_igvisc"));

           oproducto.Id_prodFOX = rdr.IsDBNull(rdr.GetOrdinal("idProdFox")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idProdFox"));

           return oproducto;
       }

       public static EProducto mObtenerTejido(EProducto eprod)
       {
           DBAccess db = new DBAccess();
           db.AddParameter("@pchr_idproducto", eprod.Id_producto);
           db.AddParameter("@pchr_idEmpresa", eprod.IdEmpresa);
           List<EProducto> result = new List<EProducto>();
           using (IDataReader rd = db.ExecuteReader("MG_Tejido_qry03"))
           {
               while (rd.Read())
               {
                   return mCargarTejido(rd);
               }
           }

           return eprod;
       }

       private static EProducto mCargarExistenciaTejido(IDataReader rdr)
       {
           EProducto oprod = new EProducto();
           oprod.existe = rdr.IsDBNull(rdr.GetOrdinal("existe")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("existe"));
           return oprod;
       }


       public static List<EProducto> MG_Tejido_qry06(EProducto prod)
       {
           DBAccess db = new DBAccess();
           db.AddParameter("@pid_producto", prod.Id_producto);
           db.AddParameter("@pidEmpresa", prod.IdEmpresa);

           List<EProducto> result = new List<EProducto>();

           using (IDataReader rdr = db.ExecuteReader("MG_Tejido_qry06"))
           {
               while (rdr.Read())
               {
                   result.Add(mCargarExistenciaTejido(rdr));
               }
           }
           return result;
       }


       public static void Tejeduria_mnt03(EProdXUnd prod)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pid_empresa", prod.Id_Empresa);
           db.AddParameter("@pid_producto", prod.Id_producto);
           db.AddParameter("@pid_prodprese", prod.Id_prodprese);

           db.ExecuteNonQuery("MG_Tejeduria_mnt03");

       }


       public static EProducto mObtenerTejido2(EProducto eprod)
       {
           DBAccess db = new DBAccess();
           db.AddParameter("@pchr_idproducto", eprod.Id_producto);
           db.AddParameter("@pchr_idEmpresa", eprod.IdEmpresa);
           List<EProducto> result = new List<EProducto>();
           using (IDataReader rd = db.ExecuteReader("MG_Tejido_qry03"))
           {
               while (rd.Read())
               {
                   return mCargarTejido2(rd);
               }
           }

           return eprod;
       }

       private static EProducto mCargarTejido2(IDataReader rdr)
       {
           EProducto oproducto = new EProducto();
           oproducto.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
           oproducto.Ds_producto = rdr.IsDBNull(rdr.GetOrdinal("ds_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_producto"));
           
           return oproducto;
       }





    }
}
