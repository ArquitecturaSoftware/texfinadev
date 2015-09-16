using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Core.Data;
using Texfina.Entity.Co;

namespace Texfina.DOQry.Co
{
    public class DFamilia
    {

        public static IDataReader Familia_qry01(int psintypesel, string idEmpresa)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", psintypesel);
            db.AddParameter("@idEmpresa", idEmpresa);
            return db.ExecuteReader("MG_Familias_qry01");
        }

        /// <summary>
        /// codigo para desktop  Familia_qry01
        /// </summary>
        /// <param name="psintypesel"></param>
        /// <param name="pchr_idgrupo"></param>
        /// <returns></returns>
        /// 

        public static List<Dato> Familia_qry01_(int Codigo, string idEmpresa)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", Codigo);
            db.AddParameter("@idEmpresa", idEmpresa);

            IDataReader reader = db.ExecuteReader("MG_Familias_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_grupo"].ToString();
                _dato.desc = reader["ds_familia"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


        public static IDataReader Familia_qry02(int psintypesel, string pchr_idgrupo, string idEmpresa)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", psintypesel);
            db.AddParameter("@pchr_idgrupo", pchr_idgrupo);
            db.AddParameter("@idEmpresa", idEmpresa);
            return db.ExecuteReader("MG_Familias_qry01");
        }
        /// <summary>
        /// codigo desktop Familia_qry02_
        /// </summary>
        
        /// <returns></returns>
        /// 
        public static List<Dato> Familia_qry02_(int psintypesel, string pchr_idgrupo, string idEmpresa)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", psintypesel);
            db.AddParameter("@pchr_idgrupo", pchr_idgrupo);
            db.AddParameter("@idEmpresa", idEmpresa);
            IDataReader reader = db.ExecuteReader("MG_Familias_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_familia"].ToString();
                _dato.desc = reader["ds_familia"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }

        public static IDataReader Familia_qry03(int psintypesel, string pchr_idgrupo, string pchr_idfamilia, string idEmpresa)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", psintypesel);
            db.AddParameter("@pchr_idgrupo", pchr_idgrupo);
            db.AddParameter("@pchr_idfamilia", pchr_idfamilia);
            db.AddParameter("@idEmpresa", pchr_idgrupo);
            return db.ExecuteReader("MG_Familias_qry01");
        }


        /// <summary>
        /// codigo desktop Familia_qry02_
        /// </summary>

        /// <returns></returns>
        /// 
        public static List<Dato> Familia_qry03_(int psintypesel, string pchr_idgrupo, string pchr_idfamilia, string idEmpresa)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", psintypesel);
            db.AddParameter("@pchr_idgrupo", pchr_idgrupo);
            db.AddParameter("@pchr_idfamilia", pchr_idfamilia);
            db.AddParameter("@idEmpresa", idEmpresa);
            IDataReader reader = db.ExecuteReader("MG_Familias_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_subfami"].ToString();
                _dato.desc = reader["ds_familia"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }

        public static DataSet GetFamilia(EFamilia fm)
        {

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", fm.psintypesel);
            db.AddParameter("@idEmpresa", fm.idEmpresa);
            db.AddParameter("@pchr_idgrupo", fm.Id_grupo);
            db.AddParameter("@pchr_idfamilia", fm.Id_familia);
            db.AddParameter("@pchr_idsubfami", fm.Id_subfami);

            return db.ExecuteDataSet("MG_Familias_qry01");
        }


        public static void Familia_mnt01(EFamilia fm)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", fm.idEmpresa);
            db.AddParameter("@pid_grupo", fm.Id_grupo);
            db.AddParameter("@pid_familia", fm.Id_familia);
            db.AddParameter("@pid_subfami", fm.Id_subfami);
            db.AddParameter("@pds_familia", fm.Ds_familia);
            db.AddParameter("@pnu_ultgen", fm.Nu_ultgen);
            db.AddParameter("@pid_ucrearec", fm.Id_ucrearec);
            db.AddParameter("@pid_uupdarec", fm.Id_uupdarec);
            db.AddParameter("@pst_anulado", fm.St_anulado);
            
            db.ExecuteNonQuery("MG_Familia_mnt01");

        }
    }
}
