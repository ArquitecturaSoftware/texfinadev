using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Core.Data;
using Texfina.Entity.Co;

namespace Texfina.DOQry.Co
{
    public class DUbigeo
    {
        public static IDataReader MG_Pais_qry01()
        {
            DBAccess db = new DBAccess();

            return db.ExecuteReader("MG_Pais_qry01");
        }


        /// <summary>
        /// codigo para desktop del procedimiento MG_Pais_qry01
        /// </summary>
        /// <param name="pais"></param>
        /// <returns></returns>
        public static List<Dato> MG_Pais_qry01_()
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
     
            IDataReader reader = db.ExecuteReader("MG_Pais_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["idPais"].ToString();
                _dato.desc = reader["dsNombre"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


        public static IDataReader MG_Departamento_qry01(String pais)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@Pais", pais);
            return db.ExecuteReader("MG_Departamento_qry02");
        }

        /// <summary>
        /// codigo desktop 
        /// </summary>
        /// <param name="pais"></param>
        /// <param name="depa"></param>
        /// <returns></returns>
        /// 
        public static List<Dato> MG_Departamento_qry01_(String pais)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@Pais", pais);         
            IDataReader reader = db.ExecuteReader("MG_Departamento_qry02");
            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["idDepa"].ToString();
                _dato.desc = reader["dsNombre"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }

        public static IDataReader MG_Provincia_qry01(String pais, String depa)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@Pais", pais);
            db.AddParameter("@Depa", depa);
            return db.ExecuteReader("MG_Provincia_qry01");
        }
        /// <summary>
        /// codigo para desktop  MG_Provincia_qry01_
        /// </summary>
        
        /// <returns></returns>
        public static List<Dato> MG_Provincia_qry01_(String pais, String depa)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@Pais", pais);
            db.AddParameter("@Depa", depa);

            IDataReader reader = db.ExecuteReader("MG_Provincia_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["idProv"].ToString();
                _dato.desc = reader["dsNombre"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


        public static IDataReader MG_Distrito_qry01(String pais, String depa, String prov)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@Pais", pais);
            db.AddParameter("@Depa", depa);
            db.AddParameter("@Prov", prov);
            return db.ExecuteReader("MG_Distrito_qry01");
        }

        /// <summary>
        /// codigo para desktop MG_Distrito_qry01_
        /// </summary>
        
        /// <returns></returns>
        public static List<Dato> MG_Distrito_qry01_(String pais, String depa, String prov)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@Pais", pais);
            db.AddParameter("@Depa", depa);
            db.AddParameter("@Prov", prov);
            IDataReader reader = db.ExecuteReader("MG_Distrito_qry01");
            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["idDist"].ToString();
                _dato.desc = reader["dsNombre"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }

    }
}
