using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Texfina.Core.Data;
using Texfina.Entity.Co;

namespace Texfina.DOQry.Co
{
    public class DExportacion
    {
        public static DataSet GetList(Eexportacion exp)
        {

            DBAccess db = new DBAccess();

            db.AddParameter("@psintypesel", exp.psintypesel);
            db.AddParameter("@idExportacion", exp.Id_Exporta);
            db.AddParameter("@dsExportacion", exp.Ds_Exporta);
            db.AddParameter("@idEmpresa", exp.Id_Empresa);

            return db.ExecuteDataSet("MG_Exportacion_qry01");
        }


        public static List<Dato> ObtenerDatoExport( Eexportacion exp)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", exp.psintypesel);
            db.AddParameter("@idExportacion", exp.Id_Exporta);
            db.AddParameter("@dsExportacion", exp.Ds_Exporta);
            db.AddParameter("@idEmpresa", exp.Id_Empresa);

            IDataReader reader = db.ExecuteReader("MG_Exportacion_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();


                _dato.desc = reader["Descripcion"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


        /// <summary>
        /// generar codigo
        /// </summary>
        /// <returns></returns>
        public static IDataReader Exportacion_qry01(string idperiodo, string idEmpresa)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@idPeriodo", idperiodo);
            db.AddParameter("@idEmpresa", idEmpresa);

            return db.ExecuteReader("MG_GencodigoExportacion");
        }

        /// <summary>
        /// codigo desktop


        public static List<Dato> Exportacion_qry01_(string idPeriodo, string idEmpresa)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@idPeriodo", idPeriodo);
            db.AddParameter("@idEmpresa", idEmpresa);

            IDataReader reader = db.ExecuteReader("MG_GencodigoExportacion");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_Exportacion"].ToString();

                _lista.Add(_dato);
            }
            return _lista;
        }
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>

        public static IDataReader GetList02(Eexportacion exp)
        {

            DBAccess db = new DBAccess();

       
            db.AddParameter("@idEmpresa", exp.Id_Empresa);
            db.AddParameter("@idExportacion", exp.Id_Exporta);
            db.AddParameter("@dsExportacion", exp.Ds_Exporta);
            return db.ExecuteReader("MG_Exportacion_qry01");
        }

        public static void Exportacion_mnt01(Eexportacion exp)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pid_Exporta", exp.Id_Exporta);
            db.AddParameter("@id_Empresa", exp.Id_Empresa);
            db.AddParameter("@pds_Exporta", exp.Ds_Exporta);
            db.AddParameter("@pid_via", exp.Id_via);
            db.AddParameter("@pid_tercom", exp.Id_tercom);
            db.AddParameter("@pid_ucrearec", exp.Id_ucrearec);
            db.AddParameter("@pid_uupdarec", exp.Id_uupdarec);

            db.ExecuteNonQuery("MG_Exportacion_mnt01");

        }

        public static void ExportacionEliminar_mnt01(Eexportacion exp)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@idEmpresa", exp.Id_Empresa);
            db.AddParameter("@idExportacion", exp.Id_Exporta);
            db.AddParameter("@pid_uupdarec", exp.Id_uupdarec);

            db.ExecuteNonQuery("MG_ExportacionEliminar_mnt01");

        }

    }
}
