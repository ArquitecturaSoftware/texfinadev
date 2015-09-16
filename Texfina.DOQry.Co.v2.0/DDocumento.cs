using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Core.Data;
using Texfina.Entity.Co;

namespace Texfina.DOQry.Co
{
    public class DDocumento
    {
        public static IDataReader Mg_documento_qry01()
        {
            DBAccess db = new DBAccess();
            return db.ExecuteReader("MG_Documento_qry01");
        }


        public static List<Dato> ObtenerDato()
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

            IDataReader reader = db.ExecuteReader("MG_Documento_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_docucom"].ToString();
                _dato.desc = reader["ds_docucom"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }
    }
}
