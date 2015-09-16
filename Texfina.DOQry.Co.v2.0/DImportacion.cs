using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Core.Data;
using System.Data;
using Texfina.Entity.Co;

namespace Texfina.DOQry.Co
{
    public class DImportacion
    {

        public static DataSet GetList(EImportacion imp)
        {

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", imp.psintypesel);
            db.AddParameter("@idImporta", imp.Id_importa);
            db.AddParameter("@dsImporta", imp.Ds_importa);
            db.AddParameter("@idEmpresa", imp.Id_empresa);

            return db.ExecuteDataSet("MG_Importacion_qry01");
        }

        public static List<Dato> ObtenerDatoImport( EImportacion imp)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", imp.psintypesel);
            db.AddParameter("@idImporta", imp.Id_importa);
            db.AddParameter("@dsImporta", imp.Ds_importa);
            db.AddParameter("@idEmpresa", imp.Id_empresa);

            IDataReader reader = db.ExecuteReader("MG_Importacion_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                //_dato.id = reader[par1].ToString();
                _dato.desc = reader["Descripcion"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }



        /// <summary>
        /// generar codigo
        /// </summary>
        /// <returns></returns>
        public static IDataReader Importacion_qry01(string idperiodo, string idEmpresa)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@idPeriodo",idperiodo);

            db.AddParameter("@idEmpresa", idEmpresa);

            return db.ExecuteReader("MG_GencodigoImportacion");
        }

        /// <summary>
        /// desktop Importacion_qry01_
        /// </summary>
        /// <param name="imp"></param>
        /// <returns></returns>

        public static List<Dato> Importacion_qry01_(string idPeriodo, string idEmpresa)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@idPeriodo", idPeriodo);
            db.AddParameter("@idEmpresa", idEmpresa);

            IDataReader reader = db.ExecuteReader("MG_GencodigoImportacion");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_Importacion"].ToString();

                _lista.Add(_dato);
            }
            return _lista;
        }



        public static IDataReader GetList02(EImportacion imp)
        {

            DBAccess db = new DBAccess();

            db.AddParameter("@idImporta", imp.Id_importa);

            db.AddParameter("@dsImporta", imp.Ds_importa);
         
            db.AddParameter("@idEmpresa", imp.Id_empresa);

            return db.ExecuteReader("MG_Importacion_qry01");
        }

        public static void Importacion_mnt01(EImportacion imp)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pid_importa", imp.Id_importa);
            db.AddParameter("@id_Empresa", imp.Id_empresa);
            db.AddParameter("@pds_importa", imp.Ds_importa);
            db.AddParameter("@pid_via", imp.Id_via);
            db.AddParameter("@pid_tercom", imp.Id_tercom);
            db.AddParameter("@pid_ucrearec", imp.Id_ucrearec);
            db.AddParameter("@pid_uupdarec", imp.Id_uupdarec);

            db.ExecuteNonQuery("MG_Importacion_mnt01");

        }


        public static void ImportacionEliminar_mnt01(EImportacion imp)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@idEmpresa", imp.Id_empresa);
            db.AddParameter("@idImportacion", imp.Id_importa);
            db.AddParameter("@pid_uupdarec", imp.Id_uupdarec);

            db.ExecuteNonQuery("MG_ImportacionEliminar_mnt01");

        }
    }
}
