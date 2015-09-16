using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Co;
using Texfina.Core.Data;

namespace Texfina.DOQry.Co
{
    public class DPersonalBandeja
    {
        public static DataSet GetList(EPersonalBandeja per)
        {

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", per.psintypesel);
            db.AddParameter("@pidPersonal", per.IdPersonal);
            db.AddParameter("@pnuDocIden", per.NuDocIden);
            db.AddParameter("@pdsApellNom", per.DsApellNom);

            return db.ExecuteDataSet("RH_Personal_qry04");
        }

        //consulta por codigo del personal, para que solo muestre el nombre y apellido en la OC
        public static List<Dato> ObtenerDatoPersonal(string commandtext, string par1, string par2, EPersonalBandeja pers)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", pers.psintypesel);
            db.AddParameter("@pidPersonal", pers.IdPersonal);
            db.AddParameter("@pnuDocIden", pers.NuDocIden);
            db.AddParameter("@pdsApellNom", pers.DsApellNom);

            IDataReader reader = db.ExecuteReader(commandtext);

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader[par1].ToString();
                _dato.desc = reader[par2].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }
    }
}
