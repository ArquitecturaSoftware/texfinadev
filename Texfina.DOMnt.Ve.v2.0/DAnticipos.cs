using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.Core.Data;
using Texfina.Entity.Ve;


namespace Texfina.DOMnt.Ve
{
    public class DAnticipos
    {

        public static List<Dato> GenCodeAnticipoMnt(String Codigo)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@idEmpresa", Codigo);

            IDataReader reader = db.ExecuteReader("MG_GenCodeAnticipos");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["idAnticipo"].ToString();
                _dato.desc = reader["idAnticipo"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


       
    }
}
