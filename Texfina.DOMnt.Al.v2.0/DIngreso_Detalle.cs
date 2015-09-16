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
    public class DIngreso_Detalle
    {

        public static void IngresoDetalle_mnt01(EIngresoDetalle obj)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", obj.IdEmpresa);
            db.AddParameter("@pidIngreso", obj.IdIngreso);
            db.AddParameter("@pidPeriodo", obj.IdPeriodo);
            db.AddParameter("@pCod_Bar", obj.Cod_Bar);
            db.AddParameter("@pid_producto", obj.Id_producto);
            db.AddParameter("@pid_clipro", obj.Id_clipro);
            db.AddParameter("@pid_color", obj.Id_color);
            db.AddParameter("@pnu_Item", obj.Nu_Item);
            db.AddParameter("@pnu_tf", obj.Nu_tf);
            db.AddParameter("@pnu_op", obj.Nu_op);
            db.AddParameter("@pid_Mercado", obj.Id_mercado);
            db.AddParameter("@pid_tipTela", obj.Id_tipTela);
            db.AddParameter("@pid_Tipo", obj.Id_Tipo);
            db.AddParameter("@pid_TipIngreso", obj.Id_TipIngreso);
            db.AddParameter("@pqt_rollo", obj.Qt_rollo);
            db.AddParameter("@pqt_peso_desp", obj.Qt_peso_desp);
            db.AddParameter("@pqt_peso_real", obj.Qt_peso_real);
            db.AddParameter("@pqt_peso_actual", obj.Qt_peso_actual);
            db.AddParameter("@pqt_densidad", obj.Qt_densidad);
            db.AddParameter("@pqt_ancho", obj.Qt_ancho);
            db.AddParameter("@pidVendedor", obj.id_Vendedor);            
            db.AddParameter("@pst_estado", obj.St_estado);
            db.AddParameter("@pid_ucreatrec", obj.Id_ucreatrec);
            db.AddParameter("@Cod_Bar2", obj.Cod_Bar2);
            db.ExecuteNonQuery("AL_Ingreso_Detalle_mnt01");

        }



     public static DataSet AL_IngresoDetalle_qry02(EIngresoDetalle obj)
       {
           DBAccess db = new DBAccess();

            db.AddParameter("@psintypesel", obj.psintypesel);
            db.AddParameter("@pid_empresa", obj.IdEmpresa);
            db.AddParameter("@id_periodo", obj.IdPeriodo);
            db.AddParameter("@id_ingreso", obj.IdIngreso);
            db.AddParameter("@nu_tf", obj.Nu_tf);
            db.AddParameter("@ds_producto", obj.ds_producto);
           return db.ExecuteDataSet("AL_IngresoDetalle_qry02");
       }



     private static EIngresoDetalle mCargarIngDet(IDataReader rdr)
     {
         EIngresoDetalle objID = new EIngresoDetalle();
         objID.Nu_Item = rdr.IsDBNull(rdr.GetOrdinal("nu_Item")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_Item"));
         objID.Nu_tf = rdr.IsDBNull(rdr.GetOrdinal("nu_tf")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_tf"));
         objID.Nu_op = rdr.IsDBNull(rdr.GetOrdinal("nu_op")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_op"));
         objID.Id_mercado = rdr.IsDBNull(rdr.GetOrdinal("id_Mercado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Mercado"));
         objID.Id_tipTela = rdr.IsDBNull(rdr.GetOrdinal("id_tipTela")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tipTela"));
         objID.Id_Tipo = rdr.IsDBNull(rdr.GetOrdinal("id_Tipo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Tipo"));
         objID.Id_TipIngreso = rdr.IsDBNull(rdr.GetOrdinal("id_TipIngreso")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_TipIngreso"));
         objID.Id_clipro = rdr.IsDBNull(rdr.GetOrdinal("id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clipro"));
         objID.ds_clipro = rdr.IsDBNull(rdr.GetOrdinal("dsCliente")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsCliente"));
         objID.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
         objID.ds_producto = rdr.IsDBNull(rdr.GetOrdinal("dsProducto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsProducto"));
         objID.Id_color = rdr.IsDBNull(rdr.GetOrdinal("id_color")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_color"));
         objID.ds_color = rdr.IsDBNull(rdr.GetOrdinal("dsColor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsColor"));
         objID.Qt_rollo = rdr.IsDBNull(rdr.GetOrdinal("qt_rollo")) ? 0 : rdr.GetInt32(rdr.GetOrdinal("qt_rollo"));
         objID.Qt_peso_desp = rdr.IsDBNull(rdr.GetOrdinal("qt_peso_desp")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso_desp"));
         objID.Qt_ancho = rdr.IsDBNull(rdr.GetOrdinal("qt_ancho")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_ancho"));
         objID.Qt_densidad = rdr.IsDBNull(rdr.GetOrdinal("qt_densidad")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_densidad"));
         objID.id_Vendedor = rdr.IsDBNull(rdr.GetOrdinal("id_Vendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Vendedor"));
         objID.Ds_Vendedor = rdr.IsDBNull(rdr.GetOrdinal("dsVendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsVendedor"));
        
         return objID;
     }



     public static List<EIngresoDetalle> AL_IngresoDetalle_qry01(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();

         db.AddParameter("@pid_empresa", obj.IdEmpresa);
         db.AddParameter("@id_periodo", obj.IdPeriodo);
         db.AddParameter("@id_ingreso", obj.IdIngreso);


         List<EIngresoDetalle> result = new List<EIngresoDetalle>();
         using (IDataReader rd = db.ExecuteReader("AL_IngresoDetalle_qry01"))
         {
             while (rd.Read())
             {
                 result.Add(mCargarIngDet(rd));
             }
         }

         return result;
     }



     private static EIngresoDetalle _mCargarIngDet(IDataReader rdr)
     {
         EIngresoDetalle objID = new EIngresoDetalle();
         objID.Cod_Bar = rdr.IsDBNull(rdr.GetOrdinal("Cod_Bar")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("Cod_Bar"));
         objID.Nu_Item = rdr.IsDBNull(rdr.GetOrdinal("nu_Item")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_Item"));
         objID.Nu_tf = rdr.IsDBNull(rdr.GetOrdinal("nu_tf")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_tf"));
         objID.Nu_op = rdr.IsDBNull(rdr.GetOrdinal("nu_op")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_op"));
         objID.Id_mercado = rdr.IsDBNull(rdr.GetOrdinal("id_Mercado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Mercado"));
         objID.Id_tipTela = rdr.IsDBNull(rdr.GetOrdinal("id_tipTela")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tipTela"));
         objID.Id_Tipo = rdr.IsDBNull(rdr.GetOrdinal("id_Tipo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Tipo"));
         objID.Id_TipIngreso = rdr.IsDBNull(rdr.GetOrdinal("id_TipIngreso")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_TipIngreso"));
         objID.Id_clipro = rdr.IsDBNull(rdr.GetOrdinal("id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clipro"));
         objID.ds_clipro = rdr.IsDBNull(rdr.GetOrdinal("dsCliente")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsCliente"));
         objID.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
         objID.ds_producto = rdr.IsDBNull(rdr.GetOrdinal("dsProducto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsProducto"));
         objID.Id_color = rdr.IsDBNull(rdr.GetOrdinal("id_color")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_color"));
         objID.ds_color = rdr.IsDBNull(rdr.GetOrdinal("dsColor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsColor"));
         objID.Qt_rollo = rdr.IsDBNull(rdr.GetOrdinal("qt_rollo")) ? 0 : rdr.GetInt32(rdr.GetOrdinal("qt_rollo"));
         objID.Qt_peso_desp = rdr.IsDBNull(rdr.GetOrdinal("qt_peso_desp")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso_desp"));
         objID.Qt_peso_real = rdr.IsDBNull(rdr.GetOrdinal("qt_peso_real")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso_real"));
         objID.Qt_ancho = rdr.IsDBNull(rdr.GetOrdinal("qt_ancho")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_ancho"));
         objID.Qt_densidad = rdr.IsDBNull(rdr.GetOrdinal("qt_densidad")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_densidad"));
         objID.id_Vendedor = rdr.IsDBNull(rdr.GetOrdinal("id_Vendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Vendedor"));
         objID.Ds_Vendedor = rdr.IsDBNull(rdr.GetOrdinal("dsVendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsVendedor"));
         return objID;
     }


     public static List<EIngresoDetalle> AL_IngresoDetalle_qry03(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();

         db.AddParameter("@pid_empresa", obj.IdEmpresa);
         db.AddParameter("@id_periodo", obj.IdPeriodo);
         db.AddParameter("@id_ingreso", obj.IdIngreso);


         List<EIngresoDetalle> result = new List<EIngresoDetalle>();
         using (IDataReader rd = db.ExecuteReader("AL_IngresoDetalle_qry03"))
         {
             while (rd.Read())
             {
                 result.Add(_mCargarIngDet(rd));
             }
         }

         return result;
     }


     public static void AL_Ingreso_Detalle_mnt03(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();

         db.AddParameter("@pidEmpresa", obj.IdEmpresa);
         db.AddParameter("@pidPeriodo", obj.IdPeriodo);
         db.AddParameter("@pidIngreso", obj.IdIngreso);
         db.AddParameter("@pnu_tf", obj.Nu_tf);
         db.AddParameter("@pid_producto", obj.Id_producto);
         db.AddParameter("@pid_uupdarec", obj.Id_uupdarec);
         db.ExecuteNonQuery("AL_Ingreso_Detalle_mnt03");

     }



     private static EParametros mCargarIngresoDetalle(IDataReader rdr)
     {

         EParametros obj = new EParametros();
         obj.idIngreso = rdr.IsDBNull(rdr.GetOrdinal("idIngreso")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idIngreso"));
         obj.nu_Item = rdr.IsDBNull(rdr.GetOrdinal("nu_Item")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_Item"));
         obj.feguia = rdr.IsDBNull(rdr.GetOrdinal("feguia")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("feguia"));
         obj.id_docucom = rdr.IsDBNull(rdr.GetOrdinal("id_docucom")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_docucom"));
         obj.nu_doc = rdr.IsDBNull(rdr.GetOrdinal("nu_doc")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_doc"));
         obj.id_Almacen = rdr.IsDBNull(rdr.GetOrdinal("id_Almacen")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Almacen"));
         obj.id_Tipo = rdr.IsDBNull(rdr.GetOrdinal("id_Tipo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Tipo"));
         obj.id_TipIngreso = rdr.IsDBNull(rdr.GetOrdinal("id_TipIngreso")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_TipIngreso"));
         obj.id_tiptela = rdr.IsDBNull(rdr.GetOrdinal("id_tipTela")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tipTela"));
         obj.id_mercado = rdr.IsDBNull(rdr.GetOrdinal("id_Mercado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Mercado"));
         obj.id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
         obj.ds_producto = rdr.IsDBNull(rdr.GetOrdinal("ds_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_producto"));
         obj.id_color = rdr.IsDBNull(rdr.GetOrdinal("id_color")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_color"));
         obj.ds_color = rdr.IsDBNull(rdr.GetOrdinal("ds_color")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_color"));
         obj.nu_tf = rdr.IsDBNull(rdr.GetOrdinal("nu_tf")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_tf"));
         obj.nu_op = rdr.IsDBNull(rdr.GetOrdinal("nu_op")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_op"));
         obj.qt_rollo = rdr.IsDBNull(rdr.GetOrdinal("qt_rollo")) ? 0 : rdr.GetInt32(rdr.GetOrdinal("qt_rollo"));
         obj.id_clipro = rdr.IsDBNull(rdr.GetOrdinal("id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clipro"));
         obj.ds_raznombre = rdr.IsDBNull(rdr.GetOrdinal("ds_raznombre")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_raznombre"));
         obj.id_vendedor = rdr.IsDBNull(rdr.GetOrdinal("id_vendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vendedor"));
         obj.dsVendedor = rdr.IsDBNull(rdr.GetOrdinal("dsVendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsVendedor"));
         obj.qt_ancho = rdr.IsDBNull(rdr.GetOrdinal("qt_ancho")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_ancho"));
         obj.qt_densidad = rdr.IsDBNull(rdr.GetOrdinal("qt_densidad")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_densidad"));
         obj.qt_peso_desp = rdr.IsDBNull(rdr.GetOrdinal("qt_peso_desp")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso_desp"));
         obj.qt_peso_real = rdr.IsDBNull(rdr.GetOrdinal("qt_peso_real")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso_real"));
         obj.qt_peso_actual = rdr.IsDBNull(rdr.GetOrdinal("qt_peso_actual")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso_actual"));
         obj.codbarra = rdr.IsDBNull(rdr.GetOrdinal("Cod_Bar")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("Cod_Bar"));
        
         return obj;
     }
        





     public static EParametros AL_Ingreso_Detalle_qry7(EParametros obj)
     {
         DBAccess db = new DBAccess();

         db.AddParameter("@pidEmpresa", obj.idEmpresa);
         db.AddParameter("@pidPeriodo", obj.idperiodo);
         db.AddParameter("@pCod_Bar", obj.codbarra);


         using (IDataReader rd = db.ExecuteReader("AL_Ingreso_Detalle_qry7"))
         {
             while (rd.Read())
             {
                 return mCargarIngresoDetalle(rd);
             }
         }

         return obj;
     }


     public static void AL_Ingreso_Detalle_mnt02(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();

         db.AddParameter("@idEmpresa", obj.IdEmpresa);
         db.AddParameter("@idPeriodo", obj.IdPeriodo);
         db.AddParameter("@Cod_Bar", obj.Cod_Bar);
         db.AddParameter("@qt_peso_real", obj.Qt_peso_real);
         db.AddParameter("@id_uupdarec", obj.Id_uupdarec);
         db.ExecuteNonQuery("AL_Ingreso_Detalle_mnt02");

     }


     public static DataSet AL_Producto_Stock(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();

         db.AddParameter("@psintypesel", obj.psintypesel);
         db.AddParameter("@pidEmpresa", obj.IdEmpresa);
         db.AddParameter("@ds_raznombre", obj.ds_clipro);
         db.AddParameter("@ds_producto", obj.ds_producto);
         db.AddParameter("@ds_vendedor", obj.Ds_Vendedor);
         db.AddParameter("@ds_color", obj.ds_color); 

         return db.ExecuteDataSet("AL_Ingreso_Detalle_Stock");
     }

        //**************************************************************
     public static DataSet AL_Ingreso_Detalle_Stock_TF(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();

         db.AddParameter("@psintypesel", obj.psintypesel);
         db.AddParameter("@pidEmpresa", obj.IdEmpresa);
         db.AddParameter("@ds_raznombre", obj.ds_clipro);
         db.AddParameter("@ds_producto", obj.ds_producto);
         db.AddParameter("@ds_vendedor", obj.Ds_Vendedor);
         db.AddParameter("@ds_color", obj.ds_color);
         db.AddParameter("@nu_tf", obj.Nu_tf);

         return db.ExecuteDataSet("AL_Ingreso_Detalle_Stock_TF");
     }

     //**************************************************************





     private static EIngresoDetalle mCargarIngresoDetalle_qry04(IDataReader rdr)
     {
         EIngresoDetalle objID = new EIngresoDetalle();
         objID.Nu_Item = rdr.IsDBNull(rdr.GetOrdinal("nu_Item")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_Item"));
         objID.Cod_Bar = rdr.IsDBNull(rdr.GetOrdinal("Cod_Bar")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("Cod_Bar"));
         objID.Qt_rollo = rdr.IsDBNull(rdr.GetOrdinal("qt_rollo_actual")) ? 0 : rdr.GetInt32(rdr.GetOrdinal("qt_rollo_actual"));
         objID.Qt_peso_desp = rdr.IsDBNull(rdr.GetOrdinal("qt_peso_desp")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso_desp"));
         objID.Qt_peso_real = rdr.IsDBNull(rdr.GetOrdinal("qt_peso_real")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso_real"));

         return objID;
     }


     public static List<EIngresoDetalle> AL_IngresoDetalle_qry04(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();

         db.AddParameter("@idEmpresa", obj.IdEmpresa);
         db.AddParameter("@idPeriodo", obj.IdPeriodo);
         db.AddParameter("@idIngreso", obj.IdIngreso);
         db.AddParameter("@nu_tf", obj.Nu_tf);
         db.AddParameter("@id_clipro", obj.Id_clipro);
         db.AddParameter("@id_producto", obj.Id_producto);
         db.AddParameter("@id_color", obj.Id_color);
         db.AddParameter("@NROLLO", obj.nrollo);



         List<EIngresoDetalle> result = new List<EIngresoDetalle>();
         using (IDataReader rd = db.ExecuteReader("AL_IngresoDetalle_qry04"))
         {
             while (rd.Read())
             {
                 result.Add(mCargarIngresoDetalle_qry04(rd));
             }
         }

         return result;
     }


     public static void AL_Ingreso_Detalle_mnt04(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();

         db.AddParameter("@pidEmpresa", obj.IdEmpresa);
         db.AddParameter("@pidPeriodo", obj.IdPeriodo);
         db.AddParameter("@pidIngreso", obj.IdIngreso);
         db.AddParameter("@pnu_tf", obj.Nu_tf);
         db.AddParameter("@pid_producto", obj.Id_producto);
         db.AddParameter("@pCod_Bar", obj.Cod_Bar);
         db.AddParameter("@pnu_Item", obj.Nu_Item);
         db.AddParameter("@pid_uupdarec", obj.Id_uupdarec);
         db.ExecuteNonQuery("AL_Ingreso_Detalle_mnt04");

     }


     public static void AL_Ingreso_Detalle_mnt05(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();

         db.AddParameter("@idEmpresa", obj.IdEmpresa);
         db.AddParameter("@idPeriodo", obj.IdPeriodo);
         db.AddParameter("@Cod_Bar", obj.Cod_Bar);
         db.AddParameter("@idIngreso", obj.IdIngreso);
         db.AddParameter("@qt_peso_real", obj.Qt_peso_real);
         db.AddParameter("@id_uupdarec", obj.Id_uupdarec);
         db.ExecuteNonQuery("AL_Ingreso_Detalle_mnt05");

     }
     public static void AL_Ingreso_Detalle_mnt06(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();

         db.AddParameter("@pidEmpresa", obj.IdEmpresa);
         db.AddParameter("@pidIngreso", obj.IdIngreso);
         db.AddParameter("@pidPeriodo", obj.IdPeriodo);
         db.AddParameter("@pCod_Bar", obj.Cod_Bar);
         db.AddParameter("@pid_producto", obj.Id_producto);
         db.AddParameter("@pid_clipro", obj.Id_clipro);
         db.AddParameter("@pid_color", obj.Id_color);
         db.AddParameter("@pnu_Item", obj.Nu_Item);
         db.AddParameter("@pnu_tf", obj.Nu_tf);
         db.AddParameter("@pnu_op", obj.Nu_op);
         db.AddParameter("@pid_Mercado", obj.Id_mercado);
         db.AddParameter("@pid_tipTela", obj.Id_tipTela);
         db.AddParameter("@pid_Tipo", obj.Id_Tipo);
         db.AddParameter("@pid_TipIngreso", obj.Id_TipIngreso);
         db.AddParameter("@pqt_rollo", obj.Qt_rollo);
         db.AddParameter("@pqt_peso_desp", obj.Qt_peso_desp);
         db.AddParameter("@pqt_peso_real", obj.Qt_peso_real);
         db.AddParameter("@pqt_peso_actual", obj.Qt_peso_actual);
         db.AddParameter("@pqt_densidad", obj.Qt_densidad);
         db.AddParameter("@pqt_ancho", obj.Qt_ancho);
         db.AddParameter("@pidVendedor", obj.id_Vendedor);         
         db.AddParameter("@pst_estado", obj.St_estado);
         db.AddParameter("@pCod_Bar2", obj.Cod_Bar2);
         db.AddParameter("@pid_ucreatrec", obj.Id_ucreatrec);
         db.ExecuteNonQuery("AL_Ingreso_Detalle_mnt06");

     }


     public DataTable AL_Ingreso_etiqueta02_rpt(EIngresoDetalle oc)
     {
         DBAccess db = new DBAccess();
         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DBAccess.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, oc.IdEmpresa));
         //arrPrm.Add(DBAccess.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, oc.IdPeriodo));
         arrPrm.Add(DBAccess.CreateParameter("@pidIngreso", SqlDbType.Char, 7, oc.IdIngreso));
         arrPrm.Add(DBAccess.CreateParameter("@Cod_Bar", SqlDbType.VarChar, 23, oc.Cod_Bar));

         

         DataTable dt = db.ExecuteDatatable("AL_Ingreso_etiqueta02_rpt", arrPrm);
         return dt;
     }


     public DataTable AL_Ingreso_etiqueta03_rpt(EIngresoDetalle oc)
     {
         DBAccess db = new DBAccess();
         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DBAccess.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, oc.IdEmpresa));                  
         arrPrm.Add(DBAccess.CreateParameter("@Cod_Bar", SqlDbType.VarChar, oc.Cod_Bar));
         DataTable dt = db.ExecuteDatatable("AL_Ingreso_etiqueta03_rpt", arrPrm);
         return dt;
     }

     public static void AL_Ingreso_Detalle_mnt07(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();

         db.AddParameter("@pidEmpresa", obj.IdEmpresa);
         db.AddParameter("@pidIngreso", obj.IdIngreso);
         db.AddParameter("@pidPeriodo", obj.IdPeriodo);         
         db.AddParameter("@pid_producto", obj.Id_producto);
         db.AddParameter("@pid_clipro", obj.Id_clipro);
         db.AddParameter("@pid_color", obj.Id_color);         
         db.AddParameter("@pnu_tf", obj.Nu_tf);
         db.AddParameter("@pnu_op", obj.Nu_op);
         db.AddParameter("@pid_Mercado", obj.Id_mercado);
         db.AddParameter("@pid_tipTela", obj.Id_tipTela);
         db.AddParameter("@pid_Tipo", obj.Id_Tipo);
         db.AddParameter("@pid_TipIngreso", obj.Id_TipIngreso);         
         db.AddParameter("@pqt_peso_desp", obj.Qt_peso_desp);
         db.AddParameter("@pqt_densidad", obj.Qt_densidad);
         db.AddParameter("@pidVendedor", obj.id_Vendedor);
         db.AddParameter("@pqt_ancho", obj.Qt_ancho);        
         db.AddParameter("@pid_ucreatrec", obj.Id_ucreatrec);
         db.ExecuteNonQuery("AL_Ingreso_Detalle_mnt07");

     }


     public static List<EIngresoDetalle> AL_Ingreso_Detalle_Stock02(EIngresoDetalle obj)
     {
         List<EIngresoDetalle> _lista = new List<EIngresoDetalle>();

         DBAccess db = new DBAccess();
         db.AddParameter("@pidEmpresa", obj.IdEmpresa);
         db.AddParameter("@id_clipro", obj.Id_clipro);
         db.AddParameter("@id_producto", obj.Id_producto);
         db.AddParameter("@id_vendedor", obj.id_Vendedor);
         db.AddParameter("@id_color", obj.Id_color);

         IDataReader reader = db.ExecuteReader("AL_Ingreso_Detalle_Stock02");

         while (reader.Read())
         {
             EIngresoDetalle _dato = new EIngresoDetalle();

             _dato.Qt_rollo = Convert.ToInt16(reader["stock"]);
             _dato.qt_rollo_reserv = Convert.ToInt16(reader["reservado"]);

             _lista.Add(_dato);
         }
         return _lista;
     }


     public DataTable AL_Ingreso_Detalle_rpt01(EIngresoDetalle oc)
     {
         DBAccess db = new DBAccess();
         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, oc.IdEmpresa));
         arrPrm.Add(DBAccess.CreateParameter("@feIni", SqlDbType.VarChar, 10, oc.fecha));
         arrPrm.Add(DBAccess.CreateParameter("@feFin", SqlDbType.VarChar, 10, oc.fechaFin));
         arrPrm.Add(DBAccess.CreateParameter("@dsCliente", SqlDbType.VarChar, 60, oc.ds_clipro));
         arrPrm.Add(DBAccess.CreateParameter("@dsProducto", SqlDbType.VarChar, 100, oc.ds_producto));
         arrPrm.Add(DBAccess.CreateParameter("@dsColor", SqlDbType.VarChar, 80, oc.ds_color));
         arrPrm.Add(DBAccess.CreateParameter("@dsMercado", SqlDbType.VarChar, 30, oc.Id_mercado));
         arrPrm.Add(DBAccess.CreateParameter("@dsTipTela", SqlDbType.VarChar, 20, oc.Id_tipTela));
         arrPrm.Add(DBAccess.CreateParameter("@dsTipIngreso", SqlDbType.VarChar, 30, oc.Id_TipIngreso));
         arrPrm.Add(DBAccess.CreateParameter("@dsTipo", SqlDbType.VarChar, 30, oc.Id_Tipo));



         DataTable dt = db.ExecuteDatatable("AL_Ingreso_Detalle_rpt01", arrPrm);
         return dt;
     }

     public DataTable _AL_Producto_Stock(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();
         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DBAccess.CreateParameter("@psintypesel", SqlDbType.Char, 1, obj.psintypesel));
         arrPrm.Add(DBAccess.CreateParameter("@pidEmpresa", SqlDbType.VarChar, 3, obj.IdEmpresa));
         arrPrm.Add(DBAccess.CreateParameter("@ds_raznombre", SqlDbType.VarChar, 60, obj.ds_clipro));
         arrPrm.Add(DBAccess.CreateParameter("@ds_producto", SqlDbType.VarChar, 100, obj.ds_producto));
         arrPrm.Add(DBAccess.CreateParameter("@ds_vendedor", SqlDbType.VarChar, 60, obj.Ds_Vendedor));
         arrPrm.Add(DBAccess.CreateParameter("@ds_color", SqlDbType.VarChar, 60, obj.ds_color));

         DataTable dt = db.ExecuteDatatable("AL_Ingreso_Detalle_Stock", arrPrm);
         return dt;
     }



     public DataTable _AL_Ingreso_Detalle_Stock_TF(EIngresoDetalle obj)
     {
         DBAccess db = new DBAccess();
         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DBAccess.CreateParameter("@psintypesel", SqlDbType.Char, 1, obj.psintypesel));
         arrPrm.Add(DBAccess.CreateParameter("@pidEmpresa", SqlDbType.VarChar, 3, obj.IdEmpresa));
         arrPrm.Add(DBAccess.CreateParameter("@ds_raznombre", SqlDbType.VarChar, 60, obj.ds_clipro));
         arrPrm.Add(DBAccess.CreateParameter("@ds_producto", SqlDbType.VarChar, 100, obj.ds_producto));
         arrPrm.Add(DBAccess.CreateParameter("@ds_vendedor", SqlDbType.VarChar, 60, obj.Ds_Vendedor));
         arrPrm.Add(DBAccess.CreateParameter("@ds_color", SqlDbType.VarChar, 60, obj.ds_color));
         arrPrm.Add(DBAccess.CreateParameter("@nu_tf", SqlDbType.VarChar, 60, obj.Nu_tf));

         DataTable dt = db.ExecuteDatatable("AL_Ingreso_Detalle_Stock_TF", arrPrm);
         return dt;
     }


    }
}
