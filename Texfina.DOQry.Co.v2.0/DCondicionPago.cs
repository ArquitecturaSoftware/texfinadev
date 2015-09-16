using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Co;
using Texfina.Core.Data;
using System.Data;
namespace Texfina.DOQry.Co
{
    public class DCondicionPago
    {
        public static DataSet GetList(ECondicionPago condp)
        {

            DBAccess db = new DBAccess();

            db.AddParameter("@psintypesel", condp.psintypesel);
            db.AddParameter("@ds_condpago", condp.Ds_condpago);

            db.AddParameter("@id_condpago", condp.Id_condpago);

            //db.AddParameter("@dia", condp.Qt_docu);

            return db.ExecuteDataSet("MG_CondicionPago_qry01");
        }

        public static List<Dato> ObtenerDatoFPago(string commandtext, string par1, string par2, ECondicionPago condp)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", condp.psintypesel);
            db.AddParameter("@ds_condpago", condp.Ds_condpago);
            db.AddParameter("@id_condpago", condp.Id_condpago);

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
