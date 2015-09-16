using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Core.Data;
using Texfina.Entity.Co;
namespace Texfina.DOQry.Co
{
    public class DDeTipImpuesto
    {
        public static IDataReader Impuesto_qry01(EDTipImpuesto imp )
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@idPeriodo", imp.IdPeriodo);
            return db.ExecuteReader("MG_Impuesto_qry01");
        }

        /// <summary>
        /// obtener datos de impuesto en para desktop
        /// </summary>
        /// <param name="commandtext"></param>
        /// <param name="par1"></param>
        /// <param name="par2"></param>
        /// <param name="prov"></param>
        /// <returns></returns>
        public static List<Dato> _Impuesto_qry01(string commandtext, string par1, string par2, EDTipImpuesto imp)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

            db.AddParameter("@idPeriodo", imp.IdPeriodo);

            IDataReader reader = db.ExecuteReader(commandtext);

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader[par1].ToString();
                _dato.desc = (reader[par2]).ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }
    }
}
