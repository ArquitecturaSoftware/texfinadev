using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Ve;
using Texfina.Core.Data;
using System.Data;
namespace Texfina.DOQry.Ve
{
    public class DAnticipos
    {
        public static DataSet GetList(EAnticipos obj)
        {

            DBAccess db = new DBAccess();
            
            db.AddParameter("@pidEmpresa ", obj.IdEmpresa);
            db.AddParameter("@pidAnticipo ", obj.IdAnticipo);
            db.AddParameter("@pdsCliente", obj.DsCliente);

            return db.ExecuteDataSet("VE_Anticipos_qry01");
        }


        public static List<Dato> GetDatoAnticipos(string commandtext, string par1, string par2, EAnticipos obj)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            //db.AddParameter("@psintypesel", obj.psintypesel);
            db.AddParameter("@ds_condpago", obj.DsCliente);
            db.AddParameter("@id_condpago", obj.IdAnticipo);

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
