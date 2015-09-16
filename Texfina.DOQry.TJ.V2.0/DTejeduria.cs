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
  public class DTejeduria
    {

      public static DataSet TJ_tejeduria_qry05(ETejeduria tj)
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


          return db.ExecuteDataSet("TJ_Tejeduria_qry05");
      }


      private static ETejeduria mCargarExistenciaTJ(IDataReader rdr)
      {
          ETejeduria oTJ = new ETejeduria();
          oTJ.existe = rdr.IsDBNull(rdr.GetOrdinal("existe")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("existe"));
          return oTJ;
      }

      public static List<ETejeduria> TJ_tejeduria_qry06(ETejeduria oTJ)
      {
          DBAccess db = new DBAccess();
          db.AddParameter("@pidEmpresa", oTJ.IdEmpresa);
          //db.AddParameter("@pidPeriodo", oTJ.IdPeriodo);
          db.AddParameter("@pid_producto", oTJ.Id_producto);
          db.AddParameter("@pnu_correficha", oTJ.Nu_correficha);
          db.AddParameter("@pexists", oTJ.existe);


          List<ETejeduria> result = new List<ETejeduria>();

          using (IDataReader rdr = db.ExecuteReader("TJ_Tejeduria_qry06"))
          {
              while (rdr.Read())
              {
                  result.Add(mCargarExistenciaTJ(rdr));
              }
          }
          return result;
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

          oTJ.Nu_refmuestra = rdr.IsDBNull(rdr.GetOrdinal("nu_refmuestra")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_refmuestra"));
          oTJ.Nu_tf = rdr.IsDBNull(rdr.GetOrdinal("nu_tf")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_tf"));
          oTJ.Nu_gt = rdr.IsDBNull(rdr.GetOrdinal("nu_gt")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_gt"));
          oTJ.Nu_tfref = rdr.IsDBNull(rdr.GetOrdinal("nu_tfref")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_tfref"));
          oTJ.Id_vtipmcdo = rdr.IsDBNull(rdr.GetOrdinal("id_vtipmcdo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vtipmcdo"));
          
          oTJ.Nu_regula = rdr.IsDBNull(rdr.GetOrdinal("nu_regula")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_regula"));
          oTJ.Id_vdestino = rdr.IsDBNull(rdr.GetOrdinal("id_vdestino")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vdestino"));
          
          oTJ.Id_vtipancru = rdr.IsDBNull(rdr.GetOrdinal("id_vtipancru")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vtipancru"));
          
          oTJ.Qt_anchcrudo = rdr.IsDBNull(rdr.GetOrdinal("qt_anchcrudo")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_anchcrudo"));

          oTJ.Qt_denscrudo = rdr.IsDBNull(rdr.GetOrdinal("qt_denscrudo")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_denscrudo"));
          oTJ.Qt_rendcrudo = rdr.IsDBNull(rdr.GetOrdinal("qt_rendcrudo")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_rendcrudo"));

          oTJ.Qt_anchacaba = rdr.IsDBNull(rdr.GetOrdinal("qt_anchacaba")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_anchacaba"));
          oTJ.Qt_densacaba = rdr.IsDBNull(rdr.GetOrdinal("qt_densacaba")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_densacaba"));
          oTJ.Qt_rendacaba = rdr.IsDBNull(rdr.GetOrdinal("qt_rendacaba")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_rendacaba"));
          oTJ.Id_maqtenido = rdr.IsDBNull(rdr.GetOrdinal("id_maqtenido")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_maqtenido"));

          oTJ.Nu_porencla = rdr.IsDBNull(rdr.GetOrdinal("nu_porencla")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("nu_porencla"));

          oTJ.Nu_porencan = rdr.IsDBNull(rdr.GetOrdinal("nu_porencan")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("nu_porencan"));

          oTJ.Ds_observa = rdr.IsDBNull(rdr.GetOrdinal("ds_observa")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_observa"));

          oTJ.Nu_porrev = rdr.IsDBNull(rdr.GetOrdinal("nu_porrev")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("nu_porrev"));

          oTJ.Nu_gradosrev = rdr.IsDBNull(rdr.GetOrdinal("nu_gradosrev")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("nu_gradosrev"));
          oTJ.Nu_pormerma = rdr.IsDBNull(rdr.GetOrdinal("nu_pormerma")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("nu_pormerma"));
          oTJ.Mt_costtenido = rdr.IsDBNull(rdr.GetOrdinal("mt_costtenido")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_costtenido"));
          oTJ.Mt_totconsumo = rdr.IsDBNull(rdr.GetOrdinal("mt_totconsumo")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_totconsumo"));
          oTJ.Id_ptmaq = rdr.IsDBNull(rdr.GetOrdinal("id_ptmaq")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_ptmaq"));
          oTJ.Nu_ptdiame = rdr.IsDBNull(rdr.GetOrdinal("nu_ptdiame")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("nu_ptdiame"));
          oTJ.Nu_ptgalga = rdr.IsDBNull(rdr.GetOrdinal("nu_ptgalga")) ? 0 : rdr.GetInt16(rdr.GetOrdinal("nu_ptgalga"));
          
          oTJ.Nu_ptsistrab = rdr.IsDBNull(rdr.GetOrdinal("nu_ptsistrab")) ? 0 : rdr.GetInt16(rdr.GetOrdinal("nu_ptsistrab"));
          oTJ.Nu_ptsisanul = rdr.IsDBNull(rdr.GetOrdinal("nu_ptsisanul")) ? 0 : rdr.GetInt16(rdr.GetOrdinal("nu_ptsisanul"));
          oTJ.Nu_ptrpm = rdr.IsDBNull(rdr.GetOrdinal("nu_ptrpm")) ? 0 : rdr.GetInt16(rdr.GetOrdinal("nu_ptrpm"));
          
          oTJ.Qt_ptpeso = rdr.IsDBNull(rdr.GetOrdinal("qt_ptpeso")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_ptpeso"));
          oTJ.Ds_obstejido = rdr.IsDBNull(rdr.GetOrdinal("ds_obstejido")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_obstejido"));
          oTJ.Ds_evadeftj = rdr.IsDBNull(rdr.GetOrdinal("ds_evadeftj")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_evadeftj"));

          oTJ.nu_platina = rdr.IsDBNull(rdr.GetOrdinal("nu_platina")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("nu_platina"));
          oTJ.qt_anchdatreqacaba = rdr.IsDBNull(rdr.GetOrdinal("qt_anchdatreqacaba")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_anchdatreqacaba"));
          oTJ.qt_densdatreqacaba = rdr.IsDBNull(rdr.GetOrdinal("qt_densdatreqacaba")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_densdatreqacaba"));
          oTJ.Id_Color = rdr.IsDBNull(rdr.GetOrdinal("id_color")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_color"));

          oTJ.ds_Color = rdr.IsDBNull(rdr.GetOrdinal("dsColor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsColor"));
          return oTJ;
      }


      public static ETejeduria TJ_Tejeduria_qry07(ETejeduria oTJ)
      {
          DBAccess db = new DBAccess();

          db.AddParameter("@pchr_idEmpresa", oTJ.IdEmpresa);
          db.AddParameter("@pchr_idproducto", oTJ.Id_producto);
          db.AddParameter("@pchr_nucorreficha", oTJ.Nu_correficha);
          db.AddParameter("@pchr_nutf", oTJ.Nu_tf);
          db.AddParameter("@pchr_nutfref", oTJ.Nu_tfref);

          List<ETejeduria> result = new List<ETejeduria>();
          using (IDataReader rd = db.ExecuteReader("TJ_Tejeduria_qry07"))
          {
              while (rd.Read())
              {
                  return mCargarTJ(rd);
              }
          }

          return oTJ;
      }


      public static void TJ_Tejeduria_mnt02(ETejeduria tj)
      {
          DBAccess db = new DBAccess();

          db.AddParameter("@pidEmpresa", tj.IdEmpresa);
          db.AddParameter("@pidPeriodo", tj.IdPeriodo);
          db.AddParameter("@pid_producto", tj.Id_producto);
          db.AddParameter("@pnu_correficha", tj.Nu_correficha);
          db.AddParameter("@pid_clipro", tj.Id_clipro);
          db.AddParameter("@pfe_registro", tj.Fe_registro);
          db.AddParameter("@pnu_refmuestra", tj.Nu_refmuestra);
          db.AddParameter("@pnu_tf", tj.Nu_tf);
          db.AddParameter("@pnu_gt", tj.Nu_gt);
          db.AddParameter("@pnu_tfref", tj.Nu_tfref);
          db.AddParameter("@pid_vtipmcdo", tj.Id_vtipmcdo);
          db.AddParameter("@pnu_regula", tj.Nu_regula);
          db.AddParameter("@pid_vdestino", tj.Id_vdestino);
          db.AddParameter("@pid_vtipancru", tj.Id_vtipancru);
          db.AddParameter("@pqt_anchcrudo", tj.Qt_anchcrudo);
          db.AddParameter("@pqt_denscrudo", tj.Qt_denscrudo);
          db.AddParameter("@pqt_rendcrudo", tj.Qt_rendcrudo);
          db.AddParameter("@pqt_anchacaba", tj.Qt_anchacaba);
          db.AddParameter("@pqt_densacaba", tj.Qt_densacaba);
          db.AddParameter("@pqt_rendacaba", tj.Qt_rendacaba);
          db.AddParameter("@pid_maqtenido", tj.Id_maqtenido);
          db.AddParameter("@pnu_porencla", tj.Nu_porencla);
          db.AddParameter("@pnu_porencan", tj.Nu_porencan);
          db.AddParameter("@pds_observa", tj.Ds_observa);
          db.AddParameter("@pid_ptmaq", tj.Id_ptmaq);
          db.AddParameter("@pnu_ptdiame", tj.Nu_ptdiame);
          db.AddParameter("@pnu_ptgalga", tj.Nu_ptgalga);
          db.AddParameter("@pnu_ptsistrab", tj.Nu_ptsistrab);
          db.AddParameter("@pnu_ptsisanul", tj.Nu_ptsisanul);
          db.AddParameter("@pnu_ptrpm", tj.Nu_ptrpm);
          db.AddParameter("@pqt_ptpeso", tj.Qt_ptpeso);
          //db.AddParameter("@pfe_pttejini", tj.Fe_pttejini);
          //db.AddParameter("@pfe_pttejfin", tj.Fe_pttejfin);
          db.AddParameter("@pds_obstejido", tj.Ds_obstejido);
          db.AddParameter("@pds_evadeftj", tj.Ds_evadeftj);
          db.AddParameter("@pnu_porrev", tj.Nu_porrev);
          db.AddParameter("@pnu_gradosrev", tj.Nu_gradosrev);
          db.AddParameter("@pnu_pormerma", tj.Nu_pormerma);
          db.AddParameter("@pmt_costtenido", tj.Mt_costtenido);
          db.AddParameter("@pmt_totconsumo", tj.Mt_totconsumo);
          db.AddParameter("@pnu_platina", tj.nu_platina);
          db.AddParameter("@pqt_anchdatreqacaba", tj.qt_anchdatreqacaba);
          db.AddParameter("@pqt_densdatreqacaba", tj.qt_densdatreqacaba);
          db.AddParameter("@pid_ucrearec", tj.Id_ucrearec);         
          db.AddParameter("@pid_color", tj.Id_Color);


          db.ExecuteNonQuery("TJ_Tejeduria_mnt02");

      }

      public static List<Dato> TJ_TejeduriaGenCod(string idEmpresa, string idProducto)
      {
          List<Dato> _lista = new List<Dato>();

          DBAccess db = new DBAccess();

          db.AddParameter("@pidEmpresa", idEmpresa);
          db.AddParameter("@pid_producto", idProducto);

          IDataReader reader = db.ExecuteReader("TJ_TejeduriaGenCod");

          while (reader.Read())
          {
              Dato _dato = new Dato();

              _dato.id = reader["tj_idNucorre"].ToString();

              _lista.Add(_dato);
          }
          return _lista;
      }


      public static void TJ_Tejeduria_mnt04(ETejeduria tj)
      {
          DBAccess db = new DBAccess();

          db.AddParameter("@pidEmpresa", tj.IdEmpresa);
          db.AddParameter("@pidPeriodo", tj.IdPeriodo);
          db.AddParameter("@pid_producto", tj.Id_producto);
          db.AddParameter("@pnu_correficha", tj.Nu_correficha);
          db.AddParameter("@pqt_anchacaba", tj.Qt_anchacaba);
          db.AddParameter("@pqt_densacaba", tj.Qt_densacaba);
          db.AddParameter("@pqt_rendacaba", tj.Qt_rendacaba);
          db.AddParameter("@pid_maqtenido", tj.Id_maqtenido);
          db.AddParameter("@pnu_porencla", tj.Nu_porencla);
          db.AddParameter("@pnu_porencan", tj.Nu_porencan);
          db.AddParameter("@pid_uupdarec", tj.Id_uupdarec);
          db.AddParameter("@pid_color", tj.Id_Color);

          db.ExecuteNonQuery("TJ_Tejeduria_mnt04");

      }



      public DataTable GetFichaTejeduria_rpt01(ETejeduria tj)
      {
          DBAccess db = new DBAccess();
          ArrayList arrPrm = new ArrayList();

          //arrPrm.Add(DBAccess.CreateParameter("@psintypesel", SqlDbType.Int, tj.psintypesel));
          arrPrm.Add(DBAccess.CreateParameter("@pchr_idproduct", SqlDbType.Char, 12, tj.Id_producto));
          arrPrm.Add(DBAccess.CreateParameter("@pchr_nucorreficha", SqlDbType.Char, 6, tj.Nu_correficha));
          arrPrm.Add(DBAccess.CreateParameter("@pid_empresa", SqlDbType.Char, 3, tj.IdEmpresa));

          DataTable dt = db.ExecuteDatatable("TJ_Fichatela_qry01", arrPrm);
          return dt;
      }



    }
}
