using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Co;
using Texfina.Core.Data;

namespace Texfina.DOQry.Co
{
    public class DEmpEstable
    {
        public static IDataReader EmpEstableFill(EEmpEstable Est)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", Est.IdEmpresa);

            db.AddParameter("@pidEstable", Est.IdEstable);

            return db.ExecuteReader("SY_EmpEstable_qry04");

        }

    }
}
