using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.Core.Data;

namespace Texfina.DOMnt.Al
{
    public class DAlmacen
    {
        public static List<Texfina.Entity.Co.Dato> ObtenerAlmacen()
        {
            List<Texfina.Entity.Co.Dato> _lista = new List<Texfina.Entity.Co.Dato>();

            DBAccess db = new DBAccess();

            IDataReader reader = db.ExecuteReader("MG_Almacen_qry");

            while (reader.Read())
            {
                Texfina.Entity.Co.Dato _dato = new Texfina.Entity.Co.Dato();

                _dato.id = reader["id_Almacen"].ToString();
                _dato.desc = reader["dsAlmacen"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }

    }
}
