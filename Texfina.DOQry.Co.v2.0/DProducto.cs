using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Co;
using Texfina.Core.Data;

namespace Texfina.DOQry.Co
{
   public class DProducto
    {
       public static IDataReader GenCodProducto_qry01(EProducto prod)
       {
           DBAccess db = new DBAccess();
           db.AddParameter("@pchr_idgrupo", prod.Id_grupo);
           db.AddParameter("@pchr_idfamilia", prod.Id_familia);
           db.AddParameter("@pchr_idsubfami", prod.Id_subfami);
           db.AddParameter("@ds_producto", prod.Ds_producto);
           db.AddParameter("@ds_prodalias", prod.Ds_prodalias);
           db.AddParameter("@idEmpresa", prod.IdEmpresa);

           return db.ExecuteReader("MG_GenerarCodeprod1");
       }

       /// <summary>
       /// generar codigo para desktop
       /// 
       /// </summary>
      
       /// <returns></returns>

       public static List<Dato> GenCodProducto_qry01_(EProducto prod)
       {
           List<Dato> _lista = new List<Dato>();

           DBAccess db = new DBAccess();
           db.AddParameter("@pchr_idgrupo", prod.Id_grupo);
           db.AddParameter("@pchr_idfamilia", prod.Id_familia);
           db.AddParameter("@pchr_idsubfami", prod.Id_subfami);
           db.AddParameter("@ds_producto", prod.Ds_producto);
           db.AddParameter("@ds_prodalias", prod.Ds_prodalias);
           db.AddParameter("@idEmpresa", prod.IdEmpresa);
           IDataReader reader = db.ExecuteReader("MG_GenerarCodeprod1");

           while (reader.Read())
           {
               Dato _dato = new Dato();

               _dato.id = reader["id_Producto"].ToString();
              _dato.desc = reader["id_Producto"].ToString();
               _lista.Add(_dato);
           }
           return _lista;
       }


       public static DataSet ProductoFill(EProducto prod)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@psintypesel", prod.psintypesel);
           db.AddParameter("@id_producto", prod.Id_producto);
           db.AddParameter("@ds_producto", prod.Ds_producto);
           db.AddParameter("@dsPresent", prod.Ds_prese);
           
           db.AddParameter("@id_empresa", prod.IdEmpresa);

           return db.ExecuteDataSet("MG_Producto_qry01_prueba");
       }

       private static EProducto mCargarProd(IDataReader rdr)
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

           return oproducto;
       }

       public static EProducto mObtenerProducto(EProducto eprod)
       {
           DBAccess db = new DBAccess();
           db.AddParameter("@pchr_idproducto", eprod.Id_producto);
           db.AddParameter("@pchr_idEmpresa", eprod.IdEmpresa);
           List<EProducto> result = new List<EProducto>();
           using (IDataReader rd = db.ExecuteReader("MG_Producto_qry03"))
           {
               while (rd.Read())
               {
                   return mCargarProd(rd);
               }
           }

           return eprod;
       }

       public static DataSet ProductoFill_(EProducto prod)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@idproducto", prod.Id_producto);
           db.AddParameter("@dsProducto", prod.Ds_producto);
           db.AddParameter("@idEmpresa", prod.IdEmpresa);

           return db.ExecuteDataSet("MG_Producto_qry02");
       }




       public static void Producto_Insert(EProducto prod)
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
         
           db.ExecuteNonQuery("MG_productos_Insert");
           
       }



       private static EDetProducto mCargarProducto(IDataReader rdr)
       {
           EDetProducto oProd = new EDetProducto();
           oProd._Codigo = rdr.IsDBNull(rdr.GetOrdinal("Codigo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("Codigo"));

           oProd._Producto = rdr.IsDBNull(rdr.GetOrdinal("Producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("Producto"));
           oProd._Presenta = rdr.IsDBNull(rdr.GetOrdinal("Presenta")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("Presenta"));
           oProd._UM = rdr.IsDBNull(rdr.GetOrdinal("UM")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("UM"));
           oProd._Peso_Bruto = rdr.IsDBNull(rdr.GetOrdinal("Peso Bruto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("Peso Bruto"));
           oProd._id_tipgstimp = rdr.IsDBNull(rdr.GetOrdinal("id_tipogsto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tipogsto"));
           oProd._dstg = rdr.IsDBNull(rdr.GetOrdinal("ds_tipogsto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_tipogsto"));
           oProd._Pres = rdr.IsDBNull(rdr.GetOrdinal("id_prodprese")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_prodprese"));

           return oProd;
       }




       public static EDetProducto mListarProductoDGen(EDetProducto eprod)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@id_producto", eprod._Codigo);
           db.AddParameter("@id_Present", eprod._Pres);
           db.AddParameter("@id_empresa", eprod._Empresa);

           List<ETerceros> result = new List<ETerceros>();

           using (IDataReader rd = db.ExecuteReader("MG_Producto_qry05"))
           {

               while (rd.Read())
               {
                   return mCargarProducto(rd);
               }

           }

           return eprod;
       }

       private static EProducto mCargarExistenciaProducto(IDataReader rdr)
       {
           EProducto oprod = new EProducto();
           oprod.existe = rdr.IsDBNull(rdr.GetOrdinal("existe")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("existe"));
           return oprod;
       }


       public static List<EProducto> MG_Producto_qry06(EProducto prod)
       {
           DBAccess db = new DBAccess();
           db.AddParameter("@pid_producto", prod.Id_producto);
           db.AddParameter("@pidEmpresa", prod.IdEmpresa);

           List<EProducto> result = new List<EProducto>();

           using (IDataReader rdr = db.ExecuteReader("MG_Producto_qry06"))
           {
               while (rdr.Read())
               {
                   result.Add(mCargarExistenciaProducto(rdr));
               }
           }
           return result;
       }



    }
}
